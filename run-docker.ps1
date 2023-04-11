# Build docker image for Web
dotnet publish .\src\Udacity.DevOps.Capstone.Blazor --os linux --arch x64 -p:PublishProfile=DefaultContainer -c Release

# Build docker image for DbMigrator
dotnet publish .\src\Udacity.DevOps.Capstone.DbMigrator --os linux --arch x64 /t:PublishContainer -c Release

# Setup local HTTPS
dotnet dev-certs https -ep "$env:USERPROFILE\.aspnet\https\aspnetapp.pfx"  -p "password"
dotnet dev-certs https --trust

# Run docker-compose
docker-compose up