using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMAssistant
{
    public static class GlobalValues
    {
        public static List<string> CurrentOrder = new List<string>();
        public static List<string> ResourceNameList = new List<string>();
        public static Dictionary<string, string> ResourceTextFileList = new Dictionary<string, string>();
        public static string[] Classnames = { "adept", "engineer", "infiltrator", "sentinel", "soldier", "vanguard" };
        public static string[] AbilityLevels = { "Cantrip", "1st level", "2nd level", "3rd level", "4th level"};
        public static string[] StatusList = { "Blinded", "Charmed", "Deafened", "Frightened", "Frozen", "Grappled", "Incapacitated", "Invisible", "Paralyzed", "Lifted", "Poisoned", "Primed", "Prone", "Restrained", "Stunned", "Targeting", "Unconscious" };
        public static List<Ability> Abilities = new List<Ability>();
        public static int LoadedCurrentInitiative = -1;
        //public static string[] ControlNameList = { "CharacterNameText", "CharacterInitiative", "CharacterAC", "CharacterHP", "CharacterShields", "CharacterRegen", "CharacterBarrier", "CharacterStatus", "CharacterNotes" };
        public static void InitializeValues()
        {
            //foreach(string Name in Properties.Resources.PCNames.Split('\n'))
            //{
            //    string currentName = Name.Trim();
            //    if (currentName != "")
            //    {
            //        CurrentOrder.Add(currentName);
            //    }
            //}
            LoadResourceTextFileNames();
            PopulateAbilityList();
        }
        public static void LoadResourceTextFileNames()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string[] names = assembly.GetManifestResourceNames();
            foreach (string name in names)
            {
                string cur = name.Trim();
                if (cur.Length > 4 && cur.Substring(cur.Length - 4) == ".txt")
                {
                    ResourceNameList.Add(cur);
                    string CurrentFile = "";
                    using (Stream stream = assembly.GetManifestResourceStream(cur))
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        CurrentFile = reader.ReadToEnd();
                    }
                    ResourceTextFileList.Add(cur,CurrentFile);
                }
            }
        }
        public static void PopulateAbilityList()
        {
            string[] Lines = Properties.Resources.AllSpellInfo.Split('\n');
            List<string> ToAdd = new List<string>();
            bool IsClass = false;
            for (int i = Lines.Length - 1; i > -1; i--)
            {
                string currentLine = Lines[i].Trim();
                ToAdd.Add(currentLine);
                if (IsClass == false && Classnames.Contains(currentLine))
                {
                    IsClass = true;
                }
                if (IsClass == true && Classnames.Contains(currentLine) == false)
                {
                    IsClass = false;
                    Abilities.Add(new Ability(ToAdd));
                    ToAdd = new List<string>();
                }
            }
        }
        public static int GetAbilityIndexByName(string name)
        {
            for (int i = 0; i < Abilities.Count(); i++)
            {
                if (Abilities[i].Name == name)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
