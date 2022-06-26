using System.ComponentModel.DataAnnotations.Schema;

namespace ListaNet.Models
{
    public class Servico
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServicoID { get; set; }
        public string Plano { get; set; }
        public int Valor { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}