using System;
using Microsoft.Data.SqlClient;

namespace  capaDatos
{


    public class personas
    {

        //atributos de la clase personas para ser heredados en otras clases 
        public int ID;
        public string Nombre;
        public string apellido;
        public string Tipo; 

    }
    //clase estudiante para heredar de la clase personas sus atributos 

    public class estudiante : personas

    {
        public string carrera = "Ingeneria de Software";

    }

    public class Docente : personas

    { 
     public string materia = "Programacion";

    }

    public class personaDatos

    {

        public string conexion = "server=.;Database=escuela;integrated security=true";



        public personas obtenerPersonasID(int idBusqueda)

        {
            using (SqlConnection conn = new SqlConnection(conexion))

            {

                conn.Open();

                string query = "Select * from personas WHERE Id = @ID";
            }


        }



    }


}
