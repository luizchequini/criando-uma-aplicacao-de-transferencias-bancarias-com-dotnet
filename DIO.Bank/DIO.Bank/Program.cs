﻿using DIO.Bank.Classes;
using DIO.Bank.Enum;
using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços");
            Console.ReadLine();
        }

        private static void Depositar()
        {
            throw new NotImplementedException();
        }

        private static void Sacar()
        {
            throw new NotImplementedException();
        }

        private static void Transferir()
        {
            throw new NotImplementedException();
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");

            Console.WriteLine("1 Passoa Física | 2 Pessoa Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do CLiente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o Saldo Atual: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta, nome: entradaNome, saldo: entradaSaldo, credito: entradaCredito);
            listaContas.Add(novaConta);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar Contas");

            if(listaContas.Count == 0)
            {
                Console.WriteLine("Nunhuma conta cadastrada!");
                return;
            }

            for(int i = 0; i < listaContas.Count; i++)
            {
                Conta conta = listaContas[i];
                Console.WriteLine("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("LUIZ CHEQUINI - BANK");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1: Listar contas");
            Console.WriteLine("2: Inserir nova conta");
            Console.WriteLine("3: Transferir");
            Console.WriteLine("4: Sacar");
            Console.WriteLine("5: Depositar");
            Console.WriteLine("C: Limpar tela");
            Console.WriteLine("X: Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcaoUsuario;
        }
    }
}
