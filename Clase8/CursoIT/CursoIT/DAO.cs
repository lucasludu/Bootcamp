using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CursoIT
{
    class DAO
    {
        public static void Select()
        {
            SqlConnection conn = new SqlConnection("Server=LAPTOP-2VFM5C8I\\SQLEXPRESS;Database=DevPlaceBD;Integrated Security=True;");
            conn.Open();

            string query = "SELECT * FROM Curso C JOIN Tecnologia T ON T.IdTecnologia = C.idCurso";

            SqlCommand cmd = new SqlCommand(query, conn);

            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();

            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr[2]);
                Console.WriteLine(dr[3]);
                Console.WriteLine(dr[4]);
                Console.WriteLine(dr[5]);
            }
            Console.ReadKey();
        }
    }
}
