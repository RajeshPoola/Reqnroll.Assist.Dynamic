#!/bin/bash

rm -rf ./Reqnroll.Assist.Dynamic/bin/Release

dotnet clean
dotnet test
dotnet build -c Release

dotnet pack ./Reqnroll.Assist.Dynamic.csproj -p:NuspecFile=./Reqnroll.Assist.Dynamic.nuspec -c Release

open ./bin/Release