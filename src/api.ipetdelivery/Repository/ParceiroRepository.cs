using api.ipetdelivery.Models;
using System;
using System.Collections.Generic;

namespace api.ipetdelivery.Repository
{
    public class ParceiroRepository : BaseRepository<Parceiro>
    {
        public override IEnumerable<Parceiro> get()
        {
            Random random = new Random();
            return new List<Parceiro>()
            {
                new Parceiro()
                {
                    avaliacao = (decimal)random.NextDouble() * 5,
                    nome = "Pet Shop 1",
                    idParceiro = 1,
                    descricao = "Descrição breve 1",
                    categoria = new Categoria()
                    {
                        idCategoria = 1,
                        descricao = "Pet"
                    }
                },
                new Parceiro()
                {
                    avaliacao = (decimal)random.NextDouble() * 5,
                    nome = "Pet Shop 2",
                    idParceiro = 2,
                    descricao = "Descrição breve 2",
                    categoria = new Categoria()
                    {
                        idCategoria = 1,
                        descricao = "Pet"
                    }
                },
                new Parceiro()
                {
                    avaliacao = (decimal)random.NextDouble() * 5,
                    nome = "Pet Shop 3",
                    idParceiro = 3,
                    descricao = "Descrição breve 3",
                    categoria = new Categoria()
                    {
                        idCategoria = 1,
                        descricao = "Pet"
                    }
                },
                new Parceiro()
                {
                    avaliacao = (decimal)random.NextDouble() * 5,
                    nome = "Banho e Tosa 1",
                    idParceiro = 4,
                    descricao = "Descrição breve 1",
                    categoria = new Categoria()
                    {
                        idCategoria = 2,
                        descricao = "Banho e tosa"
                    }
                },
                new Parceiro()
                {
                    avaliacao = (decimal)random.NextDouble() * 5,
                    nome = "Banho e Tosa 2",
                    idParceiro = 5,
                    descricao = "Descrição breve 2",
                    categoria = new Categoria()
                    {
                        idCategoria = 2,
                        descricao = "Banho e tosa"
                    }
                },
                new Parceiro()
                {
                    avaliacao = (decimal)random.NextDouble() * 5,
                    nome = "Adestrador 1",
                    idParceiro = 6,
                    descricao = "Descrição breve 1",
                    categoria = new Categoria()
                    {
                        idCategoria = 3,
                        descricao = "Adestramento"
                    }
                },
                new Parceiro()
                {
                    avaliacao = (decimal)random.NextDouble() * 5,
                    nome = "Adestrador 2",
                    idParceiro = 7,
                    descricao = "Descrição breve 2",
                    categoria = new Categoria()
                    {
                        idCategoria = 3,
                        descricao = "Adestramento"
                    }
                },
                new Parceiro()
                {
                    avaliacao = (decimal)random.NextDouble() * 5,
                    nome = "Adestrador 3",
                    idParceiro = 8,
                    descricao = "Descrição breve 3",
                    categoria = new Categoria()
                    {
                        idCategoria = 3,
                        descricao = "Adestramento"
                    }
                }
            };
        }
    }
}
