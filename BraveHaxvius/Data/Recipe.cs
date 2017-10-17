using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Recipe
    {
        public String Name { get; set; }
        public String RecipeBookId { get; set; }
        public String Description { get; set; }
        public String CountId { get; set; }
        public String Gil { get; set; }

        public static readonly Recipe Potion = new Recipe { Name = "Potion"};
        public static readonly Recipe HiPotion = new Recipe { Name = "Hi-Potion"};
        public static readonly Recipe Ether = new Recipe { Name = "Ether"};
        public static readonly Recipe Antidote = new Recipe { Name = "Antidote"};
        public static readonly Recipe EyeDrops = new Recipe { Name = "Eye Drops"};
        public static readonly Recipe SmellingSalts = new Recipe { Name = "Smelling Salts"};
        public static readonly Recipe EchoHerbs = new Recipe { Name = "Echo Herbs"};
        public static readonly Recipe UnicornHorn = new Recipe { Name = "Unicorn Horn"};
        public static readonly Recipe Vaccine = new Recipe { Name = "Vaccine"};
        public static readonly Recipe GoldNeedle = new Recipe { Name = "Gold Needle"};
        public static readonly Recipe Remedy = new Recipe { Name = "Remedy"};
        public static readonly Recipe Hyper = new Recipe { Name = "Hyper"};
        public static readonly Recipe HealingSpring = new Recipe { Name = "Healing Spring"};
        public static readonly Recipe SmokeBomb = new Recipe { Name = "Smoke Bomb"};
        public static readonly Recipe BodyBoost = new Recipe { Name = "Body Boost"};
        public static readonly Recipe ManaBoost = new Recipe { Name = "Mana Boost"};
        public static readonly Recipe ProtectDrink = new Recipe { Name = "Protect Drink"};
        public static readonly Recipe ShellDrink = new Recipe { Name = "Shell Drink"};
        public static readonly Recipe BacchussWine = new Recipe { Name = "Bacchus's Wine"};
        public static readonly Recipe Grenade = new Recipe { Name = "Grenade"};
        public static readonly Recipe FragGrenade = new Recipe { Name = "Frag Grenade"};
        public static readonly Recipe Shuriken = new Recipe { Name = "Shuriken"};
        public static readonly Recipe FumaShuriken = new Recipe { Name = "Fuma Shuriken"};
        public static readonly Recipe Tent = new Recipe { Name = "Tent"};
        public static readonly Recipe MagicKey = new Recipe { Name = "Magic Key"};
        public static readonly Recipe BronzeKnife = new Recipe { Name = "Bronze Knife"};
        public static readonly Recipe Dagger = new Recipe { Name = "Dagger"};
        public static readonly Recipe SleepDagger = new Recipe { Name = "Sleep Dagger"};
        public static readonly Recipe Broadsword = new Recipe { Name = "Broadsword"};
        public static readonly Recipe LongSword = new Recipe { Name = "Long Sword"};
        public static readonly Recipe GreatSword = new Recipe { Name = "Great Sword"};
        public static readonly Recipe BusterSword = new Recipe { Name = "Buster Sword"};
        public static readonly Recipe Kotetsu = new Recipe { Name = "Kotetsu"};
        public static readonly Recipe Kikuichimonji = new Recipe { Name = "Kiku-ichimonji"};
        public static readonly Recipe Kazekiri = new Recipe { Name = "Kazekiri"};
        public static readonly Recipe Kodachi = new Recipe { Name = "Kodachi"};
        public static readonly Recipe BattleAxe = new Recipe { Name = "Battle Axe"};
        public static readonly Recipe GreatAxe = new Recipe { Name = "Great Axe"};
        public static readonly Recipe WoodenHammer = new Recipe { Name = "Wooden Hammer"};
        public static readonly Recipe IronHammer = new Recipe { Name = "Iron Hammer"};
        public static readonly Recipe WarHammer = new Recipe { Name = "War Hammer"};
        public static readonly Recipe BronzeMace = new Recipe { Name = "Bronze Mace"};
        public static readonly Recipe IronMace = new Recipe { Name = "Iron Mace"};
        public static readonly Recipe Javelin = new Recipe { Name = "Javelin"};
        public static readonly Recipe Partisan = new Recipe { Name = "Partisan"};
        public static readonly Recipe BronzeKnuckles = new Recipe { Name = "Bronze Knuckles"};
        public static readonly Recipe MetalKnuckles = new Recipe { Name = "Metal Knuckles"};
        public static readonly Recipe CatClaws = new Recipe { Name = "Cat Claws"};
        public static readonly Recipe Rod = new Recipe { Name = "Rod"};
        public static readonly Recipe IronRod = new Recipe { Name = "Iron Rod"};
        public static readonly Recipe Staff = new Recipe { Name = "Staff"};
        public static readonly Recipe CherryStaff = new Recipe { Name = "Cherry Staff"};
        public static readonly Recipe WizardsStaff = new Recipe { Name = "Wizard's Staff"};
        public static readonly Recipe RuneStaff = new Recipe { Name = "Rune Staff"};
        public static readonly Recipe ShortBow = new Recipe { Name = "Short Bow"};
        public static readonly Recipe LongBow = new Recipe { Name = "Long Bow"};
        public static readonly Recipe GreatBow = new Recipe { Name = "Great Bow"};
        public static readonly Recipe Altair = new Recipe { Name = "Altair"};
        public static readonly Recipe LeatherWhip = new Recipe { Name = "Leather Whip"};
        public static readonly Recipe ChainWhip = new Recipe { Name = "Chain Whip"};
        public static readonly Recipe Boomerang = new Recipe { Name = "Boomerang"};
        public static readonly Recipe Chakram = new Recipe { Name = "Chakram"};
        public static readonly Recipe MoonRingBlade = new Recipe { Name = "Moon Ring Blade"};
        public static readonly Recipe Harp = new Recipe { Name = "Harp"};
        public static readonly Recipe SilverHarp = new Recipe { Name = "Silver Harp"};
        public static readonly Recipe LeatherShield = new Recipe { Name = "Leather Shield"};
        public static readonly Recipe SmallShield = new Recipe { Name = "Small Shield"};
        public static readonly Recipe Buckler = new Recipe { Name = "Buckler"};
        public static readonly Recipe BronzeShield = new Recipe { Name = "Bronze Shield"};
        public static readonly Recipe IronShield = new Recipe { Name = "Iron Shield"};
        public static readonly Recipe LeatherHat = new Recipe { Name = "Leather Hat"};
        public static readonly Recipe FeatheredCap = new Recipe { Name = "Feathered Cap"};
        public static readonly Recipe WizardsHat = new Recipe { Name = "Wizard's Hat"};
        public static readonly Recipe Bandana = new Recipe { Name = "Bandana"};
        public static readonly Recipe CelebrantsMiter = new Recipe { Name = "Celebrant's Miter"};
        public static readonly Recipe HypnoCrown = new Recipe { Name = "Hypno Crown"};
        public static readonly Recipe RedCap = new Recipe { Name = "Red Cap"};
        public static readonly Recipe BronzeHelm = new Recipe { Name = "Bronze Helm"};
        public static readonly Recipe IronHelm = new Recipe { Name = "Iron Helm"};
        public static readonly Recipe LeatherShirt = new Recipe { Name = "Leather Shirt"};
        public static readonly Recipe BardsTunic = new Recipe { Name = "Bard's Tunic"};
        public static readonly Recipe ScholarRobe = new Recipe { Name = "Scholar Robe"};
        public static readonly Recipe PowerVest = new Recipe { Name = "Power Vest"};
        public static readonly Recipe Kenpogi = new Recipe { Name = "Kenpogi"};
        public static readonly Recipe MagesHabit = new Recipe { Name = "Mage's Habit"};
        public static readonly Recipe SurvivalVest = new Recipe { Name = "Survival Vest"};
        public static readonly Recipe NinjaGear = new Recipe { Name = "Ninja Gear"};
        public static readonly Recipe BlackBeltGi = new Recipe { Name = "Black Belt Gi"};
        public static readonly Recipe LeatherPlate = new Recipe { Name = "Leather Plate"};
        public static readonly Recipe CopperCuirass = new Recipe { Name = "Copper Cuirass "};
        public static readonly Recipe IronPlate = new Recipe { Name = "Iron Plate"};
        public static readonly Recipe BronzeArmor = new Recipe { Name = "Bronze Armor"};
        public static readonly Recipe IronArmor = new Recipe { Name = "Iron Armor"};
        public static readonly Recipe CottonRobe = new Recipe { Name = "Cotton Robe"};
        public static readonly Recipe SilkRobe = new Recipe { Name = "Silk Robe"};
        public static readonly Recipe TravelersGarbs = new Recipe { Name = "Traveler's Garbs"};
        public static readonly Recipe GaiaGear = new Recipe { Name = "Gaia Gear"};
        public static readonly Recipe ClericsRobes = new Recipe { Name = "Cleric's Robes"};
        public static readonly Recipe IronGloves = new Recipe { Name = "Iron Gloves"};
        public static readonly Recipe PowerWrist = new Recipe { Name = "Power Wrist"};
        public static readonly Recipe HyperWrist = new Recipe { Name = "Hyper Wrist"};
        public static readonly Recipe SilverArmlet = new Recipe { Name = "Silver Armlet"};
        public static readonly Recipe FireRing = new Recipe { Name = "Fire Ring"};
        public static readonly Recipe IceRing = new Recipe { Name = "Ice Ring"};
        public static readonly Recipe SparkRing = new Recipe { Name = "Spark Ring"};
        public static readonly Recipe WaterRing = new Recipe { Name = "Water Ring"};
        public static readonly Recipe GaleRing = new Recipe { Name = "Gale Ring"};
        public static readonly Recipe EarthRing = new Recipe { Name = "Earth Ring"};
        public static readonly Recipe ProtectRing = new Recipe { Name = "Protect Ring"};
        public static readonly Recipe BarrierRing = new Recipe { Name = "Barrier Ring"};
        public static readonly Recipe RegenRing = new Recipe { Name = "Regen Ring"};
        public static readonly Recipe CatsBell = new Recipe { Name = "Cat's Bell"};
        public static readonly Recipe HerosRing = new Recipe { Name = "Hero's Ring"};
        public static readonly Recipe MuscleBelt = new Recipe { Name = "Muscle Belt"};
        public static readonly Recipe Libra = new Recipe { Name = "Libra"};
        public static readonly Recipe Cure = new Recipe { Name = "Cure"};
        public static readonly Recipe Blindna = new Recipe { Name = "Blindna"};
        public static readonly Recipe Vox = new Recipe { Name = "Vox"};
        public static readonly Recipe Poisona = new Recipe { Name = "Poisona"};
        public static readonly Recipe Paralyna = new Recipe { Name = "Paralyna"};
        public static readonly Recipe Stona = new Recipe { Name = "Stona"};
        public static readonly Recipe Fire = new Recipe { Name = "Fire"};
        public static readonly Recipe Blizzard = new Recipe { Name = "Blizzard"};
        public static readonly Recipe Thunder = new Recipe { Name = "Thunder"};
        public static readonly Recipe Water = new Recipe { Name = "Water"};
        public static readonly Recipe Aero = new Recipe { Name = "Aero"};
        public static readonly Recipe Stone = new Recipe { Name = "Stone"};
        public static readonly Recipe Bio = new Recipe { Name = "Bio"};
        public static readonly Recipe Blizzara = new Recipe { Name = "Blizzara"};
        public static readonly Recipe Thundara = new Recipe { Name = "Thundara"};
        public static readonly Recipe Watera = new Recipe { Name = "Watera"};
        public static readonly Recipe Aerora = new Recipe { Name = "Aerora"};
        public static readonly Recipe Gravity = new Recipe { Name = "Gravity"};
        public static readonly Recipe Drain = new Recipe { Name = "Drain"};
        public static readonly Recipe Biora = new Recipe { Name = "Biora"};
        public static readonly Recipe Sleep = new Recipe { Name = "Sleep"};
        public static readonly Recipe Blind = new Recipe { Name = "Blind"};
        public static readonly Recipe Barfire = new Recipe { Name = "Barfire"};
        public static readonly Recipe Barblizzard = new Recipe { Name = "Barblizzard"};
        public static readonly Recipe Barthunder = new Recipe { Name = "Barthunder"};
        public static readonly Recipe Barwater = new Recipe { Name = "Barwater"};
        public static readonly Recipe Baraero = new Recipe { Name = "Baraero"};
        public static readonly Recipe Barstone = new Recipe { Name = "Barstone"};
        public static readonly Recipe Silence = new Recipe { Name = "Silence"};
        public static readonly Recipe Barfira = new Recipe { Name = "Barfira"};
        public static readonly Recipe Barblizzara = new Recipe { Name = "Barblizzara"};
        public static readonly Recipe Barthundara = new Recipe { Name = "Barthundara"};
        public static readonly Recipe Shell = new Recipe { Name = "Shell"};
        public static readonly Recipe Deshell = new Recipe { Name = "Deshell"};
        public static readonly Recipe Barwatera = new Recipe { Name = "Barwatera"};
        public static readonly Recipe Baraerora = new Recipe { Name = "Baraerora"};
        public static readonly Recipe Barstonra = new Recipe { Name = "Barstonra"};
        public static readonly Recipe Steal = new Recipe { Name = "Steal"};
        public static readonly Recipe Brace = new Recipe { Name = "Brace"};
        public static readonly Recipe FireBlade = new Recipe { Name = "Fire Blade"};
        public static readonly Recipe BlizzardBlade = new Recipe { Name = "Blizzard Blade"};
        public static readonly Recipe SilenceBlade = new Recipe { Name = "Silence Blade"};
        public static readonly Recipe WaterBlade = new Recipe { Name = "Water Blade"};
        public static readonly Recipe StoneBlade = new Recipe { Name = "Stone Blade"};
        public static readonly Recipe BlindBlade = new Recipe { Name = "Blind Blade"};
        public static readonly Recipe BioBlade = new Recipe { Name = "Bio Blade"};
        public static readonly Recipe MagicInfuse = new Recipe { Name = "Magic Infuse"};
        public static readonly Recipe MentalBreak = new Recipe { Name = "Mental Break"};
        public static readonly Recipe BioBlaster = new Recipe { Name = "Bio Blaster"};
        public static readonly Recipe BombFragment = new Recipe { Name = "Bomb Fragment"};
        public static readonly Recipe FishScale = new Recipe { Name = "Fish Scale"};
        public static readonly Recipe GiantFeather = new Recipe { Name = "Giant Feather"};
        public static readonly Recipe Pinwheel = new Recipe { Name = "Pinwheel"};
        public static readonly Recipe Icebrand = new Recipe { Name = "Icebrand"};
        public static readonly Recipe CoralSword = new Recipe { Name = "Coral Sword"};
        public static readonly Recipe FireRod = new Recipe { Name = "Fire Rod"};
        public static readonly Recipe Capella = new Recipe { Name = "Capella"};
        public static readonly Recipe ShockWhip = new Recipe { Name = "Shock Whip"};
        public static readonly Recipe OchreShield = new Recipe { Name = "Ochre Shield"};
        public static readonly Recipe GreenBeret = new Recipe { Name = "Green Beret"};
        public static readonly Recipe Barbut = new Recipe { Name = "Barbut"};
        public static readonly Recipe SagesSurplice = new Recipe { Name = "Sage's Surplice"};
        public static readonly Recipe Protect = new Recipe { Name = "Protect"};
        public static readonly Recipe MP = new Recipe { Name = "MP +10%"};
        public static readonly Recipe SPR = new Recipe { Name = "SPR +10%"};
        public static readonly Recipe BugKiller = new Recipe { Name = "Bug Killer"};
        public static readonly Recipe XPotion = new Recipe { Name = "X-Potion"};
        public static readonly Recipe TurboEther = new Recipe { Name = "Turbo Ether"};
        public static readonly Recipe HolyTorch = new Recipe { Name = "Holy Torch"};
        public static readonly Recipe MythrilSpear = new Recipe { Name = "Mythril Spear"};
        public static readonly Recipe MagesHat = new Recipe { Name = "Mage's Hat"};
        public static readonly Recipe SagesRobe = new Recipe { Name = "Sage's Robe"};
        public static readonly Recipe MythrilGloves = new Recipe { Name = "Mythril Gloves"};
        public static readonly Recipe Cura = new Recipe { Name = "Cura"};
        public static readonly Recipe DEF = new Recipe { Name = "DEF +10%"};
        public static readonly Recipe MythrilHammer = new Recipe { Name = "Mythril Hammer"};
        public static readonly Recipe WindSpear = new Recipe { Name = "Wind Spear"};
        public static readonly Recipe MythrilHelm = new Recipe { Name = "Mythril Helm"};
        public static readonly Recipe Bravery = new Recipe { Name = "Bravery"};
        public static readonly Recipe MAG = new Recipe { Name = "MAG +10%"};
        public static readonly Recipe FineBlade = new Recipe { Name = "Fine Blade"};
        public static readonly Recipe SuperiorBlade = new Recipe { Name = "Superior Blade"};
        public static readonly Recipe AntarcticWind = new Recipe { Name = "Antarctic Wind"};
        public static readonly Recipe ZeussRage = new Recipe { Name = "Zeus's Rage"};
        public static readonly Recipe EarthDrum = new Recipe { Name = "Earth Drum"};
        public static readonly Recipe MythrilDagger = new Recipe { Name = "Mythril Dagger"};
        public static readonly Recipe MainGauche = new Recipe { Name = "Main Gauche"};
        public static readonly Recipe MythrilSword = new Recipe { Name = "Mythril Sword"};
        public static readonly Recipe Osafune = new Recipe { Name = "Osafune"};
        public static readonly Recipe MythrilMace = new Recipe { Name = "Mythril Mace"};
        public static readonly Recipe MythrilClaws = new Recipe { Name = "Mythril Claws"};
        public static readonly Recipe MythrilBow = new Recipe { Name = "Mythril Bow"};
        public static readonly Recipe MythrilWhip = new Recipe { Name = "Mythril Whip"};
        public static readonly Recipe MythrilBuckler = new Recipe { Name = "Mythril Buckler"};
        public static readonly Recipe LargeShield = new Recipe { Name = "Large Shield"};
        public static readonly Recipe MythrilShield = new Recipe { Name = "Mythril Shield"};
        public static readonly Recipe TigerMask = new Recipe { Name = "Tiger Mask"};
        public static readonly Recipe MythrilPlate = new Recipe { Name = "Mythril Plate"};
        public static readonly Recipe SilverCuirass = new Recipe { Name = "Silver Cuirass"};
        public static readonly Recipe PaladinArmor = new Recipe { Name = "Paladin Armor"};
        public static readonly Recipe MythrilArmor = new Recipe { Name = "Mythril Armor"};
        public static readonly Recipe WizardsRobe = new Recipe { Name = "Wizard's Robe"};
        public static readonly Recipe MoonBracer = new Recipe { Name = "Moon Bracer"};
        public static readonly Recipe Dispel = new Recipe { Name = "Dispel"};
        public static readonly Recipe Faith = new Recipe { Name = "Faith"};
        public static readonly Recipe SpiritSlayer = new Recipe { Name = "Spirit Slayer"};
        public static readonly Recipe HP_905101500 = new Recipe { Name = "HP +15%"};
        public static readonly Recipe SleepBlade = new Recipe { Name = "Sleep Blade"};
        public static readonly Recipe AeroBlade = new Recipe { Name = "Aero Blade"};
        public static readonly Recipe StonraBlade_905200660 = new Recipe { Name = "Stonra Blade"};
        public static readonly Recipe VorpalAxe = new Recipe { Name = "Vorpal Axe"};
        public static readonly Recipe GaeBolg = new Recipe { Name = "Gae Bolg"};
        public static readonly Recipe LightCurtain = new Recipe { Name = "Light Curtain"};
        public static readonly Recipe WyvernsFeather = new Recipe { Name = "Wyvern's Feather"};
        public static readonly Recipe WhiteFang = new Recipe { Name = "White Fang"};
        public static readonly Recipe MythrilSaber = new Recipe { Name = "Mythril Saber"};
        public static readonly Recipe Chirijiraden = new Recipe { Name = "Chirijiraden"};
        public static readonly Recipe MythrilAxe = new Recipe { Name = "Mythril Axe"};
        public static readonly Recipe Escutcheon = new Recipe { Name = "Escutcheon"};
        public static readonly Recipe Brigandine = new Recipe { Name = "Brigandine"};
        public static readonly Recipe Curaga = new Recipe { Name = "Curaga"};
        public static readonly Recipe EVOMAG = new Recipe { Name = "EVO MAG +10%"};
        public static readonly Recipe WateraBlade = new Recipe { Name = "Watera Blade"};
        public static readonly Recipe WingedSaint = new Recipe { Name = "Winged Saint"};
        public static readonly Recipe MoraleTalisman = new Recipe { Name = "Morale Talisman"};
        public static readonly Recipe RodofGravity = new Recipe { Name = "Rod of Gravity"};
        public static readonly Recipe VoidVessel = new Recipe { Name = "Void Vessel"};
        public static readonly Recipe StonraBlade_1000000004 = new Recipe { Name = "Stonra Blade"};
        public static readonly Recipe HP_1000000005 = new Recipe { Name = "HP +15%"};
        public static readonly Recipe BurstShot = new Recipe { Name = "Burst Shot"};
        public static readonly Recipe StandardMogcakePack = new Recipe { Name = "Standard Mogcake Pack"};
        public static readonly Recipe RareMogcakePack = new Recipe { Name = "Rare Mogcake Pack"};
        public static readonly Recipe PremiumMogcakePack = new Recipe { Name = "Premium Mogcake Pack"};
        public static readonly Recipe LunarCurtain = new Recipe { Name = "Lunar Curtain"};
        public static readonly Recipe NorthWind = new Recipe { Name = "North Wind"};
        public static readonly Recipe Flametongue = new Recipe { Name = "Flametongue"};
        public static readonly Recipe ATK = new Recipe { Name = "ATK +10%"};
        public static readonly Recipe AutoProtect = new Recipe { Name = "Auto-Protect"};
        public static readonly Recipe BioraBlade = new Recipe { Name = "Biora Blade"};
        public static readonly Recipe RightArm = new Recipe { Name = "Right Arm"};
        public static readonly Recipe BlueFang = new Recipe { Name = "Blue Fang"};
        public static readonly Recipe SleepSword = new Recipe { Name = "Sleep Sword"};
        public static readonly Recipe FlameLance = new Recipe { Name = "Flame Lance"};
        public static readonly Recipe PoisonKnuckles = new Recipe { Name = "Poison Knuckles"};
        public static readonly Recipe ThunderShield = new Recipe { Name = "Thunder Shield"};
        public static readonly Recipe IceArmor = new Recipe { Name = "Ice Armor"};
        public static readonly Recipe AutoShell = new Recipe { Name = "Auto-Shell"};
        public static readonly Recipe OsmoseBlade = new Recipe { Name = "Osmose Blade"};
        public static readonly Recipe ShiningSplendor = new Recipe { Name = "Shining Splendor"};
        public static readonly Recipe YPotion = new Recipe { Name = "Y-Potion"};
        public static readonly Recipe MegaEther = new Recipe { Name = "Mega Ether"};
        public static readonly Recipe BloodSword = new Recipe { Name = "Blood Sword"};
        public static readonly Recipe RedFang = new Recipe { Name = "Red Fang"};
        public static readonly Recipe Trident = new Recipe { Name = "Trident"};
        public static readonly Recipe RodofLightning = new Recipe { Name = "Rod of Lightning"};
        public static readonly Recipe ElvenBow = new Recipe { Name = "Elven Bow"};
        public static readonly Recipe FlameMail = new Recipe { Name = "Flame Mail"};
        public static readonly Recipe Death = new Recipe { Name = "Death"};
        public static readonly Recipe BirdKiller = new Recipe { Name = "Bird Killer"};
        public static readonly Recipe AutoPotion = new Recipe { Name = "Auto-Potion"};
        public static readonly Recipe PowerBreak = new Recipe { Name = "Power Break"};
        public static readonly Recipe MagicBreak = new Recipe { Name = "Magic Break"};
        public static readonly Recipe GiantsAxe = new Recipe { Name = "Giant's Axe"};
        public static readonly Recipe Werebuster = new Recipe { Name = "Werebuster"};
        public static readonly Recipe IceLance = new Recipe { Name = "Ice Lance"};
        public static readonly Recipe IceRod = new Recipe { Name = "Ice Rod"};
        public static readonly Recipe Sirius = new Recipe { Name = "Sirius"};
        public static readonly Recipe MysteryVeil = new Recipe { Name = "Mystery Veil"};
        public static readonly Recipe GoldenArmor = new Recipe { Name = "Golden Armor"};
        public static readonly Recipe BlackRobe = new Recipe { Name = "Black Robe"};
        public static readonly Recipe UndeadKiller = new Recipe { Name = "Undead Killer"};
        public static readonly Recipe ArmorBreak = new Recipe { Name = "Armor Break"};
        public static readonly Recipe ThunderBlade = new Recipe { Name = "Thunder Blade"};
        public static readonly Recipe MonarchsRing = new Recipe { Name = "Monarch's Ring"};
        public static readonly Recipe DominationRing = new Recipe { Name = "Domination Ring"};
        public static readonly Recipe RulersRing = new Recipe { Name = "Ruler's Ring"};
        public static readonly Recipe RingofDominion = new Recipe { Name = "Ring of Dominion"};
        public static readonly Recipe HeavenlyWrath = new Recipe { Name = "Heavenly Wrath"};
        public static readonly Recipe DragonScale = new Recipe { Name = "Dragon Scale"};
        public static readonly Recipe GoldenStaff = new Recipe { Name = "Golden Staff"};
        public static readonly Recipe BlessedHammer = new Recipe { Name = "Blessed Hammer"};
        public static readonly Recipe IceShield = new Recipe { Name = "Ice Shield"};
        public static readonly Recipe GoldenVest = new Recipe { Name = "Golden Vest"};
        public static readonly Recipe WhiteRobe = new Recipe { Name = "White Robe"};
        public static readonly Recipe BuddingMapleWand = new Recipe { Name = "Budding Maple Wand"};
        public static readonly Recipe ScionConjurersDalmatica = new Recipe { Name = "Scion Conjurer's Dalmatica"};
        public static readonly Recipe ScionConjurersPattens = new Recipe { Name = "Scion Conjurer's Pattens"};
        public static readonly Recipe CobaltWinglet = new Recipe { Name = "Cobalt Winglet"};
        public static readonly Recipe AntecedentsAttire = new Recipe { Name = "Antecedent's Attire"};
        public static readonly Recipe MeteorSurvivorRing = new Recipe { Name = "Meteor Survivor Ring"};
        public static readonly Recipe UldahnFalchion = new Recipe { Name = "Ul'dahn Falchion"};
        public static readonly Recipe ScionThiefsTunic = new Recipe { Name = "Scion Thief's Tunic"};
        public static readonly Recipe ScionThiefsHalfgloves = new Recipe { Name = "Scion Thief's Halfgloves"};
        public static readonly Recipe GaiasCry = new Recipe { Name = "Gaia's Cry"};
        public static readonly Recipe GoldenBlade = new Recipe { Name = "Golden Blade"};
        public static readonly Recipe FlameShield = new Recipe { Name = "Flame Shield"};
        public static readonly Recipe Circlet = new Recipe { Name = "Circlet"};
        public static readonly Recipe AngelRing = new Recipe { Name = "Angel Ring"};
        public static readonly Recipe BreakBlade = new Recipe { Name = "Break Blade"};
        public static readonly Recipe Razzmatazz = new Recipe { Name = "Razzmatazz"};
        public static readonly Recipe HyperBall = new Recipe { Name = "Hyper Ball"};
        public static readonly Recipe Override = new Recipe { Name = "Override"};
        public static readonly Recipe ThunderSpear = new Recipe { Name = "Thunder Spear"};
        public static readonly Recipe Betelgeuse = new Recipe { Name = "Betelgeuse"};
        public static readonly Recipe GoldenShield = new Recipe { Name = "Golden Shield"};
        public static readonly Recipe Imperil = new Recipe { Name = "Imperil"};
        public static readonly Recipe Microphone_1000000014 = new Recipe { Name = "Microphone"};
        public static readonly Recipe EveningGloves = new Recipe { Name = "Evening Gloves"};
        public static readonly Recipe BunnyMask_1000000016 = new Recipe { Name = "Bunny Mask"};
        public static readonly Recipe StylishBlackDress_1000000017 = new Recipe { Name = "Stylish Black Dress"};
        public static readonly Recipe MemoryCandy = new Recipe { Name = "Memory Candy"};
        public static readonly Recipe MageMasher = new Recipe { Name = "Mage Masher"};
        public static readonly Recipe RasAlgethi = new Recipe { Name = "Ras Algethi"};
        public static readonly Recipe GalkanDagger = new Recipe { Name = "Galkan Dagger"};
        public static readonly Recipe LeucosVoulge = new Recipe { Name = "Leucos Voulge"};
        public static readonly Recipe ThothsWand = new Recipe { Name = "Thoth's Wand"};
        public static readonly Recipe OrcPiercer = new Recipe { Name = "Orc Piercer"};
        public static readonly Recipe Retaliator = new Recipe { Name = "Retaliator"};
        public static readonly Recipe IridalStaff = new Recipe { Name = "Iridal Staff"};
        public static readonly Recipe TacticianMagiciansWand = new Recipe { Name = "Tactician Magician's Wand"};
        public static readonly Recipe SharkGun = new Recipe { Name = "Shark Gun"};
        public static readonly Recipe SlickDart = new Recipe { Name = "Slick Dart"};
        public static readonly Recipe Raikiri = new Recipe { Name = "Raikiri"};
        public static readonly Recipe MoogleSpear = new Recipe { Name = "Moogle Spear"};
        public static readonly Recipe BreakShot = new Recipe { Name = "Break Shot"};
        public static readonly Recipe collab_903001270 = new Recipe { Name = "collab"};
        public static readonly Recipe TwinWhip = new Recipe { Name = "Twin Whip"};
        public static readonly Recipe Microphone_903001290 = new Recipe { Name = "Microphone"};
        public static readonly Recipe TorrentRing = new Recipe { Name = "Torrent Ring"};
        public static readonly Recipe DivineShield = new Recipe { Name = "Divine Shield"};
        public static readonly Recipe RavenBeret = new Recipe { Name = "Raven Beret"};
        public static readonly Recipe TacticianMagiciansCoat = new Recipe { Name = "Tactician Magician's Coat"};
        public static readonly Recipe ParadeCuirass = new Recipe { Name = "Parade Cuirass"};
        public static readonly Recipe GoldenHairpin = new Recipe { Name = "Golden Hairpin"};
        public static readonly Recipe ParadeGorget = new Recipe { Name = "Parade Gorget"};
        public static readonly Recipe MoogleCrown = new Recipe { Name = "Moogle Crown"};
        public static readonly Recipe MoogleCape = new Recipe { Name = "Moogle Cape"};
        public static readonly Recipe UnsuiClothes = new Recipe { Name = "Unsui Clothes"};
        public static readonly Recipe GoldenHelm = new Recipe { Name = "Golden Helm"};
        public static readonly Recipe collab_904001620 = new Recipe { Name = "collab"};
        public static readonly Recipe collab_904001630 = new Recipe { Name = "collab"};
        public static readonly Recipe collab_904001640 = new Recipe { Name = "collab"};
        public static readonly Recipe collab_904001650 = new Recipe { Name = "collab"};
        public static readonly Recipe collab_904001660 = new Recipe { Name = "collab"};
        public static readonly Recipe collab_904001670 = new Recipe { Name = "collab"};
        public static readonly Recipe collab_904001680 = new Recipe { Name = "collab"};
        public static readonly Recipe collab_904001690 = new Recipe { Name = "collab"};
        public static readonly Recipe collab_904001700 = new Recipe { Name = "collab"};
        public static readonly Recipe FestivalRobe = new Recipe { Name = "Festival Robe+"};
        public static readonly Recipe FestivalCap = new Recipe { Name = "Festival Cap+"};
        public static readonly Recipe PlatinumTiara = new Recipe { Name = "Platinum Tiara"};
        public static readonly Recipe Fransisca = new Recipe { Name = "Fransisca"};
        public static readonly Recipe GloryStaff = new Recipe { Name = "Glory Staff"};
        public static readonly Recipe KrisKnife = new Recipe { Name = "Kris Knife"};
        public static readonly Recipe RoyalRing = new Recipe { Name = "Royal Ring"};
        public static readonly Recipe collab_904001780 = new Recipe { Name = "collab"};
        public static readonly Recipe collab_904001790 = new Recipe { Name = "collab"};
        public static readonly Recipe EveningGlove = new Recipe { Name = "Evening Glove"};
        public static readonly Recipe BunnyMask_904001810 = new Recipe { Name = "Bunny Mask"};
        public static readonly Recipe StylishBlackDress_904001820 = new Recipe { Name = "Stylish Black Dress"};
        public static readonly Recipe Darkra = new Recipe { Name = "Darkra"};
        public static readonly Recipe DragonKiller = new Recipe { Name = "Dragon Killer+"};
        public static readonly Recipe MogSearch = new Recipe { Name = "Mog Search"};
        public static readonly Recipe MogResist = new Recipe { Name = "Mog Resist"};
        public static readonly Recipe MogRise = new Recipe { Name = "Mog Rise"};
        public static readonly Recipe FiraBlade = new Recipe { Name = "Fira Blade"};
        public static readonly Recipe ChocolateEgg = new Recipe { Name = "Chocolate Egg"};
        public static readonly Recipe GreatEgg = new Recipe { Name = "Great Egg"};
        public static readonly Recipe MagicalEgg = new Recipe { Name = "Magical Egg"};
        public static readonly Recipe RadiantEgg = new Recipe { Name = "Radiant Egg"};
        public static readonly Recipe StaffofWrath = new Recipe { Name = "Staff of Wrath"};
        public static readonly Recipe CrownofJustice = new Recipe { Name = "Crown of Justice"};
        public static readonly Recipe BlackBandana = new Recipe { Name = "Black Bandana"};
        public static readonly Recipe SecondKnife = new Recipe { Name = "Second Knife"};
        public static readonly Recipe IcyVeins = new Recipe { Name = "Icy Veins"};
        public static readonly Recipe ColdSnap = new Recipe { Name = "Cold Snap"};
        public static readonly Recipe DrakesclawRod = new Recipe { Name = "Drakesclaw Rod"};
        public static readonly Recipe DrakesguardRobe = new Recipe { Name = "Drakesguard Robe"};
        public static readonly Recipe BahamutsFang = new Recipe { Name = "Bahamut's Fang"};
        public static readonly Recipe DragonsRoar = new Recipe { Name = "Dragon's Roar"};
        public static readonly Recipe GutsKnuckle = new Recipe { Name = "Guts Knuckle"};
        public static readonly Recipe GoldenEye = new Recipe { Name = "Golden Eye"};
        public static readonly Recipe ScionStrikersVisor = new Recipe { Name = "Scion Striker's Visor"};
        public static readonly Recipe ScionStrikersAttire = new Recipe { Name = "Scion Striker's Attire"};
        public static readonly Recipe ScionThaumaturgesMonocle = new Recipe { Name = "Scion Thaumaturge's Monocle"};
        public static readonly Recipe ScionThaumaturgesRobe = new Recipe { Name = "Scion Thaumaturge's Robe"};
        public static readonly Recipe Adventurer = new Recipe { Name = "Adventurer"};
        public static readonly Recipe AdventurerII = new Recipe { Name = "Adventurer II"};
        public static readonly Recipe AdventurerIII = new Recipe { Name = "Adventurer III"};
        public static readonly Recipe AdventurerIV = new Recipe { Name = "Adventurer IV"};
        public static readonly Recipe AdventurerV = new Recipe { Name = "Adventurer V"};
        public static readonly Recipe BrokenArm = new Recipe { Name = "Broken Arm"};
        public static readonly Recipe AngelWand = new Recipe { Name = "Angel Wand"};
        public static readonly Recipe PlatinumMusket = new Recipe { Name = "Platinum Musket"};
        public static readonly Recipe AncientOverlord = new Recipe { Name = "Ancient Overlord"};
        public static readonly Recipe IronWill = new Recipe { Name = "Iron Will"};
        public static readonly Recipe DragoonLance = new Recipe { Name = "Dragoon Lance"};
        public static readonly Recipe TypeFists = new Recipe { Name = "Type-3 Fists"};
        public static readonly Recipe CruelOath = new Recipe { Name = "Cruel Oath"};
        public static readonly Recipe BellowsArmGuard = new Recipe { Name = "Bellows Arm Guard"};
        public static readonly Recipe MagicBarrierDevice = new Recipe { Name = "Magic Barrier Device"};
        public static readonly Recipe ZDHelmet = new Recipe { Name = "ZD Helmet"};
        public static readonly Recipe AngelWing = new Recipe { Name = "Angel Wing"};
        public static readonly Recipe PlatinumRobe = new Recipe { Name = "Platinum Robe"};
        public static readonly Recipe SeraphimShield = new Recipe { Name = "Seraphim Shield"};
        public static readonly Recipe EmilsHead = new Recipe { Name = "Emil's Head"};
        public static readonly Recipe HeavyArmorB = new Recipe { Name = "Heavy Armor: B"};
        public static readonly Recipe PlatinaArmor = new Recipe { Name = "Platina Armor"};
        public static readonly Recipe BlizzaraBlade = new Recipe { Name = "Blizzara Blade"};
        public static readonly Recipe ThundaraBlade = new Recipe { Name = "Thundara Blade"};
        public static readonly Recipe AeroraBlade = new Recipe { Name = "Aerora Blade"};

		public static readonly List<Recipe> Recipes = new List<Recipe>
		{
           Potion,
           HiPotion,
           Ether,
           Antidote,
           EyeDrops,
           SmellingSalts,
           EchoHerbs,
           UnicornHorn,
           Vaccine,
           GoldNeedle,
           Remedy,
           Hyper,
           HealingSpring,
           SmokeBomb,
           BodyBoost,
           ManaBoost,
           ProtectDrink,
           ShellDrink,
           BacchussWine,
           Grenade,
           FragGrenade,
           Shuriken,
           FumaShuriken,
           Tent,
           MagicKey,
           BronzeKnife,
           Dagger,
           SleepDagger,
           Broadsword,
           LongSword,
           GreatSword,
           BusterSword,
           Kotetsu,
           Kikuichimonji,
           Kazekiri,
           Kodachi,
           BattleAxe,
           GreatAxe,
           WoodenHammer,
           IronHammer,
           WarHammer,
           BronzeMace,
           IronMace,
           Javelin,
           Partisan,
           BronzeKnuckles,
           MetalKnuckles,
           CatClaws,
           Rod,
           IronRod,
           Staff,
           CherryStaff,
           WizardsStaff,
           RuneStaff,
           ShortBow,
           LongBow,
           GreatBow,
           Altair,
           LeatherWhip,
           ChainWhip,
           Boomerang,
           Chakram,
           MoonRingBlade,
           Harp,
           SilverHarp,
           LeatherShield,
           SmallShield,
           Buckler,
           BronzeShield,
           IronShield,
           LeatherHat,
           FeatheredCap,
           WizardsHat,
           Bandana,
           CelebrantsMiter,
           HypnoCrown,
           RedCap,
           BronzeHelm,
           IronHelm,
           LeatherShirt,
           BardsTunic,
           ScholarRobe,
           PowerVest,
           Kenpogi,
           MagesHabit,
           SurvivalVest,
           NinjaGear,
           BlackBeltGi,
           LeatherPlate,
           CopperCuirass,
           IronPlate,
           BronzeArmor,
           IronArmor,
           CottonRobe,
           SilkRobe,
           TravelersGarbs,
           GaiaGear,
           ClericsRobes,
           IronGloves,
           PowerWrist,
           HyperWrist,
           SilverArmlet,
           FireRing,
           IceRing,
           SparkRing,
           WaterRing,
           GaleRing,
           EarthRing,
           ProtectRing,
           BarrierRing,
           RegenRing,
           CatsBell,
           HerosRing,
           MuscleBelt,
           Libra,
           Cure,
           Blindna,
           Vox,
           Poisona,
           Paralyna,
           Stona,
           Fire,
           Blizzard,
           Thunder,
           Water,
           Aero,
           Stone,
           Bio,
           Blizzara,
           Thundara,
           Watera,
           Aerora,
           Gravity,
           Drain,
           Biora,
           Sleep,
           Blind,
           Barfire,
           Barblizzard,
           Barthunder,
           Barwater,
           Baraero,
           Barstone,
           Silence,
           Barfira,
           Barblizzara,
           Barthundara,
           Shell,
           Deshell,
           Barwatera,
           Baraerora,
           Barstonra,
           Steal,
           Brace,
           FireBlade,
           BlizzardBlade,
           SilenceBlade,
           WaterBlade,
           StoneBlade,
           BlindBlade,
           BioBlade,
           MagicInfuse,
           MentalBreak,
           BioBlaster,
           BombFragment,
           FishScale,
           GiantFeather,
           Pinwheel,
           Icebrand,
           CoralSword,
           FireRod,
           Capella,
           ShockWhip,
           OchreShield,
           GreenBeret,
           Barbut,
           SagesSurplice,
           Protect,
           MP,
           SPR,
           BugKiller,
           XPotion,
           TurboEther,
           HolyTorch,
           MythrilSpear,
           MagesHat,
           SagesRobe,
           MythrilGloves,
           Cura,
           DEF,
           MythrilHammer,
           WindSpear,
           MythrilHelm,
           Bravery,
           MAG,
           FineBlade,
           SuperiorBlade,
           AntarcticWind,
           ZeussRage,
           EarthDrum,
           MythrilDagger,
           MainGauche,
           MythrilSword,
           Osafune,
           MythrilMace,
           MythrilClaws,
           MythrilBow,
           MythrilWhip,
           MythrilBuckler,
           LargeShield,
           MythrilShield,
           TigerMask,
           MythrilPlate,
           SilverCuirass,
           PaladinArmor,
           MythrilArmor,
           WizardsRobe,
           MoonBracer,
           Dispel,
           Faith,
           SpiritSlayer,
           HP_905101500,
           SleepBlade,
           AeroBlade,
           StonraBlade_905200660,
           VorpalAxe,
           GaeBolg,
           LightCurtain,
           WyvernsFeather,
           WhiteFang,
           MythrilSaber,
           Chirijiraden,
           MythrilAxe,
           Escutcheon,
           Brigandine,
           Curaga,
           EVOMAG,
           WateraBlade,
           WingedSaint,
           MoraleTalisman,
           RodofGravity,
           VoidVessel,
           StonraBlade_1000000004,
           HP_1000000005,
           BurstShot,
           StandardMogcakePack,
           RareMogcakePack,
           PremiumMogcakePack,
           LunarCurtain,
           NorthWind,
           Flametongue,
           ATK,
           AutoProtect,
           BioraBlade,
           RightArm,
           BlueFang,
           SleepSword,
           FlameLance,
           PoisonKnuckles,
           ThunderShield,
           IceArmor,
           AutoShell,
           OsmoseBlade,
           ShiningSplendor,
           YPotion,
           MegaEther,
           BloodSword,
           RedFang,
           Trident,
           RodofLightning,
           ElvenBow,
           FlameMail,
           Death,
           BirdKiller,
           AutoPotion,
           PowerBreak,
           MagicBreak,
           GiantsAxe,
           Werebuster,
           IceLance,
           IceRod,
           Sirius,
           MysteryVeil,
           GoldenArmor,
           BlackRobe,
           UndeadKiller,
           ArmorBreak,
           ThunderBlade,
           MonarchsRing,
           DominationRing,
           RulersRing,
           RingofDominion,
           HeavenlyWrath,
           DragonScale,
           GoldenStaff,
           BlessedHammer,
           IceShield,
           GoldenVest,
           WhiteRobe,
           BuddingMapleWand,
           ScionConjurersDalmatica,
           ScionConjurersPattens,
           CobaltWinglet,
           AntecedentsAttire,
           MeteorSurvivorRing,
           UldahnFalchion,
           ScionThiefsTunic,
           ScionThiefsHalfgloves,
           GaiasCry,
           GoldenBlade,
           FlameShield,
           Circlet,
           AngelRing,
           BreakBlade,
           Razzmatazz,
           HyperBall,
           Override,
           ThunderSpear,
           Betelgeuse,
           GoldenShield,
           Imperil,
           Microphone_1000000014,
           EveningGloves,
           BunnyMask_1000000016,
           StylishBlackDress_1000000017,
           MemoryCandy,
           MageMasher,
           RasAlgethi,
           GalkanDagger,
           LeucosVoulge,
           ThothsWand,
           OrcPiercer,
           Retaliator,
           IridalStaff,
           TacticianMagiciansWand,
           SharkGun,
           SlickDart,
           Raikiri,
           MoogleSpear,
           BreakShot,
           collab_903001270,
           TwinWhip,
           Microphone_903001290,
           TorrentRing,
           DivineShield,
           RavenBeret,
           TacticianMagiciansCoat,
           ParadeCuirass,
           GoldenHairpin,
           ParadeGorget,
           MoogleCrown,
           MoogleCape,
           UnsuiClothes,
           GoldenHelm,
           collab_904001620,
           collab_904001630,
           collab_904001640,
           collab_904001650,
           collab_904001660,
           collab_904001670,
           collab_904001680,
           collab_904001690,
           collab_904001700,
           FestivalRobe,
           FestivalCap,
           PlatinumTiara,
           Fransisca,
           GloryStaff,
           KrisKnife,
           RoyalRing,
           collab_904001780,
           collab_904001790,
           EveningGlove,
           BunnyMask_904001810,
           StylishBlackDress_904001820,
           Darkra,
           DragonKiller,
           MogSearch,
           MogResist,
           MogRise,
           FiraBlade,
           ChocolateEgg,
           GreatEgg,
           MagicalEgg,
           RadiantEgg,
           StaffofWrath,
           CrownofJustice,
           BlackBandana,
           SecondKnife,
           IcyVeins,
           ColdSnap,
           DrakesclawRod,
           DrakesguardRobe,
           BahamutsFang,
           DragonsRoar,
           GutsKnuckle,
           GoldenEye,
           ScionStrikersVisor,
           ScionStrikersAttire,
           ScionThaumaturgesMonocle,
           ScionThaumaturgesRobe,
           Adventurer,
           AdventurerII,
           AdventurerIII,
           AdventurerIV,
           AdventurerV,
           BrokenArm,
           AngelWand,
           PlatinumMusket,
           AncientOverlord,
           IronWill,
           DragoonLance,
           TypeFists,
           CruelOath,
           BellowsArmGuard,
           MagicBarrierDevice,
           ZDHelmet,
           AngelWing,
           PlatinumRobe,
           SeraphimShield,
           EmilsHead,
           HeavyArmorB,
           PlatinaArmor,
           BlizzaraBlade,
           ThundaraBlade,
           AeroraBlade,
		};
    }
}