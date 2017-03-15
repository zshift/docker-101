#!/bin/bash
dotnet restore
dotnet publish -c Release -o out
docker build -t docker-101:final -f ./Dockerfile.prod .