
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