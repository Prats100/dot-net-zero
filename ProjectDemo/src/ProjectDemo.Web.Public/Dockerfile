#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/ProjectDemo.Web.Public/ProjectDemo.Web.Public.csproj", "src/ProjectDemo.Web.Public/"]
COPY ["src/ProjectDemo.Web.Core/ProjectDemo.Web.Core.csproj", "src/ProjectDemo.Web.Core/"]
COPY ["src/ProjectDemo.Application/ProjectDemo.Application.csproj", "src/ProjectDemo.Application/"]
COPY ["src/ProjectDemo.Application.Shared/ProjectDemo.Application.Shared.csproj", "src/ProjectDemo.Application.Shared/"]
COPY ["src/ProjectDemo.Core.Shared/ProjectDemo.Core.Shared.csproj", "src/ProjectDemo.Core.Shared/"]
COPY ["src/ProjectDemo.Core/ProjectDemo.Core.csproj", "src/ProjectDemo.Core/"]
COPY ["src/ProjectDemo.EntityFrameworkCore/ProjectDemo.EntityFrameworkCore.csproj", "src/ProjectDemo.EntityFrameworkCore/"]
COPY ["src/ProjectDemo.GraphQL/ProjectDemo.GraphQL.csproj", "src/ProjectDemo.GraphQL/"]
RUN dotnet restore "src/ProjectDemo.Web.Public/ProjectDemo.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/ProjectDemo.Web.Public"
RUN dotnet build "ProjectDemo.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectDemo.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectDemo.Web.Public.dll"]
