FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TS-BE/TS-BE.csproj", "TS-BE/"]
RUN dotnet restore "TS-BE/TS-BE.csproj"
COPY . .
WORKDIR "/src/TS-BE"
RUN dotnet build "TS-BE.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TS-BE.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TS-BE.dll"]
