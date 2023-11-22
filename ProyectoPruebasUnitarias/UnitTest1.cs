using Entidades;
using login;

namespace ProyectoPruebasUnitarias
{
 

    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Testea si la BD devuelve una lista de vehiculos o un null
        /// </summary>
        [TestMethod]
        public void TestearBD_DevuelvaListaVehiculos()
        {
            //arrange
            AccesoVehiculos accesoVehiculos = new AccesoVehiculos();

            //Act
            List<Vehiculo> listaVehiculos = accesoVehiculos.ObtenerListaVehiculos();

            //Assert
            Assert.IsNotNull(listaVehiculos);
        }
        /// <summary>
        /// Testea si cambia el estado del vehiculo cuando se "Enciende"
        /// </summary>
        [TestMethod]
        public void Testear_Encendido_Auto()
        {
            Auto auto = new Auto(2005, 120, "rojo", 5,300);
            string EstadoAutoAntes = auto.Estado;

            auto.Encender();

            Assert.AreNotEqual(EstadoAutoAntes, auto.Estado);
        }

        /// <summary>
        /// Verifica si el login funciona bien cuando se loguea correctamente
        /// </summary>
        [TestMethod]
        public void Verificar_Correcto_RegistraAccesoYDevuelveUsuario()
        {
            // Arrange
            string correo = "corre@prueba.com";
            string clave = "prueba";
            bool registrarAcceso = false;

            List<Usuario> listaUsuarios = new List<Usuario>
            {
                new Usuario { Correo = correo, Clave = clave }
            };

            // Act
            Usuario usuario = Usuario.Verificar(correo, clave, registrarAcceso, listaUsuarios);

            // Assert
            Assert.IsNotNull(usuario);
            Assert.AreEqual(correo, usuario.Correo);
            Assert.AreEqual(clave, usuario.Clave);
        }
        

        /// <summary>
        /// Verifica si el login funcion bien cuando se loguea incorrectamente
        /// </summary>
        [TestMethod]
        public void Verificar_Incorrecto_NoRegistraAccesoYDevuelveNull()
        {
            // Arrange
            string correo = "corre@prueba.com";
            string clave = "prueba";
            bool registrarAcceso = false;

            List<Usuario> listaUsuarios = new List<Usuario>
            {
                new Usuario { Correo = "correo@incorrecto", Clave = "claveIncorrecta" }
            };

            // Act
            Usuario usuario = Usuario.Verificar(correo, clave, registrarAcceso, listaUsuarios);

            // Assert
            Assert.IsNull(usuario);
        }

    }

}