gen:
	protoc -I=protos --csharp_out=protos/pb protos/test.proto

clean:
	rm protos/pb/*.cs

build:
	dotnet build TOOKAN-TEST

run:
	dotnet run
