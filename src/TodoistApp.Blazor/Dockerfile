#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TodoistApp.Blazor/TodoistApp.Blazor.csproj", "TodoistApp.Blazor/"]
RUN dotnet restore "TodoistApp.Blazor/TodoistApp.Blazor.csproj"
COPY . .
WORKDIR "/src/TodoistApp.Blazor"
RUN dotnet build "TodoistApp.Blazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TodoistApp.Blazor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TodoistApp.Blazor.dll"]