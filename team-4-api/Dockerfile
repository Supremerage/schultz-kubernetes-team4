FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["team-4-api.csproj", "team-4-api/"]
RUN dotnet restore "team-4-api/team-4-api.csproj"
COPY . team-4-api/
WORKDIR "/src/team-4-api"
RUN dotnet build "team-4-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "team-4-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "team-4-api.dll"]