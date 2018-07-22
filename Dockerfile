FROM microsoft/dotnet:2.0-sdk AS builder
WORKDIR /appsrc
COPY . .
RUN dotnet publish ./Aoo/Aoo.csproj /property:PublishWithAspNetCoreTargetManifest=false -c Release

FROM microsoft/aspnetcore:2.0.8-stretch
WORKDIR /app
COPY --from=builder /appsrc/Aoo/bin/Release/netcoreapp2.0/ .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Aoo.dll