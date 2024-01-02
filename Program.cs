using DesafioPOO.Models;

// FEITO: Realizar os testes com as classes Nokia e Iphone

// cria o aparelho nokia
Smartphone nokia = new Nokia(numero:"81 99111 2223", modelo:"Nokia G21", imei: "IMEI.info 351814800315235", memoria: "128 GB");

// inicia testes para o nokia
Console.WriteLine($"Executanto testes para o aparelho {nokia.Modelo} {nokia.Memoria}:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("GitHub");
Console.WriteLine($"O dispositivo {nokia.IMEI} está cadastrado para uso com o número {nokia.Numero}.");


Console.WriteLine("\n--------------------\n");

// cria o aparelho iPhone
Smartphone iPhone = new Iphone(numero:"81 99222 3334", modelo:"iPhone 12", imei:"IMEI.info: 353031119645776", memoria:"64 GB");

// inicia testes para o iPhone
Console.WriteLine($"Executanto testes para o aparelho {iPhone.Modelo} {iPhone.Memoria}:");
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("GitHub");
Console.WriteLine($"O dispositivo {iPhone.IMEI} está cadastrado para uso com o número {iPhone.Numero}.");

Console.WriteLine("\n--------------------\n\nTestes finalizados");