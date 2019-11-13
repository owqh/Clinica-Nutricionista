using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ClinicaMedica.Models
{
    public class csPaciente
    {
        //Metodo para insertar 
        public void Insert(String nombres, String apellidos, String direccion, int dui, String fecha_nacimiento, char sexo,
            String correo, String estado_civil, float peso, int altura, int telefono, String alergias, String padecimientos_previos)
        {
            string conexion = ConfigurationManager.ConnectionStrings["DBClinica"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand("insertPaciente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombres", nombres);
            cmd.Parameters.AddWithValue("@apellidos", apellidos);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@dui", dui);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@estado_civil", estado_civil);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@altura", altura);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@alergias", alergias);
            cmd.Parameters.AddWithValue("@padecimientos_previos", padecimientos_previos);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }


        //Metodo para Modificar un paciente 
        public void Update(String codigo_paciente, String nombres, String apellidos, String direccion, int dui, String fecha_nacimiento, char sexo,
            String correo, String estado_civil, float peso, int altura, int telefono, String alergias, String padecimientos_previos)
        {
            string conexion = ConfigurationManager.ConnectionStrings["DBClinica"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand("insertPaciente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo_paciente", codigo_paciente);
            cmd.Parameters.AddWithValue("@nombres", nombres);
            cmd.Parameters.AddWithValue("@apellidos", apellidos);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@dui", dui);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@estado_civil", estado_civil);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@altura", altura);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@alergias", alergias);
            cmd.Parameters.AddWithValue("@padecimientos_previos", padecimientos_previos);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }


        //Metodo para eliminar un paciente (eliminacion suave)
        public void delete(String codigo_paciente, String nombres, String apellidos, String direccion, int dui, String fecha_nacimiento, char sexo,
            String correo, String estado_civil, float peso, int altura, int telefono, String alergias, String padecimientos_previos)
        {
            string conexion = ConfigurationManager.ConnectionStrings["DBClinica"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand("deletePaciente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo_paciente", codigo_paciente);
            cmd.Parameters.AddWithValue("@nombres", nombres);
            cmd.Parameters.AddWithValue("@apellidos", apellidos);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@dui", dui);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@estado_civil", estado_civil);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@altura", altura);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@alergias", alergias);
            cmd.Parameters.AddWithValue("@padecimientos_previos", padecimientos_previos);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }
    }
}