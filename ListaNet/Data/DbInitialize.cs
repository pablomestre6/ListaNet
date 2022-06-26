using ListaNet.Models;
using System;
using System.Linq;

namespace ListaNet.Data
{
    public class DbInitialize
    {
        public static void Initialize(OpticalContext context)
        {
            context.Database.EnsureCreated();

            if (context.Produtos.Any())
            {
                return;
            }

                var produto = new Produto[]
                {
                    new Produto{FirstMidName="Pablo ",LastName="José",EnrollmentDate=DateTime.Parse("2009-08-11")},
                    new Produto{FirstMidName="Marcos ",LastName="Eliabe",EnrollmentDate=DateTime.Parse("2006-05-04")},
                    new Produto{FirstMidName="Marcos",LastName="Rickard",EnrollmentDate=DateTime.Parse("2002-09-23")},
                    new Produto{FirstMidName="Grazzy ",LastName="Silva",EnrollmentDate=DateTime.Parse("2002-01-09")},
                    new Produto{FirstMidName="Michael ",LastName="Torres",EnrollmentDate=DateTime.Parse("2010-03-09")},
                    new Produto{FirstMidName="Jaqueline ",LastName="Rubi",EnrollmentDate=DateTime.Parse("2002-09-03")},
                    new Produto{FirstMidName="Vivian ",LastName="Shankilina",EnrollmentDate=DateTime.Parse("2001-08-01")},
                    new Produto{FirstMidName="Ivan ",LastName="Nobre",EnrollmentDate=DateTime.Parse("2001-05-11")},
                };
                  context.Produtos.AddRange(produto);
                  context.SaveChanges();

                    var servico = new Servico[]
                    {
                         new Servico{ServicoID=1050, Plano="100",Valor=3},
                         new Servico{ServicoID=4022, Plano="190",Valor=3},
                         new Servico{ServicoID=4022, Plano="90",Valor=3},
                         new Servico{ServicoID=4022, Plano="150",Valor=3},
                         new Servico{ServicoID=4022, Plano="120",Valor=4},
                         new Servico{ServicoID=4022, Plano="450",Valor=4},
                         new Servico{ServicoID=4022, Plano="200",Valor=3},
                         new Servico{ServicoID=4022, Plano="124",Valor=4},
                    };
                      context.Servicos.AddRange(servico);
                      context.SaveChanges();

                    var enrollments = new Enrollment[]
                    {
                          new Enrollment{ProdutosID=1,ServicosID=1050,Grade=Grade.A},
                          new Enrollment{ProdutosID=1,ServicosID=4022,Grade=Grade.C},
                          new Enrollment{ProdutosID=1,ServicosID=4041,Grade=Grade.B},
                          new Enrollment{ProdutosID=2,ServicosID=1041,Grade=Grade.B},
                          new Enrollment{ProdutosID=2,ServicosID=3141,Grade=Grade.F},
                          new Enrollment{ProdutosID=2,ServicosID=2021,Grade=Grade.F},
                          new Enrollment{ProdutosID=3,ServicosID=1050},
                          new Enrollment{ProdutosID=4,ServicosID=1050},
                          new Enrollment{ProdutosID=4,ServicosID=4022,Grade=Grade.F},
                          new Enrollment{ProdutosID=5,ServicosID=4041,Grade=Grade.C},
                          new Enrollment{ProdutosID=6,ServicosID=1045},
                          new Enrollment{ProdutosID=7,ServicosID=3141,Grade=Grade.A},
                    };

                    context.Enrollments.AddRange(enrollments);
                    context.SaveChanges();
        }
    }
}
