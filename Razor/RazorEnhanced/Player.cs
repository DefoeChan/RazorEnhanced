﻿using Assistant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RazorEnhanced
{
	public class Player
	{
		// Stats
		public static int Hits { get { return World.Player.Hits; } }
		public static int HitsMax { get { return World.Player.HitsMax; } }
		public static int Str { get { return World.Player.Str; } }
		public static int Mana { get { return World.Player.Mana; } }
		public static int ManaMax { get { return World.Player.ManaMax; } }
		public static int Int { get { return World.Player.Int; } }
		public static int Stam { get { return World.Player.Stam; } }
		public static int StamMax { get { return World.Player.StamMax; } }
		public static int Dex { get { return World.Player.Dex; } }
		public static int StatCap { get { return World.Player.StatCap; } }

		// Resistance
		public static int AR { get { return World.Player.AR; } }

		public static int FireResistance { get { return World.Player.FireResistance; } }
		public static int ColdResistance { get { return World.Player.ColdResistance; } }
		public static int EnergyResistance { get { return World.Player.EnergyResistance; } }
		public static int PoisonResistance { get { return World.Player.PoisonResistance; } }

		// KR Attribute
		public static int SwingSpeedIncrease { get { return World.Player.SwingSpeedIncrease; } }
		public static int DamageChanceIncrease { get { return World.Player.DamageChanceIncrease; } }
		public static int LowerReagentCost { get { return World.Player.LowerReagentCost; } }
		public static int HitPointsRegeneration { get { return World.Player.HitPointsRegeneration; } }
		public static int StaminaRegeneration { get { return World.Player.StaminaRegeneration; } }
		public static int ManaRegeneration { get { return World.Player.ManaRegeneration; } }
		public static int ReflectPhysicalDamage { get { return World.Player.ReflectPhysicalDamage; } }
		public static int EnhancePotions { get { return World.Player.EnhancePotions; } }
		public static int DefenseChanceIncrease { get { return World.Player.DefenseChanceIncrease; } }
		public static int SpellDamageIncrease { get { return World.Player.SpellDamageIncrease; } }
		public static int FasterCastRecovery { get { return World.Player.FasterCastRecovery; } }
		public static int FasterCasting { get { return World.Player.FasterCasting; } }
		public static int LowerManaCost { get { return World.Player.LowerManaCost; } }
		public static int StrengthIncrease { get { return World.Player.StrengthIncrease; } }
		public static int DexterityIncrease { get { return World.Player.DexterityIncrease; } }
		public static int IntelligenceIncrease { get { return World.Player.IntelligenceIncrease; } }
		public static int HitPointsIncrease { get { return World.Player.HitPointsIncrease; } }
		public static int StaminaIncrease { get { return World.Player.StaminaIncrease; } }
		public static int ManaIncrease { get { return World.Player.ManaIncrease; } }
		public static int MaximumHitPointsIncrease { get { return World.Player.MaximumHitPointsIncrease; } }
		public static int MaximumStaminaIncrease { get { return World.Player.MaximumStaminaIncrease; } }
		public static int MaximumManaIncrease { get { return World.Player.MaximumManaIncrease; } }

		// Flags
		public static bool IsGhost { get { return World.Player.IsGhost; } }

		public static bool Poisoned { get { return World.Player.Poisoned; } }
		public static bool YellowHits { get { return World.Player.Blessed; } }
		public static bool Visible { get { return World.Player.Visible; } }
		public static bool WarMode { get { return World.Player.Warmode; } }
		public static bool Paralized { get { return World.Player.Paralized; } }
		public static bool HasSpecial { get { return World.Player.HasSpecial; } }

		// Self
		public static bool Female { get { return World.Player.Female; } }

		public static String Name { get { return World.Player.Name; } }
		public static byte Notoriety { get { return World.Player.Notoriety; } }

		public static Item Backpack
		{
			get
			{
				Assistant.Item assistantBackpack = World.Player.Backpack;
				if (assistantBackpack == null)
					return null;
				else
				{
					RazorEnhanced.Item enhancedBackpack = new RazorEnhanced.Item(assistantBackpack);
					return enhancedBackpack;
				}
			}
		}

		public static Item Bank
		{
			get
			{
				Assistant.Item assistantBank = World.Player.GetItemOnLayer(Layer.Bank);
				if (assistantBank == null)
					return null;
				else
				{
					RazorEnhanced.Item enhancedBackpack = new RazorEnhanced.Item(assistantBank);
					return enhancedBackpack;
				}
			}
		}

		public static Item Quiver
		{
			get
			{
				Assistant.Item assistantQuiver = World.Player.Quiver;
				if (assistantQuiver == null)
					return null;
				else
				{
					RazorEnhanced.Item enhancedQuiver = new RazorEnhanced.Item(assistantQuiver);
					return enhancedQuiver;
				}
			}
		}

		public static Item Mount
		{
			get
			{
				Assistant.Item assistantMount = World.Player.GetItemOnLayer(Assistant.Layer.Mount);
				if (assistantMount == null)
					return null;
				else
				{
					RazorEnhanced.Item enhancedMount = new RazorEnhanced.Item(assistantMount);
					return enhancedMount;
				}
			}
		}

		public static int Gold { get { return Convert.ToInt32(World.Player.Gold); } }
		public static int Luck { get { return World.Player.Luck; } }
		public static int Body { get { return World.Player.Body; } }
		public static int Serial { get { return World.Player.Serial; } }

		// Follower
		public static int FollowersMax { get { return World.Player.FollowersMax; } }

		public static int Followers { get { return World.Player.Followers; } }

		// Weight
		public static int MaxWeight { get { return World.Player.MaxWeight; } }

		public static int Weight { get { return World.Player.Weight; } }

		// Position
		public static Point3D Position { get { return new Point3D(World.Player.Position); } }
		public static int Map { get { return World.Player.Map; } }
		public static string Direction
		{
			get
			{
				switch (World.Player.Direction & Assistant.Direction.Mask)
				{
					case Assistant.Direction.North: return "North";
					case Assistant.Direction.South: return "South";
					case Assistant.Direction.West: return "West";
					case Assistant.Direction.East: return "East";
					case Assistant.Direction.Right: return "Right";
					case Assistant.Direction.Left: return "Left";
					case Assistant.Direction.Down: return "Down";
					case Assistant.Direction.Up: return "Up";
					default: return "Undefined";
				}
			}
		}

		public static int DistanceTo(Mobile m)
		{
			int x = Math.Abs(Position.X - m.Position.X);
			int y = Math.Abs(Position.Y - m.Position.Y);

			return x > y ? x : y;
		}

		public static int DistanceTo(Item i)
		{
			int x = Math.Abs(Position.X - i.Position.X);
			int y = Math.Abs(Position.Y - i.Position.Y);

			return x > y ? x : y;
		}

		internal static string GetBuffDescription(BuffIcon icon)
		{
			string description = String.Empty;

			switch (icon)
			{
				case BuffIcon.ActiveMeditation:
					description = "Meditation";
					break;

				case BuffIcon.Agility:
					description = "Agility";
					break;

				case BuffIcon.AnimalForm:
					description = "Animal Form";
					break;

				case BuffIcon.ArcaneEmpowerment:
					description = "Arcane Enpowerment";
					break;

				case BuffIcon.ArcaneEmpowermentNew:
					description = "Arcane Enpowerment (new)";
					break;

				case BuffIcon.ArchProtection:
					description = "Arch Protection";
					break;

				case BuffIcon.ArmorPierce:
					description = "Armor Pierce";
					break;

				case BuffIcon.AttuneWeapon:
					description = "Attunement";
					break;

				case BuffIcon.AuraOfNausea:
					description = "Aura of Nausea";
					break;

				case BuffIcon.Bleed:
					description = "Bleed";
					break;

				case BuffIcon.Bless:
					description = "Bless";
					break;

				case BuffIcon.Block:
					description = "Block";
					break;

				case BuffIcon.BloodOathCaster:
					description = "Bload Oath (caster)";
					break;

				case BuffIcon.BloodOathCurse:
					description = "Bload Oath (curse)";
					break;

				case BuffIcon.BloodwormAnemia:
					description = "BloodWorm Anemia";
					break;

				case BuffIcon.CityTradeDeal:
					description = "City Trade Deal";
					break;

				case BuffIcon.Clumsy:
					description = "Clumsy";
					break;

				case BuffIcon.Confidence:
					description = "Confidence";
					break;

				case BuffIcon.CorpseSkin:
					description = "Corpse Skin";
					break;

				case BuffIcon.CounterAttack:
					description = "Counter Attack";
					break;

				case BuffIcon.CriminalStatus:
					description = "Criminal";
					break;

				case BuffIcon.Cunning:
					description = "Cunning";
					break;

				case BuffIcon.Curse:
					description = "Curse";
					break;

				case BuffIcon.CurseWeapon:
					description = "Curse Weapon";
					break;

				case BuffIcon.DeathStrike:
					description = "Death Strike";
					break;

				case BuffIcon.DefenseMastery:
					description = "Defense Mastery";
					break;

				case BuffIcon.Despair:
					description = "Despair";
					break;

				case BuffIcon.DespairTarget:
					description = "Despair (target)";
					break;

				case BuffIcon.DisarmNew:
					description = "Disarm (new)";
					break;

				case BuffIcon.Disguised:
					description = "Disguised";
					break;

				case BuffIcon.DismountPrevention:
					description = "Dismount Prevention";
					break;

				case BuffIcon.DivineFury:
					description = "Divine Fury";
					break;

				case BuffIcon.DragonSlasherFear:
					description = "Dragon Slasher Fear";
					break;

				case BuffIcon.Enchant:
					description = "Enchant";
					break;

				case BuffIcon.EnemyOfOne:
					description = "Enemy Of One";
					break;

				case BuffIcon.EnemyOfOneNew:
					description = "Enemy Of One (new)";
					break;

				case BuffIcon.EssenceOfWind:
					description = "Essence Of Wind";
					break;

				case BuffIcon.EtherealVoyage:
					description = "Ethereal Voyage";
					break;

				case BuffIcon.Evasion:
					description = "Evasion";
					break;

				case BuffIcon.EvilOmen:
					description = "Evil Omen";
					break;

				case BuffIcon.FactionLoss:
					description = "Faction Loss";
					break;

				case BuffIcon.FanDancerFanFire:
					description = "Fan Dancer Fan Fire";
					break;

				case BuffIcon.FeebleMind:
					description = "Feeble Mind";
					break;

				case BuffIcon.Feint:
					description = "Feint";
					break;

				case BuffIcon.ForceArrow:
					description = "Force Arrow";
					break;

				case BuffIcon.GargoyleBerserk:
					description = "Berserk";
					break;

				case BuffIcon.GargoyleFly:
					description = "Fly";
					break;

				case BuffIcon.GazeDespair:
					description = "Gaze Despair";
					break;

				case BuffIcon.GiftOfLife:
					description = "Gift Of Life";
					break;

				case BuffIcon.GiftOfRenewal:
					description = "Gift Of Renewal";
					break;

				case BuffIcon.HealingSkill:
					description = "Healing";
					break;

				case BuffIcon.HeatOfBattleStatus:
					description = "Heat Of Battle";
					break;

				case BuffIcon.HidingAndOrStealth:
					description = "Hiding";
					break;

				case BuffIcon.HiryuPhysicalResistance:
					description = "Hiryu Physical Malus";
					break;

				case BuffIcon.HitDualwield:
					description = "Hit Dual Wield";
					break;

				case BuffIcon.HitLowerAttack:
					description = "Hit Lower Attack";
					break;

				case BuffIcon.HitLowerDefense:
					description = "Hit Lower Defense";
					break;

				case BuffIcon.HonorableExecution:
					description = "Honorable Execution";
					break;

				case BuffIcon.Honored:
					description = "Honored";
					break;

				case BuffIcon.HorrificBeast:
					description = "Horrific Beast";
					break;

				case BuffIcon.HowlOfCacophony:
					description = "Hawl Of Cacophony";
					break;

				case BuffIcon.ImmolatingWeapon:
					description = "Immolating Weapon";
					break;

				case BuffIcon.Incognito:
					description = "Incognito";
					break;

				case BuffIcon.Inspire:
					description = "Inspire";
					break;

				case BuffIcon.Invigorate:
					description = "Invigorate";
					break;

				case BuffIcon.Invisibility:
					description = "Invisibility";
					break;

				case BuffIcon.LichForm:
					description = "Lich Form";
					break;

				case BuffIcon.LightningStrike:
					description = "Lighting Strike";
					break;

				case BuffIcon.MagicFish:
					description = "Magic Fish";
					break;

				case BuffIcon.MagicReflection:
					description = "Magic Reflection";
					break;

				case BuffIcon.ManaPhase:
					description = "Mana Phase";
					break;

				case BuffIcon.MassCurse:
					description = "Mass Curse";
					break;

				case BuffIcon.MedusaStone:
					description = "Medusa Stone";
					break;

				case BuffIcon.Mindrot:
					description = "Mind Rot";
					break;

				case BuffIcon.MomentumStrike:
					description = "Momentum Strike";
					break;

				case BuffIcon.MortalStrike:
					description = "Mortal Strike";
					break;

				case BuffIcon.NightSight:
					description = "Night Sight";
					break;

				case BuffIcon.NoRearm:
					description = "NoRearm";
					break;

				case BuffIcon.OrangePetals:
					description = "Orange Petals";
					break;

				case BuffIcon.PainSpike:
					description = "Pain Spike";
					break;

				case BuffIcon.Paralyze:
					description = "Paralyze";
					break;

				case BuffIcon.Perfection:
					description = "Perfection";
					break;

				case BuffIcon.Perseverance:
					description = "Perseverance";
					break;

				case BuffIcon.Poison:
					description = "Poison";
					break;

				case BuffIcon.PoisonResistanceImmunity:
					description = "Poison Resistance";
					break;

				case BuffIcon.Polymorph:
					description = "Polymorph";
					break;

				case BuffIcon.Protection:
					description = "Protection";
					break;

				case BuffIcon.PsychicAttack:
					description = "Psychic Attack";
					break;

				case BuffIcon.ConsecrateWeapon:
					description = "Consecrate Weapon";
					break;

				case BuffIcon.Rage:
					description = "Rage";
					break;

				case BuffIcon.RageFocusing:
					description = "Rage Focusing";
					break;

				case BuffIcon.RageFocusingTarget:
					description = "Rage Focusing (target)";
					break;

				case BuffIcon.ReactiveArmor:
					description = "Reactive Armor";
					break;

				case BuffIcon.ReaperForm:
					description = "Reaper Form";
					break;

				case BuffIcon.Resilience:
					description = "Resilience";
					break;

				case BuffIcon.RoseOfTrinsic:
					description = "Rose Of Trinsic";
					break;

				case BuffIcon.RotwormBloodDisease:
					description = "Rotworm Blood Disease";
					break;

				case BuffIcon.RuneBeetleCorruption:
					description = "Rune Beetle Corruption";
					break;

				case BuffIcon.SkillUseDelay:
					description = "Skill Use Delay";
					break;

				case BuffIcon.Sleep:
					description = "Sleep";
					break;

				case BuffIcon.SpellFocusing:
					description = "Spell Focusing";
					break;

				case BuffIcon.SpellFocusingTarget:
					description = "Spell Focusing (target)";
					break;

				case BuffIcon.SpellPlague:
					description = "Spell Plague";
					break;

				case BuffIcon.SplinteringEffect:
					description = "Splintering Effect";
					break;

				case BuffIcon.StoneForm:
					description = "Stone Form";
					break;

				case BuffIcon.Strangle:
					description = "Strangle";
					break;

				case BuffIcon.Strength:
					description = "Strength";
					break;

				case BuffIcon.Surge:
					description = "Surge";
					break;

				case BuffIcon.SwingSpeed:
					description = "Swing Speed";
					break;

				case BuffIcon.TalonStrike:
					description = "Talon Strike";
					break;

				case BuffIcon.Weaken:
					description = "Weaken";
					break;
				case BuffIcon.VampiricEmbrace:
					description = "Vampiric Embrace";
					break;
			}

			return description;
		}

		// Buff
		public static List<string> Buffs
		{
			get
			{
				List<string> buffs = new List<string>();
				foreach (BuffIcon icon in World.Player.Buffs)
				{
					buffs.Add(GetBuffDescription(icon));
				}
				return buffs;
			}
		}

		public static bool BuffsExist(string buffname)
		{
			if (World.Player == null || World.Player.Buffs == null)
				return false;

			for (int i = 0; i < World.Player.Buffs.Count; i++)
			{
				if (GetBuffDescription(World.Player.Buffs[i]) == buffname)
					return true;
			}

			return false;
		}

		public static void UnEquipItemByLayer(String layer, bool wait = true)
		{
			Enum.TryParse<Layer>(layer, out Layer l);

			Assistant.Item item = World.Player.GetItemOnLayer(l);

			if (item != null)
			{
				if (wait)
				{
					ClientCommunication.SendToServerWait(new LiftRequest(item.Serial, item.Amount));
					ClientCommunication.SendToServerWait(new DropRequest(item.Serial, Assistant.Point3D.MinusOne, World.Player.Backpack.Serial));
				}
				else
				{
					ClientCommunication.SendToServer(new LiftRequest(item.Serial, item.Amount));
					ClientCommunication.SendToServer(new DropRequest(item.Serial, Assistant.Point3D.MinusOne, World.Player.Backpack.Serial));
				}
			}
			else
			{
				Scripts.SendMessageScriptError("Script Error: UnEquipItemByLayer: No item found on layer: " + layer);
			}
		}

		public static void EquipItem(int serial)
		{
			Assistant.Item item = World.FindItem((Assistant.Serial)serial);
			if (item == null)
			{
				Scripts.SendMessageScriptError("Script Error: EquipItem: Item serial: (" + serial + ") not found");
				return;
			}

			if (item.Container == null && Assistant.Utility.Distance(item.GetWorldPosition(), World.Player.Position) > 3)
			{
				Scripts.SendMessageScriptError("Script Error: EquipItem: Item serial: (" + serial + ") too away");
				return;
			}
			ClientCommunication.SendToServerWait(new LiftRequest(item.Serial, item.Amount)); // Prende
			ClientCommunication.SendToServerWait(new EquipRequest(item.Serial, World.Player.Serial, item.Layer)); // Equippa
		}

		public static void EquipItem(Item item)
		{
			Assistant.Mobile player = World.Player;
			if (item.Container == 0 && Misc.DistanceSqrt(item.GetWorldPosition(), Position) > 3)
			{
				Scripts.SendMessageScriptError("Script Error: EquipItem: Item serial: (" + item.Serial + ") too away");
				return;
			}
			ClientCommunication.SendToServerWait(new LiftRequest(item.Serial, item.Amount)); // Prende
			ClientCommunication.SendToServerWait(new EquipRequest(item.Serial, World.Player.Serial, item.AssistantLayer)); // Equippa
		}

		public static void EquipUO3D(List<int> serials)
		{
			List<uint> serialstoequip = new List<uint>(); 
			foreach (int serial in serials)
				serialstoequip.Add((uint)serial);

			ClientCommunication.SendToServerWait(new EquipItemMacro(serialstoequip));

		}
		public static bool CheckLayer(String layer)
		{
			Enum.TryParse<Layer>(layer, out Layer l);
			
			Assistant.Item item = World.Player.GetItemOnLayer(l);

			if (item != null)
				return true;
			else
				return false;
		}

		public static Item GetItemOnLayer(String layer)
		{
			Enum.TryParse<Layer>(layer, out Layer l);

			Assistant.Item assistantItem = null;
			if (l != Assistant.Layer.Invalid)
			{
				assistantItem = World.Player.GetItemOnLayer(l);
				if (assistantItem == null)
					return null;
				else
				{
					RazorEnhanced.Item enhancedItem = new RazorEnhanced.Item(assistantItem);
					return enhancedItem;
				}
			}
			else
				return null;
		}

		// Skill
		public static double GetSkillValue(string skillname)
		{
			Enum.TryParse<SkillName>(skillname.Replace(" ", ""), out SkillName skill);
			return World.Player.Skills[(int)skill].Value;
		}

		public static double GetRealSkillValue(string skillname)
		{
			Enum.TryParse<SkillName>(skillname.Replace(" ", ""), out SkillName skill);
			return World.Player.Skills[(int)skill].Base;
		}


		public static double GetSkillCap(string skillname)
		{
			Enum.TryParse<SkillName>(skillname.Replace(" ", ""), out SkillName skill);
			return World.Player.Skills[(int)skill].Cap;
		}

		public static int GetSkillStatus(string skillname)
		{
			Enum.TryParse<SkillName>(skillname.Replace(" ", ""), out SkillName skill);
			return (int)World.Player.Skills[(int)skill].Lock;
		}

		public static void UseSkill(string skillname, bool wait = true)
		{
			Enum.TryParse<SkillName>(skillname.Replace(" ", ""), out SkillName skill);

			if (wait)
				ClientCommunication.SendToServerWait(new UseSkill((int)skill));
			else
				ClientCommunication.SendToServer(new UseSkill((int)skill));

			if (skill == SkillName.Hiding)
				StealthSteps.Hide();

			else if (skill == SkillName.Stealth)
			{
				if (!World.Player.Visible) // Trigger stealth step counter
					StealthSteps.Hide();
			}		
		}
		// Map Message
		public static void MapSay(int num)
		{
			MapSay(num.ToString());
		}

		public static void MapSay(string msg)
		{
			if (msg != null && msg != string.Empty)
				ClientCommunication.PostTextSend(msg);
		}

		// Game Message
		public static void ChatSay(int hue, int num)
		{
			ChatSay(hue, num.ToString());
		}

		public static void ChatSay(int hue, string msg)
		{
			List<ushort> kw = EncodedSpeech.GetKeywords(msg);
			if (kw.Count == 1 && kw[0] == 0)
			{
				ClientCommunication.SendToServerWait(new ClientUniMessage(Assistant.MessageType.Regular, hue, 3, Language.CliLocName, kw, msg));
			}
			else
			{
				ClientCommunication.SendToServerWait(new ClientUniMessage(Assistant.MessageType.Encoded, hue, 3, Language.CliLocName, kw, msg));
			}
		}
		public static void ChatGuild(int num)
		{
			ChatGuild(num.ToString());
		}

		public static void ChatGuild(string msg)
		{
			if (ClientCommunication.ServerEncrypted) // is OSI
				ClientCommunication.SendToServerWait(new ClientUniMessage(Assistant.MessageType.Guild, 1, 1, "ENU", new List<ushort>(), msg));
			else
				ClientCommunication.SendToServerWait(new ClientAsciiMessage(Assistant.MessageType.Guild, 1, 1, msg));
		}

		public static void ChatAlliance(int num)
		{
			ChatAlliance(num.ToString());
		}

		public static void ChatAlliance(string msg)
		{
			if (ClientCommunication.ServerEncrypted) // is OSI
				ClientCommunication.SendToServerWait(new ClientUniMessage(Assistant.MessageType.Alliance, 1, 1, "ENU", new List<ushort>(), msg));
			else
				ClientCommunication.SendToServerWait(new ClientAsciiMessage(Assistant.MessageType.Alliance, 1, 1, msg));
		}

		public static void ChatEmote(int hue, int num)
		{
			ChatEmote(hue, num.ToString());
		}

		public static void ChatEmote(int hue, string msg)
		{
			ClientCommunication.SendToServerWait(new ClientAsciiMessage(Assistant.MessageType.Emote, hue, 1, msg));
		}

		public static void ChatWhisper(int hue, int num)
		{
			ChatWhisper(hue, num.ToString());
		}

		public static void ChatWhisper(int hue, string msg)
		{
			ClientCommunication.SendToServerWait(new ClientAsciiMessage(Assistant.MessageType.Whisper, hue, 1, msg));
		}

		public static void ChatYell(int hue, int num)
		{
			ChatYell(hue, num.ToString());
		}

		public static void ChatYell(int hue, string msg)
		{
			ClientCommunication.SendToServerWait(new ClientAsciiMessage(Assistant.MessageType.Yell, hue, 1, msg));
		}

		public static void ChatChannel(int num)
		{
			ChatChannel(num.ToString());
		}

		public static void ChatChannel(string msg)
		{
			ClientCommunication.SendToServerWait(new ChatAction(0x61, Language.CliLocName, msg));
		}
		
		// attack
		public static void SetWarMode(bool warflag)
		{
			ClientCommunication.SendToServerWait(new SetWarMode(warflag));
		}
		public static void Attack(Mobile m)
		{
			Attack(m.Serial);
		}

		public static void Attack(int serial)
		{
			if (World.FindMobile(serial) == null) // Mob non piu esistente
				return;

			Target.AttackMessage(serial, true);
			if (Targeting.LastAttack != serial)
			{
				ClientCommunication.SendToClientWait(new ChangeCombatant(serial));
				Targeting.LastAttack = (uint)serial;
			}
			ClientCommunication.SendToServerWait(new AttackReq(serial));
        }

		public static void AttackLast()
		{
			if (Targeting.LastAttack == 0) // Nessun last attack presente
				return;
			
			if (World.FindMobile(Targeting.LastAttack) == null) // Mob non piu esistente
				return;

			Target.AttackMessage((int)Targeting.LastAttack, true);

			ClientCommunication.SendToServerWait(new AttackReq(Targeting.LastAttack));
		}

		// Virtue
		public static void InvokeVirtue(string virtue)
		{
			Enum.TryParse<Virtues>(virtue, out Virtues v);
			ClientCommunication.SendToServerWait(new InvokeVirtue((byte)v));
		}

		public static void ChatParty(string msg, int serial = 0)
		{
			if (serial != 0)
				ClientCommunication.SendToServerWait(new SendPartyMessagePrivate(serial, msg));
			else
				ClientCommunication.SendToServerWait(new SendPartyMessage(msg));
		}

		public static void PartyInvite()
		{
			ClientCommunication.SendToServerWait(new PartyInvite());
		}

		public static void LeaveParty()
		{
			ClientCommunication.SendToServerWait(new PartyRemoveMember(World.Player.Serial));
		}

		public static void KickMember(int serial)
		{
			uint userial = Convert.ToUInt16(serial);
			ClientCommunication.SendToServerWait(new PartyRemoveMember(userial));
		}

		public static void PartyCanLoot(bool CanLoot)
		{
			if (CanLoot)
					ClientCommunication.SendToServerWait(new PartyCanLoot(0x1));
				else
					ClientCommunication.SendToServerWait(new PartyCanLoot(0x0));
		}

		// Moving
		public static bool Walk(string direction)  // Return true se walk ok false se rifiutato da server
		{
			return Run(direction);
		}

		public static bool Run(string direction)    // Return true se walk ok false se rifiutato da server
		{
			Enum.TryParse<Direction>(direction, out Direction dir);

			int timeout = 0;
			World.Player.WalkScriptRequest = 1;
			switch (dir)
			{
				case Assistant.Direction.Up:
					DLLImport.Win.PostMessage(DLLImport.Razor.FindUOWindow(), 0x100, System.Windows.Forms.Keys.Up, 0);
					break;
				case Assistant.Direction.Down:
					DLLImport.Win.PostMessage(DLLImport.Razor.FindUOWindow(), 0x100, System.Windows.Forms.Keys.Down, 0);
					break;
				case Assistant.Direction.Left:
					DLLImport.Win.PostMessage(DLLImport.Razor.FindUOWindow(), 0x100, System.Windows.Forms.Keys.Left, 0);
					break;
				case Assistant.Direction.Right:
					DLLImport.Win.PostMessage(DLLImport.Razor.FindUOWindow(), 0x100, System.Windows.Forms.Keys.Right, 0);
					break;
				case Assistant.Direction.North:
					DLLImport.Win.PostMessage(DLLImport.Razor.FindUOWindow(), 0x100, System.Windows.Forms.Keys.PageUp, 0);
					break;
				case Assistant.Direction.East:
					DLLImport.Win.PostMessage(DLLImport.Razor.FindUOWindow(), 0x100, System.Windows.Forms.Keys.PageDown, 0);
					break;
				case Assistant.Direction.West:
					DLLImport.Win.PostMessage(DLLImport.Razor.FindUOWindow(), 0x100, System.Windows.Forms.Keys.Home, 0);
					break;
				case Assistant.Direction.South:
					DLLImport.Win.PostMessage(DLLImport.Razor.FindUOWindow(), 0x100, System.Windows.Forms.Keys.End, 0);
					break;
				default:
					Misc.SendMessage(dir.ToString());
					break;
			}

			while (World.Player.WalkScriptRequest < 2)
			{
				Thread.Sleep(10);
				timeout += 10;
				if (timeout > 500)
					break;
			}				

			if (World.Player.WalkScriptRequest == 2)
			{
				World.Player.WalkScriptRequest = 0;
				return true;
			}
			else
			{
				World.Player.WalkScriptRequest = 0;
				return false;
			}
		}

		public static void PathFindTo(Assistant.Point3D Location)
		{
			PathFindTo(Location.X, Location.Y, Location.Z);
		}

		public static void PathFindTo(int x, int y, int z)
		{
			UoWarper.UODLLHandleClass = new RazorEnhanced.UoWarper.UO();
			while (!UoWarper.UODLLHandleClass.Open())
			{
				Thread.Sleep(50);
			}
			UoWarper.UODLLHandleClass.Pathfind(x, y, z);
		}

		internal static void PathFindToPacket(Assistant.Point3D Location)
		{
			ClientCommunication.SendToClientWait(new PathFindTo(Location));
		}

		internal static void PathFindToPacket(int x, int y, int z)
		{
			Assistant.Point3D loc = new Assistant.Point3D(x, y, z);
			PathFindToPacket(loc);
        }

		// Fly
		public static void Fly(bool on)
		{
			if (on)
			{
				if (!World.Player.Flying)
					ClientCommunication.SendToServerWait(new ToggleFly());
			}
			else
			{
				if (World.Player.Flying)
					ClientCommunication.SendToServerWait(new ToggleFly());
			}
		}

		// Message
		public static void HeadMessage(int hue, int num)
		{
			HeadMessage(hue, num.ToString());
		}

		public static void HeadMessage(int hue, string message)
		{
			ClientCommunication.SendToClientWait(new UnicodeMessage(World.Player.Serial, World.Player.Body, MessageType.Regular, hue, 3, Language.CliLocName, World.Player.Name, message));
		}

		// Paperdool button click
		public static void QuestButton()
		{
			ClientCommunication.SendToServerWait(new QuestButton(World.Player.Serial));
		}

		public static void GuildButton()
		{
			ClientCommunication.SendToServerWait(new GuildButton(World.Player.Serial));
		}

		// Range
		public static bool InRangeMobile(Mobile mob, int range)
		{
			return Utility.InRange(new Assistant.Point2D(World.Player.Position.X, World.Player.Position.Y), new Assistant.Point2D(mob.Position.X, mob.Position.Y), range);
		}

		public static bool InRangeMobile(int mobserial, int range)
		{
			Assistant.Mobile mob = World.FindMobile(mobserial);
			if (mob != null)
			{
				return Utility.InRange(new Assistant.Point2D(World.Player.Position.X, World.Player.Position.Y), new Assistant.Point2D(mob.Position.X, mob.Position.Y), range);
			}
			else
				return false;
		}

		public static bool InRangeItem(Item mob, int range)
		{
			return Utility.InRange(new Assistant.Point2D(World.Player.Position.X, World.Player.Position.Y), new Assistant.Point2D(mob.Position.X, mob.Position.Y), range);
		}

		public static bool InRangeItem(int itemserial, int range)
		{
			Assistant.Item item = World.FindItem(itemserial);
			if (item != null)
			{
				return Utility.InRange(new Assistant.Point2D(World.Player.Position.X, World.Player.Position.Y), new Assistant.Point2D(item.Position.X, item.Position.Y), range);
			}
			else
				return false;
		}

		// Weapon SA
		public static void WeaponPrimarySA()
		{
			SpecialMoves.SetPrimaryAbility(true);
		}

		public static void WeaponSecondarySA()
		{
			SpecialMoves.SetSecondaryAbility(true);
		}

		public static void WeaponClearSA()
		{
			SpecialMoves.ClearAbilities(true);
		}

		public static void WeaponDisarmSA()
		{
			SpecialMoves.OnDisarm(true);
		}

		public static void WeaponStunSA()
		{
			SpecialMoves.OnStun(true);
		}

		// Props 

		public static List<string> GetPropStringList()
		{
			List<Assistant.ObjectPropertyList.OPLEntry> props = World.Player.ObjPropList.Content;

			return props.Select(prop => prop.ToString()).ToList();
		}

		public static string GetPropStringByIndex(int index)
		{
			string propstring = String.Empty;

			List<Assistant.ObjectPropertyList.OPLEntry> props = World.Player.ObjPropList.Content;
			if (props.Count > index)
				propstring = props[index].ToString();

			return propstring;
		}

		public static int GetPropValue(string name)
		{
			List<Assistant.ObjectPropertyList.OPLEntry> props = World.Player.ObjPropList.Content;

			foreach (Assistant.ObjectPropertyList.OPLEntry prop in props)
			{
				if (!prop.ToString().ToLower().Contains(name.ToLower()))
					continue;

				if (prop.Args == null)  // Props esiste ma non ha valore
					return 1;

				try
				{
					return (Convert.ToInt32(Language.ParsePropsCliloc(prop.Args)));
				}
				catch
				{
					return 1;  // errore di conversione ma esiste
				}
			}
			return 0;  // Non esiste
		}
	}
}