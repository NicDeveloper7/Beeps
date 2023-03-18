
        //declarar variável

        // Declara o fundo do terminal
        Console.BackgroundColor = ConsoleColor.Yellow;
        // Nesse caso o clear também serve para o background funcionar
        Console.Clear();

        // Cursor some
        Console.CursorVisible = false;

        // Comando para resetar as cores
        Console.ResetColor();

        //Aqui começa o menu com os laços de repetições
        Console.WriteLine("Bem-Vindo a zona de testes de beeps");
        Console.WriteLine("(1) Fundo vermelho letra azul");
        Console.WriteLine("(2) Fundo Azul letra vermelha");
        // Declarando variável e exibindo
        var opcao1 = int.Parse(Console.ReadLine()!);
        Console.Clear();
        Console.ResetColor();

        // Laço de repetição - IF (se)
        if (opcao1 == 1){
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Clear();

            Console.WriteLine("Beep1");
            Console.Beep(460, 115);
            Console.WriteLine("Beep2");
            Console.Beep(430, 115 );
            Console.WriteLine("Beep3");
            Console.Beep(461, 115);
            Console.WriteLine("Beep4");
            Console.Beep(422, 115 );
            Console.WriteLine("Beep5");
            Console.Beep(412, 115);
            Console.WriteLine("Beep6");
            Console.Beep(498, 115 );
            Console.WriteLine("Beep7");
            Console.Beep(655, 115);
            Console.WriteLine("Beep8");
            Console.Beep(733, 115 );
            Console.WriteLine("Beep9");
            Console.Beep(498, 115);
            Console.WriteLine("Beep10");
            Console.Beep(444, 115 );

            Console.WriteLine("(0) Sair");
            var opcao2 = int.Parse(Console.ReadLine()!);

            if (opcao2 == 0) {
            }


            Console.ResetColor();
          
        }
        if (opcao1 == 2) {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Clear();

            Console.WriteLine("Beep1");
            Console.Beep(460, 115);
            Console.WriteLine("Beep2");
            Console.Beep(430, 115 );
            Console.WriteLine("Beep3");
            Console.Beep(461, 115);
            Console.WriteLine("Beep4");
            Console.Beep(422, 115 );
            Console.WriteLine("Beep5");
            Console.Beep(412, 115);
            Console.WriteLine("Beep6");
            Console.Beep(498, 115 );
            Console.WriteLine("Beep7");
            Console.Beep(655, 115);
            Console.WriteLine("Beep8");
            Console.Beep(733, 115 );
            Console.WriteLine("Beep9");
            Console.Beep(498, 115);
            Console.WriteLine("Beep10");
            Console.Beep(444, 115 );
            

            Console.WriteLine("(0) Voltar ao menu");
            var opcao2 = int.Parse(Console.ReadLine()!);

            if (opcao2 == 0) {
            }

            Console.ReadKey();
        }
