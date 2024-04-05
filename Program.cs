using MinhaBiblioteca2;


while (true) 
{
    Console.WriteLine("\n\nCalculadora Financeira");
    Console.WriteLine("\n1 - CALCULAR MONTANTE");
    Console.WriteLine("2 - CALCULAR CAPITAL");
    Console.WriteLine("3 - CALCULAR TAXA");
    Console.WriteLine("4 - CALCULAR JUROS");
    Console.WriteLine("5 - CALCULAR TEMPO");

    Console.Write("\n\nEscolha uma opção: ");
    byte opcao = Convert.ToByte(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("\nDigite o Capital: ");
            double capital = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o taxa: ");
            double taxa = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o tempo: ");
            double tempo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n O valor do Montante será = " + CalculadoraFinanceira.Montante(capital, taxa, tempo)); 
            break;
        case 2:
            Console.Write("\nDigite o Montante: ");
            double montante = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o taxa: ");
            taxa = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o tempo: ");
            tempo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n O valor do Capital será = " + CalculadoraFinanceira.Capital(montante, taxa, tempo)); 
            break;
        case 3:
            Console.Write("\nDigite o Montante: ");
            montante = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o capital: ");
            capital = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o tempo: ");
            tempo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n O valor da taxa será = " + CalculadoraFinanceira.Taxa(montante, capital, tempo));
            break;
        case 4:
            Console.Write("\nDigite o Montante: ");
            montante = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o Capital: ");
            capital = Convert.ToDouble(Console.ReadLine());
         
            Console.WriteLine("\n O valor do Juros será = " + CalculadoraFinanceira.Juros(montante, capital));
            break;
        case 5:
            Console.Write("\nDigite o Montante: ");
            montante = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o capital: ");
            capital = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o taxa: ");
            taxa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nO tempo será = " + CalculadoraFinanceira.Tempo(montante,capital, taxa));
            break;
    }
        
   

    
}