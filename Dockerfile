FROM microsoft/aspnetcore:latest

WORKDIR /app

ADD WorkoutTracker.Api/artifacts /app

ENTRYPOINT [ "dotnet", "/app/WorkoutTracker.Api.dll" ]
