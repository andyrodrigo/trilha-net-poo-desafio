using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia( numero: "11112222",  modelo: "N01", imei: "11111111" , memoria: 64 );
Smartphone iphone = new Iphone( numero: "11113333",  modelo: "I01", imei: "22222222" , memoria: 128 );

Console.WriteLine("Teste com os Celulares: ");


Console.WriteLine("\nTeste Nokia: ");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\nTeste Iphone: ");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("TikTok");

