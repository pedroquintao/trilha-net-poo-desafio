using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\n----Smartphone Nokia:----\n");
Smartphone nokia = new Nokia(numero: "991237654", modelo: "G11 Plus", imei: "111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n----Smartphone Iphone:----\n");
Smartphone iphone = new Iphone(numero: "998761234", modelo: "15", imei: "999999999", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");