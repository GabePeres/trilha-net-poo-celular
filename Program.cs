using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero : "12345", modelo: "modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero : "54321", modelo: "modelo 2", imei: "2222222222", memoria: 124);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");