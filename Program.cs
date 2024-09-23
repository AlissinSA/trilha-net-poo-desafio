using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("91476-6741", "Nokia Tijolão", "231564", 64);
nokia.Ligar("João");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Twitter");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("94002-8922", "Iphone 15 Pro Max", "544569", 128);
iphone.Ligar("Maria");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("StarLink");
