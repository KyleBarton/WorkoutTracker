#!/bin/bash

#TO BE RUN FROM REPOSITORY ROOT
dotnet publish WorkoutTracker.Api/WorkoutTracker.Api.csproj --runtime ubuntu-x64 --self-contained --output ./artifacts

docker build -t kjbarton4/workouttrackerapi:latest .

docker run -d -p 5000:80 kjbarton4/workouttrackerapi:latest