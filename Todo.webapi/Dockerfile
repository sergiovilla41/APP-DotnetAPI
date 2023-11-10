
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /арр
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["./" ,"Todo.webapi/"]
RUN dotnet restore "Todo.webapi/Todo.webapi.csproj"
COPY . .
WORKDIR "/src/Todo.webapi"
RUN dotnet build "Todo.webapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Todo.webapi.csproj" -c Release -o /app/publish /p:UseAppHost=false
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet","Todo.webapi.dll"]
