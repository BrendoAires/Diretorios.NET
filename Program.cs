Watcher();

while(true)
{

    Console.WriteLine("Digite a opção desejada: ");
    Console.WriteLine("--- 1 - Criar Diretório ---");
    Console.WriteLine("--- 2 - Listar Diretório ---");
    Console.WriteLine("--- 3 - Excluir Diretório ---");
    Console.WriteLine("--- 4 - Criar Arquivo ---");
    Console.WriteLine("--- 5 - Mover arquivo --- ");
    Console.WriteLine("--- 6 - Excluir Arquivo ---");
    Console.WriteLine("--- 7 - Criar Arquivo CSV ---");    
    Console.WriteLine("--- 0 - Sair ---");

    int opcao = int.Parse(Console.ReadLine());

    
    
    if(opcao == 0){
        Console.WriteLine("Pressione Enter para sair");
        Console.ReadLine();
        return;

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
        CriarArquivo();
        break;
    
    case 5: 
        Console.WriteLine("***Excluir Arquivo***");
        Console.WriteLine();
        break;

    case 6: 
        Console.WriteLine("***Mover Arquivo***");
        Console.WriteLine();
        break;

    

    case 0: 
    
    break;
    

    
}
}

Console.WriteLine("Pressione Enter para sair");
Console.WriteLine();
Console.ReadLine();



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



/*--------WATCHER----------*/
static void Watcher()
{
    var pathWatcher = @"C:\Users\Noca\Desktop\Brendo\dotnet\diretorio.NET\Documentos";
    using var fsw = new FileSystemWatcher(pathWatcher);
    fsw.Created += OnCreated;
    fsw.Renamed += OnRenamed;
    fsw.Deleted += OnDeleted;

    fsw.EnableRaisingEvents = true;
    fsw.IncludeSubdirectories = true;

    Console.WriteLine("Pressione Enter para encerrar");
    Console.ReadLine();

    void OnCreated(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Foi criado um arquivo {e.Name}");
    }


    void OnDeleted(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"Foi excluido o arquivo {e.Name}");
    }


    void OnRenamed(object sender, RenamedEventArgs e)
    {
        Console.WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
    }
}

static void CriarArquivo(){
    var path = Path.Combine(Environment.CurrentDirectory, "Documentos");
        ListarDiretorio(path);

    Console.WriteLine("Digite o nome da pasta onde deseja criar o arquivo: ");
    var NomePasta = Console.ReadLine();

    var pathPasta = Path.Combine(Environment.CurrentDirectory, "Documentos", $"{NomePasta}");

    Console.WriteLine("Digite o nome do arquivo que deseja criar: ");

    var nomeNovoArquivo = Console.ReadLine();
    nomeNovoArquivo = Sanitar(nomeNovoArquivo);

    var pathArq = Path.Combine(Environment.CurrentDirectory, "Documentos", $"{NomePasta}", $"{nomeNovoArquivo}.csv");

    using var arq = File.CreateText(pathArq);

    Console.ReadLine();

    
}



/*---------String Builder----------*/

