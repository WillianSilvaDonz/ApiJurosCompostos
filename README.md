# Api Juros Compostos
Desenvolvimento de duas api para calculo de juros compostos

Desenvolvimento consiste em duas Web Api em C# com mvc aonde uma api so busca a taxa de juros que ja vem convertida para multiplicação, e na segunda api consiste em calcular o juros conforme uma regra matematica (Valor (1+juros) ^ meses)

Para teste os seguintes links:

https://jurospadraowillian.azurewebsites.net/taxajuros <- Retorna a taxa de juros padrao "0.01"

https://calculajuroswillian.azurewebsites.net/ <- Aonde calcula o juros e tem um point com informações da api

Na WebApi CalculaJuros foi adicionado Swagger como forma de documentação.

No projeto tambem tem teste unitario usando Xunit e Moq como exemplos.

É usado o HttpClient para consumir a api de jurosPadrao.
