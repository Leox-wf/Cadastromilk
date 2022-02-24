using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastromilk.Model
{
    class ModelCadastro
    {
        private static int id;
        private static string nome;
        private static string fone;
        private static string cpf;
        private static string endereco;
        private static string ncarterinha;
        private static string data;
        private static string Responsavel;

        public static int Id { get => id; set => id = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Fone { get => fone; set => fone = value; }
        public static string Cpf { get => cpf; set => cpf = value; }
        public static string Endereco { get => endereco; set => endereco = value; }
        public static string Ncarterinha { get => ncarterinha; set => ncarterinha = value; }
        public static string Data { get => data; set => data = value; }
        public static string Responsavel1 { get => Responsavel; set => Responsavel = value; }
        public static string Retorno { get; internal set; }
    }
}
