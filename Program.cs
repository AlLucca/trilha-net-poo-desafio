using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("123", "Nokia", "123", 32);
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();
nokia.Ligar();

Iphone iphone = new Iphone("123", "Iphone", "123", 32);
iphone.InstalarAplicativo("WhatsApp");
iphone.ReceberLigacao();
iphone.Ligar();