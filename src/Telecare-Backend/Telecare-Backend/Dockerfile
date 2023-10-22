#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Telecare-Backend/Telecare.Api.csproj", "Telecare-Backend/"]
COPY ["Telecare.Persistance/Telecare.Persistance.csproj", "Telecare.Persistance/"]
COPY ["Telecare.Application/Telecare.Application.csproj", "Telecare.Application/"]
COPY ["Entities/Telecare.Domain.csproj", "Entities/"]
RUN dotnet restore "Telecare-Backend/Telecare.Api.csproj"
COPY . .
WORKDIR "/src/Telecare-Backend"
RUN dotnet build "Telecare.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Telecare.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Telecare.Api.dll"]