# Usa una imagen base de ASP.NET Core Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Usa una imagen base para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia el archivo de proyecto y restaura dependencias
COPY ["IoT.Platform.API.csproj", "./"]
RUN dotnet restore "IoT.Platform.API.csproj"

# Copia el resto del código fuente y compila
COPY . .
RUN dotnet build "IoT.Platform.API.csproj" -c Release -o /app/build

# Publica la aplicación
FROM build AS publish
RUN dotnet publish "IoT.Platform.API.csproj" -c Release -o /app/publish

# Configura la imagen final para ejecución
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IoT.Platform.API.dll"]
