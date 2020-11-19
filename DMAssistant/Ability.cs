using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DMAssistant
{
    public class Ability
    {
        public string Name;
        public List<string> Classes;
        public string CastTime;
        public string Range;
        public string Duration;
        public List<string> Description;
        public List<string> AdvancedOptions;
        public string SpellLevel;
        public List<string> Types;
        List<string> OriginalList;
        public Ability(List<string> toParse)
        {
            List<int> IndexList = new List<int>();
            IndexList.Add(toParse.Count - 1);
            int i;
            for (i = toParse.Count - 1;i > -1; i--)
            {
                if (toParse[i] == "CASTING TIME" || toParse[i] == "RANGE (AOE)" || toParse[i] == "DURATION" || toParse[i] == "ADVANCED OPTIONS" || GlobalValues.AbilityLevels.Contains(toParse[i]))
                {
                    IndexList.Add(i);
                }
                if (i < toParse.Count() - 3 && toParse[i + 2] == "DURATION" && toParse[i + 1] != "C")
                {
                    IndexList.Add(i);
                }
                if (i < toParse.Count() - 4 && toParse[i + 3] == "DURATION" && toParse[i + 2] == "C")
                {
                    IndexList.Add(i);
                }
            }
            Name = toParse[IndexList[0]];
            Classes = new List<string>();
            for(i = IndexList[1] + 1;i < IndexList[0]; i++)
            {
                Classes.Add(toParse[i]);
            }
            CastTime = toParse[IndexList[1] - 1];
            Range = toParse[IndexList[2] - 1];
            Duration = toParse[IndexList[3] - 1];
            Description = new List<string>();
            for (i = IndexList[5] + 1; i <= IndexList[4]; i++)
            {
                Description.Add(toParse[i]);
            }
            AdvancedOptions = new List<string>();
            for (i = IndexList[6] + 1; i < IndexList[5]; i++)
            {
                AdvancedOptions.Add(toParse[i]);
            }
            SpellLevel = toParse[IndexList[6]];
            Types = new List<string>();
            for (i = IndexList[6] - 1; i >= 0; i--)
            {
                string CurrentLine = toParse[i].Trim();
                if (CurrentLine != "")
                {
                    Types.Add(CurrentLine);
                }
            }
            OriginalList = toParse;
        }
        public string DisplayAbility()
        {
            string result = "";
            foreach (string line in OriginalList)
            {
                result = $"{line}\r\n" + result;
            }
            return result;
        }
    }
}
