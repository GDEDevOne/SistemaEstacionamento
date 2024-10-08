﻿using SistemaEstacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine(@"Seja bem vindo ao sistema de estacionamento!
Antes de iniciar, precisamos configurar os preços que serão cobrados ao final do serviço.

Digite o preço inicial:");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora, digite o preço por hora:");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new(precoInicial, precoPorHora);

bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");

    Console.WriteLine("1 - Cadastrar novo veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar todos os veículos");
    Console.WriteLine("4 - Encerrar sistema");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.CadastrarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");