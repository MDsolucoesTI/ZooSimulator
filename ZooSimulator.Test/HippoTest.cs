//////////////////////////////////////////////////////////////////////////
// Criacao...........: 08/2014
// Sistema...........: Zoo Simulator - Práticas de OOP
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZooSimulator.Animals;

namespace ZooSimulator.Test
{
  [TestClass]
  public class HippoTest
  {
    [TestMethod]
    public void CriacaoObjetoHippo()
    {
      Hippo hippo = new Hippo();

      Assert.IsNotNull(hippo);
    }

    [TestMethod]
    public void VerificaMakeNoiseHippo()
    {
      string barulho;
      Hippo hippo = new Hippo();

      barulho = hippo.MakeNoise();

      Assert.AreEqual(barulho, "Hipoooooo");
    }

    [TestMethod]
    public void VerificaSleepHippo()
    {
      string barulho;
      Hippo hippo = new Hippo();

      barulho = hippo.Sleep();

      Assert.AreEqual(barulho, "ZZZzzzzzz");
    }
  }
}
