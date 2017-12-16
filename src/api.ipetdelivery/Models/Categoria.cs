namespace api.ipetdelivery.Models
{
    public class Categoria
    {
        public Categoria() { }
        public Categoria(int idCategoria, string descricao)
        {
            this.idCategoria = idCategoria;
            this.descricao = descricao;
        }
        public int idCategoria { get; set; }
        public string descricao { get; set; }
    }
}
