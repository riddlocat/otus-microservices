FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
ENV ASPNETCORE_HTTP_PORTS=8000
EXPOSE 8000

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ContainerizedApplication.Api.csproj", "ContainerizedApplication.Api/"]
RUN dotnet restore "ContainerizedApplication.Api/ContainerizedApplication.Api.csproj"
WORKDIR "src/ContainerizedApplication.Api"
COPY . .
RUN dotnet build "ContainerizedApplication.Api.csproj" -c Development -o /app/build

FROM build AS publish
RUN dotnet publish "ContainerizedApplication.Api.csproj" -c Development -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContainerizedApplication.Api.dll"]
