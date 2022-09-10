using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia - Teste:");
Nokia nokia = new Nokia("12345678", "Modelo X", "12345678910", 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("App Teste 1");


System.Console.WriteLine("Smartphone Iphone - Teste:");
Iphone iphone = new Iphone("98765432", "Modelo Y", "12345678910", 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("App Teste 2");