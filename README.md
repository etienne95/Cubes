# Cubes

### 
The project was documented using `Swagger`, to use it you need to do the next, assuming that you are in the repository root:
1. Run `cd Cubes.Api/` command
2. Run `dotnet run` command
3. Navigate to `http://localhost:5000/cubes/swagger/index.html`

### 
The project has an empty layer called `Cubes.Infrastructure`, which sense is to make the comunication with external sources like APIs, data base, etc.

### 
The project has unit tests, to run them, you need to run the following commands, assuming that you are in the repository root:

```
cd Cubes.Tests/

dotnet test
```

###
Request Example
```
curl -X POST "http://localhost:5000/Cubes/intersection-volume" -H  "accept: text/plain" -H  "Content-Type: application/json" -d "{\"cubes\":[{\"width\":{\"center\":2,\"length\":2},\"height\":{\"center\":2,\"length\":2},\"profundity\":{\"center\":2,\"length\":2}},{\"width\":{\"center\":2,\"length\":2},\"height\":{\"center\":2,\"length\":2},\"profundity\":{\"center\":2,\"length\":2}}]}"
```

### 
Response: `8`