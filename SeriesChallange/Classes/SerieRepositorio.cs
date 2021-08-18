using System;
using System.Collections.Generic;
using DesafioInterfaces;

namespace DesafioDio01 {
  public class SerieRepositorio : IRepositorio<Serie> {

    private List<Serie> listarSerie = new List<Serie>();

    public void Atualiza(int id, Serie entidade) {
      listarSerie[id] = entidade;
    }

    public void Excluir(int id) {
      listarSerie[id].Excluir();
    }

    public void Insere(Serie entidade) {
      listarSerie.Add(entidade);
    }

    public List<Serie> Lista() {
      return listarSerie;
    }

    public int ProximoId() {
      return listarSerie.Count;
    }

    public Serie RetornaPorId(int id) {
      return listarSerie[id];
    }
  }
}