# exemplo-api-asp-net-core
Exemplo de API utilizando Asp Net Core 1.0 e publicando no ubuntu 16.04

#Instalar dotnet-dev-1.0.0-preview2-003131

sudo sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ xenial main" > /etc/apt/sources.list.d/dotnetdev.list'

sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 417A8893

sudo apt-get update

sudo apt-get install dotnet-dev-1.0.0-preview2-003131

#Baixar projeto

sudo git clone https://github.com/yeikicosta/exemplo-api-asp-net-core.git

#Rodar projeto

/exemplo-api-asp-net-core/src/api.ipetdelivery$ sudo dotnet build

/exemplo-api-asp-net-core/src/api.ipetdelivery$ sudo dotnet restore

/exemplo-api-asp-net-core/src/api.ipetdelivery$ sudo dotnet run

Project api.ipetdelivery (.NETCoreApp,Version=v1.0) was previously compiled. Skipping compilation. 

Hosting environment: Production Content root path: /home/andre/webapi/exemplo-api-asp-net-core/src/api.ipetdelivery 

Now listening on: http://localhost:5000 

Application started. Press Ctrl+C to shut down.


