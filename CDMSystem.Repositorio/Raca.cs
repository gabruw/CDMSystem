using System;
using System.Collections.Generic;
using System.Text;

namespace CDMSystem.Repositorio.Context
{
    public class Raca
    {
        public Raca()
        {
            var newRaca = new Dominio.Entidades.Raca();

            var personagemRepository = new PersonagemRaca();
            personagemRepository.Incluid(newRaca);
        }
    }
}
