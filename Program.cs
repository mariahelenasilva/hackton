// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using hackton.solicitacao;
using hackton.pessoa;
using cadastropessoa.Abstract;

namespace Hackathon
{
    public class Program
    {
        static List<Aluno> alunos = new List<Aluno>();
        static List<Solicitacao> solicitacoes = new List<Solicitacao>();

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU INICIAL");
                Console.WriteLine("1. Alunos");
                Console.WriteLine("2. Administração");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        MenuAlunos();
                        break;
                    case "2":
                        MenuAdministracao();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void MenuAlunos()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ALUNOS");
                Console.WriteLine("1. Cadastro");
                Console.WriteLine("2. Solicitar entrada ou saída");
                Console.WriteLine("3. Já sou cadastrado");
                Console.WriteLine("4. Menu Inicial");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        CadastrarAluno();
                        break;
                    case "2":
                        SolicitarEntradaSaida();
                        break;
                    case "3":
                        VisualizarSolicitacoes();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void MenuAdministracao()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ADMINISTRAÇÃO");
                Console.WriteLine("1. Docente");
                Console.WriteLine("2. Coordenação");
                Console.WriteLine("3. Menu Inicial");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Docente();
                        break;
                    case "2":
                        Coordenacao();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CadastrarAluno()
        {
            Console.Clear();
            Console.WriteLine("CADASTRO DE ALUNO");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Matrícula: ");
            string matricula = Console.ReadLine();
            Console.Write("Turma: ");
            string turma = Console.ReadLine();

            alunos.Add(new Aluno(nome, matricula, turma));
            Console.WriteLine("Aluno cadastrado com sucesso! Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        static void SolicitarEntradaSaida()
        {
            Console.Clear();
            Console.WriteLine("SOLICITAR ENTRADA OU SAÍDA");
            Console.Write("Matrícula: ");
            string matricula = Console.ReadLine();
            Console.Write("Tipo de solicitação (entrada/saída): ");
            string tipo = Console.ReadLine();
            Console.Write("Data e hora do evento: ");
            string dataHora = Console.ReadLine();
            Console.Write("Motivo: ");
            string motivo = Console.ReadLine();
            Console.Write("Horário de retorno (se aplicável): ");
            string horarioRetorno = Console.ReadLine();
            Console.Write("Data da solicitação: ");
            string dataSolicitacao = Console.ReadLine();

            solicitacoes.Add(new Solicitacao(matricula, tipo, dataHora, motivo, horarioRetorno, dataSolicitacao));

            Console.WriteLine("Solicitação registrada com sucesso! Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        static void VisualizarSolicitacoes()
        {
            Console.Clear();
            Console.Write("Digite sua matrícula: ");
            string matricula = Console.ReadLine();

            var solicitacoesAluno = solicitacoes.FindAll(s => s.Matricula == matricula);

            if (solicitacoesAluno.Count == 0)
            {
                Console.WriteLine("Nenhuma solicitação encontrada.");
            }
            else
            {
                Console.WriteLine("Solicitações encontradas:");
                foreach (var s in solicitacoesAluno)
                {
                    Console.WriteLine($"Tipo: {s.Tipo}, Data e Hora: {s.DataHora}, Motivo: {s.Motivo}, Retorno: {s.HorarioRetorno}, Data da Solicitação: {s.DataSolicitacao}");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        static void Docente()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU DOCENTE");
                Console.WriteLine("1. Visualizar todos os alunos cadastrados");
                Console.WriteLine("2. Visualizar todas as solicitações");
                Console.WriteLine("3. Aprovar/Rejeitar solicitações");
                Console.WriteLine("4. Voltar ao menu Administração");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        VisualizarAlunos();
                        break;
                    case "2":
                        VisualizarTodasSolicitacoes();
                        break;
                    case "3":
                        AprovarRejeitarSolicitacao();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void Coordenacao()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU COORDENAÇÃO");
                Console.WriteLine("1. Visualizar todos os alunos cadastrados");
                Console.WriteLine("2. Visualizar todas as solicitações");
                Console.WriteLine("3. Aprovar/Rejeitar solicitações");
                Console.WriteLine("4. Voltar ao menu Administração");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        VisualizarAlunos();
                        break;
                    case "2":
                        VisualizarTodasSolicitacoes();
                        break;
                    case "3":
                        AprovarRejeitarSolicitacao();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AprovarRejeitarSolicitacao()
        {
            Console.Clear();
            if (solicitacoes.Count == 0)
            {
                Console.WriteLine("Não há solicitações pendentes.");
            }
            else
            {
                Console.WriteLine("Digite a matrícula do aluno para gerenciar a solicitação:");
                string matricula = Console.ReadLine();
                var solicitacao = solicitacoes.Find(s => s.Matricula == matricula);

                if (solicitacao != null)
                {
                    Console.WriteLine($"Solicitação encontrada: Tipo: {solicitacao.Tipo}, Motivo: {solicitacao.Motivo}");
                    Console.Write("Aprovar (A) ou Rejeitar (R)? ");
                    string escolha = Console.ReadLine().ToUpper();

                    if (escolha == "A")
                    {
                        solicitacoes.Remove(solicitacao);
                        Console.WriteLine("Solicitação aprovada!");
                    }
                    else if (escolha == "R")
                    {
                        solicitacoes.Remove(solicitacao);
                        Console.WriteLine("Solicitação rejeitada!");
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida.");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma solicitação encontrada para essa matrícula.");
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        static void VisualizarAlunos()
        {
            Console.Clear();
            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
            }
            else
            {
                Console.WriteLine("Lista de alunos cadastrados:");
                foreach (var aluno in alunos)
                {
                    Console.WriteLine($"Nome: {aluno.Nome}, Matrícula: {aluno.Matricula}, Turma: {aluno.Turma}");
                }
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        static void VisualizarTodasSolicitacoes()
        {
            Console.Clear();
            if (solicitacoes.Count == 0)
            {
                Console.WriteLine("Não há solicitações registradas.");
            }
            else
            {
                Console.WriteLine("Lista de todas as solicitações:");
                foreach (var s in solicitacoes)
                {
                    Console.WriteLine($"Matrícula: {s.Matricula}, Tipo: {s.Tipo}, Data e Hora: {s.DataHora}, Motivo: {s.Motivo}, Retorno: {s.HorarioRetorno}, Data Solicitação: {s.DataSolicitacao}");
                }
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

    }
}




