namespace ListaNet.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        internal readonly object Servico;

        public int EnrollmentID { get; set; }
        public int ProdutosID { get; set; }
        public int ServicosID { get; set; }
       
        public Grade? Grade { get; set; }

        public Produto Produtos { get; set; }
        public Servico Servicos { get; set; }
    }
}
