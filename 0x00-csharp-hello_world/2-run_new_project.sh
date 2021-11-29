#!/usr/bin/env bash
# Bash script that initializes, buid and run a new C# project inside a folder titled 0-new_project

if [!-d /2-new_project ];
then
cd 0-new_project
dotnet new console
dotnet build
dotnet run
fi
