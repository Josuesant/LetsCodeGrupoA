using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsCodeGrupoA.calculator
{
    public static class Calculator
    {
        public static void Menu()
        {
            Console.WriteLine("Insira a quantidade de operações, no máximo até 99:");
            int operacoes = int.Parse(Console.ReadLine()); //precisa fazer validação

            List<string> expressao = new List<string>();
            List<string> listTemp = new List<string>();

            Console.WriteLine("Insira um valor:");
            var num1 = Console.ReadLine();
            expressao.Add(num1);

            for (int i = 0; i < operacoes; i++)
            {
                Console.WriteLine("Insira a operação:");
                var caracterie = Console.ReadLine();
                expressao.Add(caracterie); //precisa fazer validação para não usar operadores iguais em sequência

                Console.WriteLine("Insira um valor:");
                var num2 = Console.ReadLine();
                expressao.Add(num2);
            }
            var test = "6 * 5 ^ 4 + 3 / 2 * 9 ^ 9 / 9 + 4 - 2";
            var lista = test.Split(" ");
            expressao = lista.ToList();

            Multi(expressao, listTemp, "*");
            //Multi(expressao, "*");
            //Multi(expressao, "/");
            //Multi(expressao, "+");
            //Multi(expressao, "-");
            Console.WriteLine("-----------------------");
        }

        public static void Multi(List<string> expressao, List<string> listTemp, string operacao)
        {
            var list = expressao;
            // list.ForEach(x => Console.WriteLine(x));

            // for (int i = 0; i < list.Count; i++)
            // {
            //     if (list[i].Equals(operacao))
            //     {
            //         var anterior = list[i - 1];
            //         var proximo = list[i + 1];
            //         list[i] = Calc(anterior, proximo, operacao);
            //         list.RemoveAt(i + 1);
            //         list.RemoveAt(i - 1);
            //         i = i - 1;
            //     }
            // }

            Parallel.For(0, list.Count, i =>
            {
                if (list[i].Equals(operacao))
                {
                    var anterior = list[i - 1];
                    var proximo = list[i + 1];
                    list[i] = "";
                    listTemp.Add(Calc(anterior, proximo, operacao));
                }
            });
            list.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("-----------------------");
            listTemp.ForEach(y => Console.WriteLine(y));
        }

    public static string Calc(string num1, string num2, string operacao)
    {
        var result = "0";
        switch (operacao)
        {
            case "*":
                result = (int.Parse(num1) * int.Parse(num2)).ToString();
                break;
            case "+":
                result = (int.Parse(num1) + int.Parse(num2)).ToString();
                break;
            case "-":
                result = (int.Parse(num1) - int.Parse(num2)).ToString();
                break;
            case "^":
                result = Math.Pow(int.Parse(num1), int.Parse(num2)).ToString();
                break;
            case "/":
                result = (int.Parse(num1) / int.Parse(num2)).ToString();
                break;
        }
        return result;
    }
}
}
