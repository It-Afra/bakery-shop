﻿using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Infrastructure.EntityFramework.Configuration
{
    public class bksSchaduleConfiguration : IEntityTypeConfiguration<bksSchadule>
    {
        public void Configure(EntityTypeBuilder<bksSchadule> builder)
        {
            builder.ToTable(nameof(bksSchadule));

            builder.HasKey(b => b.Id);

            builder.Property(s => s.SchaduleDate).HasMaxLength(10).IsRequired();

            builder.Property(s => s.SchaduleDateL).IsRequired();

            builder.Property(s => s.SchaduleTime).HasMaxLength(10).IsRequired();

            builder.Property(s => s.SchaduleTimeL).IsRequired();
        }
    }
}
