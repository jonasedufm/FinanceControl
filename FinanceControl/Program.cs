using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl
{
    class FinanceControl
    {
        // Listas para armazenar despesas e receitas
        List<decimal> expenses = new List<decimal>();
        List<decimal> incomes = new List<decimal>();

        // Método principal que inicia a execução do programa
        public void Run()
        {
            while (true)
            {
                // Exibe o menu de opções
                Console.WriteLine("1. Adicionar Despesa");
                Console.WriteLine("2. Adicionar Receita");
                Console.WriteLine("3. Ver Relatório Financeiro");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                string choice = Console.ReadLine();

                // Verifica a escolha do usuário e chama o método correspondente
                switch (choice)
                {
                    case "1":
                        AddExpense();
                        break;
                    case "2":
                        AddIncome();
                        break;
                    case "3":
                        ViewFinancialReport();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        // Método para adicionar uma despesa à lista de despesas
        public void AddExpense()
        {
            Console.Write("Digite o valor da despesa: ");
            decimal expense = decimal.Parse(Console.ReadLine());
            expenses.Add(expense);
            Console.WriteLine("Despesa adicionada com sucesso.");
        }

        // Método para adicionar uma receita à lista de receitas
        public void AddIncome()
        {
            Console.Write("Digite o valor da receita: ");
            decimal income = decimal.Parse(Console.ReadLine());
            incomes.Add(income);
            Console.WriteLine("Receita adicionada com sucesso.");
        }

        // Método para exibir o relatório financeiro
        public void ViewFinancialReport()
        {
            // Variáveis para calcular o total de despesas, receitas e saldo
            decimal totalExpenses = 0;
            decimal totalIncomes = 0;

            // Calcula o total de despesas somando todos os valores da lista de despesas
            foreach (decimal expense in expenses)
            {
                totalExpenses += expense;
            }

            // Calcula o total de receitas somando todos os valores da lista de receitas
            foreach (decimal income in incomes)
            {
                totalIncomes += income;
            }

            // Calcula o saldo subtraindo o total de despesas do total de receitas
            decimal balance = totalIncomes - totalExpenses;

            // Exibe o relatório financeiro
            Console.WriteLine("Relatório Financeiro:");
            Console.WriteLine("Despesas totais: " + totalExpenses);
            Console.WriteLine("Receitas totais: " + totalIncomes);
            Console.WriteLine("Saldo: " + balance);
        }
    }

    class Program
    {
        // Método principal que cria uma instância do FinanceControl e inicia o programa
        static void Main(string[] args)
        {
            FinanceControl financeControl = new FinanceControl();
            financeControl.Run();
        }
    }
}
