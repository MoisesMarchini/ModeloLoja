using ModeloLoja.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLoja.Users
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }

        public Produto(int _id)
        {
            id = _id;

            nome = Database.dataTableProdutos.Rows[id-1].ItemArray[1].ToString();
            descricao = Database.dataTableProdutos.Rows[id-1].ItemArray[2].ToString();
            preco = (double)Database.dataTableProdutos.Rows[id-1].ItemArray[3];
            quantidade = (int)Database.dataTableProdutos.Rows[id-1].ItemArray[4];
        }
    }
}
