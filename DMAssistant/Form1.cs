using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMAssistant
{
    public partial class Form1 : Form
    {
        private GroupView GroupView1;
        private List<DnDCharacter> DMList = new List<DnDCharacter>();
        public Form1()
        {
            InitializeComponent();
            GlobalValues.InitializeValues();
            GroupView1 = new GroupView();
            GroupView1.Show();
            GroupView1.PopulateInitiativeList();
            PopulatePictureList();
            ResourceList.Items.Clear();
            foreach (string Name in GlobalValues.ResourceNameList)
            {
                ResourceList.Items.Add(Name);
            }
            //CharacterNameText.TextChanged += CharacterHidden_CheckedChanged;
            //CharacterInitiative.ValueChanged += CharacterHidden_CheckedChanged;
            //CharacterAC.ValueChanged += CharacterHidden_CheckedChanged;
            //CharacterHP.ValueChanged += CharacterHidden_CheckedChanged;
            //CharacterShields.ValueChanged += CharacterHidden_CheckedChanged;
            //CharacterRegen.ValueChanged += CharacterHidden_CheckedChanged;
            //CharacterBarrier.ValueChanged += CharacterHidden_CheckedChanged;
            //CharacterStatus.TextChanged += CharacterHidden_CheckedChanged;
            //CharacterNotes.TextChanged += CharacterHidden_CheckedChanged;
        }

        private void LoadBattle_Click(object sender, EventArgs e)
        {
            if (ResourceList.SelectedIndex != -1)
            {
                if (MessageBox.Show("Start New Battle?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string FileName = (string)ResourceList.SelectedItem;
                    DMList.Clear();
                    AddToDMList(Properties.Resources.Party);
                    AddToDMList(GlobalValues.ResourceTextFileList[FileName]);
                    RefreshDMInitiativeList();
                }
            }
        }
        private void AddToDMList(string toParse)
        {
            string[] Lines = toParse.Split('\n');
            foreach (string line in Lines)
            {
                string currentLine = line.Trim();
                if (currentLine != "" && currentLine.Split(';').Length > 1)
                {
                    DnDCharacter ToAdd = new DnDCharacter(currentLine);
                    DMList.Add(ToAdd);
                }
            }
            if (Lines[0].Split(';').Length == 1)
            {
                if (int.TryParse(Lines[0], out int result))
                {
                    GlobalValues.LoadedCurrentInitiative = result;
                }
            }
        }
        private void RefreshDMInitiativeList()
        {
            DMInitiativeList.Items.Clear();
            foreach(DnDCharacter currentCharacter in DMList)
            {
                DMInitiativeList.Items.Add(currentCharacter.Name);
            }
            var OrderQ = from item in DMList.AsEnumerable()
                         where item.Hidden == false
                         orderby item.Initiative descending
                         select item;
            GlobalValues.CurrentOrder = new List<string>();
            foreach (DnDCharacter currentCharacter in OrderQ)
            {
                GlobalValues.CurrentOrder.Add(currentCharacter.Name);
            }
            if(GlobalValues.CurrentOrder.Count > 0)
            {
                GroupView1.PopulateInitiativeList();
                GroupView1.ResetSelected();
            }
        }
        private void RemoveCharacter_Click(object sender, EventArgs e)
        {
            if (DMInitiativeList.SelectedIndex != -1)
            {
                if (MessageBox.Show("Really Remove Character?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DMList.RemoveAt(DMInitiativeList.SelectedIndex);
                    RefreshDMInitiativeList();
                }
            }
        }

        private void DMInitiativeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = DMInitiativeList.SelectedIndex;
            if (index != -1)
            {
                CharacterNameText.Text = DMList[index].Name;
                CharacterInitiative.Value = DMList[index].Initiative;
                CharacterAC.Value = DMList[index].AC;
                CharacterHP.Value = DMList[index].HP;
                CharacterShields.Value = DMList[index].Shields;
                CharacterBarrier.Value = DMList[index].Barrier;
                CharacterRegen.Value = DMList[index].Regen;
                CharacterStatus.Text = DMList[index].Status;
                CharacterNotes.Text = DMList[index].Notes;
                CharacterHidden.Checked = DMList[index].Hidden;
            }
        }

        private void AddCharacter_Click(object sender, EventArgs e)
        {
            DMList.Add(new DnDCharacter());
            RefreshDMInitiativeList();
        }

        private void NextCharacter_Click(object sender, EventArgs e)
        {
            GroupView1.IncrementInitiativeList(1);
        }

        private void PreviousCharacter_Click(object sender, EventArgs e)
        {
            GroupView1.IncrementInitiativeList(-1);
        }

        private void SetToTop_Click(object sender, EventArgs e)
        {
            GroupView1.IncrementInitiativeList(999);
        }

        private void CharacterEdit_Click(object sender, EventArgs e)
        {
            int index = DMInitiativeList.SelectedIndex;
            if (index != -1)
            {
                DMList[index].Name = CharacterNameText.Text;
                DMList[index].Initiative = (int)CharacterInitiative.Value;
                DMList[index].AC = (int)CharacterAC.Value;
                DMList[index].HP = (int)CharacterHP.Value;
                DMList[index].Shields = (int)CharacterShields.Value;
                DMList[index].Barrier = (int)CharacterBarrier.Value;
                DMList[index].Regen = (int)CharacterRegen.Value;
                DMList[index].Status = CharacterStatus.Text;
                DMList[index].Notes = CharacterNotes.Text;
                DMList[index].Hidden = CharacterHidden.Checked;
                RefreshDMInitiativeList();
            }
        }

        private void ShowStatus_Click(object sender, EventArgs e)
        {
            int Index = DMInitiativeList.SelectedIndex;
            string ToText = "";
            if (Index != -1)
            {
                if (DMList[Index].Shields > 0)
                {
                    ToText += $"{DMList[Index].Name} has a blue aura.\r\n";
                }
                if (DMList[Index].Barrier > 0)
                {
                    ToText += $"{DMList[Index].Name} has a purple aura.\r\n";
                }
                if (DMList[Index].Status != "")
                {
                    foreach (string s in DMList[Index].Status.Split('|'))
                    {
                        ToText += $"{DMList[Index].Name} is {s}.\r\n";
                    }
                }
                GroupView1.ModifyStatus(ToText);
            }
        }

        private void CharacterHidden_CheckedChanged(object sender, EventArgs e)
        {
            //RefreshDMInitiativeList();
        }

        private void ClassAbilitySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> SelectedClasses = new List<string>();
            for (int i = 0; i < GlobalValues.Classnames.Length; i++)
            {
                if (ClassAbilitySelect.GetItemChecked(i) == true)
                {
                    SelectedClasses.Add(GlobalValues.Classnames[i]);
                }
            }
            List<string> SelectedAbilityLevels = new List<string>();
            for (int i = 0 + GlobalValues.Classnames.Length; i < GlobalValues.AbilityLevels.Length + GlobalValues.Classnames.Length; i++)
            {
                if (ClassAbilitySelect.GetItemChecked(i) == true)
                {
                    SelectedAbilityLevels.Add(GlobalValues.AbilityLevels[i - GlobalValues.Classnames.Length]);
                }
            }
            AbilityList.Items.Clear();
            var AbilityQ = from ability in GlobalValues.Abilities.AsEnumerable()
                           where ability.Classes.Any(item => SelectedClasses.Contains(item))
                           && SelectedAbilityLevels.Contains(ability.SpellLevel) == true
                           orderby ability.Name ascending
                           select ability.Name;
            foreach (string name in AbilityQ)
            {
                AbilityList.Items.Add(name);
            }
        }

        private void ShowAbility_Click(object sender, EventArgs e)
        {
            if (AbilityList.SelectedIndex != -1)
            {
                int index = GlobalValues.GetAbilityIndexByName((string)AbilityList.SelectedItem);
                if (index != -1)
                {
                    GroupView1.ModifyStatus(GlobalValues.Abilities[index].DisplayAbility());
                }
            }
        }

        private void UnhideAllCharacters_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Unhide All?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DnDCharacter currentChar in DMList)
                {
                    currentChar.Hidden = false;
                }
                RefreshDMInitiativeList();
            }
        }

        private void ClearImage_Click(object sender, EventArgs e)
        {
            GroupView1.ClearImage();
        }

        private void PickNewImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Shockwave\Desktop\D&D Stuff";
                openFileDialog.Filter = "png files (*.png)|*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap picture = new Bitmap(openFileDialog.FileName);
                    GroupView1.SetImage(picture);
                }
            }
        }

        private void SaveEncounter_Click(object sender, EventArgs e)
        {
            string ToFile = "";
            ToFile += $"{GroupView1.ExportCurrentInitiative()}\r\n";
            foreach(DnDCharacter currentCharacter in DMList)
            {
                ToFile += $"{currentCharacter.ExportCharacter()}\r\n";
            }
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter sw = new StreamWriter(myStream);
                    sw.Write(ToFile);
                    sw.Close();
                    myStream.Close();
                }
            }
        }

        private void LoadEncounter_Click(object sender, EventArgs e)
        {
            string FileText = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Shockwave\Desktop\D&D Stuff";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filestream = openFileDialog.OpenFile();
                    using(StreamReader reader = new StreamReader(filestream))
                    {
                        FileText = reader.ReadToEnd();
                    }
                }
            }
            if (FileText.Trim() != "")
            {
                DMList.Clear();
                AddToDMList(FileText);
                RefreshDMInitiativeList();
                if (GlobalValues.LoadedCurrentInitiative != -1)
                {
                    GroupView1.IncrementInitiativeList(999);
                    GroupView1.IncrementInitiativeList(GlobalValues.LoadedCurrentInitiative);
                }
            }
        }

        private void AddCustomCharacter_Click(object sender, EventArgs e)
        {
            if (CustomCharacterBox.Text != "" && CustomCharacterBox.Text.Split(';').Length == 10)
            {
                if (MessageBox.Show("Really Add Character?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DMList.Add(new DnDCharacter(CustomCharacterBox.Text));
                    RefreshDMInitiativeList();
                }
            }
        }

        private void AbilityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AbilityList.SelectedIndex != -1)
            {
                int index = GlobalValues.GetAbilityIndexByName((string)AbilityList.SelectedItem);
                if (index != -1)
                {
                    ShowMeStatusBox.Text = GlobalValues.Abilities[index].DisplayAbility();
                }
            }
        }

        private void ChangeMyPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Shockwave\Desktop\D&D Stuff";
                openFileDialog.Filter = "png files (*.png)|*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MyPicture.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void MovePictureToGroup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Show them this Image?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GroupView1.SetImage(new Bitmap(MyPicture.Image));
            }
        }

        private void PictureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupView1.ControlBringToFront($"{PictureList.SelectedItem}");
        }
        public void PopulatePictureList()
        {
        //private CustomPictureBox KroganPicture1;
        //private CustomPictureBox KroganPicture2;
        //private CustomPictureBox VolusEngineer;
        //private CustomPictureBox HumanMaleVanguard;
        //private CustomPictureBox Elcor;
        //private CustomPictureBox AsariAdept;
        //private CustomPictureBox GethInfiltrator;
        //private CustomPictureBox B8;
        //private CustomPictureBox customPictureBox7;
        //private CustomPictureBox customPictureBox8;
        //private CustomPictureBox customPictureBox9;
        //private CustomPictureBox customPictureBox10;
        //private CustomPictureBox customPictureBox11;
        //private CustomPictureBox customPictureBox12;
        //private CustomPictureBox customPictureBox13;
        //private CustomPictureBox Tuspii;
            PictureList.Items.Clear();
            PictureList.Items.Add("KroganPicture1");
            PictureList.Items.Add("KroganPicture2");
            PictureList.Items.Add("HumanMaleVanguard");
            PictureList.Items.Add("VolusEngineer");
            PictureList.Items.Add("Elcor");
            PictureList.Items.Add("AsariAdept");
            PictureList.Items.Add("GethInfiltrator");
            PictureList.Items.Add("B8");
            PictureList.Items.Add("Tuspii");
            PictureList.Items.Add("Nemesis1");
            PictureList.Items.Add("ShieldBoi1");
            PictureList.Items.Add("ShieldBoi2");
            PictureList.Items.Add("Rampart1");
            PictureList.Items.Add("Rampart2");
            PictureList.Items.Add("Rampart3");
            PictureList.Items.Add("Rampart4");
            PictureList.Items.Add("SlayerLike1");
        }
        private void HideUnhide_Click(object sender, EventArgs e)
        {
            if (PictureList.SelectedIndex != -1)
            {
                GroupView1.ControlToggleVisible($"{PictureList.SelectedItem}");
            }
        }
        private void HideAll_Click(object sender, EventArgs e)
        {
            GroupView1.AllToggleVisible(false);
        }
        private void UnhideAll_Click(object sender, EventArgs e)
        {
            GroupView1.AllToggleVisible(true);
        }
    }
    public class CustomPictureBox : PictureBox
    {
        public CustomPictureBox(IContainer container)
        {
            container.Add(this);
        }

        Point point1;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            point1 = e.Location;
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point1.X;
                this.Top += e.Y - point1.Y;
            }
        }
    }
}
