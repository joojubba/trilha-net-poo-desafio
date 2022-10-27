using static System.Console;
using DesafioPOO.Models;

WriteLine("## Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

WriteLine("\n");

WriteLine("## Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "Modelo 2", imei: "222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
