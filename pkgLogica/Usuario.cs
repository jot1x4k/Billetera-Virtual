using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testForms.pkgBaseDatos;

namespace testForms.pkgLogica
{
    internal class Usuario
    {
        Datos data = new Datos();
        public int fnc_registrarUsuario (
            string prm_nombre,
            string prm_mail,
            int prm_id,
            string prm_usuario,
            string prm_clave,
            string prm_fechaNac
            )
        {
            string sqlRegistroUsuario =
                $"SELECT fnc_registrar('{prm_nombre}', '{prm_mail}', {prm_id}, '{prm_usuario}', '{prm_clave}', TO_DATE('{prm_fechaNac}', 'dd-mm-yyyy')) FROM dual";
            object resultado = data.fnc_escalar(sqlRegistroUsuario);

            return Convert.ToInt32( resultado );    
        }

        public long fnc_loginUsuario (string prm_usuario, string prm_clave)
        {
            string sql = $"SELECT fnc_login('{prm_usuario}', '{prm_clave}') FROM dual";

            object resultado = data.fnc_escalar(sql);

            if (resultado != null)
            {
                return Convert.ToInt64(resultado); // id Usuario = login válido, 0 = inválido
            }
            else
            {
                return 0;
            }
        }

        public string fnc_verificarAdmin(long prm_idUsuario)
        {
            string consultaAdmin =
                    $"SELECT usu_tipo FROM Usuarios WHERE usu_id = {prm_idUsuario}";
            object resultado = data.fnc_escalar(consultaAdmin);

            if (resultado != null)
            {
                return resultado.ToString();
            }
            else
            {
                return "cliente";
            }
        }

        public DateTime fnc_verificarFechaCreacion(long prm_idUsuario)
        {
            string consultaFecha =
                $"SELECT usu_fechacreacion FROM Usuarios WHERE usu_id = {prm_idUsuario}";
            object resultado = data.fnc_escalar(consultaFecha);

            if (resultado != null)
            {
                string fechaString = resultado.ToString();
                if (DateTime.TryParse(fechaString, out DateTime fecha))
                {
                    return fecha;
                }
            }
            {
                return DateTime.MinValue;
            }
        }

        public DataTable fnc_consultarUsuarios ()
        {
            return data.fnc_select("Usuarios");
        }
        public DataTable fnc_consultarSolicitudes()
        {
            return data.fnc_select("solicitudproducto");
        }
    }
}
