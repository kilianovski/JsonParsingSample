# JsonParsingSample
Demo of a strange behaviour of a default ASP.NET Core json deserializer

## Steps to reproduce

Send `POST` request to _http://localhost:53346/api/values_ with body:

```json
{
	"name": "Fish",
	"age": 12
}I}am}the}invalid}json}
```

## Expected behaviour

400 (bad request) is returned

## Actual behaviour

200 (ok) is returned:

```
Welcome, Fish! I know, that you are 12 y.o.
```


