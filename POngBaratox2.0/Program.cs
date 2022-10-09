using System;
using Controllers;
using Models;

namespace POngBaratox2._0
{
    internal class Program
    {
        static Animal Coleta_Dados_pet()
        {
            Console.Write("Infome a Familia do Animal: ");
            string f = Console.ReadLine();
            Console.Write("Informe a Raça do Animal: ");
            string ra = Console.ReadLine();
            Console.Write("Informe o Sexo do Animal: ");
            string sx = Console.ReadLine();
            Console.Write("Informe o Nome do Animal: ");
            string n = Console.ReadLine();

            return new Animal(f, ra, sx, n);
        }
        static Adotante Coleta_Dados_adotante()
        {
            Console.Write("Informe o Nome: ");
            string n = Console.ReadLine();
            Console.Write("Informe o CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Informe o Sexo: ");
            string sx = Console.ReadLine();
            Console.Write("Informe a Data de Nascimento: ");
            DateTime dn = DateTime.Parse(Console.ReadLine());
            Console.Write("Informe um Telefone: ");
            string nm = Console.ReadLine();
            EnderecoController end = new();
            Endereco Endereco = end.Coleta_Dados_endereco();

            return new Adotante(n, cpf, sx, dn, nm, Endereco);
        }
        static void Menu_inicial()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t>>>>>>>> Informe a Opção desejada <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   1 - Cadastrar Animal   <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   2 - Cadastrar Adotante <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   3 - Doar animal        <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   4 - Editar cadastro    <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   0 - Sair               <<<<<<<<<<<<");


        }
        static void Menu_editar()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t>>>>>>>>   Informe a Opção desejada         <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   1 - Editar cadastro de Animal    <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   2 - Editar cadastro de Adotante  <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   0 - Sair                         <<<<<<<<<<<<");

        }
        static void EditarAnimal()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t>>>>>>>>   Informe a Opção desejada         <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   1 - Editar Familia               <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   2 - Editar Raça                  <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   3 - Editar Sexo                  <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   4 - Editar Nome                  <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   0 - Sair                         <<<<<<<<<<<<");
        }
        static void EditarAdotante()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t>>>>>>>>   Informe a Opção desejada         <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   1 - Editar Nome                  <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   2 - Editar Data de Nascimeto     <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   3 - Editar Telefone              <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   4 - Editar CEP                   <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   5 - Editar Rua                   <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   6 - Editar Cidade                <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   7 - Editar Bairro                <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   8 - Editar Estado                <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   9 - Editar Numero da casa        <<<<<<<<<<<<");
            Console.WriteLine("\t\t\t\t>>>>>>>>   0 - Sair                         <<<<<<<<<<<<");
        }


        static void Main(string[] args)
        {
            int opc;
            do
            {
                Menu_inicial();
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Animal pet = Coleta_Dados_pet();
                        new AnimalController().InserirAnimal(pet);

                        Console.WriteLine("\t\t\t\t>>>>>>>> CADASTRO REALLIZADO COM SUCESSO! <<<<<<<<<<<<");
                        Console.ReadKey();
                        break;
                    case 2:
                        Adotante people = Coleta_Dados_adotante();
                        new AdotanteController().InserirAdotante(people);

                        Console.WriteLine("\t\t\t\t>>>>>>>> CADASTRO REALLIZADO COM SUCESSO! <<<<<<<<<<<<");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Informe o ID do Animal a ser doado: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Informe o CPF do Adotante: ");
                        string cpf = Console.ReadLine();
                        new AnimalController().doarAnimal(cpf, id);

                        Console.WriteLine("\t\t\t\t>>>>>>>>  ADOÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                        Console.ReadKey();
                        break;
                    case 4:
                        Menu_editar();
                        int opcE = int.Parse(Console.ReadLine());
                        switch (opcE)
                        {
                            case 1:
                                EditarAnimal();
                                int opcA = int.Parse((Console.ReadLine()));
                                switch (opcA)
                                {
                                    case 1:
                                        Console.Write("Informe o ID do Animal a ser doado: ");
                                        id = int.Parse(Console.ReadLine());
                                        Console.Write("Informe a Familia desejada: ");
                                        string ff = Console.ReadLine();

                                        new AnimalController().alterar_dados_pet("Familia",ff,id);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.Write("Informe o ID do Animal a ser doado: ");
                                        id = int.Parse(Console.ReadLine());
                                        Console.Write("Informe a Raça desejada: ");
                                        string rc = Console.ReadLine();

                                        new AnimalController().alterar_dados_pet("Raca", rc, id);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                    case 3:

                                        Console.Write("Informe o ID do Animal a ser doado: ");
                                        id = int.Parse(Console.ReadLine());
                                        Console.Write("Informe o Sexo desejado: ");
                                        string sex = Console.ReadLine();


                                        new AnimalController().alterar_dados_pet("Sexo", sex, id);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.Write("Informe o ID do Animal a ser doado: ");
                                        id = int.Parse(Console.ReadLine());
                                        Console.Write("Informe a Nome desejado: ");
                                        string name = Console.ReadLine();

                                        new AnimalController().alterar_dados_pet("Nome", name, id);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                }
                                break;
                            case 2:
                                EditarAdotante();
                                int opcP = int.Parse(Console.ReadLine());
                                switch (opcP)
                                {
                                    case 1:
                                        Console.Write("Informe o CPF: ");
                                        string cpf1 = Console.ReadLine();
                                        Console.Write("Informe a Nome desejado: ");
                                        string name = Console.ReadLine();

                                        new AdotanteController().Alterar_dados_Adotante("Nome",name,cpf1);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.Write("Informe o CPF: ");
                                        string cpf2 = Console.ReadLine();
                                        Console.Write("Informe a Data de Nascimento desejada: ");
                                        string data = Console.ReadLine();

                                        new AdotanteController().Alterar_dados_Adotante("Data_Nascimento", data, cpf2);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.Write("Informe o CPF: ");
                                        string cpf3 = Console.ReadLine();
                                        Console.Write("Informe o Numero desejado: ");
                                        string num1 = Console.ReadLine();


                                        new AdotanteController().Alterar_dados_Adotante("Telefone", num1, cpf3);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.Write("Informe o CPF: ");
                                        string cpf4 = Console.ReadLine();
                                        Console.Write("Informe o CEP desejado: ");
                                        string cep1 = Console.ReadLine();

                                        new AdotanteController().Alterar_dados_Adotante("CPF", cep1, cpf4);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                    case 5:
                                        Console.Write("Informe o CPF: ");
                                        string cpf5 = Console.ReadLine();
                                        Console.Write("Informe a Rua desejado: ");
                                        string rua = Console.ReadLine();

                                        new AdotanteController().Alterar_dados_Adotante("RUA", rua, cpf5);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                    case 6:
                                        Console.Write("Informe o CPF: ");
                                        string cpf6 = Console.ReadLine();
                                        Console.Write("Informe a Cidade desejada: ");
                                        string cidade1 = Console.ReadLine();

                                        new AdotanteController().Alterar_dados_Adotante("Cidade", cidade1, cpf6);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                    case 7:
                                        Console.Write("Informe o CPF: ");
                                        string cpf7 = Console.ReadLine();
                                        Console.Write("Informe o Bairro desejada: ");
                                        string bairro1 = Console.ReadLine();


                                        new AdotanteController().Alterar_dados_Adotante("Bairro", bairro1, cpf7);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                    case 8:
                                        Console.Write("Informe o CPF: ");
                                        string cpf8 = Console.ReadLine();
                                        Console.Write("Informe o Estado desejado: ");
                                        string estado1 = Console.ReadLine();

                                        new AdotanteController().Alterar_dados_Adotante("Estado", estado1, cpf8);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                    case 9:
                                        Console.Write("Informe o CPF: ");
                                        string cpf9 = Console.ReadLine();
                                        Console.Write("Informe o Numero da casa desejada: ");
                                        string casa1 = Console.ReadLine();

                                        new AdotanteController().Alterar_dados_Adotante("Numero_Casa", casa1, cpf9);
                                        Console.WriteLine("\t\t\t\t>>>>>>>>  ALTERAÇÃO REALLIZADA COM SUCESSO! <<<<<<<<<<<<");
                                        Console.ReadKey();
                                        break;
                                }
                                break;
                        }
                        break;
                }

            } while (opc != 0);


        }
    }
}
