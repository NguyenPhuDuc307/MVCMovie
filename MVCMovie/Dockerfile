FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["MVCMovie/MVCMovie.csproj", "MVCMovie/"]
RUN dotnet restore "MVCMovie/MVCMovie.csproj"
COPY . .
WORKDIR "/src/MVCMovie"
RUN dotnet build "MVCMovie.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MVCMovie.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MVCMovie.dll"]