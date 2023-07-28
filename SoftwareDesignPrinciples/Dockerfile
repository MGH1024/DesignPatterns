FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SoftwareDesignPrinciples/SoftwareDesignPrinciples.csproj", "SoftwareDesignPrinciples/"]
RUN dotnet restore "SoftwareDesignPrinciples/SoftwareDesignPrinciples.csproj"
COPY . .
WORKDIR "/src/SoftwareDesignPrinciples"
RUN dotnet build "SoftwareDesignPrinciples.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SoftwareDesignPrinciples.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SoftwareDesignPrinciples.dll"]
