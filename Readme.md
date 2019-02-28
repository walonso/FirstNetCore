Database:  in-memory database.

- create project:
dotnet new webapi -o RetailApi

- .NET Core emits logging information and blocks command shell input. The command shell needs to be usable to test the running app. Therefore, the dotnet run output is redirected to a RetailApi.log text file. Additionally, the & runs the app as a background task to unblock command shell input.
dotnet run > RetailApi.log &

- build project:
dotnet build

- Curl examples:
* invalid post:
curl -v -k \ -H "Content-Type: application/json" \ -d "{\"name\":\"Plush Squirrel\",\"price\":0.00}" \ https://localhost:5001/api/Products

-v enables verbose output.
-d implies an HTTP POST operation and defines the request body.
-H indicates that the request body is in JSON format. The header's value overrides the default content type of application/x-www-form-urlencoded

* valid post:
curl -v -k \ -H "Content-Type: application/json" \ -d "{\"name\":\"Plush Squirrel\",\"price\":12.99}" \ https://localhost:5001/api/Products

* valid GET:
curl -k -s https://localhost:5001/api/Products/3 | python -m json.tool

* Valid PUT:
curl -k -X PUT \ -H "Content-Type: application/json" \ -d "{\"id\":2,\"name\":\"Knotted Rope\",\"price\":14.99}" \ https://localhost:5001/api/Products/2

* Valid Delete:
curl -v -k -X DELETE https://localhost:5001/api/Products/1
