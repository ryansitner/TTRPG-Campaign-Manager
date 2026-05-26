using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGManager.Models
{
    public enum Alignment
    {
        LawfulGood,
        NeutralGood,
        ChaoticGood,
        LawfulNeutral,
        TrueNeutral,
        ChaoticNeutral,
        LawfulEvil,
        NeutralEvil,
        ChaoticEvil,
        Unaligned
    }

    public enum ArmorType
    {
        // No Armor
        None,
        NaturalArmor,
        MageArmor,

        // Light Armor (Base + Full Dex Modifier)
        Padded,
        Leather,
        StuddedLeather,

        // Medium Armor (Base + Dex Modifier max 2)
        Hide,
        ChainShirt,
        ScaleMail,
        Breastplate,
        HalfPlate,

        // Heavy Armor (Base, ignores Dex)
        RingMail,
        ChainMail,
        Splint,
        Plate
    }

    public enum ClassType
    {
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Monster,
        None,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Wizard
    }

    public enum ConditionType
    {
        None,
        Blinded,
        Charmed,
        Deafened,
        Frightened,
        Grappled,
        Incapacitated,
        Paralyzed,
        Petrified,
        Poisoned,
        Prone,
        Restrained,
        Stunned,
        Unconscious
    }

    public enum CreatureAbilityType
    {
        Action,
        BonusAction,
        Reaction,
        SpecialTrait,
        LegendaryAction,
        LairAction
    }

    public enum DamageType
    {
        None, // Used in CreatureAbility for non-damaging abilities like bonus actions or special traits
        Bludgeoning,
        Piercing,
        Slashing,
        Fire,
        Cold,
        Lightning,
        Thunder,
        Acid,
        Poison,
        Psychic,
        Necrotic,
        Radiant,
        Force,
        Corruption // Unique damage type for custom campaign
    }

    public enum ItemRarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Artifact
    }

    public enum ItemType
    {
        AdventuringGear,
        Armor,
        Jewelry,
        Potion,
        Scroll,
        Shield,
        Treasure,
        Wand,
        Weapon,
        WondrousItem
    }

    public enum LanguageType
    {
        None,
        Common,
        Dwarvish,
        Elvish,
        Giant,
        Gnomish,
        Goblin,
        Halfling,
        Orc,
        Abyssal,
        Celestial,
        DeepSpeech,
        Draconic,
        Infernal,
        Primordial,
        Sylvan,
        Undercommon,
        ThievesCant,
        Custom
    }

    public enum MapType
    {
        World,
        Town,
        Dungeon,
        Battle
    }

    public enum ModifierType
    {
        Resistant,
        Vulnerable,
        Immune
    }

    public enum MonsterType
    {
        Humanoid,
        Beast,
        Undead,
        Dragon,
        Giant,
        Fey,
        Elemental,
        Construct,
        Aberration,
        Monstrosity,
        Celestial,
        Fiend,
        Ooze,
        Plant,
        Swarm
    }

    public enum MovementType
    {
        Walking,
        Flying,
        Swimming,
        Climbing,
        Burrowing
    }

    public enum ProficiencyLevel
    {
        None,
        Proficient,
        Expertise
    }

    public enum Size
    {
        Tiny,
        Small,
        Medium,
        Large,
        Huge,
        Gargantuan
    }

    public enum SkillType
    {
        Acrobatics,
        AnimalHandling,
        Arcana,
        Athletics,
        Deception,
        History,
        Insight,
        Intimidation,
        Investigation,
        Medicine,
        Nature,
        Perception,
        Performance,
        Persuasion,
        Religion,
        SleightOfHand,
        Stealth,
        Survival
    }

    public enum SpellcastingStat
    {
        Intelligence,
        Wisdom,
        Charisma,
        None
    }

    public enum SpellSchool
    {
        None,
        Abjuration,
        Conjuration,
        Divination,
        Enchantment,
        Evocation,
        Illusion,
        Necromancy,
        Transmutation,
        Corruption /* Unique magic school for custom campaign */
    }

    public enum StandardRace
    {
        None, // Default for enemies
        Human, // Default for NPCs
        Elf,
        Dwarf,
        Halfling,
        Gnome,
        Dragonborn,
        Tiefling,
        Orc,
        Custom
    }

    public enum StatType
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    }

}
