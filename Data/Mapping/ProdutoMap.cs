using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project_EveryMind.Models;

namespace Project_EveryMind.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure (EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(x => x.Nome).IsRequired().HasColumnName("Nome").HasColumnType("VARCHAR").HasMaxLength(70);

            builder.Property(x => x.CodigoProduto).IsRequired().HasColumnName("CodigoProduto").HasColumnType("VARCHAR").HasMaxLength(70);

            builder.Property(x => x.DescriçãoProduto).IsRequired().HasColumnName("DescriçãoProduto").HasColumnType("TEXT").HasMaxLength(255);

            builder.Property(x=>x.PrecoProduto).IsRequired().HasColumnName("PrecoProduto").HasColumnType("VARCHAR").HasMaxLength(70);

            builder.HasIndex(x => x.CodigoProduto, "IX_Produto_Codigo").IsUnique();
        }
    }
}
