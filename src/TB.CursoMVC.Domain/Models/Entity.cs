using System;

namespace TB.CursoMVC.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public abstract bool IsValid();

    }
}