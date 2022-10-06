using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPI.Providers.Database.MySQL.Models
{
    public partial class CifSuiteContext : DbContext
    {
        public CifSuiteContext()
        {
        }

        public CifSuiteContext(DbContextOptions<CifSuiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Consolidation> Consolidations { get; set; } = null!;
        public virtual DbSet<Entity> Entities { get; set; } = null!;
        public virtual DbSet<Portfolioitem> Portfolioitems { get; set; } = null!;
        public virtual DbSet<Portfolioitemsvalidated> Portfolioitemsvalidateds { get; set; } = null!;
        public virtual DbSet<Wcurrency> Wcurrencies { get; set; } = null!;
        public virtual DbSet<Wfundingcollateralquality> Wfundingcollateralqualities { get; set; } = null!;
        public virtual DbSet<Witemclassification> Witemclassifications { get; set; } = null!;
        public virtual DbSet<Wportfolioitemtype> Wportfolioitemtypes { get; set; } = null!;
        public virtual DbSet<Wpurpose> Wpurposes { get; set; } = null!;
        public virtual DbSet<Wslriskcategory> Wslriskcategories { get; set; } = null!;
        public virtual DbSet<Wspecializedlending> Wspecializedlendings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user id=root;password=12Sqdan09;database=validatedump", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.38-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");

            modelBuilder.Entity<Consolidation>(entity =>
            {
                entity.ToTable("consolidation");

                entity.HasComment("Tabela se popunjava samo u slučaju konsolidovanog izveštavan")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.InstitutionName).HasMaxLength(255);

                entity.Property(e => e.InstitutionNo).HasMaxLength(255);

                entity.Property(e => e.InstitutionType).HasColumnType("int(11)");

                entity.Property(e => e.Share).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.ToTable("entities");

                entity.HasComment("Lista svih entiteta sa kojima Banka ima poslovanje.\nZa svaki")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.EntityNo, "i2");

                entity.HasIndex(e => e.EntityType, "i3");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Country)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.EntityType).HasColumnType("int(11)");

                entity.Property(e => e.InternalNo).HasMaxLength(255);

                entity.Property(e => e.IsHighNetWorthIndividual).HasColumnType("bit(1)");

                entity.Property(e => e.IsUnlikelyToWithdrawFunds).HasColumnType("bit(1)");

                entity.Property(e => e.IsValidated).HasColumnType("int(3)");

                entity.Property(e => e.LegalEntity).HasMaxLength(8);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.NonResident).HasColumnType("bit(1)");

                entity.Property(e => e.RegionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RegionID");

                entity.Property(e => e.Relationship).HasColumnType("bit(1)");

                entity.Property(e => e.Sector).HasColumnType("int(11)");

                entity.Property(e => e.Sskrsector)
                    .HasColumnType("int(11)")
                    .HasColumnName("SSKRSector");

                entity.Property(e => e.Treatment).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Portfolioitem>(entity =>
            {
                entity.ToTable("portfolioitems");

                entity.HasComment("U tabeli se vode fiksne karakteristike svih instrumenata u B")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ItemNo, "i5");

                entity.HasIndex(e => new { e.EntryDate, e.IsBalanceItem, e.IsAgregatePositionItem, e.IsBankingBookInstrument }, "i6");

                entity.HasIndex(e => e.ItemType, "i61");

                entity.HasIndex(e => e.CurrencyPay, "iCurrP");

                entity.HasIndex(e => new { e.EntryDate, e.ItemNo }, "index2");

                entity.HasIndex(e => new { e.EntryDate, e.OnBalancePartNo }, "index22");

                entity.HasIndex(e => e.EntityNo, "index3");

                entity.HasIndex(e => new { e.EntryDate, e.EntityNo }, "index4");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Class1LiquidAssetOverride).HasColumnType("bit(1)");

                entity.Property(e => e.Class2AliquidAssetOverride)
                    .HasColumnType("bit(1)")
                    .HasColumnName("Class2ALiquidAssetOverride");

                entity.Property(e => e.Class2BliquidAssetOverride)
                    .HasColumnType("bit(1)")
                    .HasColumnName("Class2BLiquidAssetOverride");

                entity.Property(e => e.CurrencyPay)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.CurrencyRef)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.FundingCollateralQuality).HasColumnType("int(11)");

                entity.Property(e => e.InitialCreditImpairedStatus).HasColumnType("bit(1)");

                entity.Property(e => e.InstrumentStatus).HasColumnType("int(11)");

                entity.Property(e => e.IsAgregatePositionItem).HasColumnType("bit(1)");

                entity.Property(e => e.IsBalanceItem).HasColumnType("bit(1)");

                entity.Property(e => e.IsBankingBookInstrument).HasColumnType("bit(1)");

                entity.Property(e => e.IsCorrOrPbaccount)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IsCorrOrPBAccount");

                entity.Property(e => e.IsCreditLiquidityLine).HasColumnType("bit(1)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(3)");

                entity.Property(e => e.IsDepositOfBankNetwork).HasColumnType("bit(1)");

                entity.Property(e => e.IsDepositOperatingAccount).HasColumnType("bit(1)");

                entity.Property(e => e.IsEffectiveFullyCoveredDeposit).HasColumnType("bit(1)");

                entity.Property(e => e.IsFundingCallableWithin30Days).HasColumnType("bit(1)");

                entity.Property(e => e.IsHighRisk).HasColumnType("bit(1)");

                entity.Property(e => e.IsIncludedInMarketIndex).HasColumnType("bit(1)");

                entity.Property(e => e.IsLiability).HasColumnType("bit(1)");

                entity.Property(e => e.IsLiquid).HasColumnType("bit(1)");

                entity.Property(e => e.IsLongTerm).HasColumnType("bit(1)");

                entity.Property(e => e.IsOnlyAccessibleOnline).HasColumnType("bit(1)");

                entity.Property(e => e.IsPartOfDiversifiedPortfolio).HasColumnType("bit(1)");

                entity.Property(e => e.IsPaymetScheduleGenerated).HasColumnType("bit(1)");

                entity.Property(e => e.IsPenalizedWithdrawal).HasColumnType("bit(1)");

                entity.Property(e => e.IsReliableSourceOfLiquidity).HasColumnType("bit(1)");

                entity.Property(e => e.IsSecuredFundingInstrument).HasColumnType("bit(1)");

                entity.Property(e => e.IsSecuritizedItem).HasColumnType("bit(1)");

                entity.Property(e => e.IsSteadyCf)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IsSteadyCF");

                entity.Property(e => e.IsValidated).HasColumnType("int(3)");

                entity.Property(e => e.IsWithdrawalLimitCondition).HasColumnType("bit(1)");

                entity.Property(e => e.ItemClassification).HasColumnType("int(11)");

                entity.Property(e => e.ItemName).HasMaxLength(255);

                entity.Property(e => e.ItemType).HasColumnType("int(11)");

                entity.Property(e => e.LastErrorField).HasMaxLength(64);

                entity.Property(e => e.LastErrorId)
                    .HasColumnType("int(3)")
                    .HasColumnName("LastErrorID");

                entity.Property(e => e.LifetimeCroverride)
                    .HasColumnType("bit(1)")
                    .HasColumnName("LifetimeCROverride");

                entity.Property(e => e.Pdmodel)
                    .HasColumnType("int(11)")
                    .HasColumnName("PDModel");

                entity.Property(e => e.Purpose).HasColumnType("int(11)");

                entity.Property(e => e.Seniority).HasColumnType("int(11)");

                entity.Property(e => e.SlriskCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("SLRiskCategory");

                entity.Property(e => e.SpecializedLending).HasColumnType("int(11)");

                entity.Property(e => e.SubConsolidatedId)
                    .HasMaxLength(255)
                    .HasColumnName("SubConsolidatedID");

                entity.Property(e => e.TerminationPeriod)
                    .HasMaxLength(45)
                    .HasComment("Samo za depozite: otkazni rok - ugovoreno razdoblje između davanja zahteva za raspolaganje depozitom i trenutka u kojem su sredstva depozita stvarno raspoloživa (u danima - D, nedeljama - W, mesecima - M, godinama - Y)");
            });

            modelBuilder.Entity<Portfolioitemsvalidated>(entity =>
            {
                entity.ToTable("portfolioitemsvalidated");

                entity.HasComment("U tabeli se vode fiksne karakteristike svih instrumenata u B")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ItemNo, "i5");

                entity.HasIndex(e => new { e.EntryDate, e.IsBalanceItem, e.IsAgregatePositionItem, e.IsBankingBookInstrument }, "i6");

                entity.HasIndex(e => e.ItemType, "i61");

                entity.HasIndex(e => e.CurrencyPay, "iCurrP");

                entity.HasIndex(e => new { e.EntryDate, e.ItemNo }, "index2");

                entity.HasIndex(e => new { e.EntryDate, e.OnBalancePartNo }, "index22");

                entity.HasIndex(e => e.EntityNo, "index3");

                entity.HasIndex(e => new { e.EntryDate, e.EntityNo }, "index4");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Class1LiquidAssetOverride).HasColumnType("bit(1)");

                entity.Property(e => e.Class2AliquidAssetOverride)
                    .HasColumnType("bit(1)")
                    .HasColumnName("Class2ALiquidAssetOverride");

                entity.Property(e => e.Class2BliquidAssetOverride)
                    .HasColumnType("bit(1)")
                    .HasColumnName("Class2BLiquidAssetOverride");

                entity.Property(e => e.CurrencyPay)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.CurrencyRef)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.FundingCollateralQuality).HasColumnType("int(11)");

                entity.Property(e => e.InitialCreditImpairedStatus).HasColumnType("bit(1)");

                entity.Property(e => e.InstrumentStatus).HasColumnType("int(11)");

                entity.Property(e => e.IsAgregatePositionItem).HasColumnType("bit(1)");

                entity.Property(e => e.IsBalanceItem).HasColumnType("bit(1)");

                entity.Property(e => e.IsBankingBookInstrument).HasColumnType("bit(1)");

                entity.Property(e => e.IsCorrOrPbaccount)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IsCorrOrPBAccount");

                entity.Property(e => e.IsCreditLiquidityLine).HasColumnType("bit(1)");

                entity.Property(e => e.IsDepositOfBankNetwork).HasColumnType("bit(1)");

                entity.Property(e => e.IsDepositOperatingAccount).HasColumnType("bit(1)");

                entity.Property(e => e.IsEffectiveFullyCoveredDeposit).HasColumnType("bit(1)");

                entity.Property(e => e.IsFundingCallableWithin30Days).HasColumnType("bit(1)");

                entity.Property(e => e.IsHighRisk).HasColumnType("bit(1)");

                entity.Property(e => e.IsIncludedInMarketIndex).HasColumnType("bit(1)");

                entity.Property(e => e.IsLiability).HasColumnType("bit(1)");

                entity.Property(e => e.IsLiquid).HasColumnType("bit(1)");

                entity.Property(e => e.IsLongTerm).HasColumnType("bit(1)");

                entity.Property(e => e.IsOnlyAccessibleOnline).HasColumnType("bit(1)");

                entity.Property(e => e.IsPartOfDiversifiedPortfolio).HasColumnType("bit(1)");

                entity.Property(e => e.IsPaymetScheduleGenerated).HasColumnType("bit(1)");

                entity.Property(e => e.IsPenalizedWithdrawal).HasColumnType("bit(1)");

                entity.Property(e => e.IsReliableSourceOfLiquidity).HasColumnType("bit(1)");

                entity.Property(e => e.IsSecuredFundingInstrument).HasColumnType("bit(1)");

                entity.Property(e => e.IsSecuritizedItem).HasColumnType("bit(1)");

                entity.Property(e => e.IsSteadyCf)
                    .HasColumnType("bit(1)")
                    .HasColumnName("IsSteadyCF");

                entity.Property(e => e.IsWithdrawalLimitCondition).HasColumnType("bit(1)");

                entity.Property(e => e.ItemClassification).HasColumnType("int(11)");

                entity.Property(e => e.ItemName).HasMaxLength(255);

                entity.Property(e => e.ItemType).HasColumnType("int(11)");

                entity.Property(e => e.LifetimeCroverride)
                    .HasColumnType("bit(1)")
                    .HasColumnName("LifetimeCROverride");

                entity.Property(e => e.Pdmodel)
                    .HasColumnType("int(11)")
                    .HasColumnName("PDModel");

                entity.Property(e => e.Purpose).HasColumnType("int(11)");

                entity.Property(e => e.Seniority).HasColumnType("int(11)");

                entity.Property(e => e.SlriskCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("SLRiskCategory");

                entity.Property(e => e.SpecializedLending).HasColumnType("int(11)");

                entity.Property(e => e.SubConsolidatedId)
                    .HasMaxLength(255)
                    .HasColumnName("SubConsolidatedID");

                entity.Property(e => e.TerminationPeriod)
                    .HasMaxLength(45)
                    .HasComment("Samo za depozite: otkazni rok - ugovoreno razdoblje između davanja zahteva za raspolaganje depozitom i trenutka u kojem su sredstva depozita stvarno raspoloživa (u danima - D, nedeljama - W, mesecima - M, godinama - Y)");
            });

            modelBuilder.Entity<Wcurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PRIMARY");

                entity.ToTable("wcurrencies");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.Isoalpha3, "iCurr1");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyName).HasMaxLength(100);

                entity.Property(e => e.Isoalpha3)
                    .HasMaxLength(3)
                    .HasColumnName("ISOAlpha3")
                    .IsFixedLength();

                entity.Property(e => e.Major).HasColumnType("bit(1)");
            });

            modelBuilder.Entity<Wfundingcollateralquality>(entity =>
            {
                entity.HasKey(e => e.FundingCollateralQualityId)
                    .HasName("PRIMARY");

                entity.ToTable("wfundingcollateralqualities");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.FundingCollateralQualityId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("FundingCollateralQualityID");

                entity.Property(e => e.FundingCollateralQualityDesc).HasMaxLength(45);
            });

            modelBuilder.Entity<Witemclassification>(entity =>
            {
                entity.HasKey(e => e.ItemClassificationId)
                    .HasName("PRIMARY");

                entity.ToTable("witemclassifications");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.ItemClassificationId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ItemClassificationID");

                entity.Property(e => e.ItemClassification).HasMaxLength(45);
            });

            modelBuilder.Entity<Wportfolioitemtype>(entity =>
            {
                entity.HasKey(e => e.PortfolioItemTypeIdPk)
                    .HasName("PRIMARY");

                entity.ToTable("wportfolioitemtypes");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PortfolioItemTypeIdPk)
                    .HasColumnType("int(11)")
                    .HasColumnName("PortfolioItemTypeID_PK");

                entity.Property(e => e.IsAgregatePositionItem).HasColumnType("bit(1)");

                entity.Property(e => e.IsBalanceItem).HasColumnType("bit(1)");

                entity.Property(e => e.IsLiability).HasColumnType("bit(1)");

                entity.Property(e => e.PortfolioItemTypeDesc).HasMaxLength(255);

                entity.Property(e => e.PortfolioItemTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PortfolioItemTypeID");
            });

            modelBuilder.Entity<Wpurpose>(entity =>
            {
                entity.HasKey(e => e.PurposeId)
                    .HasName("PRIMARY");

                entity.ToTable("wpurposes");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PurposeId, "PurposeID")
                    .IsUnique();

                entity.Property(e => e.PurposeId)
                    .HasColumnType("int(10)")
                    .ValueGeneratedNever()
                    .HasColumnName("PurposeID");

                entity.Property(e => e.PurposeDesc).HasMaxLength(255);
            });

            modelBuilder.Entity<Wslriskcategory>(entity =>
            {
                entity.HasKey(e => e.SlriskCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("wslriskcategories");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.SlriskCategoryId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("SLRIskCategoryID");

                entity.Property(e => e.SlriskCategoryDesc)
                    .HasMaxLength(255)
                    .HasColumnName("SLRIskCategoryDesc");
            });

            modelBuilder.Entity<Wspecializedlending>(entity =>
            {
                entity.HasKey(e => e.SpecializedLendingId)
                    .HasName("PRIMARY");

                entity.ToTable("wspecializedlendings");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.SpecializedLendingId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("SpecializedLendingID");

                entity.Property(e => e.SpecializedLendingDesc).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
