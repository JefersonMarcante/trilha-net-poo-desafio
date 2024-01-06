using DesafioPOO.Models;

Console.WriteLine("Testes do Smartphone Nokia");
Smartphone nokia = new Nokia("(12)123456789", "Modelo 01", "123456789", 12);
Console.WriteLine($"Numero: {nokia.Numero}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\nTestes do Smartphone Iphone");
Smartphone iphone = new Iphone("(98)987654321", "Modelo 02", "987654321", 24);
Console.WriteLine($"Numero: {iphone.Numero}");
iphone.Ligar();
nokia.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
