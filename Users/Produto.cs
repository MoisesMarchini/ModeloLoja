using ModeloLoja.Scripts;
using System;
using System.Collections.Generic;
using System.Data;
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
        public string imgPath { get; set; }

        public Produto(int _id)
        {
            id = _id;

            nome = Database.dataTableProdutos.Rows[id-1].ItemArray[1].ToString();
            descricao = Database.dataTableProdutos.Rows[id-1].ItemArray[2].ToString();
            preco = double.Parse(Database.dataTableProdutos.Rows[id-1].ItemArray[3].ToString());
            quantidade = (int)Database.dataTableProdutos.Rows[id - 1].ItemArray[4];
            imgPath = Database.dataTableProdutos.Rows[id - 1].ItemArray[5].ToString();
        }
        public Produto(DataRow row)
        {
            id = (int)row.ItemArray[0];
            nome = row.ItemArray[1].ToString();
            descricao = row.ItemArray[2].ToString();
            preco = double.Parse(row.ItemArray[3].ToString());
            quantidade = (int)row.ItemArray[4];
            imgPath = row.ItemArray[5].ToString();
        }
    }
}
