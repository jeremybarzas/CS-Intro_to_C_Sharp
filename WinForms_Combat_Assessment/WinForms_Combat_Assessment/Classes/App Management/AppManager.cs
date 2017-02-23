using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public class AppManager
    {
        private string m_combatLog;

        public string CombatLog
        {
            get { return m_combatLog; }
            set { m_combatLog = value; }
        }

        public static void DoActions()
        {
            var info = instance.DataManager.CurrentPlayer.Info;
            string s1 = "";
            string s2 = "";
            string s3 = "";

            // item action
            List<int> itemValues = instance.DataManager.CurrentPlayer.DoItemAction(instance.DataManager.CurrentPlayer.Info.ItemTarget);

            // weapon action
            int weaponValue = instance.DataManager.CurrentPlayer.DoWeaponAction(instance.DataManager.CurrentPlayer.Info.AttackTarget);

            // spell action
            List<int> spellValues = instance.DataManager.CurrentPlayer.DoSpellAction(instance.DataManager.CurrentPlayer.Info.SpellTarget);

            // potion check
            if (itemValues[0] != 0 && itemValues[1] == 0 && itemValues[2] == 0 && itemValues[3] == 0)
            {
                s1 = string.Format("{0} has used {1} on {2} for + {3} health. \n", info.Name, info.ActiveItem.Name, info.ItemTarget.Info.Name, itemValues[0]);
            }
           
            // ether check
            if (itemValues[0] == 0 && itemValues[1] != 0 && itemValues[2] == 0 && itemValues[3] == 0)
            {
                s1 = string.Format("{0} has used {1} on {2} for + {3} mana. \n", info.Name, info.ActiveItem.Name, info.ItemTarget.Info.Name, itemValues[1]);
            }
            
            // elixir check
            if (itemValues[0] != 0 && itemValues[1] != 0 && itemValues[2] == 0 && itemValues[3] == 0)
            {                
                s1 = string.Format("{0} has used {1} on {2} for + {3} health and + {4} mana. \n", info.Name, info.ActiveItem.Name, info.ItemTarget.Info.Name, itemValues[0], itemValues[1]);                
            }
            
            // red runestone check
            if (itemValues[0] == 0 && itemValues[1] == 0 && itemValues[2] != 0 && itemValues[3] == 0)
            {
                s1 = string.Format("{0} has used {1} on {2} for + {3} strength. \n", info.Name, info.ActiveItem.Name, info.ItemTarget.Info.Name, itemValues[2]);
            }
            
            // blue runestone check
            if (itemValues[0] == 0 && itemValues[1] == 0 && itemValues[2] == 0 && itemValues[3] != 0)
            {
                s1 = string.Format("{0} has used {1} on {2} for + {3} intellect. \n", info.Name, info.ActiveItem.Name, info.ItemTarget.Info.Name, itemValues[3]);
            }            

            // weapon check
            s2 = string.Format("{0} has attacked {1} with {2} for - {3} health. \n", info.Name, info.AttackTarget.Info.Name, info.ActiveWeapon.Name, weaponValue);           
            
            // spell damage check
            if (spellValues[0] != 0 && spellValues[1] == 0)
            {
                s3 = string.Format("{0} has cast {1} on {2} for - {3} health. \n", info.Name, info.ActiveSpell.Name, info.SpellTarget.Info.Name, spellValues[0]);
            }

            // spell healing check
            if (spellValues[0] == 0 && spellValues[1] != 0)
            {
                s3 = string.Format("{0} has cast {1} on {2} for + {3} health. \n", info.Name, info.ActiveSpell.Name, info.SpellTarget.Info.Name, spellValues[1]);
            }           

            string s4 = string.Format("==================== Action Results ====================\n\n{0}\n{1}\n{2}\n", s1, s2, s3);
            
            instance.CombatLog = s4;     
        }

        private DataManager m_dataManager;

        public DataManager DataManager
        {
            get { return m_dataManager; }
            set { m_dataManager = value; }
        }

        public delegate void Del();
        public Del Initializer;
        
        public void InitalizeDataManager()
        {
            DataManager = new DataManager();

            DataManager.AddToWeaponList(new Sword("Sword", 25));
            DataManager.AddToWeaponList(new Axe("Axe", 25));
            DataManager.AddToWeaponList(new Mace("Mace", 25));

            DataManager.AddToSpellList(new MagicMissle("Magic Missle", 25, 0, 25));
            DataManager.AddToSpellList(new Flashburn("Flashburn", 25, 0, 25));
            DataManager.AddToSpellList(new Blizzard("Blizzard", 25, 0, 25));
            DataManager.AddToSpellList(new LightningBolt("Lightning Bolt", 25, 0, 25));
            DataManager.AddToSpellList(new Regeneration("Regeneration", 0, 25, 25));
            DataManager.AddToSpellList(new DivineIntervention("Divine Intervention", 0, 25, 25));

            DataManager.AddToItemList(new Potion("Potion", 50, 0));
            DataManager.AddToItemList(new Potion("Ether", 0, 50));
            DataManager.AddToItemList(new Potion("Elixir", 30, 30));
            DataManager.AddToItemList(new RuneStone("Red Runestone", 1, 0));
            DataManager.AddToItemList(new RuneStone("Blue Runestone", 0, 1));
        }

        public void InitalizeMainFSM()
        {
            DataManager.MainFSM = new FSM();

            DataManager.MainFSM.AddState(new MainMenuState(0));
            DataManager.MainFSM.AddState(new GameRulesState(1));
            DataManager.MainFSM.AddState(new CharacterSheetState(2));
            DataManager.MainFSM.AddState(new ScoreboardState(3));
            DataManager.MainFSM.AddState(new DiceRollState(4));
            DataManager.MainFSM.AddState(new CombatPhaseState(5));
            DataManager.MainFSM.AddState(new GameOverState(6));
            DataManager.MainFSM.AddState(new LoadoutOptionsInfoState(7));

            DataManager.MainFSM.SetState(0);
        }

        private static readonly AppManager instance = new AppManager();

        public static AppManager Instance
        {
            get { return instance; }           
        }

        private AppManager()
        {
            Initializer += InitalizeDataManager;
            Initializer += InitalizeMainFSM;

            Initializer.Invoke();
        } 
    }
}