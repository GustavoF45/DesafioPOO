using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

            // Criação de instâncias das classes específicas
            Smartphone meuNokia = new Nokia("12345", "3310", "123456789012345", 16);
            Smartphone meuIphone = new Iphone("67890", "13 Pro", "987654321098765", 128);

            // Utilizando os métodos das instâncias
            meuNokia.Ligar();
            meuNokia.ReceberLigacao();
            meuNokia.InstalarAplicativo("WhatsApp");

            meuIphone.Ligar();
            meuIphone.ReceberLigacao();
            meuIphone.InstalarAplicativo("Instagram");