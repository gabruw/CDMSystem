using CDMSystem.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDMSystem.Repositorio
{
    public class Personagem
    {
        public Personagem()
        {
            var newPersonagem = new Dominio.Entidades.Personagem();

            var personagemRepository = new PersonagemRepository();
            personagemRepository.Incluid(newPersonagem);
        }
    }
}