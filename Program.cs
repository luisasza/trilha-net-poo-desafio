using DesafioPOO.Models;

// FEITO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero:"81 99111 2223", modelo:"Nokia G21", imei: "IMEI.info 351814800315235", memoria: "128 GB");
Console.WriteLine($"Executanto testes para o aparelho {nokia.Modelo} {nokia.Memoria}:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("GitHub");

Console.WriteLine("\n--------------------\n");

Smartphone iPhone = new Iphone(numero:"81 99222 3334", modelo:"iPhone 12", imei:"IMEI.info: 353031119645776", memoria:"64 GB");
Console.WriteLine($"Executanto testes para o aparelho {iPhone.Modelo} {iPhone.Memoria}:");
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("GitHub");

Console.WriteLine("\n--------------------\n\nTestes finalizados");