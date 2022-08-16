using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Model;

namespace WebApi.EntityConfig;

public class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("tb_book");

        builder.HasKey(prop => prop.Id)
        .HasName("PK_book");

        builder.Property(prop => prop.Id)
            .IsRequired()
            .HasColumnName("Id")
            .HasColumnType("int");

        builder.Property(prop => prop.Author)
            .IsRequired()
            .HasColumnName("Author")
            .HasColumnType("longtext");
        
        builder.Property(prop => prop.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("longtext");

        builder.Property(prop => prop.Description)
            .HasColumnName("Descritption")
            .HasColumnType("longtext");

    }
}