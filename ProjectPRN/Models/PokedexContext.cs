using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProjectPRN.Models
{
    public partial class PokedexContext : DbContext
    {
        public PokedexContext()
        {
        }

        public PokedexContext(DbContextOptions<PokedexContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<EvoChain> EvoChains { get; set; }
        public virtual DbSet<GamePatch> GamePatches { get; set; }
        public virtual DbSet<Move> Moves { get; set; }
        public virtual DbSet<Nature> Natures { get; set; }
        public virtual DbSet<PokeAbi> PokeAbis { get; set; }
        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-C60MLV4; database=Pokedex; user=sa; password=tu25072001");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Ability>(entity =>
            {
                entity.HasKey(e => e.AbiId)
                    .HasName("PK__Ability__9A2DFF2F29572725");

                entity.ToTable("Ability");

                entity.Property(e => e.AbiId)
                    .ValueGeneratedNever()
                    .HasColumnName("AbiID");

                entity.Property(e => e.AbilityName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ability Name");

                entity.Property(e => e.Effect)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("PK__Account__91CBC3785AEE82B9");

                entity.ToTable("Account");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Poke1)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Poke2)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Poke3)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Poke4)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Poke5)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Poke6)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__Category__6A1C8ADA21B6055D");

                entity.ToTable("Category");

                entity.Property(e => e.CatId)
                    .ValueGeneratedNever()
                    .HasColumnName("CatID");

                entity.Property(e => e.CatName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Cat Name");
            });

            modelBuilder.Entity<EvoChain>(entity =>
            {
                entity.HasKey(e => e.EvoId)
                    .HasName("PK__Evo Chai__DDF316FA30F848ED");

                entity.ToTable("Evo Chain");

                entity.Property(e => e.EvoId)
                    .ValueGeneratedNever()
                    .HasColumnName("EvoID");

                entity.Property(e => e.Stage1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Stage2)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GamePatch>(entity =>
            {
                entity.HasKey(e => e.GameId)
                    .HasName("PK__GamePatc__2AB897DD5165187F");

                entity.ToTable("GamePatch");

                entity.Property(e => e.GameId)
                    .ValueGeneratedNever()
                    .HasColumnName("GameID");

                entity.Property(e => e.Connectivity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Elite4)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Enimies)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GameName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GymLeader1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GymLeader2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GymLeader3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GymLeader4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GymLeader5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GymLeader6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GymLeader7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GymLeader8)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Image2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Main)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Players)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plot)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Professor)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Move>(entity =>
            {
                entity.ToTable("Move");

                entity.Property(e => e.MoveCat)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MoveName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pp).HasColumnName("PP");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Moves)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Move__TypeId__6A30C649");
            });

            modelBuilder.Entity<Nature>(entity =>
            {
                entity.ToTable("Nature");

                entity.Property(e => e.NatureId)
                    .ValueGeneratedNever()
                    .HasColumnName("NatureID");

                entity.Property(e => e.DecreaseStat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Decrease Stat");

                entity.Property(e => e.IncreaseStat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Increase Stat");

                entity.Property(e => e.NatureName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Nature Name");
            });

            modelBuilder.Entity<PokeAbi>(entity =>
            {
                entity.HasKey(e => new { e.AbiId, e.PokeId })
                    .HasName("PK__Poke-Abi__129CD63D440B1D61");

                entity.ToTable("Poke-Abi");

                entity.Property(e => e.AbiId).HasColumnName("AbiID");

                entity.Property(e => e.PokeId).HasColumnName("PokeID");

                entity.HasOne(d => d.Abi)
                    .WithMany(p => p.PokeAbis)
                    .HasForeignKey(d => d.AbiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Poke-Abi__AbiID__46E78A0C");

                entity.HasOne(d => d.Poke)
                    .WithMany(p => p.PokeAbis)
                    .HasForeignKey(d => d.PokeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Poke-Abi__PokeID__45F365D3");
            });

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.HasKey(e => e.PokeId)
                    .HasName("PK__Pokemon__8B12912934C8D9D1");

                entity.ToTable("Pokemon");

                entity.Property(e => e.PokeId)
                    .ValueGeneratedNever()
                    .HasColumnName("PokeID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Describe)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("describe");

                entity.Property(e => e.EvoId).HasColumnName("EvoID");

                entity.Property(e => e.FemaleRate).HasColumnName("Female Rate");

                entity.Property(e => e.Hp).HasColumnName("HP");

                entity.Property(e => e.Img)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaleRate).HasColumnName("Male Rate");

                entity.Property(e => e.PokemonName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pokemon Name");

                entity.Property(e => e.SpAttack).HasColumnName("Sp.Attack");

                entity.Property(e => e.SpDefense).HasColumnName("Sp.Defense");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeId2).HasColumnName("TypeID2");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Pokemons)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__Pokemon__CatID__3F466844");

                entity.HasOne(d => d.Evo)
                    .WithMany(p => p.Pokemons)
                    .HasForeignKey(d => d.EvoId)
                    .HasConstraintName("FK__Pokemon__EvoID__403A8C7D");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PokemonTypes)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Pokemon__TypeID__3E52440B");

                entity.HasOne(d => d.TypeId2Navigation)
                    .WithMany(p => p.PokemonTypeId2Navigations)
                    .HasForeignKey(d => d.TypeId2)
                    .HasConstraintName("FK__Pokemon__TypeID2__412EB0B6");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("Type");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("TypeID");

                entity.Property(e => e.BugRate).HasColumnName("Bug Rate");

                entity.Property(e => e.DarkRate).HasColumnName("Dark Rate");

                entity.Property(e => e.DragonRate).HasColumnName("Dragon Rate");

                entity.Property(e => e.ElectricRate).HasColumnName("Electric Rate");

                entity.Property(e => e.FairyRate).HasColumnName("Fairy Rate");

                entity.Property(e => e.FightingRate).HasColumnName("Fighting Rate");

                entity.Property(e => e.FireRate).HasColumnName("Fire Rate");

                entity.Property(e => e.FlyingRate).HasColumnName("Flying Rate");

                entity.Property(e => e.GhostRate).HasColumnName("Ghost Rate");

                entity.Property(e => e.GrassRate).HasColumnName("Grass Rate");

                entity.Property(e => e.GroundRate).HasColumnName("Ground Rate");

                entity.Property(e => e.IceRate).HasColumnName("Ice Rate");

                entity.Property(e => e.NormalRate).HasColumnName("Normal Rate");

                entity.Property(e => e.PoisonRate).HasColumnName("Poison Rate");

                entity.Property(e => e.PsychicRate).HasColumnName("Psychic Rate");

                entity.Property(e => e.RockRate).HasColumnName("Rock Rate");

                entity.Property(e => e.SteelRate).HasColumnName("Steel Rate");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Type Name");

                entity.Property(e => e.WaterRate).HasColumnName("Water Rate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
