FROM microsoft/dotnet
WORKDIR /app

# copy project and restore as distinct layers
COPY docker-101.csproj .
RUN dotnet restore

# copy and build everything else
COPY . .
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/docker-101.dll"]
