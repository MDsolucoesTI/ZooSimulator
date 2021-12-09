//////////////////////////////////////////////////////////////////////////
// Criacao...........: 08/2010
// Sistema...........: Zoo Simulator - Práticas de OOP
// Desenvolvedores...: Denny Paulista Azevedo Filho
// Copyright.........: Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooSimulator.Animals
{
  public abstract class Animal
  {
    protected struct Localizacao
    {
      public int x;
      public int y;
    }

    #region Fields
    
    protected PictureBox figura;
    ///<summary>Tipo de Comida: 1 - Grass, 2 - Meat</summary>
    protected int comida;
    protected int fome;
    private Boundaries limites;
    protected Localizacao posicao;

    #endregion

    #region Properties
    
    public PictureBox Figura { get; set; }
    
    public int Comida
    {
      get { return comida; }
      set
      {
        if ((value >= 1) && (value <= 2))
          comida = value;
        else
          comida = 1;
      }
    }

    public int Fome { get; set; }
    
    public Boundaries Limites { get; set; }

    #endregion

    #region Methods
    
    public virtual string ProduzirSom()
    {
      return "bum bum bum";
    }

    public virtual string Comer() {
      return "Estou alimentado";
    }

    public virtual string Dormir() {
      return "ZZZzzzzzz";
    }

    public virtual string Perambular() {
      this.posicao.y += 1;
      return "passeando....";
    }
    #endregion

  }
}
