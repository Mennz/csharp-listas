# Cadastro de produtos

Programa de console em C# que mantem uma lista de produtos em memoria. Da pra
listar, adicionar, buscar por nome e remover, tudo por um menu simples.

## O que pratiquei

- `List<T>` genérica: adicionar, percorrer e remover itens
- Metodo que devolve `Produto?` (nulavel) quando nao acha nada
- Leitura de entrada do usuario com `Console.ReadLine` e `TryParse`
- Um bug bem chato de digitacao (espaco a mais quebrando a busca) e como
  achar a causa

## Como rodar

```
dotnet run
```

O programa ja nasce com tres produtos cadastrados (caneta, caderno e
borracha) pra facilitar o teste. Depois e so usar o menu numerado.
