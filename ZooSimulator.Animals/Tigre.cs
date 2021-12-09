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

namespace ZooSimulator.Animals
{
  public class Tigre : Felino
  {
    public override string ProduzirSom()
    {
      return "Rooooaauuu";
    }
    
    public override String Comer()
    {
      return "Comendo uma vaca";
    }
  }
}
