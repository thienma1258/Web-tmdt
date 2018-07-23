FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 62085
EXPOSE 44300

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Aoo.csproj Aoo/
COPY BLL.csproj BLL/
RUN dotnet restore Aoo/Aoo.csproj
COPY . .
WORKDIR /src/Aoo
RUN dotnet build Aoo.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Aoo.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Aoo.dll
