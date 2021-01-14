using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BlazorCms.Server.Models
{
    public partial class BlazorCmsContext : DbContext
    {
        public BlazorCmsContext()
        {
        }

        public BlazorCmsContext(DbContextOptions<BlazorCmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=BlazorCms");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostAuthor).HasColumnName("post_author");

                entity.Property(e => e.PostContent)
                    .HasColumnType("text")
                    .HasColumnName("post_content");

                entity.Property(e => e.PostCreated)
                    .HasMaxLength(50)
                    .HasColumnName("post_created");

                entity.Property(e => e.PostPermalink)
                    .HasMaxLength(300)
                    .HasColumnName("post_permalink");

                entity.Property(e => e.PostThumbnail)
                    .HasMaxLength(100)
                    .HasColumnName("post_thumbnail");

                entity.Property(e => e.PostTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("post_title");

                entity.Property(e => e.PostUpdated)
                    .HasMaxLength(50)
                    .HasColumnName("post_updated");

                entity.HasOne(d => d.PostAuthorNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PostAuthor)
                    .HasConstraintName("FK__Post__post_autho__619B8048");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserAvatar)
                    .HasMaxLength(100)
                    .HasColumnName("user_avatar");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("user_email");

                entity.Property(e => e.UserFname)
                    .HasMaxLength(100)
                    .HasColumnName("user_fname");

                entity.Property(e => e.UserLname)
                    .HasMaxLength(100)
                    .HasColumnName("user_lname");

                entity.Property(e => e.UserPass)
                    .HasMaxLength(300)
                    .HasColumnName("user_pass");

                entity.Property(e => e.UserRegistered)
                    .HasMaxLength(50)
                    .HasColumnName("user_registered");

                entity.Property(e => e.UserSource)
                    .HasMaxLength(50)
                    .HasColumnName("user_source");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
