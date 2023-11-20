using Entidades;
using login;

namespace ProyectoPruebasUnitarias
{
 

    [TestClass]
    public class UnitTest1
    {
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

        [TestMethod]
        public void Testear_Encendido_Auto()
        {
            Auto auto = new Auto(2005, 120, "rojo", 5,300);
            string EstadoAutoAntes = auto.estadoProperty;

            auto.Encender();

            Assert.AreNotEqual(EstadoAutoAntes, auto.estadoProperty);
        }

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