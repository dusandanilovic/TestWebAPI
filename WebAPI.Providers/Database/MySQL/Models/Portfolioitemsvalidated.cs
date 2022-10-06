using System;
using System.Collections.Generic;

namespace WebAPI.Providers.Database.MySQL.Models
{
    /// <summary>
    /// U tabeli se vode fiksne karakteristike svih instrumenata u B
    /// </summary>
    public partial class Portfolioitemsvalidated
    {
        public int Id { get; set; }
        public DateOnly EntryDate { get; set; }
        public string ItemNo { get; set; } = null!;
        public string? ItemName { get; set; }
        public string EntityNo { get; set; } = null!;
        public ulong IsLiability { get; set; }
        public ulong IsBalanceItem { get; set; }
        public ulong IsBankingBookInstrument { get; set; }
        public ulong IsAgregatePositionItem { get; set; }
        public string? SubConsolidatedId { get; set; }
        public int? ItemClassification { get; set; }
        public string? OnBalancePartNo { get; set; }
        public int ItemType { get; set; }
        public string CurrencyRef { get; set; } = null!;
        public string? CurrencyPay { get; set; }
        public double? FaceValue { get; set; }
        public double? DownPayment { get; set; }
        public ulong? IsPaymetScheduleGenerated { get; set; }
        /// <summary>
        /// Samo za depozite: otkazni rok - ugovoreno razdoblje između davanja zahteva za raspolaganje depozitom i trenutka u kojem su sredstva depozita stvarno raspoloživa (u danima - D, nedeljama - W, mesecima - M, godinama - Y)
        /// </summary>
        public string? TerminationPeriod { get; set; }
        public int? Seniority { get; set; }
        public ulong? IsLiquid { get; set; }
        public ulong? IsSecuritizedItem { get; set; }
        public int? Purpose { get; set; }
        public ulong? IsIncludedInMarketIndex { get; set; }
        public ulong? IsPartOfDiversifiedPortfolio { get; set; }
        public ulong? IsSteadyCf { get; set; }
        public ulong? IsLongTerm { get; set; }
        public int? SpecializedLending { get; set; }
        public int? SlriskCategory { get; set; }
        public ulong? IsHighRisk { get; set; }
        public double? DeductionFromCapital { get; set; }
        public ulong? IsWithdrawalLimitCondition { get; set; }
        public ulong? InitialCreditImpairedStatus { get; set; }
        public int? Pdmodel { get; set; }
        public ulong? LifetimeCroverride { get; set; }
        public ulong? IsSecuredFundingInstrument { get; set; }
        public ulong? IsReliableSourceOfLiquidity { get; set; }
        public ulong? IsEffectiveFullyCoveredDeposit { get; set; }
        public ulong? IsFundingCallableWithin30Days { get; set; }
        public ulong? IsDepositOperatingAccount { get; set; }
        public ulong? IsDepositOfBankNetwork { get; set; }
        public int? FundingCollateralQuality { get; set; }
        public ulong? Class1LiquidAssetOverride { get; set; }
        public ulong? Class2AliquidAssetOverride { get; set; }
        public ulong? Class2BliquidAssetOverride { get; set; }
        public ulong? IsOnlyAccessibleOnline { get; set; }
        public ulong? IsCreditLiquidityLine { get; set; }
        public int? InstrumentStatus { get; set; }
        public ulong? IsPenalizedWithdrawal { get; set; }
        public ulong? IsCorrOrPbaccount { get; set; }
    }
}
