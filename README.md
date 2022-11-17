<center>**Estudo Using static e nameOf**</center><br>

<center> **using static** </center>
Para deixar o c�digo mais simples e de f�cil entendimento, podemos declarar os namespaces como est�ticos (static),o que facilita o uso dos m�todos nos c�digos.<br>

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
At� mesmo no intellisense quando est� digitando o c�digo j� aparece os m�todos.<br><br>

<center> **Uso de nameOf no operador (param�tro)** </center><br>

Em certos casos onde temos diversas chamadas de m�todos passando par�metros, muitas vezes podem ocorrer erros, valores inv�lidos ou nulos, f�rmulas erradas, etc. E, na maioria das vezes a mensagem de erro que retorna � gen�rica.Para estes casos de n�o deixar o usu�rio ou a �rea de suporte na m�o, sem saber ao certo qual o par�metro que est� com erro, foi criado o nameof.<br><br>

exemplo:
```csharp
public static int idade(int pAno)
      {
         if (pAno > DateTime.Today.Year)
         {
               throw new Exception($�ano invalido {nameof(pAno)}�);
         }
         return DateTime.Today.Year - pAno;
      }

// C�digo completo acompanhe no program.cs
```