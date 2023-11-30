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
  "id": "1234-abcde-6789-fghijklmop",
  "titulo": "Comprar pão",
  "concluido": false
}
```
