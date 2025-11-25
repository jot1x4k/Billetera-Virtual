using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace testForms.pkgBaseDatos
{
    internal class Datos
    {
        private readonly string connectionString;

        public Datos()
        {
            var cfg = AppConfig.Load();
            connectionString = "Server=localhost;Port=3306;Database=testforms;Uid=root;Pwd=admin";
            //connectionString = $"Server={cfg.Server};Port={cfg.Port};Database={cfg.Database};Uid={cfg.User};Pwd={cfg.Password};";
        }

        public int fnc_dml(string prmConsulta)
        {
            using (var conexion = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand(prmConsulta, conexion))
            {
                try
                {
                    conexion.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error BD: {ex.Message}");
                    return 0;
                }
            }
        }

        public object fnc_escalar(string prmConsulta)
        {
            using (var conexion = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand(prmConsulta, conexion))
            {
                try
                {
                    conexion.Open();
                    object resultado = cmd.ExecuteScalar();
                    return resultado == DBNull.Value ? null : resultado;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error BD: {ex.Message}");
                    return null;
                }
            }
        }

        public DataTable fnc_select(string prm_tabla)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string sql = $"SELECT * FROM {prm_tabla}";
                using (var adapter = new MySqlDataAdapter(sql, conn))
                {
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    return tabla;
                }
            }
        }

        // ---------------------------------------------------------------
        // FUNCION: fnc_registrar
        // ---------------------------------------------------------------
        public int fnc_registrarUsuario(string prm_nombre, string prm_mail, long prm_id, string prm_usuario, string prm_clave, string prm_fechaNac)
        {
            using (var conexion = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand(
                "SELECT fnc_registrar(@prm_nombre, @prm_correo, @prm_id, @prm_usuario, @prm_clave, @prm_fechaNac);",
                conexion))
            {
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@prm_nombre", prm_nombre);
                cmd.Parameters.AddWithValue("@prm_correo", prm_mail);
                cmd.Parameters.AddWithValue("@prm_id", prm_id);
                cmd.Parameters.AddWithValue("@prm_usuario", prm_usuario);
                cmd.Parameters.AddWithValue("@prm_clave", prm_clave);
                cmd.Parameters.AddWithValue("@prm_fechaNac", DateTime.Parse(prm_fechaNac));

                try
                {
                    conexion.Open();
                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value) return 0;
                    return Convert.ToInt32(result);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error MySQL: {ex.Message}");
                    return 0;
                }
            }
        }

        // ---------------------------------------------------------------
        // PROCEDIMIENTO: prc_infoCuenta
        // ---------------------------------------------------------------
        public (string nombre, long cuentaNum, decimal saldoCuenta)? fnc_obtenerInfoCuenta(long prm_idUsuario)
        {
            using (var conexion = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand("prc_infoCuenta", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("prm_id", prm_idUsuario);
                cmd.Parameters.Add(new MySqlParameter("p_nombre", MySqlDbType.VarChar, 100) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new MySqlParameter("p_cuentaNum", MySqlDbType.Int64) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new MySqlParameter("p_cuentaSaldo", MySqlDbType.Decimal) { Direction = ParameterDirection.Output });

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    string nombre = cmd.Parameters["p_nombre"].Value.ToString();
                    long cuentaNum = Convert.ToInt64(cmd.Parameters["p_cuentaNum"].Value);
                    decimal saldoCuenta = Convert.ToDecimal(cmd.Parameters["p_cuentaSaldo"].Value);

                    return (nombre, cuentaNum, saldoCuenta);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error BD: {ex.Message}");
                    return null;
                }
            }
        }

        // ---------------------------------------------------------------
        // PROCEDIMIENTO: prc_infoCliente
        // ---------------------------------------------------------------
        public (string mail, string usuario, string clave)? fnc_obtenerInfoCliente(long prm_idUsuario)
        {
            using (var conexion = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand("prc_infoCliente", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("prm_id", prm_idUsuario);
                cmd.Parameters.Add(new MySqlParameter("p_mail", MySqlDbType.VarChar, 50) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new MySqlParameter("p_usuario", MySqlDbType.VarChar, 50) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new MySqlParameter("p_clave", MySqlDbType.VarChar, 50) { Direction = ParameterDirection.Output });

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    string mail = cmd.Parameters["p_mail"].Value.ToString();
                    string usuario = cmd.Parameters["p_usuario"].Value.ToString();
                    string clave = cmd.Parameters["p_clave"].Value.ToString();

                    return (mail, usuario, clave);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error BD: {ex.Message}");
                    return null;
                }
            }
        }

        // ---------------------------------------------------------------
        // PROCEDIMIENTO: prc_actualizar_cliente
        // ---------------------------------------------------------------
        public int fnc_actualizarInfoCliente(long prm_idUsuario, string prm_correo, string prm_usuario, string prm_clave)
        {
            using (var conexion = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand("prc_actualizar_cliente", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("prm_id", prm_idUsuario);
                cmd.Parameters.AddWithValue("p_mail", prm_correo);
                cmd.Parameters.AddWithValue("p_usuario", prm_usuario);
                cmd.Parameters.AddWithValue("p_clave", prm_clave);

                var p_resultado = new MySqlParameter("p_resultado", MySqlDbType.Int32)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(p_resultado);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    return Convert.ToInt32(p_resultado.Value);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error BD: {ex.Message}");
                    return 0;
                }
            }
        }

        // ---------------------------------------------------------------
        // PROCEDIMIENTO: prc_consultarMovimientos
        // ---------------------------------------------------------------
        public DataTable fnc_consultarMovimientos(long prm_idUsuario)
        {
            using (var conn = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand("prc_consultarMovimientos", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("prm_idUsuario", prm_idUsuario);

                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabla = new DataTable();
                    try
                    {
                        adapter.Fill(tabla);
                        return tabla;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error BD: " + ex.Message);
                        return null;
                    }
                }
            }
        }

        // ---------------------------------------------------------------
        // PROCEDIMIENTO: prc_transferencia
        // ---------------------------------------------------------------
        public (DateTime fecha, long referencia)? fnc_transferencia(long prm_idUsuario, long prm_destinatario, decimal prm_monto)
        {
            using (var conexion = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand("prc_transferencia", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("prm_idUsuario", prm_idUsuario);
                cmd.Parameters.AddWithValue("prm_cuenta_destinatario", prm_destinatario);
                cmd.Parameters.AddWithValue("prm_monto", prm_monto);

                var p_fecha = new MySqlParameter("prm_fecha", MySqlDbType.DateTime) { Direction = ParameterDirection.Output };
                var p_ref = new MySqlParameter("prm_referencia", MySqlDbType.Int64) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(p_fecha);
                cmd.Parameters.Add(p_ref);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    DateTime fecha = Convert.ToDateTime(p_fecha.Value);
                    long referencia = Convert.ToInt64(p_ref.Value);

                    return (fecha, referencia);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error BD: {ex.Message}");
                    return null;
                }
            }
        }

        // ---------------------------------------------------------------
        // PROCEDIMIENTO: prc_extracto
        // ---------------------------------------------------------------
        public (decimal saldoInicio, decimal ingresos, decimal egresos, decimal saldoFin, DateTime fechaInicio, DateTime fechaFin)? fnc_generarExtracto(long prm_idUsuario, DateTime prm_periodo)
        {
            using (var conn = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand("prc_extracto", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("prm_id", prm_idUsuario);
                cmd.Parameters.AddWithValue("prm_periodo", prm_periodo);

                cmd.Parameters.Add(new MySqlParameter("outP_saldoInicio", MySqlDbType.Decimal) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new MySqlParameter("outP_ingresos", MySqlDbType.Decimal) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new MySqlParameter("outP_egresos", MySqlDbType.Decimal) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new MySqlParameter("outP_saldoFin", MySqlDbType.Decimal) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new MySqlParameter("outP_fechaInicio", MySqlDbType.DateTime) { Direction = ParameterDirection.Output });
                cmd.Parameters.Add(new MySqlParameter("outP_fechaFin", MySqlDbType.DateTime) { Direction = ParameterDirection.Output });

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    decimal saldoInicio = Convert.ToDecimal(cmd.Parameters["outP_saldoInicio"].Value);
                    decimal ingresos = Convert.ToDecimal(cmd.Parameters["outP_ingresos"].Value);
                    decimal egresos = Convert.ToDecimal(cmd.Parameters["outP_egresos"].Value);
                    decimal saldoFin = Convert.ToDecimal(cmd.Parameters["outP_saldoFin"].Value);
                    DateTime fechaInicio = Convert.ToDateTime(cmd.Parameters["outP_fechaInicio"].Value);
                    DateTime fechaFin = Convert.ToDateTime(cmd.Parameters["outP_fechaFin"].Value);

                    return (saldoInicio, ingresos, egresos, saldoFin, fechaInicio, fechaFin);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error BD: {ex.Message}");
                    return null;
                }
            }
        }

        internal int fnc_registrarProducto(string v_remitente, long v_id, string v_fechaExp, string v_estudios, string v_fechaNac, long v_telefono, string v_correo, decimal v_ingresos, decimal v_egresos, string v_producto)
        {
            using (var conn = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand("prc_registrarProducto", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("prm_nombre", MySqlDbType.VarChar, 100).Value = v_remitente;
                cmd.Parameters.Add("prm_id", MySqlDbType.Int64).Value = v_id;
                cmd.Parameters.Add("prm_exp", MySqlDbType.Date).Value = DateTime.Parse(v_fechaExp);
                cmd.Parameters.Add("prm_estudios", MySqlDbType.VarChar, 50).Value = v_estudios;
                cmd.Parameters.Add("prm_nac", MySqlDbType.Date).Value = DateTime.Parse(v_fechaNac);
                cmd.Parameters.Add("prm_telefono", MySqlDbType.Int64).Value = v_telefono;
                cmd.Parameters.Add("prm_correo", MySqlDbType.VarChar, 50).Value = v_correo;
                cmd.Parameters.Add("prm_ingresos", MySqlDbType.Int64).Value = v_ingresos;
                cmd.Parameters.Add("prm_egresos", MySqlDbType.Int64).Value = v_egresos;
                cmd.Parameters.Add("prm_producto", MySqlDbType.VarChar, 50).Value = v_producto;

                cmd.Parameters.Add(new MySqlParameter("prm_resultado", MySqlDbType.Int32) { Direction = ParameterDirection.Output });

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    int resultado = int.Parse(cmd.Parameters["prm_resultado"].Value.ToString());

                    return resultado;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error BD: {ex.Message}");
                    return 0;
                }
            }
        }

        public DataTable fnc_consultarSolicitudes()
        {
            using (var conn = new MySqlConnection(connectionString))
            using (var cmd = new MySqlCommand("prc_consultarSolicitudes", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabla = new DataTable();
                    try
                    {
                        adapter.Fill(tabla);
                        return tabla;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error BD: " + ex.Message);
                        return null;
                    }
                }
            }
        }
    }
}
