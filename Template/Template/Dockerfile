FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Template/Template/Template.csproj", "Template/Template/"]
RUN dotnet restore "Template/Template/Template.csproj"
COPY . .
WORKDIR "/src/Template/Template"
RUN dotnet build "Template.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Template.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Template.dll"]
