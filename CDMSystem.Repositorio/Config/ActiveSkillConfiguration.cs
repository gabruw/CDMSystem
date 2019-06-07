using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDMSystem.Repositorio.Config
{
    public class ActiveSkillConfiguration : IEntityTypeConfiguration<ActiveSkill>
    {
        public void Configure(EntityTypeBuilder<ActiveSkill> builder)
        {
            throw new NotImplementedException();
        }
    }
}