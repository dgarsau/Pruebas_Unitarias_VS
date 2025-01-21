using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod]
        public void validarMetodoIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado vs valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }

        [TestMethod]
        public void validarMetodoReintegro()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);
            // afirmación de la prueba (valor esperado vs valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }

        //Controla la excepción por ingreso negativo
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarIngresoException()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -10;
            double saldoActual = 0;
            

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado vs valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

        }


        //Controla la excepción por reintegro negativo.
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarReintegroException()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = -500;
            double saldoActual = 0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);
            // afirmación de la prueba (valor esperado vs valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
        }


        //Controla la excepción provocada por saldo insuficiente.
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarReintegroException2()
        {
            // preparación del caso de prueba
            double saldoInicial = 0;
            double reintegro = 500;
            double saldoActual = 0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);
            // afirmación de la prueba (valor esperado vs valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
        }
    }
}
