#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CourseDotNet6/CourseDotNet6.csproj", "CourseDotNet6/"]
RUN dotnet restore "CourseDotNet6/CourseDotNet6.csproj"
COPY . .
WORKDIR "/src/CourseDotNet6"
RUN dotnet build "CourseDotNet6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CourseDotNet6.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CourseDotNet6.dll"]