using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using EntidadesAbstractas;
using EntidadesInstanciables;
using Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void TestArchivosException()
        {
            //arrange
            Texto text = new Texto();
            bool resultado = false;
            string datos;
            //act
            try
            {
                text.Leer("unaDireccionInesxistente.txt", out datos);

            }
            catch (ArchivosException e)
            {
                resultado = true;
            }

            //assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestAlumnoRepetidoException()
        {
            //arrange
            bool resultado = false;

            Alumno a1 = new Alumno(1, "Juan", "Lopez", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino,
                Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);

            Alumno a2 = new Alumno(1, "Juan", "Lopez", "12234456", EntidadesAbstractas.Persona.ENacionalidad.Argentino,
                Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);

            Universidad uni = new Universidad();
            //act
            try
            {
                uni += a1;
                uni += a2;

            }
            catch (AlumnoRepetidoException e)
            {
                resultado = true;
            }

            //assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestDniInvalidoException()
        {
            //arrange
            bool resultado = false;

            //act
            try
            {
                Alumno a1 = new Alumno(1, "Juan", "Lopez", "gsdgsdg", EntidadesAbstractas.Persona.ENacionalidad.Extranjero,
                    Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);

            }
            catch (DniInvalidoException e)
            {
                resultado = true;
            }

            //assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestSinProfesorException()
        {
            //arrange
            bool resultado = false;
            Profesor aux;
            Universidad uni = new Universidad();

            //act
            try
            {
                aux = uni == EntidadesInstanciables.Universidad.EClases.Laboratorio;

            }
            catch (SinProfesorException e)
            {
                resultado = true;
            }

            //assert
            Assert.IsTrue(resultado);
        }

    }
}
