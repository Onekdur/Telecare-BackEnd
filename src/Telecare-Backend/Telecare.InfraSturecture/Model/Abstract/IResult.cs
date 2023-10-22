namespace Telecare.InfraSturecture.Model.Abstract
{
    public interface IResult
    {
        string Title { get; set; }
        string Type { get; }
        bool IsSuccess { get; }
        int StatusCode { get; }
        string[] Errors { get; }
    }

    public interface IResult<out T> : IResult
    {
        T? Data { get; }
    }

}
