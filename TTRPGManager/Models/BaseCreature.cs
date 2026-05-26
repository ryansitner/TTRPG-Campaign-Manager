using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TTRPGManager.Models
{
    public class BaseCreature
    {
        /* Backing Fields for Smart Properties */
        private int? _passivePerception;

        public int Id { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int PassivePerception
        {
            get
            {
                // Manual Override: If the user explicitly set a value, return it.
                if (_passivePerception.HasValue) return _passivePerception.Value;

                // Default Calculation: 10 + WisdomMod + Skill Proficiency
                int bonus = WisdomModifier;
                var perceptionSkill = Skills.FirstOrDefault(s => s.Skill == SkillType.Perception);

                if (perceptionSkill != null)
                {
                    // Use the skill's specific override if it exists
                    if (perceptionSkill.OverrideBonus.HasValue)
                        return 10 + perceptionSkill.OverrideBonus.Value;

                    // Apply Proficiency or Expertise math
                    if (perceptionSkill.Proficiency == ProficiencyLevel.Proficient)
                        bonus += ProficiencyBonus;
                    else if (perceptionSkill.Proficiency == ProficiencyLevel.Expertise)
                        bonus += (ProficiencyBonus * 2);
                }

                return 10 + bonus;
            }
            set => _passivePerception = value;
        }
        public int InitiativeBonus { get; set; }
        public int CasterLevel { get; set; } = 0;
        public int SpellAttackBonus => SpellcastingModifier + ProficiencyBonus;


        public double ChallengeRating { get; set; }
        public int ProficiencyBonus => ChallengeRating < 5 ? 2 : (int)Math.Ceiling(ChallengeRating / 4.0) + 1;

        /* Armor Class */
        public bool UseManualAC { get; set; }
        public int ManualACValue { get; set; } = 10;
        public int ArmorClass
        {
            get
            {
                // 1. Check if the DM is manually overriding the AC
                if (UseManualAC == true) { return ManualACValue; }

                // TODO: Re-implement equipped Armor & Shield calculations here 
                // once the CharacterInventorySlot join table is built!

                // 2. Temporary Fallback: Base unarmored calculation
                return 10 + DexterityModifier;
            }
        }

        /* Ability Scores */
        private int _strength = 10;
        public int Strength
        {
            get => _strength;
            set => _strength = Math.Clamp(value, 0, 30);
        }
        
        private int _dexterity = 10;
        public int Dexterity
        {
            get => _dexterity;
            set
            {
                _dexterity = Math.Clamp(value, 0, 30);
                InitiativeBonus = DexterityModifier; // Automatically update Initiative to match dex Modifier
            }
        }

        private int _constitution = 10;
        public int Constitution
        {
            get => _constitution;
            set => _constitution = Math.Clamp(value, 0, 30);
        }
        
        private int _intelligence = 10;
        public int Intelligence
        {
            get => _intelligence;
            set => _intelligence = Math.Clamp(value, 0, 30);
        }
        
        private int _wisdom = 10;
        public int Wisdom
        {
            get => _wisdom;
            set => _wisdom = Math.Clamp(value, 0, 30);
        }

        private int _charisma = 10;
        public int Charisma
        {
            get => _charisma;
            set => _charisma = Math.Clamp(value, 0, 30);
        }

        /* Ability Modifiers */
        public int StrengthModifier => (int)Math.Floor((Strength - 10) / 2.0);
        public int DexterityModifier => (int)Math.Floor((Dexterity - 10) / 2.0);
        public int ConstitutionModifier => (int)Math.Floor((Constitution - 10) / 2.0);
        public int IntelligenceModifier => (int)Math.Floor((Intelligence - 10) / 2.0);
        public int WisdomModifier => (int)Math.Floor((Wisdom - 10) / 2.0);
        public int CharismaModifier => (int)Math.Floor((Charisma - 10) / 2.0);
        public int SpellcastingModifier => CastingStat switch
        {
            SpellcastingStat.Intelligence => IntelligenceModifier,
            SpellcastingStat.Wisdom => WisdomModifier,
            SpellcastingStat.Charisma => CharismaModifier,
            _ => 0 // Default - if it is None, return 0
        };

        /* Ability Saving Throws (includes proficiency if applicable) */
        public int StrengthSavingThrow => HasStrengthProficiency ? StrengthModifier + ProficiencyBonus : StrengthModifier;
        public int DexteritySavingThrow => HasDexterityProficiency ? DexterityModifier + ProficiencyBonus : DexterityModifier;
        public int ConstitutionSavingThrow => HasConstitutionProficiency ? ConstitutionModifier + ProficiencyBonus : ConstitutionModifier;
        public int IntelligenceSavingThrow => HasIntelligenceProficiency ? IntelligenceModifier + ProficiencyBonus : IntelligenceModifier;
        public int WisdomSavingThrow => HasWisdomProficiency ? WisdomModifier + ProficiencyBonus : WisdomModifier;
        public int CharismaSavingThrow => HasCharismaProficiency ? CharismaModifier + ProficiencyBonus : CharismaModifier;
        public int SpellSaveDC => 8 + ProficiencyBonus + SpellcastingModifier;

        /* Leveled Spell Slots */
        public int SpellSlotsLevel1 { get; set; }
        public int SpellSlotsLevel2 { get; set; }
        public int SpellSlotsLevel3 { get; set; }
        public int SpellSlotsLevel4 { get; set; }
        public int SpellSlotsLevel5 { get; set; }
        public int SpellSlotsLevel6 { get; set; }
        public int SpellSlotsLevel7 { get; set; }
        public int SpellSlotsLevel8 { get; set; }
        public int SpellSlotsLevel9 { get; set; }

        /* General Info */
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Portrait { get; set; } = "/images/DefaultNpcPortrait.png";
        public string? Description { get; set; }
        public string HitDice { get; set; } = string.Empty;
        public string Race { get; set; } = "None";

        /* Proficiencies and Traits */
        public bool HasStrengthProficiency { get; set; }
        public bool HasDexterityProficiency { get; set; }
        public bool HasConstitutionProficiency { get; set; }
        public bool HasIntelligenceProficiency { get; set; }
        public bool HasWisdomProficiency { get; set; }
        public bool HasCharismaProficiency { get; set; }
        public bool HasShield { get; set; }


        public ArmorType ArmorType { get; set; }
        public MonsterType MonsterType { get; set; }
        public Alignment Alignment { get; set; } = Alignment.Unaligned;
        public Size Size { get; set; } = Size.Medium;
        public ClassType ClassType { get; set; } = ClassType.None;
        public SpellcastingStat CastingStat { get; set; } = SpellcastingStat.None;

        public List<CreatureSpell> Spells { get; set; } = new List<CreatureSpell>();
        public List<Item> Inventory { get; set; } = new List<Item>();
        public List<CreatureSkill> Skills { get; set; } = new List<CreatureSkill>();
        public List<MovementSpeed> Speeds { get; set; } = new List<MovementSpeed>();
        public List<DamageModifier> Modifiers { get; set; } = new List<DamageModifier>();
        public List<ConditionImmunity> Conditions { get; set; } = new List<ConditionImmunity>();
        public List<CreatureAbility> Abilities { get; set; } = new List<CreatureAbility>();
        public List<CreatureLanguage> Languages { get; set; } = new List<CreatureLanguage>();
        public List<CreatureTrait> Traits { get; set; } = new List<CreatureTrait>();

        /* Methods */
        public void EquipWeapon(Item weapon)
        {
            // Safety Check: Confirm item is a weapon
            if (weapon.Type != ItemType.Weapon || weapon.DamageDice == null)
                return;

            // Determine to use Strength or Dexterity modifier
            int attackModifier = StrengthModifier;
            if (weapon.IsFinesseWeapon && DexterityModifier > StrengthModifier)
            {
                attackModifier = DexterityModifier;
            }

            // Create the Action
            var newAttack = new CreatureAbility
            {
                Name = weapon.Name + " Attack",
                Type = CreatureAbilityType.Action,
                Description = $"Melee Weapon Attack with {weapon.Name}.",
                DamageDice = weapon.DamageDice,
                DamageType = weapon.DamageType,
                //DamageBonus = attackModifier, << REMOVED DAMAGE BONUS AS MODIFIER SHOULD BE CALCULATED
            };

            // Add it to the Creature's action list
            this.Abilities.Add(newAttack);
        }

        public void UnequipWeapon(Item weapon)
        {
            // Remove the weapon item from the backpack
            this.Inventory.Remove(weapon);

            // Identify the action created by the weapon
            // using the exact string pattern used in EquipWeapon
            string targetActionName = weapon.Name + " Attack";

            // Use LINQ to search the Abilities list for that specific name
            var actionToRemove = this.Abilities.FirstOrDefault(ability => ability.Name == targetActionName);

            // If found, delete it from the action list
            if (actionToRemove != null)
            {
                this.Abilities.Remove(actionToRemove);
            }
        }

    }
}
