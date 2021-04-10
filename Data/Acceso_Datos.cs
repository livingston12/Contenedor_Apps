using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidade;

namespace Data
{
  public class Acceso_Datos
    {
        public static SqlConnection con = new SqlConnection();
        SqlCommand comando = MetodosDatos.CrearComando();
        public static bool login(string usuario, string pass, string tipo)
        {
           
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT * FROM USUARIOS WHERE usuario='" + usuario + "' and pass='" + pass + "' and tipo='" + tipo + "'";

            if (MetodosDatos.ejecutarComandoSelect(comando).Rows.Count > 0)
            {
                return true;
            }
            else return false;


        }

        //-------------------USUARIOS-----------------------------
        public DataTable BuscarUsuario(Eusuario usuario) {
            if (usuario == null) usuario = new Eusuario();
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_usuario", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@a",usuario.a);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@pass", "");
            comando.Parameters.AddWithValue("@tipo", "");
            comando.Parameters.AddWithValue("@nombre", usuario.nombre);
            comando.Parameters.AddWithValue("@apellido", "");
            comando.Parameters.AddWithValue("@curso", "");
            return MetodosDatos.ejecutarComandoSelect(comando);
        }

       

        public void InsertarUsuario(Eusuario usuario)
        {
            try
            {
                con.ConnectionString = Conexion.cadenaConexion;
                comando = new SqlCommand("Sp_usuario", con);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@a",usuario.a);
                comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
                comando.Parameters.AddWithValue("@pass", usuario.pass);
                comando.Parameters.AddWithValue("@tipo", usuario.tipo);
                comando.Parameters.AddWithValue("@nombre", usuario.nombre);
                comando.Parameters.AddWithValue("@apellido", usuario.apellido);
                comando.Parameters.AddWithValue("@curso", usuario.curso);
                con.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
      
        //----------------SUPLIDORES--------------------------------
        public DataTable BuscarSuplidores(Esuplidores suplidor) {
            if (suplidor == null) suplidor = new Esuplidores();
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_suplidor", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@a", suplidor.a);
            comando.Parameters.AddWithValue("@nombre", suplidor.nombre);
            comando.Parameters.AddWithValue("@direccion", "");
            comando.Parameters.AddWithValue("@telefono", "");
            comando.Parameters.AddWithValue("ciudad", "");
            return MetodosDatos.ejecutarComandoSelect(comando);
        }

      

        public void InsertarSuplidores(Esuplidores suplidor)
        {
            try
            {
                con.ConnectionString = Conexion.cadenaConexion;
                comando = new SqlCommand("Sp_suplidor", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@a", "Insertar");
                comando.Parameters.AddWithValue("@nombre", suplidor.nombre);
                comando.Parameters.AddWithValue("@direccion", suplidor.direccion);
                comando.Parameters.AddWithValue("@telefono", suplidor.telefono);
                comando.Parameters.AddWithValue("@ciudad", suplidor.ciudad);
                con.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally {
                con.Close();
            }
        }

        //______________________PROFESORES_______________________________
        #region datos profesores
        public DataTable BuscarProfesores(Eprofesores profesor)
        {
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_profesores", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@a", profesor.a);
            comando.Parameters.AddWithValue("@nombre", "");
            comando.Parameters.AddWithValue("@apellido", "");
            comando.Parameters.AddWithValue("@cedula", profesor.cedula);
            comando.Parameters.AddWithValue("@telefono", "");
            comando.Parameters.AddWithValue("@direccion", "");
            comando.Parameters.AddWithValue("@fecha", "");

           return MetodosDatos.ejecutarComandoSelect(comando);
        }

   

        public void InsertarProfesores(Eprofesores profesor)
        {
            try {
                con.ConnectionString = Conexion.cadenaConexion;
                comando = new SqlCommand("Sp_profesores", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@a", "Insertar");
                comando.Parameters.AddWithValue("@nombre", profesor.nombre);
                comando.Parameters.AddWithValue("@apellido", profesor.apellido);
                comando.Parameters.AddWithValue("@cedula", profesor.cedula);
                comando.Parameters.AddWithValue("@telefono", profesor.telefono);
                comando.Parameters.AddWithValue("@direccion", profesor.direccion);
                comando.Parameters.AddWithValue("@fecha", profesor.fecha);
                con.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            
        }

        #endregion

        //______________________MATERIAS_______________________________
        public DataTable BuscarMaterias(Ematerias materia)
        {
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_materias", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@a", materia.a);
            comando.Parameters.AddWithValue("@cod_materia", materia.cod_materia);
            comando.Parameters.AddWithValue("@nombre", materia.nombre);
            comando.Parameters.AddWithValue("@descripcion", "");
           return MetodosDatos.ejecutarComandoSelect(comando);
        }

           public void InsertarMaterias(Ematerias materia)
        {
            try
            {
                con.ConnectionString = Conexion.cadenaConexion;
                comando = new SqlCommand("Sp_materias", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@a", "Insertar");
                comando.Parameters.AddWithValue("@cod_materia", materia.cod_materia);
                comando.Parameters.AddWithValue("@nombre", materia.nombre);
                comando.Parameters.AddWithValue("@descripcion", materia.descripcion);
                con.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            
        }


        //______________________EVENTOS_______________________________
        public void InsertarEventos(Eeventos evento)
        {
            try
            {
                con.ConnectionString = Conexion.cadenaConexion;
                comando = new SqlCommand("Sp_eventos", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@a", evento.a);
                comando.Parameters.AddWithValue("@descripcion", evento.descripcion);
                comando.Parameters.AddWithValue("@referencia", evento.referencia);
                comando.Parameters.AddWithValue("@precio", evento.precio);
                comando.Parameters.AddWithValue("@fecha", evento.fecha);
                con.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public DataTable BuscarEventos(Eeventos evento)
        {
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_eventos", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@a", evento.a);
            comando.Parameters.AddWithValue("@descripcion", evento.descripcion);
            comando.Parameters.AddWithValue("@referencia", evento.referencia);
            comando.Parameters.AddWithValue("@precio", "");
            comando.Parameters.AddWithValue("@fecha", "");
            return MetodosDatos.ejecutarComandoSelect(comando);
        }
        public DataTable BuscarTodosEventos(Eeventos evento)
        {
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_eventos", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@a", evento.a);
            comando.Parameters.AddWithValue("@descripcion", "");
            comando.Parameters.AddWithValue("@referencia", "");
            comando.Parameters.AddWithValue("@precio", "");
            comando.Parameters.AddWithValue("@fecha", "");
            return MetodosDatos.ejecutarComandoSelect(comando);
        }

        //______________________EXCURSIONES_______________________________

        public DataTable BuscarExcursiones(Eexcursiones excursion) 
        {
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_excursiones",con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@a", excursion.a);
            comando.Parameters.AddWithValue("@descripcion", excursion.descripcion);
            comando.Parameters.AddWithValue("@referencia", excursion.referencia);
            comando.Parameters.AddWithValue("@precio", "");
            comando.Parameters.AddWithValue("@fecha", "");
            return MetodosDatos.ejecutarComandoSelect(comando);
        }
       
        public void InsertarExcursiones(Eexcursiones excursion)
        {
            try
            {
                con.ConnectionString = Conexion.cadenaConexion;
                comando = new SqlCommand("Sp_excursiones", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@a", excursion.a);
                comando.Parameters.AddWithValue("@descripcion", excursion.descripcion);
                comando.Parameters.AddWithValue("@referencia", excursion.referencia);
                comando.Parameters.AddWithValue("@precio", excursion.precio);
                comando.Parameters.AddWithValue("@fecha", excursion.fecha);
                con.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            } 
        }

        //______________________CURSOS_______________________________

        public DataTable BuscarCursos(Ecursos curso)
        {
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_cursos", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@a", curso.a);
            comando.Parameters.AddWithValue("@nombre", curso.nombre);
            comando.Parameters.AddWithValue("@horas", "");
            return MetodosDatos.ejecutarComandoSelect(comando);
        }

        public void InsertarCursos(Ecursos curso)
        {
            try
            {
                con.ConnectionString = Conexion.cadenaConexion;
                comando = new SqlCommand("Sp_cursos", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@a", curso.a);
                comando.Parameters.AddWithValue("@nombre", curso.nombre);
                comando.Parameters.AddWithValue("@horas", curso.horas);
                con.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        //______________________PRODUCTOS_______________________________
        public DataTable BuscarProductos(Eproductos producto)
        {
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_productos", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_producto", "");
            comando.Parameters.AddWithValue("@a", producto.a);
            comando.Parameters.AddWithValue("@descripcion", producto.descripcion);
            comando.Parameters.AddWithValue("@referencia", producto.refencia);
            comando.Parameters.AddWithValue("@marca", "");
            comando.Parameters.AddWithValue("@fabricante", "");
            comando.Parameters.AddWithValue("@cantidad", "");
            comando.Parameters.AddWithValue("@precio_por_mayor", "");
            comando.Parameters.AddWithValue("@precio_venta", "");
            comando.Parameters.AddWithValue("@precio_compra", "");
            return MetodosDatos.ejecutarComandoSelect(comando);
        }
        public DataTable ActualizarProductos(Eproductos producto)
        {
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_productos", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@a", producto.a);
            comando.Parameters.AddWithValue("@id_producto", producto.Id);
            comando.Parameters.AddWithValue("@descripcion", "");
            comando.Parameters.AddWithValue("@referencia", "");
            comando.Parameters.AddWithValue("@marca", "");
            comando.Parameters.AddWithValue("@fabricante", "");
            comando.Parameters.AddWithValue("@cantidad", producto.cantidad);
            comando.Parameters.AddWithValue("@precio_por_mayor", "");
            comando.Parameters.AddWithValue("@precio_venta", "");
            comando.Parameters.AddWithValue("@precio_compra", "");
            return MetodosDatos.ejecutarComandoSelect(comando);
        }

        public void InsertarProductos(Eproductos producto)
        {
            try {
                con.ConnectionString = Conexion.cadenaConexion;
                comando = new SqlCommand("Sp_productos", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@a", producto.a);
                comando.Parameters.AddWithValue("@id_producto","");
                comando.Parameters.AddWithValue("@descripcion", producto.descripcion);
                comando.Parameters.AddWithValue("@referencia", producto.refencia);
                comando.Parameters.AddWithValue("@marca", producto.marca);
                comando.Parameters.AddWithValue("@fabricante", producto.fabricante);
                comando.Parameters.AddWithValue("@cantidad", producto.cantidad);
                comando.Parameters.AddWithValue("@precio_por_mayor",producto.precio_mayor);
                comando.Parameters.AddWithValue("@precio_venta", producto.precio_venta);
                comando.Parameters.AddWithValue("@precio_compra", producto.precio_compra);
                con.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }


        //______________________ESTUDIANTES_______________________________
        public void InsertarEstudiantes(Eestudiantes estudiante)
        {
            try
            {
                con.ConnectionString = Conexion.cadenaConexion;
                comando = new SqlCommand("Sp_estudiantes", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@a", estudiante.a);
                comando.Parameters.AddWithValue("@nombre", estudiante.nombre);
                comando.Parameters.AddWithValue("@apellidos", estudiante.apellidos);
                comando.Parameters.AddWithValue("@rne", estudiante.rne);
                comando.Parameters.AddWithValue("@fecha", estudiante.fecha);
                comando.Parameters.AddWithValue("@sexo", estudiante.sexo);
                comando.Parameters.AddWithValue("@direccion", estudiante.direccion);
                comando.Parameters.AddWithValue("@telefono", estudiante.telefono);
                comando.Parameters.AddWithValue("@enfermedades", estudiante.enfermedades);
                comando.Parameters.AddWithValue("@tipo_sangre", estudiante.tipo_sangre);
                comando.Parameters.AddWithValue("@ano", estudiante.ano);
                comando.Parameters.AddWithValue("@tanda", estudiante.tanda);
                comando.Parameters.AddWithValue("@curso", estudiante.curso);
                comando.Parameters.AddWithValue("@instituto", estudiante.instituto);

                con.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable BuscarEstudiantes(Eestudiantes estudiante)
        {
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_estudiantes", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@a", estudiante.a);
            comando.Parameters.AddWithValue("@nombre", estudiante.nombre);
            comando.Parameters.AddWithValue("@apellidos", estudiante.apellidos);
            comando.Parameters.AddWithValue("@rne", estudiante.rne);
            comando.Parameters.AddWithValue("@fecha", "");
            comando.Parameters.AddWithValue("@sexo", "");
            comando.Parameters.AddWithValue("@direccion", "");
            comando.Parameters.AddWithValue("@telefono", "");
            comando.Parameters.AddWithValue("@enfermedades", "");
            comando.Parameters.AddWithValue("@tipo_sangre", "");
            comando.Parameters.AddWithValue("@ano", "");
            comando.Parameters.AddWithValue("@tanda", "");
            comando.Parameters.AddWithValue("@curso", estudiante.curso);
            comando.Parameters.AddWithValue("@instituto", "");
            return MetodosDatos.ejecutarComandoSelect(comando);
        }

        //______________________COMPRAS_______________________________
        public void InsertarCompras(Ecompras compra)
        {
            try
            {
                con.ConnectionString = Conexion.cadenaConexion;
                comando = new SqlCommand("Sp_compras", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@a", compra.a);
                comando.Parameters.AddWithValue("@suplidor", compra.suplidor);
                comando.Parameters.AddWithValue("@tipo_compra", compra.tipo_compra);
                comando.Parameters.AddWithValue("@total_pagar", compra.total_pagar);
                comando.Parameters.AddWithValue("@fecha", "");
                

                con.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }


        //______________________CXP_______________________________
        public DataTable BuscarCxp(Ecxp cxp)
        {
            con.ConnectionString = Conexion.cadenaConexion;
            comando = new SqlCommand("Sp_Cxp", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@a", cxp.a);
            comando.Parameters.AddWithValue("@suplidor", cxp.suplidor);
            
            return MetodosDatos.ejecutarComandoSelect(comando);
        }


    }
}
