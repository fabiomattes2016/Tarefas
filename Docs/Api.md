### Class Tarefa

```csharp
public class Tarefa
{
    public string titulo { get; set; }
    public bool concluido { get; set; }
}
```

### Tarefa Post Request

```js
POST {{host}}/tarefa
```

```json
{
  "titulo": "Comprar pão"
}
```

### Tarefa Put Request

```js
PUT {{host}}/tarefa
```

```json
{
  "titulo": "Comprar pão",
  "concluido": true
}
```

### Tarefa Response

```js
200 OK
```

```json
{
  "id": "3e2e7ffc-4f94-4991-b202-b7d29605ecf5",
  "titulo": "Tarefa de Testes 2",
  "concluido": false,
  "criadoEm": "2023-11-30T19:29:38.9453343Z",
  "atualizadoEm": null
}
```
