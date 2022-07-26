#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Aplicacion_Web/Aplicacion_Web.csproj", "Aplicacion_Web/"]
RUN dotnet restore "Aplicacion_Web/Aplicacion_Web.csproj"
COPY . .
WORKDIR "/src/Aplicacion_Web"
RUN dotnet build "Aplicacion_Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Aplicacion_Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Aplicacion_Web.dll"]