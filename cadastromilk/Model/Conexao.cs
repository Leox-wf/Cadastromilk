using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastromilk.Model
{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leonardo.mockaites\OneDrive\projetoc#\ProjCadastroMilk\cadastromilk\cadastromilk\Database1.mdf;Integrated Security=True";

        }
    }
}
