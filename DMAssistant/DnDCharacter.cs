using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMAssistant
{
    public class DnDCharacter
    {
        public string Name;
        public int Initiative;
        public int AC;
        public int HP;
        public int Shields;
        public int Regen;
        public int Barrier;
        public string Status;
        public string Notes;
        public bool Hidden;

        public DnDCharacter()
        {
            SetStats("New Character;17;15;40;10;5;3;;Character information needed.;true");
        }
        public DnDCharacter(string InputString)
        {
            SetStats(InputString);
        }
        public string ExportCharacter()
        {
            string result = "";

            result += $"{Name};{Initiative};{AC};{HP};{Shields};{Regen};{Barrier};{Status};{Notes};{Hidden}";

            return result;
        }
        private void SetStats(string InputString)
        {
            string[] words = InputString.Split(';');
            Name = words[0];
            Initiative = Convert.ToInt32(words[1]);
            AC = Convert.ToInt32(words[2]);
            HP = Convert.ToInt32(words[3]);
            Shields = Convert.ToInt32(words[4]);
            Regen = Convert.ToInt32(words[5]);
            Barrier = Convert.ToInt32(words[6]);
            Status = words[7];
            Notes = words[8];
            Hidden = Convert.ToBoolean(words[9]);
        }
        //public string DisplayCharacter()
        //{
        //}
    }
}
