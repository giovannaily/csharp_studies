using ExemploExplorando.Models;
using System.Globalization;


        // Crie as variáveis titulo, descricao e dataVencimento para guardar as informações das tarefas:
        string titulo, descricao, dataVencimento;

        // Obtém o titulo e a descricao a partir da entrada do console  
        Console.WriteLine("Digite o título da tarefa:");
        titulo = Console.ReadLine();

        Console.WriteLine("Digite a descrição da tarefa:");
        descricao = Console.ReadLine();

        // Crie uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres.
        if (descricao.Length > 50)
        {
            Console.WriteLine("O Valor da descrição excede a quantidade de caracteres permitido.");
        }
        else
        {
            // Caso a descricao esteja dentro do limite, solicita a entrada pelo console da data de vencimento:
            Console.WriteLine("Digite a data de vencimento da tarefa:");
            dataVencimento = Console.ReadLine();

            // Imprima a descricao e a data de vencimento:
            Console.WriteLine($"{descricao} até {dataVencimento}");
        }



















// try{

//     string[]linhas = File.ReadAllLines("C:\\Users\\Giovanna\\Documents\\C#\\ExemploExplorando\\Arquivos\\arquivoLeitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linhas);
//     }
// } catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
// Console.WriteLine("Chegou até aqui");
// }













// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C},");












// Pessoa p1 = new Pessoa(nome: "Anna", sobrenome: "moreira");
// Pessoa p2 = new Pessoa(nome: "Márcio", sobrenome: "Toledo");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();








// Pessoa p1 = new Pessoa();
// p1.Nome = "Anna";
// p1.Sobrenome = "Moreira";
// p1.Idade = 20;
// p1.Apresentar();