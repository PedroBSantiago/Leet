string leet;
Console.Clear();
Console.Write("Escreva sua frase e deixe seu jeito ninja:");
leet = Console.ReadLine()!
.ToUpper()
.Replace("A", "4")
.Replace("E", "3")
.Replace("I", "1")
.Replace("L", "1")
.Replace("O", "0")
.Replace("T", "7")
.Replace("S", "5")
;

Console.WriteLine(@$"
{leet}");

