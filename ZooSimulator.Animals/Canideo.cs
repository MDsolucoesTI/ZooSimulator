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
  public class Canideo : Animal
  {
    public override string Comer()
    {
      return "Comi carne";
    }

    public override String Dormir()
    {
      return "Estatelou e dormiu";
    }
  }
}
