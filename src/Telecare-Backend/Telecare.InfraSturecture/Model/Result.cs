using Microsoft.AspNetCore.Http;
using Telecare.InfraSturecture.Model.Abstract;

namespace Telecare.InfraSturecture.Model
{
    public class Result : IResult
    {
        public string Title { get; set; }
        public string Type { get; }
        public bool IsSuccess => StatusCode is >= 200 and <= 300;
        public int StatusCode { get; }
        public string[] Errors { get; }

        internal Result(int statusCode, string[] errors)
        {
            StatusCode = statusCode;
            Errors = errors;
            Type = statusCode switch
            {
                100 => "https://tools.ietf.org/html/rfc7231#section-6.2.1",
                101 => "https://tools.ietf.org/html/rfc7231#section-6.2.2",
                200 => "https://tools.ietf.org/html/rfc7231#section-6.3.1",
                201 => "https://tools.ietf.org/html/rfc7231#section-6.3.2",
                202 => "https://tools.ietf.org/html/rfc7231#section-6.3.3",
                204 => "https://tools.ietf.org/html/rfc7231#section-6.3.5",
                205 => "https://tools.ietf.org/html/rfc7231#section-6.3.6",
                206 => "https://tools.ietf.org/html/rfc7233#section-4.1",
                300 => "https://tools.ietf.org/html/rfc7231#section-6.4.1",
                301 => "https://tools.ietf.org/html/rfc7231#section-6.4.2",
                302 => "https://tools.ietf.org/html/rfc7231#section-6.4.3",
                303 => "https://tools.ietf.org/html/rfc7231#section-6.4.4",
                304 => "https://tools.ietf.org/html/rfc7232#section-4.1",
                305 => "https://tools.ietf.org/html/rfc7231#section-6.4.5",
                306 => "https://tools.ietf.org/html/rfc7231#section-6.4.6",
                307 => "https://tools.ietf.org/html/rfc7231#section-6.4.7",
                400 => "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                401 => "https://tools.ietf.org/html/rfc7235#section-3.1",
                402 => "https://tools.ietf.org/html/rfc7231#section-6.5.2",
                403 => "https://tools.ietf.org/html/rfc7231#section-6.5.3",
                404 => "https://tools.ietf.org/html/rfc7231#section-6.5.4",
                405 => "https://tools.ietf.org/html/rfc7231#section-6.5.5",
                406 => "https://tools.ietf.org/html/rfc7231#section-6.5.6",
                407 => "https://tools.ietf.org/html/rfc7235#section-3.2",
                408 => "https://tools.ietf.org/html/rfc7231#section-6.5.7",
                409 => "https://tools.ietf.org/html/rfc7231#section-6.5.8",
                410 => "https://tools.ietf.org/html/rfc7231#section-6.5.9",
                411 => "https://tools.ietf.org/html/rfc7231#section-6.5.10",
                412 => "https://tools.ietf.org/html/rfc7232#section-4.2",
                413 => "https://tools.ietf.org/html/rfc7231#section-6.5.11",
                414 => "https://tools.ietf.org/html/rfc7231#section-6.5.12",
                415 => "https://tools.ietf.org/html/rfc7231#section-6.5.13",
                416 => "https://tools.ietf.org/html/rfc7233#section-4.4",
                417 => "https://tools.ietf.org/html/rfc7231#section-6.5.14",
                426 => "https://tools.ietf.org/html/rfc7231#section-6.5.15",
                500 => "https://tools.ietf.org/html/rfc7231#section-6.6.1",
                501 => "https://tools.ietf.org/html/rfc7231#section-6.6.2",
                502 => "https://tools.ietf.org/html/rfc7231#section-6.6.3",
                503 => "https://tools.ietf.org/html/rfc7231#section-6.6.4",
                504 => "https://tools.ietf.org/html/rfc7231#section-6.6.5",
                505 => "https://tools.ietf.org/html/rfc7231#section-6.6.6",
                _ => "https://tools.ietf.org/html/rfc7231#section-6.6.1"
            };
            Title = IsSuccess ? "Request Success!" : "Request Failed!";
        }

        public static IResult Success() => new Result(StatusCodes.Status200OK, Array.Empty<string>());
        public static IResult Success(int statusCode) => new Result(statusCode, Array.Empty<string>());
        public static IResult Fail() => new Result(StatusCodes.Status400BadRequest, Array.Empty<string>());
        public static IResult Fail(params string[] errors) => new Result(StatusCodes.Status400BadRequest, errors);
        public static IResult Fail(int statusCode) => new Result(statusCode, Array.Empty<string>());
        public static IResult Fail(int statusCode, params string[] errors) => new Result(statusCode, errors);
    }

    public class Result<T> : Result, IResult<T>
    {        
        public T? Data { get; }

        private Result(int statusCode,T? data, string[] errors) : base(statusCode, errors)
        {
            Data = data;
        }

        internal new static IResult<T> Success() => new Result<T>(200, default(T), Array.Empty<string>()); //new keyword hide the base class's success method
        internal static IResult<T> Success(T data) => new Result<T>(200, data, Array.Empty<string>());
        internal static IResult<T> Success(int statusCode, T data) => new Result<T>(statusCode, data, Array.Empty<string>());

        internal new static IResult<T> Fail() => new Result<T>(400, default(T), Array.Empty<string>());
        internal new static IResult<T> Fail(int statusCode, params string[] errors) => new Result<T>(statusCode, default(T), errors);
    }
}
