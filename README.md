<center>**Estudo Using static e nameOf**</center><br>

<center> **using static** </center>
Para deixar o código mais simples e de fácil entendimento, podemos declarar os namespaces como estáticos (static),o que facilita o uso dos métodos nos códigos.<br>

Por exemplo:

```csharp
using System;
{
    Console.WriteLine("texto");
	Console.WriteLine("texto");
	Console.ReadLine();
}
```
Facilitando:

```csharp
using static System.Console;
{
    WriteLine("texto");
	WriteLine("texto");
	ReadLine();
}
```
Até mesmo no intellisense quando está digitando o código já aparece os métodos.<br><br>

<center> **Uso de nameOf no operador (paramêtro)** </center><br>

Em certos casos onde temos diversas chamadas de métodos passando parâmetros, muitas vezes podem ocorrer erros, valores inválidos ou nulos, fórmulas erradas, etc. E, na maioria das vezes a mensagem de erro que retorna é genérica.Para estes casos de não deixar o usuário ou a área de suporte na mão, sem saber ao certo qual o parâmetro que está com erro, foi criado o nameof.<br><br>

exemplo:
```csharp
public static int idade(int pAno)
      {
         if (pAno > DateTime.Today.Year)
         {
               throw new Exception($”ano invalido {nameof(pAno)}”);
         }
         return DateTime.Today.Year - pAno;
      }

// Código completo acompanhe no program.cs
```