using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMAssistant
{
    public partial class GroupView : Form
    {
        public GroupView()
        {
            InitializeComponent();
        }
        public void PopulateInitiativeList()
        {
            InitiativeList.Items.Clear();
            foreach (string Name in GlobalValues.CurrentOrder)
            {
                InitiativeList.Items.Add(Name);
            }
        }
        public void ControlBringToFront(string controlName)
        {
            this.Controls[controlName].BringToFront();
        }
        public void ControlToggleVisible(string controlName)
        {
            this.Controls[controlName].Visible = !this.Controls[controlName].Visible;
        }
        public void AllToggleVisible(bool allVisible)
        {
            KroganPicture1.Visible = allVisible;
            KroganPicture2.Visible = allVisible;
            VolusEngineer.Visible = allVisible;
            HumanMaleVanguard.Visible = allVisible;
            Elcor.Visible = allVisible;
            AsariAdept.Visible = allVisible;
            GethInfiltrator.Visible = allVisible;
            B8.Visible = allVisible;
            Nemesis1.Visible = allVisible;
            ShieldBoi1.Visible = allVisible;
            ShieldBoi2.Visible = allVisible;
            Rampart1.Visible = allVisible;
            Rampart2.Visible = allVisible;
            Rampart3.Visible = allVisible;
            Rampart4.Visible = allVisible;
            SlayerLike1.Visible = allVisible;
            Tuspii.Visible = allVisible;
        }
        public void IncrementInitiativeList(int value)
        {
            if (InitiativeList.SelectedIndex == -1 || value == 999)
            {
                InitiativeList.SelectedIndex = 0;
            }
            else
            {
                InitiativeList.SelectedIndex = (InitiativeList.SelectedIndex + value + InitiativeList.Items.Count) % InitiativeList.Items.Count;
            }
            CurrentCharacter.Text = $"{InitiativeList.SelectedItem}";
            NextCharacter.Text = $"{InitiativeList.Items[(InitiativeList.SelectedIndex + 1)%InitiativeList.Items.Count]}";
        }
        public void ResetSelected()
        {
            if (InitiativeList.Items.Contains(CurrentCharacter.Text))
            {
                InitiativeList.SelectedIndex = InitiativeList.Items.IndexOf(CurrentCharacter.Text);
                NextCharacter.Text = $"{InitiativeList.Items[(InitiativeList.SelectedIndex + 1) % InitiativeList.Items.Count]}";
            }
            else if (InitiativeList.Items.Contains(NextCharacter.Text))
            {
                InitiativeList.SelectedIndex = InitiativeList.Items.IndexOf(NextCharacter.Text);
                CurrentCharacter.Text = $"{InitiativeList.SelectedItem}";
                NextCharacter.Text = $"{InitiativeList.Items[(InitiativeList.SelectedIndex + 1) % InitiativeList.Items.Count]}";
            }
            else
            {
                IncrementInitiativeList(999);
            }
        }
        public void ModifyStatus(string toText)
        {
            ShowStatusBox.Text = toText;
        }
        public void ClearImage()
        {
            pictureBox1.Image = null;
        }
        public void SetImage(Bitmap image)
        {
            pictureBox1.Image = image;
        }
        public int ExportCurrentInitiative()
        {
            return InitiativeList.SelectedIndex;
        }
    }
}
