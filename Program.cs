using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        List<string> departamentos = input.Split(',')
                                          .ToList();
        
        // Contagem de funcionários por departamento
        Dictionary<string, int> contagemDepartamentos = ContarFuncionariosPorDepartamento(departamentos);

        var resultado = string.Join(Environment.NewLine,contagemDepartamentos.OrderBy(depto => depto.Key)
        .Select(depto => $"{depto.Key}: {depto.Value}"));

        Console.WriteLine(resultado);
    }

		// Método que conta o número de funcionários em cada departamento.
    static Dictionary<string, int> ContarFuncionariosPorDepartamento(List<string> departamentos)
    {
        var contagem = new Dictionary<string, int>();
        
        foreach (var departamento in departamentos)
        {
            if (contagem.ContainsKey(departamento))
            {
                contagem[departamento]++;
            }
            else
            {
                contagem[departamento] = 1;
            }
        }				
        return contagem;
    }
}
