﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data_LojaDiretorioCarrinho.Models
{
    public partial class Produto
    {
        public Produto()
        {
            ProdutoClienteCarrinho = new HashSet<ProdutoClienteCarrinho>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("pdt_nome")]
        [StringLength(50)]
        [Unicode(false)]
        [DisplayName("Nome")]
        public string PdtNome { get; set; }
        [Column("pdt_preco")]
        [DisplayName("Preço")]
        public double PdtPreco { get; set; }
        [Required]
        [Column("pdt_marca")]
        [StringLength(50)]
        [Unicode(false)]
        [DisplayName("Marca")]
        public string PdtMarca { get; set; }
        [Required]
        [Column("pdt_localProduto")]
        [StringLength(100)]
        [Unicode(false)]
        [DisplayName("Localização do Produto")]
        public string PdtLocalProduto { get; set; }

        [InverseProperty("IdProdutoNavigation")]
        public virtual ICollection<ProdutoClienteCarrinho> ProdutoClienteCarrinho { get; set; }
    }
}