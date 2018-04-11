﻿using System;

namespace TB.CursoMVC.Domain.Models
{
    public class Endereco : Entity
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Guid ClienteId { get; set; }

        // Propriedade de navegação do EF
        public virtual Cliente Cliente { get; set; }

        public override bool IsValid()
        {
            return true;
        }
    }
}