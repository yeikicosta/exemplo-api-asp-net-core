namespace api.ipetdelivery.Models
{
    public class Parceiro
    {
        public Parceiro() { }
        public Parceiro(int idParceiro, string nome, string descricao, Categoria categoria)
        {
            this.idParceiro = idParceiro;
            this.nome = nome;
            this.categoria = categoria;
        }
        public int idParceiro { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal avaliacao { get; set; }
        public Categoria categoria { get; set; }
    }
}
