using CellphoneAbstract.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "489873267", modelo: "Modelo Nokia Tijolão", imei: "001970-01-010000-0", memoria: 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("iPhone:");
Smartphone iphone = new Iphone(numero: "1987326788", modelo: "Modelo Iphone 15 pro max", imei: "038101-24-010000-1", memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("PlansVsZombies");
