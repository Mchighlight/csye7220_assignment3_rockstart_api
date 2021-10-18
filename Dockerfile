FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY bin/Release/net5.0/publish/ App/
COPY stronger.txt App/
COPY bonita_applebum.txt App/
COPY day_and_night.txt App/
WORKDIR /App
ENTRYPOINT ["dotnet", "rockstar_api.dll"]