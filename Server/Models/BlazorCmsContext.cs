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
                optionsBuilder.UseSqlite("Name=BlazorCms");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostAuthor).HasColumnName("post_author");

                entity.Property(e => e.PostCategory).HasColumnName("post_category");

                entity.Property(e => e.PostContent).HasColumnName("post_content");

                entity.Property(e => e.PostCreated).HasColumnName("post_created");

                entity.Property(e => e.PostPermalink)
                    .IsRequired()
                    .HasColumnName("post_permalink");

                entity.Property(e => e.PostThumbnail).HasColumnName("post_thumbnail");

                entity.Property(e => e.PostTitle)
                    .IsRequired()
                    .HasColumnName("post_title");

                entity.Property(e => e.PostUpdated).HasColumnName("post_updated");

                entity.HasOne(d => d.PostAuthorNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PostAuthor)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserAvatar).HasColumnName("user_avatar");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("user_email");

                entity.Property(e => e.UserFname).HasColumnName("user_fname");

                entity.Property(e => e.UserLname).HasColumnName("user_lname");

                entity.Property(e => e.UserLogged).HasColumnName("user_logged");

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasColumnName("user_pass");

                entity.Property(e => e.UserRegistered).HasColumnName("user_registered");

                entity.Property(e => e.UserRoles).HasColumnName("user_roles");

                entity.Property(e => e.UserSource).HasColumnName("user_source");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
