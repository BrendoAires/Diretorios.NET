

    Console.WriteLine("Digite a opção desejada: ");
    Console.WriteLine("--- 1 - Criar Diretório ---");
    Console.WriteLine("--- 2 - Listar Diretório ---");
    Console.WriteLine("--- 3 - Excluir Diretório ---");
    Console.WriteLine("--- 4 - Criar Arquivo ---");
    Console.WriteLine("--- 5 - Mover arquivo --- ");
    Console.WriteLine("--- 6 - Excluir Arquivo ---");
    Console.WriteLine("--- 0 - Sair ---");
    var opcao = int.Parse(Console.ReadLine());
    
    if(opcao == null){
        Console.WriteLine("Digite uma opção válida");
        Console.WriteLine();
    }

    


switch (opcao)
{
    case 1:
        Console.WriteLine("***Criar Diretório***");
        Console.WriteLine();
        criarDiretorio();
        break;

    case 2:
        Console.WriteLine("***Listar Diretório***");
        Console.WriteLine();
        var path = @"C:\Users\Noca\Desktop\Brendo\dotnet\diretorio.NET\Documentos";
        
        ListarDiretorio(path);
        break;

    case 3:
        Console.WriteLine("***Excluir Diretório***");
        Console.WriteLine();
        break;
    
    case 4: 
        Console.WriteLine("***Criar Arquivo***");
        Console.WriteLine();
        break;
    
    case 5: 
        Console.WriteLine("***Listar Arquivo***");
        Console.WriteLine();
        break;

    case 6: 
        Console.WriteLine("***Listar Mover***");
        Console.WriteLine();
        break;

    case 0: break;

    default:
     Console.WriteLine("Digite uma opção válida");
     Console.WriteLine();
     break;
}

Console.WriteLine("Pressione Enter para sair");
Console.WriteLine();
Console.ReadLine();




// criarGlobo();
//     var origem = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
//     var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Brasil","Brasil.txt");
// MoverArquivo(origem, destino);

        
//         static void MoverArquivo(string origem, string destino)
//         {
//             if(!File.Exists(origem)){
//                 Console.WriteLine("O arquivo não existe na origem");
//                 CriarArquivo();
//                 return;
//             }
//             if(File.Exists(destino)){
//                 Console.WriteLine("O arquivo já existe");
//                 return;
//             }else
//             File.Move(origem, destino);
//         }

//         static void CriarArquivo()
//         {
//             var path = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
//             if(!File.Exists(path)){
//             using var sw = File.CreateText(path);
//             sw.WriteLine("População: 200 milhões");
//             sw.WriteLine("IDH: 0,901");
//             sw.WriteLine("Atualizado em: 20/01/2022");
//             }
//         }

        

//         static void criarGlobo()
//         {

//         var path = Path.Combine(Environment.CurrentDirectory, "globo");
//             if(!Directory.Exists(path))
//             {
//                 var dirGlobo = Directory.CreateDirectory(path);
            


//                 var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
//                 var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
//                 var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

//                 var dirEUA = dirAmNorte.CreateSubdirectory("Estados Unidos");
//                 var dirCAN = dirAmNorte.CreateSubdirectory("Canadá");
//                 var dirMEX = dirAmNorte.CreateSubdirectory("México");

//                 var dirCOR = dirAmCentral.CreateSubdirectory("Costa Rica");
//                 var dirPAN = dirAmCentral.CreateSubdirectory("Central");

//                 var dirBrasil = dirAmSul.CreateSubdirectory("Brasil");
//                 var dirChil = dirAmSul.CreateSubdirectory("Chile");
//             }
//         }

static string Sanitar(string name){
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        name = name.Replace(@char, '-');
    }
    return name;
}


static void criarDiretorio()
{
    Console.WriteLine("Digite o nome do novo diretorio: ");
    string nomeDiretorio = Console.ReadLine();
    nomeDiretorio = Sanitar(nomeDiretorio);
    if(!Directory.Exists(nomeDiretorio))
    {
    if (nomeDiretorio == null)
        Console.WriteLine("Insira um nome!!");
        else{

    
        var path = Path.Combine(Environment.CurrentDirectory, "Documentos", $"{nomeDiretorio}");
        var dir = Directory.CreateDirectory(path);
        
        Console.WriteLine($"Diretório criado com sucesso no endereço: {path}");

        Console.WriteLine("Deseja criar subdiretorio? s / n");
        var resp = Console.ReadLine();

        if (resp == "s"){
            Console.WriteLine("Informe o nome do sub Diretório: ");
            var nomeSub = Console.ReadLine();
            var sub = dir.CreateSubdirectory($"{nomeSub}");
            Console.WriteLine();
            Console.WriteLine($"Sub Diretório {nomeSub} criado com sucesso no endereço: {sub}");
        }
        else{
            return;
        }

        
        }
}


    else{
        Console.WriteLine("Já existe um diretorio com esse nome");
    }
}

static void ListarDiretorio(string path)
{
    var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
    if (Directory.Exists(path)){
        
        foreach (var lista in diretorios)
        {
            var dirInfo = new DirectoryInfo(lista);
            Console.WriteLine($"[Nome]: {dirInfo.Name}");
            Console.WriteLine($"[Raiz]: {dirInfo.Root}");
            if(dirInfo != null){
                Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");

                Console.WriteLine("----------------------");
            }
            
        }
    }else
    
        Console.WriteLine("O diretório pai ainda não existe. Deseja Criar um agora? s/n");
        string resposta = Console.ReadLine();
        if (resposta == "s"){
            Console.WriteLine("O diretório Pai será criado com nome de: [Documentos]");
            Console.WriteLine();
            var pathPai = Path.Combine(Environment.CurrentDirectory, "Documentos");
            var dirPai = Directory.CreateDirectory(pathPai);
        
            Console.WriteLine($"Diretório criado com sucesso no endereço: {pathPai}");
            Console.WriteLine();
        }
        Console.WriteLine("fechar");

    
}

