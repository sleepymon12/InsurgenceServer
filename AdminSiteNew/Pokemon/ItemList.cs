﻿using System;

namespace AdminSiteNew.Pokemon
{
    public static class ItemHelper
    {
        public static string GetItemName(short id)
        {
            if (id == 0)
                return "No Item";
            return Enum.IsDefined(typeof(ItemList), id) ? Enum.GetName(typeof(ItemList), id) : string.Format("Item: {0}", id);
        }
    }
    public enum ItemList : short
    {
        None = 0,
        Repel = 1,
        SuperRepel,
        MaxRepel,
        BlackFlute,
        WhiteFlute,
        Honey,
        EscapeRope,
        RedShard,
        YellowShard,
        BlueShard,
        GreenShard,
        FireStone,
        Thunderstone,
        WaterStone,
        LeafStone,
        MoonStone,
        SunStone,
        DuskStone,
        DawnStone,
        ShinyStone,
        RedApricorn,
        YlwApricorn,
        BluApricorn,
        GrnApricorn,
        PnkApricorn,
        WhtApricorn,
        BlkApricorn,
        HelixFossil,
        DomeFossil,
        OldAmber,
        RootFossil,
        ClawFossil,
        SkullFossil,
        ArmorFossil,
        CoverFossil,
        PlumeFossil,
        PrettyWing,
        TinyMushroom,
        BigMushroom,
        BalmMushroom,
        Pearl,
        BigPearl,
        PearlString,
        Stardust,
        StarPiece,
        CometShard,
        Nugget,
        BigNugget,
        HeartScale,
        Slowpoketail,
        RareBone,
        RelicCopper,
        RelicSilver,
        RelicGold,
        RelicVase,
        RelicBand,
        RelicStatue,
        RelicCrown,
        GrowthMulch,
        DampMulch,
        StableMulch,
        GooeyMulch,
        ShoalSalt,
        ShoalShell,
        OddKeystone,
        AirBalloon,
        BrightPowder,
        Eviolite,
        FloatStone,
        DestinyKnot,
        RockyHelmet,
        EjectButton,
        RedCard,
        ShedShell,
        SmokeBall,
        LuckyEgg,
        ExpShare,
        AmuletCoin,
        SootheBell,
        CleanseTag,
        ChoiceBand,
        ChoiceSpecs,
        ChoiceScarf,
        HeatRock,
        DampRock,
        SmoothRock,
        IcyRock,
        LightClay,
        GripClaw,
        BindingBand,
        BigRoot,
        BlackSludge,
        Leftovers,
        ShellBell,
        MentalHerb,
        WhiteHerb,
        PowerHerb,
        AbsorbBulb,
        CellBattery,
        LifeOrb,
        ExpertBelt,
        Metronome,
        MuscleBand,
        WiseGlasses,
        RazorClaw,
        ScopeLens,
        WideLens,
        ZoomLens,
        KingsRock,
        RazorFang,
        LaggingTail,
        QuickClaw,
        FocusBand,
        FocusSash,
        FlameOrb,
        ToxicOrb,
        StickyBarb,
        IronBall,
        RingTarget,
        MachoBrace,
        PowerWeight,
        PowerBracer,
        PowerBelt,
        PowerLens,
        PowerBand,
        PowerAnklet,
        LaxIncense,
        FullIncense,
        LuckIncense,
        PureIncense,
        SeaIncense,
        WaveIncense,
        RoseIncense,
        OddIncense,
        RockIncense,
        Charcoal,
        MysticWater,
        Magnet,
        MiracleSeed,
        NeverMeltIce,
        BlackBelt,
        PoisonBarb,
        SoftSand,
        SharpBeak,
        TwistedSpoon,
        SilverPowder,
        HardStone,
        SpellTag,
        DragonFang,
        BlackGlasses,
        MetalCoat,
        SilkScarf,
        FlamePlate,
        SplashPlate,
        ZapPlate,
        MeadowPlate,
        IciclePlate,
        FistPlate,
        ToxicPlate,
        EarthPlate,
        SkyPlate,
        MindPlate,
        InsectPlate,
        StonePlate,
        SpookyPlate,
        DracoPlate,
        DreadPlate,
        IronPlate,
        FireGem,
        WaterGem,
        ElectricGem,
        GrassGem,
        IceGem,
        FightingGem,
        PoisonGem,
        GroundGem,
        FlyingGem,
        PsychicGem,
        BugGem,
        RockGem,
        GhostGem,
        DragonGem,
        DarkGem,
        SteelGem,
        NormalGem,
        LightBall,
        LuckyPunch,
        MetalPowder,
        QuickPowder,
        ThickClub,
        Stick,
        SoulDew,
        DeepSeaTooth,
        DeepSeaScale,
        AdamantOrb,
        LustrousOrb,
        GriseousOrb,
        DouseDrive,
        ShockDrive,
        BurnDrive,
        ChillDrive,
        Everstone,
        DragonScale,
        UpGrade,
        DubiousDisc,
        Protector,
        Electirizer,
        Magmarizer,
        ReaperCloth,
        PrismScale,
        OvalStone,
        RedScarf,
        BlueScarf,
        PinkScarf,
        GreenScarf,
        YellowScarf,
        Potion,
        SuperPotion,
        HyperPotion,
        MaxPotion,
        FullRestore,
        SacredAsh,
        Awakening,
        Antidote,
        BurnHeal,
        ParlyzHeal,
        IceHeal,
        FullHeal,
        LavaCookie,
        OldGateau,
        Casteliacone,
        Revive,
        MaxRevive,
        BerryJuice,
        RageCandyBar,
        SweetHeart,
        FreshWater,
        SodaPop,
        Lemonade,
        MoomooMilk,
        EnergyPowder,
        EnergyRoot,
        HealPowder,
        RevivalHerb,
        Ether,
        MaxEther,
        Elixir,
        MaxElixir,
        PPUp,
        PPMax,
        HPUp,
        Protein,
        Iron,
        Calcium,
        Zinc,
        Carbos,
        HealthWing,
        MuscleWing,
        ResistWing,
        GeniusWing,
        CleverWing,
        SwiftWing,
        RareCandy,
        MasterBall,
        UltraBall,
        GreatBall,
        PokéBall,
        SafariBall,
        SportBall,
        NetBall,
        DiveBall,
        NestBall,
        RepeatBall,
        TimerBall,
        LuxuryBall,
        PremierBall,
        DuskBall,
        HealBall,
        QuickBall,
        CherishBall,
        FastBall,
        LevelBall,
        LureBall,
        HeavyBall,
        LoveBall,
        FriendBall,
        MoonBall,
        TM01,
        TM02,
        TM03,
        TM04,
        TM05,
        TM06,
        TM07,
        TM08,
        TM09,
        TM10,
        TM11,
        TM12,
        TM13,
        TM14,
        TM15,
        TM16,
        TM17,
        TM18,
        TM19,
        TM20,
        TM21,
        TM22,
        TM23,
        TM24,
        TM25,
        TM26,
        TM27,
        TM28,
        TM29,
        TM30,
        TM31,
        TM32,
        TM33,
        TM34,
        TM35,
        TM36,
        TM37,
        TM38,
        TM39,
        TM40,
        TM41,
        TM42,
        TM43,
        TM44,
        TM45,
        TM46,
        TM47,
        TM48,
        TM49,
        TM50,
        TM51,
        TM52,
        TM53,
        TM54,
        TM55,
        TM56,
        TM57,
        TM58,
        TM59,
        TM60,
        TM61,
        TM62,
        TM63,
        TM64,
        TM65,
        TM66,
        TM67,
        TM68,
        TM69,
        TM70,
        TM71,
        TM72,
        TM73,
        TM74,
        TM75,
        TM76,
        TM77,
        TM78,
        TM79,
        TM80,
        TM81,
        TM82,
        TM83,
        TM84,
        TM85,
        TM86,
        TM87,
        TM88,
        TM89,
        TM90,
        TM91,
        TM92,
        TM93,
        TM94,
        TM95,
        HM01,
        HM02,
        HM03,
        HM04,
        HM05,
        HM06,
        CheriBerry,
        ChestoBerry,
        PechaBerry,
        RawstBerry,
        AspearBerry,
        LeppaBerry,
        OranBerry,
        PersimBerry,
        LumBerry,
        SitrusBerry,
        FigyBerry,
        WikiBerry,
        MagoBerry,
        AguavBerry,
        IapapaBerry,
        RazzBerry,
        BlukBerry,
        NanabBerry,
        WepearBerry,
        PinapBerry,
        PomegBerry,
        KelpsyBerry,
        QualotBerry,
        HondewBerry,
        GrepaBerry,
        TamatoBerry,
        CornnBerry,
        MagostBerry,
        RabutaBerry,
        NomelBerry,
        SpelonBerry,
        PamtreBerry,
        WatmelBerry,
        DurinBerry,
        BelueBerry,
        OccaBerry,
        PasshoBerry,
        WacanBerry,
        RindoBerry,
        YacheBerry,
        ChopleBerry,
        KebiaBerry,
        ShucaBerry,
        CobaBerry,
        PayapaBerry,
        TangaBerry,
        ChartiBerry,
        KasibBerry,
        HabanBerry,
        ColburBerry,
        BabiriBerry,
        ChilanBerry,
        LiechiBerry,
        GanlonBerry,
        SalacBerry,
        PetayaBerry,
        ApicotBerry,
        LansatBerry,
        StarfBerry,
        EnigmaBerry,
        MicleBerry,
        CustapBerry,
        JabocaBerry,
        RowapBerry,
        GrassMail,
        FlameMail,
        BubbleMail,
        BloomMail,
        TunnelMail,
        SteelMail,
        HeartMail,
        SnowMail,
        SpaceMail,
        AirMail,
        MosaicMail,
        BrickMail,
        XAttack,
        XAttack2,
        XAttack3,
        XAttack6,
        XDefend,
        XDefend2,
        XDefend3,
        XDefend6,
        XSpecial,
        XSpecial2,
        XSpecial3,
        XSpecial6,
        XSpDef,
        XSpDef2,
        XSpDef3,
        XSpDef6,
        XSpeed,
        XSpeed2,
        XSpeed3,
        XSpeed6,
        XAccuracy,
        XAccuracy2,
        XAccuracy3,
        XAccuracy6,
        DireHit,
        DireHit2,
        DireHit3,
        GuardSpec,
        ResetUrge,
        AbilityUrge,
        ItemUrge,
        ItemDrop,
        BlueFlute,
        YellowFlute,
        RedFlute,
        PokéDoll,
        FluffyTail,
        PokéToy,
        Bicycle,
        OldRod,
        GoodRod,
        SuperRod,
        Itemfinder,
        DowsingMCHN,
        PokéRadar,
        TownMap,
        PokéFlute,
        CoinCase,
        SootSack,
        SilphScope,
        DevonScope,
        Squirtbottle,
        Sprayduck,
        WailmerPail,
        Gracidea,
        AuroraTicket,
        OldSeaMap,
        DNASplicers,
        RevealGlass,
        OvalCharm,
        ShinyCharm,
        OmegaPhotograph,
        ContinentRope,
        OceanQuay,
        WilsonsAutograph,
        HackerPhotograph,
        BurntPhotograph,
        VIPLicense,
        BasementKey,
        Neurometer,
        HackerTicket,
        HackerTicket2,
        HackerTicket3,
        HackerEngine,
        IVStone,
        TMQuestion = 541,
        TM97,
        TM98,
        TM99,
        TM100,
        TM102,
        TM103,
        TM104,
        TM105,
        TM106,
        TMQuestion2,
        NuzlockeBall,
        HackerTemplate,
        MewtwoArmor,
        JoyScent,
        ExciteScent,
        VividScent,
        TimeFlute,
        Saddle,
        TM96,
        FireSeal,
        HeartSeal,
        EleSeal,
        QuestionSeal,
        StarSeal,
        AncientTome,
        Dolly,
        Machete,
        InstantLapras,
        Jetpack,
        Pickaxe,
        ScubaGear,
        HikingBoots,
        MedicalLicense,
        PieceofPaper,
        CinnabarTicket,
        RocketBoots,
        Flashlight,
        TM107,
        TM108,
        TM109,
        TM110,
        TM111,
        TM112,
        TM113,
        TM114,
        TM115,
        TM116,
        TM117,
        TM118,
        TM119,
        TM120,
        TM121,
        TM122,
        TM123,
        TM124,
        Blackticket,
        MilleniumEngine,
        PieceofPaper2,
        Dinoticket,
        MusicTicket,
        LicenseTemplate,
        DreamStone,
        YOUHACKED,
        GoGoggles,
        HMXX,
        TM125,
        Weatherstone,
        ABProtect,
        ABSleepPowder,
        ABThunderWave,
        ABToxic,
        ABConfuseRay,
        ABMedusaRay,
        ABFalseSwipe,
        RBVCreate,
        RBDoomDesire,
        RBSeedFlare,
        RBMistBall,
        RBLusterPurge,
        RBRoarofTime,
        RBSpacialRend,
        RBSacredSword,
        RBDarkVoid,
        Scizorite,
        Garchompite,
        Mawilite,
        Aerodactylite,
        Lucarionite,
        Absolite,
        Blastoisinite,
        CharizarditeX,
        Venusaurite,
        Blazikenite,
        MewtwoniteY,
        CharizarditeY,
        MewtwoniteX,
        Gengarite,
        Gardevoirite,
        Pinsirite,
        Heracrossite,
        Alakazite,
        Banettite,
        Ampharosite,
        Tyranitarite,
        SteelixiteZ,
        Cacturnite,
        Dugtrinite,
        Reuniclite,
        Sceptite,
        Swampertite,
        Bisharpite,
        OldGolurkite,
        Aggronite,
        TM126,
        TimeCaller,
        TM127,
        Golurkite,
        TM128,
        Abomasite,
        AzureFlute,
        TowerPhotograph,
        AbilityCapsule,
        Typhlosionite,
        Feraligatite,
        Meganiumite,
        Gyaradosite,
        Houndoomite,
        Manectrite,
        Medichamite,
        Kangaskhanite,
        CrestofAroma,
        Stargate,
        Helixite,
        Crawdite,
        EXPShare2,
        WeaknessPolicy,
        SkeletonKey,
        TowerPhotograph2,
        Latiosite,
        Latiasite,
        RainbowWing,
        SilverWing,
        Milotite,
        POLITOEDITE,
        NuzlockeBadge,
        AssaultVest,
        Sachet,
        WhippedDream,
        KantoCap,
        KantoCoat,
        KantoShirt,
        KantoPack,
        KantoPants,
        KantoShoes,
        Headband,
        MinersHelmet,
        PoliceHat,
        Fedora,
        PoopHat,
        ClownHat,
        TheCatsHat,
        StrawHat,
        Beret,
        Beanie,
        YoungsterCap,
        QuartzFlute,
        Eevite,
        Marowite,
        Flygonite,
        Shiftrite,
        Donphanite,
        Sablenite,
        Altarianite,
        Salamencite,
        Metagrossite,
        Lopunnite,
        Audinite,
        DeltaCharizardite,
        DeltaVenusaurite,
        DeltaBlastoisinite,
        Slowbronite,
        PixiePlate,
        Jumpsuit,
        PurplePack,
        Jumppants,
        Jumpshoes,
        Etigirafarigite,
        SunfloriteZ,
        SunfloriteO,
        RedShirt,
        BlueShirt,
        GreenShirt,
        PurpleShirt,
        BlackShirt,
        OrangeShirt,
        PinkShirt,
        YellowShirt,
        Diancite,
        Crobatite,
        Groudonite,
        KyogriteO,
        Zoronite,
        DeltaBisharpite,
        Stunfiskite,
        Florgite,
        Zebstrikite,
        DeltaGardevoirite,
        Kingdrite,
        Victreebite,
        Magmortite,
        ZekromArmor,
        TyranitarArmor,
        LeavannyArmor,
        FlygonArmor,
        Cameruptite,
        Sharpedonite,
        Pidgeotite,
        Beedrite,
        Glalitite,
        SteelixiteO,
        Galladite,
        Rayquazite,
        GreenPack,
        SafetyGoggles,
        Jirachite,
        Victinite,
        EastsWill = 769,
        NoHat,
        TrickRock,
        DarkRock,
        JawFossil,
        SailFossil,
        Tablet,
        BlueOrb,
        RedOrb,
        PurpleHairDye,
        BlueHairDye,
        BrownHairDye,
        BlackHairDye,
        RedHairDye,
        BlondHairDye,
        MegaRing,
        MysteriousScroll,
        BluePants,
        RedPants,
        GreenPants,
        GrayPants,
        DeltaScizorite,
        Magcargonite,
        Gothitite,
        Spiritombite,
        OldPhoto,
        MagicCookie,
        SpicyCurry,
        HPPill,
        AttackPill,
        DefensePill,
        SpAttackPill,
        SpDefensePill,
        SpeedPill,
        Miltankite,
        VIPPass,
        DeltaGalladite,
        CatEars,
        DevilHorns,
        SilverCrown,
        GoldenCrown,
        Avaluggite,
        Hydreigonite

    }
}
