FROM microsoft/dotnet
WORKDIR /dotnetapp

# copy project and restore as distinct layers
COPY dotnet-miami-pres.csproj .
RUN dotnet restore

# copy and build everything else
COPY . .
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/dotnet-miami-pres.dll"]
