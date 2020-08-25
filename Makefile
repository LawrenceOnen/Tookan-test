gen:
	protoc -I=protos --csharp_out=protos/pb protos/test.proto

clean:
	rm protos/pb/*.cs

build:
	dotnet build TOOKAN-TEST

run:
	dotnet run

create_project:
	dotnet new 	webapi -o 

add_ef_sql:	
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer
	
add_ef_im:
	dotnet add package Microsoft.EntityFrameworkCore.InMemory

#Create the database

dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update