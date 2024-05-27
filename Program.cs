using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");

Smartphone iphone = new Iphone(numero:"1234567", modelo: "modelo xr", imei:"1025",memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Binance");
iphone.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia(numero:"1234567", modelo: "modelo nokia lumia", imei:"1030",memoria: 100);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();