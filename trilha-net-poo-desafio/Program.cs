using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste Nokia:");
//Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "111222333444555", memoria: 512);
Smartphone nokia = new Nokia(numero: "123456789");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Teste iPhone:");
//Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 13", imei: "555444333222111", memoria: 1024);
Smartphone iphone = new Iphone(numero: "987654321");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
