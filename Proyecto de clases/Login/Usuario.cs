using Entidades;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace login
{
    public class Usuario
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Legajo { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Perfil { get; set; }

        #region metodos estaticos y sobrecargas

        /// <summary>
        /// Te deserealiza el archivo json con los usuarios y sus respectivos datos
        /// </summary>
        /// <param name="path"> lugar donde se ubica el archvio</param>
        /// <returns>Retorna la lista de usuarios con sus datos</returns>
        private static List<Usuario> Deserializacion(string path = @"..\..\..\MOCK_DATA.json")
        {
            List<Usuario> retorno = new List<Usuario>();
            try{
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    retorno = JsonConvert.DeserializeObject<List<Usuario>>(json);
                }
            }
            catch
            {
                retorno = null;
            }
            return retorno;
        }

        /// <summary>
        /// A partir de un mail y constraseñas dadas te verificacion con una lista
        /// si pertecen a un objeto usuario
        /// </summary>
        /// <param name="mail">Mail a verificar</param>
        /// <param name="contraseña"> constrseña a verificar</param>
        /// <returns>Si coinciden las verificaciones, se devuelve el objeto usuario con sus datos</returns>
        public static Usuario Verificar(string mail, string contraseña, bool registrarAcceso)
        {
            List<Usuario> lista = Deserializacion();
            return VerificacionPorLista(mail, contraseña, registrarAcceso, lista);
        }

        public static Usuario Verificar(string mail, string contraseña, bool registrarAcceso, List<Usuario> lista)
        {
            return VerificacionPorLista(mail, contraseña, registrarAcceso, lista);
        }

        private static Usuario VerificacionPorLista(string mail, string contraseña, bool registrarAcceso, List<Usuario> lista)
        {
            foreach (Usuario user in lista)
            {
                if (user.Correo == mail && user.Clave == contraseña)
                {
                    if (registrarAcceso) { RegistrarAcceso(user); }
                    return user;
                }
            }
            return null;
        }

        /// <summary>
        /// A partir de un usuario dado se guarda en un archivo la hora
        /// en la que inicio sesion y su informacion
        /// </summary>
        /// <param name="usuario">Usuario dado</param>
        private static void RegistrarAcceso(Usuario usuario)
        {
            string logFilePath = @"..\..\..\usuarios.log";
            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    string fechaHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string mensaje = $"Acceso de usuario: {usuario.Apellido} {usuario.Nombre} (Legajo: {usuario.Legajo}) - Fecha y hora: {fechaHora}";
                    writer.WriteLine(mensaje);
                }
            }
            catch { }
        }
        
        /// <summary>
        /// te deserializa el archivo donde se guardan los logs, y se 
        /// devuelve un string[] con todos los inicios de sesion
        /// </summary>
        /// <returns></returns>
        public static string[] Registro()
        {
            string logFilePath = @"..\..\..\usuarios.log";
            string[] logLines = null;
            if (File.Exists(logFilePath))
            {
                logLines = File.ReadAllLines(logFilePath);
            }
            return logLines;
        }
        
        public override string ToString()
        {
            return $"{this.Perfil} - {this.Apellido}";
        }
        #endregion
    }
}
