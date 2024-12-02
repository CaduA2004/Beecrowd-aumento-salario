using System; 

class URI {

    static void Main(string[] args) { 

        double salario = double.Parse(Console.ReadLine());

        double novoSalario, reajuste;
        int percentual;

        if (salario >= 0 && salario <= 400.00)
        {
            percentual = 15;
            reajuste = salario * 0.15;
        }
        else if (salario > 400.00 && salario <= 800.00)
        {
            percentual = 12;
            reajuste = salario * 0.12;
        }
        else if (salario > 800.00 && salario <= 1200.00)
        {
            percentual = 10;
            reajuste = salario * 0.10;
        }
        else if (salario > 1200.00 && salario <= 2000.00)
        {
            percentual = 7;
            reajuste = salario * 0.07;
        }
        else
        {
            percentual = 4;
            reajuste = salario * 0.04;
        }

        novoSalario = salario + reajuste;

        Console.WriteLine($"Novo salario: {novoSalario:F2}");
        Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
        Console.WriteLine($"Em percentual: {percentual} %");

    }

}