using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using colores;
using System.Text.Json.Nodes;
using tipos;

namespace Entidades
{
    public class AccesoVehiculos
    {
        private SqlConnection connection;
        private static string connectionString;
        private SqlCommand command;
        private SqlDataReader reader;

        static AccesoVehiculos()
        {
            AccesoVehiculos.connectionString = Proyecto_de_clases.Properties.Resources.myConnection;
        }
        public AccesoVehiculos()
        {
            this.connection = new SqlConnection(AccesoVehiculos.connectionString);
        }

        public bool TestearConexion()
        {
            bool result;

            try
            {
                this.connection.Open();
                if (this.connection.State == System.Data.ConnectionState.Open)
                {
                    result = true;
                }
                else
                {
                    result = false;
                    throw new ExceptionNoConectadaABD("No se logro conectar a la base de datos");
                } 
            }
            finally
            {
                if (this.connection.State == System.Data.ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return result;
        }

        public List<Vehiculo> ObtenerListaVehiculos()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            try
            {
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = System.Data.CommandType.Text;
                this.command.CommandText = "SELECT tipo,colorPredominante,velocidadMaxima,añoFabricacion,atributoExtraUno,atributoExtraDos,ID FROM Vehiculos";

                this.connection.Open();

                this.reader = this.command.ExecuteReader(); // para select (devuelve data)

                while (this.reader.Read())
                {
                    Vehiculo vehicular = null;
                    int tipo = (int)this.reader["tipo"];
                    int añoFabricacion = (int)this.reader["añoFabricacion"];
                    int velocidadMaxima = (int)this.reader["velocidadMaxima"];
                    enumColor colorPredominante = (enumColor)this.reader["colorPredominante"];

                    int atributoExtraUno = (int)this.reader["atributoExtraUno"];
                    object atributoExtraDos = this.reader["atributoExtraDos"];
              
                    int id = (int)this.reader["ID"];


                    if (tipo == 1)
                    {
                        int atributoExtraDosEntero = (int)(atributoExtraDos);
                        vehicular = new Entidades.Auto(añoFabricacion, velocidadMaxima, colorPredominante.ToString(), atributoExtraUno, atributoExtraDosEntero);
                    }
                    else if (tipo == 2)
                    {
                        int atributoExtraDosEntero = (int) atributoExtraDos;
                        vehicular = new Entidades.Avion(añoFabricacion, velocidadMaxima, colorPredominante.ToString(), atributoExtraUno, atributoExtraDosEntero);
                    }
                    else if (tipo == 3)
                    {
                        vehicular = new Entidades.Tren(añoFabricacion, velocidadMaxima, colorPredominante.ToString(), atributoExtraUno, atributoExtraDos.ToString());
                    }

                    vehicular.ID = id; //seteo la id

                    vehiculos.Add(vehicular);
                }

                this.reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                vehiculos = null;
            }
            finally
            {
                if (this.connection.State == System.Data.ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return vehiculos;
        }

        public bool AgregarVehiculo(Vehiculo v)
        {
            string instruccion = $"INSERT INTO Vehiculos(tipo,colorPredominante,velocidadMaxima,añoFabricacion,atributoExtraUno,atributoExtraDos) " +
                                 $"VALUES(@tipo,@colorPredominante,@velocidadMaxima,@añoFabricacion,@atributoExtraUno,@atributoExtraDos)";
            bool result = this.ReferenciarObjetoConSql(v, instruccion);
            return result;
        }

        public bool ModificarDato(Vehiculo v)
        {
            string instruccion = $"UPDATE Vehiculos SET tipo=@tipo, colorPredominante=@colorPredominante, velocidadMaxima=@velocidadMaxima," +
                                 $"añoFabricacion=@añoFabricacion, atributoExtraUno=@atributoExtraUno, atributoExtraDos=@atributoExtraDos WHERE ID=@id";
            bool result = this.ReferenciarObjetoConSql(v, instruccion);
            return result;
        }

        public bool EliminarDato(Vehiculo v)
        {
            bool result;
            string instruccion = $"DELETE FROM Vehiculos WHERE ID=@id";
            result = this.ReferenciarObjetoConSql(v, instruccion);
            return result;
        }
    
        public bool ReferenciarObjetoConSql(Vehiculo v, string instruccion)
        {
            bool result;
            try
            {
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.Parameters.AddWithValue("@tipo", v.Tipo);
                this.command.Parameters.AddWithValue("@colorPredominante", v.ColorPredominante);
                this.command.Parameters.AddWithValue("@velocidadMaxima", v.VelocidadMaxima);
                this.command.Parameters.AddWithValue("@añoFabricacion", v.AñoFabricacion);
                this.command.Parameters.AddWithValue("@id", v.ID);

                int atributoExtraUno;
                object atributoExtraDos; //object para que me tome tanto int como string

                switch (v.Tipo)
                {
                    case enumTipos.auto:
                        Auto VAuto = (Auto)v;
                        atributoExtraUno = VAuto.propertyVolumenTanque;
                        atributoExtraDos = VAuto.propertyCapacidad;
                        break;
                    case enumTipos.avion:
                        Avion VAvion = (Avion)v;
                        atributoExtraUno = VAvion.propertyAsientos;
                       atributoExtraDos = VAvion.propertyCantMotores;
                        break;
                    case enumTipos.tren:
                        Tren VTren = (Tren)v;
                        atributoExtraUno = VTren.propertyCantVagones;
                        atributoExtraDos = VTren.propertyPaisOrigen;
                        break;
                    default:
                        throw new ExceptionVehiculoInvalido("Tipo de vehículo desconocido");
                }

                this.command.Parameters.AddWithValue("@atributoExtraUno", atributoExtraUno);
                this.command.Parameters.AddWithValue("@atributoExtraDos", atributoExtraDos);

                this.command.CommandType = System.Data.CommandType.Text;
                this.command.CommandText = instruccion;

                this.connection.Open();

                int filasAfectadas = this.command.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    result = true;
                }
                else
                {
                    throw new ExceptionNoSeLogroCambiosEnBD("No se realizo ningun cambio en la base de datos");
                }
            }
            catch(Exception e) 
            {
                result = false;
                Console.WriteLine(e);
            }
            finally
            {
                if (this.connection.State == System.Data.ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return result;
        }
    
    }
}
