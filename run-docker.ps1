# Setup local HTTPS
dotnet dev-certs https -ep "$env:USERPROFILE\.aspnet\https\aspnetapp.pfx"  -p "password"
dotnet dev-certs https --trust

# Run docker-compose
docker-compose up