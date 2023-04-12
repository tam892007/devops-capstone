# Setup local HTTPS
dotnet dev-certs https -ep ${HOME}/.aspnet/https/aspnetapp.pfx -p password

# Only supported on macOS
# You need to trust certs on Linux in the way that is supported by your distribution. 
# It is likely that you need to trust the certificate in your browser.
dotnet dev-certs https --trust

# Run docker-compose
docker-compose up