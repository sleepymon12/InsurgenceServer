﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminSiteNew.Models
{
    public enum MoveList
    {
        None,
        Megahorn = 1,
        Attackorder = 2,
        Bugbuzz = 3,
        Xscissor = 4,
        Signalbeam = 5,
        Uturn = 6,
        Steamroller = 7,
        Bugbite = 8,
        Silverwind = 9,
        Strugglebug = 10,
        Twineedle = 11,
        Furycutter = 12,
        Leechlife = 13,
        Pinmissile = 14,
        Defendorder = 15,
        Healorder = 16,
        Quiverdance = 17,
        Ragepowder = 18,
        Spiderweb = 19,
        Stringshot = 20,
        Tailglow = 21,
        Foulplay = 22,
        Nightdaze = 23,
        Crunch = 24,
        Darkpulse = 25,
        Suckerpunch = 26,
        Nightslash = 27,
        Bite = 28,
        Faintattack = 29,
        Snarl = 30,
        Assurance = 31,
        Payback = 32,
        Pursuit = 33,
        Thief = 34,
        Knockoff = 35,
        Beatup = 36,
        Fling = 37,
        Punishment = 38,
        Darkvoid = 39,
        Embargo = 40,
        Faketears = 41,
        Flatter = 42,
        Honeclaws = 43,
        Memento = 44,
        Nastyplot = 45,
        Quash = 46,
        Snatch = 47,
        Switcheroo = 48,
        Taunt = 49,
        Torment = 50,
        Roaroftime = 51,
        Dracometeor = 52,
        Outrage = 53,
        Dragonrush = 54,
        Spacialrend = 55,
        Dragonpulse = 56,
        Dragonclaw = 57,
        Dragontail = 58,
        Dragonbreath = 59,
        Dualchop = 60,
        Twister = 61,
        Dragonrage = 62,
        Dragondance = 63,
        Boltstrike = 64,
        Thunder = 65,
        Volttackle = 66,
        Zapcannon = 67,
        Fusionbolt = 68,
        Thunderbolt = 69,
        Wildcharge = 70,
        Discharge = 71,
        Thunderpunch = 72,
        Voltswitch = 73,
        Spark = 74,
        Thunderfang = 75,
        Shockwave = 76,
        Electroweb = 77,
        Chargebeam = 78,
        Thundershock = 79,
        Electroball = 80,
        Charge = 81,
        Magnetrise = 82,
        Thunderwave = 83,
        Focuspunch = 84,
        Hijumpkick = 85,
        Closecombat = 86,
        Focusblast = 87,
        Superpower = 88,
        Crosschop = 89,
        Dynamicpunch = 90,
        Hammerarm = 91,
        Jumpkick = 92,
        Aurasphere = 93,
        Sacredsword = 94,
        Secretsword = 95,
        Skyuppercut = 96,
        Submission = 97,
        Brickbreak = 98,
        Drainpunch = 99,
        Vitalthrow = 100,
        Circlethrow = 101,
        Forcepalm = 102,
        Lowsweep = 103,
        Revenge = 104,
        Rollingkick = 105,
        Wakeupslap = 106,
        Karatechop = 107,
        Machpunch = 108,
        Rocksmash = 109,
        Stormthrow = 110,
        Vacuumwave = 111,
        Doublekick = 112,
        Armthrust = 113,
        Triplekick = 114,
        Counter = 115,
        Finalgambit = 116,
        Lowkick = 117,
        Reversal = 118,
        Seismictoss = 119,
        Bulkup = 120,
        Detect = 121,
        Quickguard = 122,
        Vcreate = 123,
        Blastburn = 124,
        Eruption = 125,
        Overheat = 126,
        Blueflare = 127,
        Fireblast = 128,
        Flareblitz = 129,
        Magmastorm = 130,
        Fusionflare = 131,
        Heatwave = 132,
        Inferno = 133,
        Sacredfire = 134,
        Searingshot = 135,
        Flamethrower = 136,
        Blazekick = 137,
        Fierydance = 138,
        Lavaplume = 139,
        Firepunch = 140,
        Flameburst = 141,
        Firefang = 142,
        Flamewheel = 143,
        Firepledge = 144,
        Flamecharge = 145,
        Ember = 146,
        Firespin = 147,
        Incinerate = 148,
        Heatcrash = 149,
        Sunnyday = 150,
        Willowisp = 151,
        Skyattack = 152,
        Bravebird = 153,
        Hurricane = 154,
        Aeroblast = 155,
        Fly = 156,
        Bounce = 157,
        Drillpeck = 158,
        Airslash = 159,
        Aerialace = 160,
        Chatter = 161,
        Pluck = 162,
        Skydrop = 163,
        Wingattack = 164,
        Acrobatics = 165,
        Aircutter = 166,
        Gust = 167,
        Peck = 168,
        Defog = 169,
        Featherdance = 170,
        Mirrormove = 171,
        Roost = 172,
        Tailwind = 173,
        Shadowforce = 174,
        Shadowball = 175,
        Shadowclaw = 176,
        Ominouswind = 177,
        Shadowpunch = 178,
        Hex = 179,
        Shadowsneak = 180,
        Astonish = 181,
        Lick = 182,
        Nightshade = 183,
        Confuseray = 184,
        Curse = 185,
        Destinybond = 186,
        Grudge = 187,
        Nightmare = 188,
        Spite = 189,
        Frenzyplant = 190,
        Leafstorm = 191,
        Petaldance = 192,
        Powerwhip = 193,
        Seedflare = 194,
        Solarbeam = 195,
        Woodhammer = 196,
        Leafblade = 197,
        Energyball = 198,
        Seedbomb = 199,
        Gigadrain = 200,
        Hornleech = 201,
        Leaftornado = 202,
        Magicalleaf = 203,
        Needlearm = 204,
        Razorleaf = 205,
        Grasspledge = 206,
        Megadrain = 207,
        Vinewhip = 208,
        Bulletseed = 209,
        Absorb = 210,
        Grassknot = 211,
        Aromatherapy = 212,
        Cottonguard = 213,
        Cottonspore = 214,
        Grasswhistle = 215,
        Ingrain = 216,
        Leechseed = 217,
        Sleeppowder = 218,
        Spore = 219,
        Stunspore = 220,
        Synthesis = 221,
        Worryseed = 222,
        Earthquake = 223,
        Earthpower = 224,
        Dig = 225,
        Drillrun = 226,
        Boneclub = 227,
        Mudbomb = 228,
        Bulldoze = 229,
        Mudshot = 230,
        Bonemerang = 231,
        Sandtomb = 232,
        Bonerush = 233,
        Mudslap = 234,
        Fissure = 235,
        Magnitude = 236,
        Mudsport = 237,
        Sandattack = 238,
        Spikes = 239,
        Freezeshock = 240,
        Iceburn = 241,
        Blizzard = 242,
        Icebeam = 243,
        Iciclecrash = 244,
        Icepunch = 245,
        Aurorabeam = 246,
        Glaciate = 247,
        Icefang = 248,
        Avalanche = 249,
        Icywind = 250,
        Frostbreath = 251,
        Iceshard = 252,
        Powdersnow = 253,
        Iceball = 254,
        Iciclespear = 255,
        Sheercold = 256,
        Hail = 257,
        Haze = 258,
        Mist = 259,
        Explosion = 260,
        Selfdestruct = 261,
        Gigaimpact = 262,
        Hyperbeam = 263,
        Lastresort = 264,
        Doubleedge = 265,
        Headcharge = 266,
        Megakick = 267,
        Thrash = 268,
        Eggbomb = 269,
        Judgment = 270,
        Skullbash = 271,
        Hypervoice = 272,
        Rockclimb = 273,
        Takedown = 274,
        Uproar = 275,
        Bodyslam = 276,
        Technoblast = 277,
        Extremespeed = 278,
        Hyperfang = 279,
        Megapunch = 280,
        Razorwind = 281,
        Slam = 282,
        Strength = 283,
        Triattack = 284,
        Crushclaw = 285,
        Relicsong = 286,
        Chipaway = 287,
        Dizzypunch = 288,
        Facade = 289,
        Headbutt = 290,
        Retaliate = 291,
        Secretpower = 292,
        Slash = 293,
        Hornattack = 294,
        Stomp = 295,
        Covet = 296,
        Round = 297,
        Smellingsalt = 298,
        Swift = 299,
        Vicegrip = 300,
        Cut = 301,
        Struggle = 302,
        Tackle = 303,
        Weatherball = 304,
        Echoedvoice = 305,
        Fakeout = 306,
        Falseswipe = 307,
        Payday = 308,
        Pound = 309,
        Quickattack = 310,
        Scratch = 311,
        Snore = 312,
        Doublehit = 313,
        Feint = 314,
        Tailslap = 315,
        Rage = 316,
        Rapidspin = 317,
        Spikecannon = 318,
        Cometpunch = 319,
        Furyswipes = 320,
        Barrage = 321,
        Bind = 322,
        Doubleslap = 323,
        Furyattack = 324,
        Wrap = 325,
        Constrict = 326,
        Bide = 327,
        Crushgrip = 328,
        Endeavor = 329,
        Flail = 330,
        Frustration = 331,
        Guillotine = 332,
        Hiddenpower = 333,
        Horndrill = 334,
        Naturalgift = 335,
        Present = 336,
        Return = 337,
        Sonicboom = 338,
        Spitup = 339,
        Superfang = 340,
        Trumpcard = 341,
        Wringout = 342,
        Acupressure = 343,
        Afteryou = 344,
        Assist = 345,
        Attract = 346,
        Batonpass = 347,
        Bellydrum = 348,
        Bestow = 349,
        Block = 350,
        Camouflage = 351,
        Captivate = 352,
        Charm = 353,
        Conversion = 354,
        Conversion2 = 355,
        Copycat = 356,
        Defensecurl = 357,
        Disable = 358,
        Doubleteam = 359,
        Encore = 360,
        Endure = 361,
        Entrainment = 362,
        Flash = 363,
        Focusenergy = 364,
        Followme = 365,
        Foresight = 366,
        Glare = 367,
        Growl = 368,
        Growth = 369,
        Harden = 370,
        Healbell = 371,
        Helpinghand = 372,
        Howl = 373,
        Leer = 374,
        Lockon = 375,
        Lovelykiss = 376,
        Luckychant = 377,
        Mefirst = 378,
        Meanlook = 379,
        Metronome = 380,
        Milkdrink = 381,
        Mimic = 382,
        Mindreader = 383,
        Minimize = 384,
        Moonlight = 385,
        Morningsun = 386,
        Naturepower = 387,
        Odorsleuth = 388,
        Painsplit = 389,
        Perishsong = 390,
        Protect = 391,
        Psychup = 392,
        Recover = 393,
        Recycle = 394,
        Reflecttype = 395,
        Refresh = 396,
        Roar = 397,
        Safeguard = 398,
        Scaryface = 399,
        Screech = 400,
        Sharpen = 401,
        Shellsmash = 402,
        Simplebeam = 403,
        Sing = 404,
        Sketch = 405,
        Slackoff = 406,
        Sleeptalk = 407,
        Smokescreen = 408,
        Softboiled = 409,
        Splash = 410,
        Stockpile = 411,
        Substitute = 412,
        Supersonic = 413,
        Swagger = 414,
        Swallow = 415,
        Sweetkiss = 416,
        Sweetscent = 417,
        Swordsdance = 418,
        Tailwhip = 419,
        Teeterdance = 420,
        Tickle = 421,
        Transform = 422,
        Whirlwind = 423,
        Wish = 424,
        Workup = 425,
        Yawn = 426,
        Gunkshot = 427,
        Sludgewave = 428,
        Sludgebomb = 429,
        Poisonjab = 430,
        Crosspoison = 431,
        Sludge = 432,
        Venoshock = 433,
        Clearsmog = 434,
        Poisonfang = 435,
        Poisontail = 436,
        Acid = 437,
        Acidspray = 438,
        Smog = 439,
        Poisonsting = 440,
        Acidarmor = 441,
        Coil = 442,
        Gastroacid = 443,
        Poisongas = 444,
        Poisonpowder = 445,
        Toxic = 446,
        Toxicspikes = 447,
        Psychoboost = 448,
        Dreameater = 449,
        Futuresight = 450,
        Psystrike = 451,
        Psychic = 452,
        Extrasensory = 453,
        Psyshock = 454,
        Zenheadbutt = 455,
        Lusterpurge = 456,
        Mistball = 457,
        Psychocut = 458,
        Synchronoise = 459,
        Psybeam = 460,
        Heartstamp = 461,
        Confusion = 462,
        Mirrorcoat = 463,
        Psywave = 464,
        Storedpower = 465,
        Agility = 466,
        Allyswitch = 467,
        Amnesia = 468,
        Barrier = 469,
        Calmmind = 470,
        Cosmicpower = 471,
        Gravity = 472,
        Guardsplit = 473,
        Guardswap = 474,
        Healblock = 475,
        Healpulse = 476,
        Healingwish = 477,
        Heartswap = 478,
        Hypnosis = 479,
        Imprison = 480,
        Kinesis = 481,
        Lightscreen = 482,
        Lunardance = 483,
        Magiccoat = 484,
        Magicroom = 485,
        Meditate = 486,
        Miracleeye = 487,
        Powersplit = 488,
        Powerswap = 489,
        Powertrick = 490,
        Psychoshift = 491,
        Reflect = 492,
        Rest = 493,
        Roleplay = 494,
        Skillswap = 495,
        Telekinesis = 496,
        Teleport = 497,
        Trick = 498,
        Trickroom = 499,
        Wonderroom = 500,
        Headsmash = 501,
        Rockwrecker = 502,
        Stoneedge = 503,
        Rockslide = 504,
        Powergem = 505,
        Ancientpower = 506,
        Rockthrow = 507,
        Rocktomb = 508,
        Smackdown = 509,
        Rollout = 510,
        Rockblast = 511,
        Rockpolish = 512,
        Sandstorm = 513,
        Stealthrock = 514,
        Wideguard = 515,
        Doomdesire = 516,
        Irontail = 517,
        Meteormash = 518,
        Flashcannon = 519,
        Ironhead = 520,
        Steelwing = 521,
        Mirrorshot = 522,
        Magnetbomb = 523,
        Geargrind = 524,
        Metalclaw = 525,
        Bulletpunch = 526,
        Gyroball = 527,
        Heavyslam = 528,
        Metalburst = 529,
        Autotomize = 530,
        Irondefense = 531,
        Metalsound = 532,
        Shiftgear = 533,
        Hydrocannon = 534,
        Waterspout = 535,
        Hydropump = 536,
        Muddywater = 537,
        Surf = 538,
        Aquatail = 539,
        Crabhammer = 540,
        Dive = 541,
        Scald = 542,
        Waterfall = 543,
        Razorshell = 544,
        Brine = 545,
        Bubblebeam = 546,
        Octazooka = 547,
        Waterpulse = 548,
        Waterpledge = 549,
        Aquajet = 550,
        Watergun = 551,
        Clamp = 552,
        Whirlpool = 553,
        Bubble = 554,
        Aquaring = 555,
        Raindance = 556,
        Soak = 557,
        Watersport = 558,
        Withdraw = 559,
        Oblivionwing = 560,
        Geomancy = 561,
        Adapt = 562,
        Ragestate = 563,
        Devour = 564,
        Tesseract = 565,
        Darkepitaph = 566,
        Renaissance = 567,
        Soulwrecker = 568,
        Infernalrage = 569,
        Abyssalcrush = 570,
        Forestsurge = 571,
        Titanicforce = 572,
        Nervalcut = 573,
        Omnifist = 574,
        Voidcaller = 575,
        Dragonflux = 576,
        Razorstorm = 577,
        Zombiestrike = 578,
        Custommove = 579,
        Livewire = 580,
        Epicenter = 581,
        Lunarcannon = 582,
        Dracojet = 583,
        Echolocation = 584,
        Shadowend = 585,
        Shadowstorm = 586,
        Shadowblast = 587,
        Shadowbolt = 588,
        Shadowbreak = 589,
        Shadowchill = 590,
        Shadowfire = 591,
        Shadowrave = 592,
        Shadowrush = 593,
        Shadowwave = 594,
        Shadowblitz = 595,
        Shadowdown = 596,
        Shadowhalf = 597,
        Shadowhold = 598,
        Shadowmist = 599,
        Shadowpanic = 600,
        Shadowshed = 601,
        Shadowsky = 602,
        Flashfreeze = 603,
        Permafrost = 604,
        Medusaray = 605,
        Darkmatter = 606,
        Angelwings = 607,
        Powershrine = 609,
        Specialshrine = 610,
        Dradestorm = 611,
        Dragonify = 612,
        Fumble = 613,
        Wildfire = 614,
        Silverforce = 615,
        Venusforce = 616,
        Earthforce = 617,
        Marsforce = 618,
        Zeusforce = 619,
        Saturnforce = 620,
        Cloudforce = 621,
        Plutoforce = 622,
        Lunaforce = 623,
        Graviforce = 624,
        Fairyforce = 625,
        Fairyfyre = 626,
        Moonblast = 627,
        Shadowheat = 628,
        Shadowsurf = 629,
        Shadowgale = 630,
        Shadowsword = 631,
        Shadowwrath = 632,
        Shadowcrush = 633,
        Boomburst = 634,
        Kingsshield = 635,
        Terraforce = 636,
        Bullethail = 637,
        Crystalrush = 638,
        Solarcharge = 639,
        Wormhole = 640,
        Playrough = 641,
        Drainingkiss = 642,
        Watershuriken = 643,
        Spikyshield = 644,
        Mysticalfire = 645,
        Freezedry = 646,
        Flyingpress = 647,
        Diamondstorm = 648,
        Steameruption = 649,
        Hyperspace = 650,
        Darksonata = 651,
        Paraboliccharge = 652,
        Hiddenpowerrock = 653,
        Dazzlinggleam = 654,
        Hiddenpowerice = 655,
        Hiddenpowernormal = 656,
        Hiddenpowerfighting = 657,
        Hiddenpowerflying = 658,
        Hiddenpowerpoison = 659,
        Hiddenpowerground = 660,
        Hiddenpowerghost = 661,
        Hiddenpowerbug = 662,
        Hiddenpowersteel = 663,
        Hiddenpowerfire = 664,
        Hiddenpowerwater = 665,
        Hiddenpowergrass = 666,
        Hiddenpowerelectric = 667,
        Hiddenpowerpsychic = 668,
        Hiddenpowerice2 = 668,
        Hiddenpowerdragon = 669,
        Hiddenpowerdark = 670,
        Hiddenpowerfairy = 671,
        Karmasurge = 672,
        Karmasow = 673,
        Karmareap = 674,
        Ragnarok = 675,
        Powder = 676,
        Nobleroar = 677,
        Fairywind = 678,
        Grassyterrain = 679,
        Mistyterrain = 680,
        Electricterrain = 681,
        Petalblizzard = 682,
        Disarmingvoice = 683,
        Flowershield = 684,
        Babydolleyes = 685,
        Aromaticmist = 686,
        Playnice = 687,
        Nuzzle = 688,
        Eerieimpulse = 689,
        Forestcurse = 690,
        Trickortreat = 691,
        Phantomforce = 692,
        Venomdrench = 693,
        Rototiller = 694,
        Fellstinger = 695,
        Belch = 696,
        Confide = 697,
        Fairylock = 698,
        Infestation = 699,
        Landswrath = 700,
        Matblock = 701,
        Thousandarrows = 702,
        Thousandwaves = 703,
        Stickyweb = 704,
        Topsyturvy = 705,
        Poweruppunch = 706,
        Newmoon = 707,
        Jetstream = 708,
        Achillesheel = 709,
        Corrode = 710,
        Drakonvoice = 711,
        Ancientroar = 712,
        Dragonsascent = 713,
        Originpulse = 714,
        Precipiceblades = 715,
    }
}
