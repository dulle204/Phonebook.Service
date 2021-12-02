#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Phonebook.Data.Migration/Phonebook.Data.Migration.csproj", "Phonebook.Data.Migration/"]
COPY ["Phonebook.Data/Phonebook.Data.csproj", "Phonebook.Data/"]
RUN dotnet restore "Phonebook.Data.Migration/Phonebook.Data.Migration.csproj"
COPY . .
WORKDIR "/src/Phonebook.Data.Migration"
RUN dotnet build "Phonebook.Data.Migration.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Phonebook.Data.Migration.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Phonebook.Data.Migration.dll"]