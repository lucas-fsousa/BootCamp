using System;

namespace DesafioDio01 {
  class Program {
    static SerieRepositorio repositorio = new SerieRepositorio();
    static void Main(string[] args) {

      string selectionado = "";
      while(!selectionado.ToUpper().Equals("X")) {
        selectionado = Menu();
        switch(selectionado) {
          case "1":
            ListarSeries();
            break;
          case "2":
            InserirSerie();
            break;
          case "3":
            AtualizarSerie();
            break;
          case "4":
            ExcluirSerie();
            break;
          case "5":
            VisualizarSerie();
            break;
          case "C":
            Console.Clear();
            break;
          default:
            break;
        }
      }

    }
    private static void ListarSeries() {
      print("Listando séries...");
      var lista = repositorio.Lista();

      if(lista.Count == 0) {
        print("Nenhuma série ainda cadastrada");
        return;
      }

      foreach(var serie in lista) {
        if(!serie.retornaExcluido()) {
          print($"#ID: {serie.retornaId()} - {serie.retornaTItulo()}");
        }
        
      }
    }
    private static void AtualizarSerie() {
      printl("Digite o ID da série: ");
      int indicaSerie = int.Parse(Console.ReadLine());

      foreach(int i in Enum.GetValues(typeof(Genero))) {
        print($"{i} - {Enum.GetName(typeof(Genero), i)}");
      }

      printl("Digite o Gênero conforme datado nas opções acima: ");
      int entradadaGenero = int.Parse(Console.ReadLine());

      printl("Digite o Titulo da série: ");
      string entradadaTitulo = Console.ReadLine();

      printl("Digite o Ano de inicio da série: ");
      int entradadaAno = int.Parse(Console.ReadLine());

      printl("Digite a descrição da série: ");
      string entradadaDescricao = Console.ReadLine();

      Serie atualizarSerie = new Serie(repositorio.ProximoId(), (Genero) entradadaGenero, entradadaTitulo, entradadaDescricao, entradadaAno);

      repositorio.Atualiza(indicaSerie, atualizarSerie);
    }
    private static void InserirSerie() {
      print("Inserir nova série ao catalogo");
      foreach(int i in Enum.GetValues(typeof(Genero))) {
        print($"{i} - {Enum.GetName(typeof(Genero), i)}");
      }

      printl("Digite o Gênero conforme datado nas opções acima: ");
      int entradadaGenero = int.Parse(Console.ReadLine());

      printl("Digite o Titulo da série: ");
      string entradadaTitulo = Console.ReadLine();

      printl("Digite o Ano de inicio da série: ");
      int entradadaAno = int.Parse(Console.ReadLine());

      printl("Digite a descrição da série: ");
      string entradadaDescricao = Console.ReadLine();

      Serie novaSerie = new Serie(repositorio.ProximoId(), (Genero)entradadaGenero, entradadaTitulo, entradadaDescricao, entradadaAno);
      repositorio.Insere(novaSerie);
    }
    private static void ExcluirSerie() {
      printl("Digite o ID da série: ");
      int indiceSerie = int.Parse(Console.ReadLine());
      repositorio.Excluir(indiceSerie);
    }
    private static void VisualizarSerie() {
      printl("Digite o ID da série: ");
      int indiceSerie = int.Parse(Console.ReadLine());
      var serie = repositorio.RetornaPorId(indiceSerie);
      Console.WriteLine(serie);
    }
    private static string Menu() {
      print("------------------------------");
      print("-- Informe a opção desejada --");
      print("-- [1] - Listar Séries      --");
      print("-- [2] - Adicionar Série    --");
      print("-- [3] - Atualizar Série    --");
      print("-- [4] - Excluir Série      --");
      print("-- [5] - Visualizar Série   --");
      print("-- [C] - Limpar Tela        --");
      print("-- [X] - Sair               --");
      print("------------------------------");
      printl("=> ");
      string selecionado = Console.ReadLine().ToUpper();
      print("");
      print("");
      return selecionado;
    }
    private static void printl(object str) {
      Console.Write(str);
    }
    private static void print(object str) {
      Console.WriteLine(str);
    }
  }
}
