using System;

namespace DesafioDio01 {
  public class Serie: Molde {
    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }
    private bool Excluido { get; set; }

    public Serie(int id, Genero genero, string titulo, string descricao, int ano) {
      this.Id = id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
      this.Excluido = false;
    }

    public override string ToString() {
      string retorno = "";
      retorno += "gênero: " + this.Genero + Environment.NewLine;
      retorno += "titulo: " + this.Titulo + Environment.NewLine;
      retorno += "descrição: " + this.Descricao + Environment.NewLine;
      retorno += "ano de inicio: " + this.Ano + Environment.NewLine;
      retorno +=  "excluido: " + this.Excluido + Environment.NewLine;
      return retorno;
    }

    public string retornaTItulo() {
      return this.Titulo;
    }

    internal int retornaId() {
      return this.Id;
    }

    internal bool retornaExcluido() {
      return this.Excluido;
    }
    public void Excluir() {
      this.Excluido = true;
    }

  }
}