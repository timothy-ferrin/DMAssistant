namespace DMAssistant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DMInitiativeList = new System.Windows.Forms.ListBox();
            this.AddCharacter = new System.Windows.Forms.Button();
            this.RemoveCharacter = new System.Windows.Forms.Button();
            this.CharacterEdit = new System.Windows.Forms.Button();
            this.CharacterName = new System.Windows.Forms.Label();
            this.CharacterInitiative = new System.Windows.Forms.NumericUpDown();
            this.CharacterAC = new System.Windows.Forms.NumericUpDown();
            this.CharacterHP = new System.Windows.Forms.NumericUpDown();
            this.CharacterShields = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CharacterRegen = new System.Windows.Forms.NumericUpDown();
            this.CharacterBarrier = new System.Windows.Forms.NumericUpDown();
            this.CharacterStatus = new System.Windows.Forms.TextBox();
            this.CharacterNotes = new System.Windows.Forms.TextBox();
            this.CharacterHidden = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CharacterNameText = new System.Windows.Forms.TextBox();
            this.NextCharacter = new System.Windows.Forms.Button();
            this.ShowStatus = new System.Windows.Forms.Button();
            this.LoadBattle = new System.Windows.Forms.Button();
            this.PreviousCharacter = new System.Windows.Forms.Button();
            this.ResourceList = new System.Windows.Forms.ListBox();
            this.SetToTop = new System.Windows.Forms.Button();
            this.AbilityList = new System.Windows.Forms.ListBox();
            this.ShowAbility = new System.Windows.Forms.Button();
            this.ClassAbilitySelect = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UnhideAllCharacters = new System.Windows.Forms.Button();
            this.ClearImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PickNewImage = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveEncounter = new System.Windows.Forms.Button();
            this.LoadEncounter = new System.Windows.Forms.Button();
            this.AddCustomCharacter = new System.Windows.Forms.Button();
            this.CustomCharacterBox = new System.Windows.Forms.TextBox();
            this.ShowMeStatusBox = new System.Windows.Forms.TextBox();
            this.MyPicture = new System.Windows.Forms.PictureBox();
            this.ChangeMyPicture = new System.Windows.Forms.Button();
            this.MovePictureToGroup = new System.Windows.Forms.Button();
            this.PictureList = new System.Windows.Forms.ListBox();
            this.HideUnhide = new System.Windows.Forms.Button();
            this.HideAll = new System.Windows.Forms.Button();
            this.UnhideAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterInitiative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterShields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterRegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterBarrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DMInitiativeList
            // 
            this.DMInitiativeList.FormattingEnabled = true;
            this.DMInitiativeList.Location = new System.Drawing.Point(12, 12);
            this.DMInitiativeList.Name = "DMInitiativeList";
            this.DMInitiativeList.Size = new System.Drawing.Size(156, 459);
            this.DMInitiativeList.TabIndex = 0;
            this.DMInitiativeList.SelectedIndexChanged += new System.EventHandler(this.DMInitiativeList_SelectedIndexChanged);
            // 
            // AddCharacter
            // 
            this.AddCharacter.Location = new System.Drawing.Point(174, 12);
            this.AddCharacter.Name = "AddCharacter";
            this.AddCharacter.Size = new System.Drawing.Size(114, 23);
            this.AddCharacter.TabIndex = 2;
            this.AddCharacter.Text = "Add New Character";
            this.AddCharacter.UseVisualStyleBackColor = true;
            this.AddCharacter.Click += new System.EventHandler(this.AddCharacter_Click);
            // 
            // RemoveCharacter
            // 
            this.RemoveCharacter.Location = new System.Drawing.Point(174, 41);
            this.RemoveCharacter.Name = "RemoveCharacter";
            this.RemoveCharacter.Size = new System.Drawing.Size(114, 23);
            this.RemoveCharacter.TabIndex = 3;
            this.RemoveCharacter.Text = "Remove Character";
            this.RemoveCharacter.UseVisualStyleBackColor = true;
            this.RemoveCharacter.Click += new System.EventHandler(this.RemoveCharacter_Click);
            // 
            // CharacterEdit
            // 
            this.CharacterEdit.Location = new System.Drawing.Point(498, 506);
            this.CharacterEdit.Name = "CharacterEdit";
            this.CharacterEdit.Size = new System.Drawing.Size(90, 23);
            this.CharacterEdit.TabIndex = 5;
            this.CharacterEdit.Text = "Edit";
            this.CharacterEdit.UseVisualStyleBackColor = true;
            this.CharacterEdit.Click += new System.EventHandler(this.CharacterEdit_Click);
            // 
            // CharacterName
            // 
            this.CharacterName.AutoSize = true;
            this.CharacterName.Location = new System.Drawing.Point(559, 72);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(35, 13);
            this.CharacterName.TabIndex = 6;
            this.CharacterName.Text = "Name";
            // 
            // CharacterInitiative
            // 
            this.CharacterInitiative.Location = new System.Drawing.Point(498, 114);
            this.CharacterInitiative.Name = "CharacterInitiative";
            this.CharacterInitiative.Size = new System.Drawing.Size(66, 20);
            this.CharacterInitiative.TabIndex = 7;
            // 
            // CharacterAC
            // 
            this.CharacterAC.Location = new System.Drawing.Point(498, 140);
            this.CharacterAC.Name = "CharacterAC";
            this.CharacterAC.Size = new System.Drawing.Size(66, 20);
            this.CharacterAC.TabIndex = 8;
            // 
            // CharacterHP
            // 
            this.CharacterHP.Location = new System.Drawing.Point(498, 166);
            this.CharacterHP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CharacterHP.Name = "CharacterHP";
            this.CharacterHP.Size = new System.Drawing.Size(66, 20);
            this.CharacterHP.TabIndex = 9;
            // 
            // CharacterShields
            // 
            this.CharacterShields.Location = new System.Drawing.Point(498, 192);
            this.CharacterShields.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CharacterShields.Name = "CharacterShields";
            this.CharacterShields.Size = new System.Drawing.Size(66, 20);
            this.CharacterShields.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Initiative";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "AC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Shields";
            // 
            // CharacterRegen
            // 
            this.CharacterRegen.Location = new System.Drawing.Point(498, 218);
            this.CharacterRegen.Name = "CharacterRegen";
            this.CharacterRegen.Size = new System.Drawing.Size(66, 20);
            this.CharacterRegen.TabIndex = 15;
            // 
            // CharacterBarrier
            // 
            this.CharacterBarrier.Location = new System.Drawing.Point(498, 244);
            this.CharacterBarrier.Name = "CharacterBarrier";
            this.CharacterBarrier.Size = new System.Drawing.Size(66, 20);
            this.CharacterBarrier.TabIndex = 16;
            // 
            // CharacterStatus
            // 
            this.CharacterStatus.Location = new System.Drawing.Point(498, 270);
            this.CharacterStatus.Name = "CharacterStatus";
            this.CharacterStatus.Size = new System.Drawing.Size(409, 20);
            this.CharacterStatus.TabIndex = 17;
            // 
            // CharacterNotes
            // 
            this.CharacterNotes.Location = new System.Drawing.Point(498, 296);
            this.CharacterNotes.Multiline = true;
            this.CharacterNotes.Name = "CharacterNotes";
            this.CharacterNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CharacterNotes.Size = new System.Drawing.Size(409, 175);
            this.CharacterNotes.TabIndex = 18;
            // 
            // CharacterHidden
            // 
            this.CharacterHidden.AutoSize = true;
            this.CharacterHidden.Location = new System.Drawing.Point(498, 477);
            this.CharacterHidden.Name = "CharacterHidden";
            this.CharacterHidden.Size = new System.Drawing.Size(60, 17);
            this.CharacterHidden.TabIndex = 19;
            this.CharacterHidden.Text = "Hidden";
            this.CharacterHidden.UseVisualStyleBackColor = true;
            this.CharacterHidden.CheckedChanged += new System.EventHandler(this.CharacterHidden_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Regen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Barrier";
            // 
            // CharacterNameText
            // 
            this.CharacterNameText.Location = new System.Drawing.Point(498, 88);
            this.CharacterNameText.Name = "CharacterNameText";
            this.CharacterNameText.Size = new System.Drawing.Size(157, 20);
            this.CharacterNameText.TabIndex = 22;
            this.CharacterNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NextCharacter
            // 
            this.NextCharacter.Location = new System.Drawing.Point(174, 70);
            this.NextCharacter.Name = "NextCharacter";
            this.NextCharacter.Size = new System.Drawing.Size(114, 23);
            this.NextCharacter.TabIndex = 23;
            this.NextCharacter.Text = "Next Character";
            this.NextCharacter.UseVisualStyleBackColor = true;
            this.NextCharacter.Click += new System.EventHandler(this.NextCharacter_Click);
            // 
            // ShowStatus
            // 
            this.ShowStatus.Location = new System.Drawing.Point(174, 157);
            this.ShowStatus.Name = "ShowStatus";
            this.ShowStatus.Size = new System.Drawing.Size(114, 23);
            this.ShowStatus.TabIndex = 24;
            this.ShowStatus.Text = "Show Status";
            this.ShowStatus.UseVisualStyleBackColor = true;
            this.ShowStatus.Click += new System.EventHandler(this.ShowStatus_Click);
            // 
            // LoadBattle
            // 
            this.LoadBattle.Location = new System.Drawing.Point(369, 12);
            this.LoadBattle.Name = "LoadBattle";
            this.LoadBattle.Size = new System.Drawing.Size(114, 23);
            this.LoadBattle.TabIndex = 25;
            this.LoadBattle.Text = "Load Battle";
            this.LoadBattle.UseVisualStyleBackColor = true;
            this.LoadBattle.Click += new System.EventHandler(this.LoadBattle_Click);
            // 
            // PreviousCharacter
            // 
            this.PreviousCharacter.Location = new System.Drawing.Point(174, 99);
            this.PreviousCharacter.Name = "PreviousCharacter";
            this.PreviousCharacter.Size = new System.Drawing.Size(114, 23);
            this.PreviousCharacter.TabIndex = 26;
            this.PreviousCharacter.Text = "Previous Character";
            this.PreviousCharacter.UseVisualStyleBackColor = true;
            this.PreviousCharacter.Click += new System.EventHandler(this.PreviousCharacter_Click);
            // 
            // ResourceList
            // 
            this.ResourceList.FormattingEnabled = true;
            this.ResourceList.Location = new System.Drawing.Point(174, 410);
            this.ResourceList.Name = "ResourceList";
            this.ResourceList.Size = new System.Drawing.Size(261, 173);
            this.ResourceList.TabIndex = 27;
            // 
            // SetToTop
            // 
            this.SetToTop.Location = new System.Drawing.Point(174, 128);
            this.SetToTop.Name = "SetToTop";
            this.SetToTop.Size = new System.Drawing.Size(114, 23);
            this.SetToTop.TabIndex = 28;
            this.SetToTop.Text = "Set To Top";
            this.SetToTop.UseVisualStyleBackColor = true;
            this.SetToTop.Click += new System.EventHandler(this.SetToTop_Click);
            // 
            // AbilityList
            // 
            this.AbilityList.FormattingEnabled = true;
            this.AbilityList.Location = new System.Drawing.Point(1007, 12);
            this.AbilityList.Name = "AbilityList";
            this.AbilityList.Size = new System.Drawing.Size(217, 602);
            this.AbilityList.TabIndex = 29;
            this.AbilityList.SelectedIndexChanged += new System.EventHandler(this.AbilityList_SelectedIndexChanged);
            // 
            // ShowAbility
            // 
            this.ShowAbility.Location = new System.Drawing.Point(881, 12);
            this.ShowAbility.Name = "ShowAbility";
            this.ShowAbility.Size = new System.Drawing.Size(120, 23);
            this.ShowAbility.TabIndex = 30;
            this.ShowAbility.Text = "Show Selected Ability";
            this.ShowAbility.UseVisualStyleBackColor = true;
            this.ShowAbility.Click += new System.EventHandler(this.ShowAbility_Click);
            // 
            // ClassAbilitySelect
            // 
            this.ClassAbilitySelect.CheckOnClick = true;
            this.ClassAbilitySelect.FormattingEnabled = true;
            this.ClassAbilitySelect.Items.AddRange(new object[] {
            "Adept",
            "Engineer",
            "Infiltrator",
            "Sentinel",
            "Soldier",
            "Vanguard",
            "Cantrip",
            "1st level",
            "2nd level",
            "3rd level",
            "4th level"});
            this.ClassAbilitySelect.Location = new System.Drawing.Point(916, 72);
            this.ClassAbilitySelect.Name = "ClassAbilitySelect";
            this.ClassAbilitySelect.Size = new System.Drawing.Size(85, 169);
            this.ClassAbilitySelect.TabIndex = 31;
            this.ClassAbilitySelect.SelectedIndexChanged += new System.EventHandler(this.ClassAbilitySelect_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(861, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Display These Class Abilities";
            // 
            // UnhideAllCharacters
            // 
            this.UnhideAllCharacters.Location = new System.Drawing.Point(174, 186);
            this.UnhideAllCharacters.Name = "UnhideAllCharacters";
            this.UnhideAllCharacters.Size = new System.Drawing.Size(114, 23);
            this.UnhideAllCharacters.TabIndex = 33;
            this.UnhideAllCharacters.Text = "Unhide All";
            this.UnhideAllCharacters.UseVisualStyleBackColor = true;
            this.UnhideAllCharacters.Click += new System.EventHandler(this.UnhideAllCharacters_Click);
            // 
            // ClearImage
            // 
            this.ClearImage.Location = new System.Drawing.Point(174, 215);
            this.ClearImage.Name = "ClearImage";
            this.ClearImage.Size = new System.Drawing.Size(114, 23);
            this.ClearImage.TabIndex = 34;
            this.ClearImage.Text = "Clear Image";
            this.ClearImage.UseVisualStyleBackColor = true;
            this.ClearImage.Click += new System.EventHandler(this.ClearImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PickNewImage
            // 
            this.PickNewImage.Location = new System.Drawing.Point(174, 244);
            this.PickNewImage.Name = "PickNewImage";
            this.PickNewImage.Size = new System.Drawing.Size(114, 23);
            this.PickNewImage.TabIndex = 35;
            this.PickNewImage.Text = "Pick New Image";
            this.PickNewImage.UseVisualStyleBackColor = true;
            this.PickNewImage.Click += new System.EventHandler(this.PickNewImage_Click);
            // 
            // SaveEncounter
            // 
            this.SaveEncounter.Location = new System.Drawing.Point(369, 41);
            this.SaveEncounter.Name = "SaveEncounter";
            this.SaveEncounter.Size = new System.Drawing.Size(114, 23);
            this.SaveEncounter.TabIndex = 36;
            this.SaveEncounter.Text = "Save Encounter";
            this.SaveEncounter.UseVisualStyleBackColor = true;
            this.SaveEncounter.Click += new System.EventHandler(this.SaveEncounter_Click);
            // 
            // LoadEncounter
            // 
            this.LoadEncounter.Location = new System.Drawing.Point(369, 70);
            this.LoadEncounter.Name = "LoadEncounter";
            this.LoadEncounter.Size = new System.Drawing.Size(114, 23);
            this.LoadEncounter.TabIndex = 37;
            this.LoadEncounter.Text = "Load Encounter";
            this.LoadEncounter.UseVisualStyleBackColor = true;
            this.LoadEncounter.Click += new System.EventHandler(this.LoadEncounter_Click);
            // 
            // AddCustomCharacter
            // 
            this.AddCustomCharacter.Location = new System.Drawing.Point(174, 273);
            this.AddCustomCharacter.Name = "AddCustomCharacter";
            this.AddCustomCharacter.Size = new System.Drawing.Size(114, 23);
            this.AddCustomCharacter.TabIndex = 38;
            this.AddCustomCharacter.Text = "Add Custom Char";
            this.AddCustomCharacter.UseVisualStyleBackColor = true;
            this.AddCustomCharacter.Click += new System.EventHandler(this.AddCustomCharacter_Click);
            // 
            // CustomCharacterBox
            // 
            this.CustomCharacterBox.Location = new System.Drawing.Point(294, 275);
            this.CustomCharacterBox.Name = "CustomCharacterBox";
            this.CustomCharacterBox.Size = new System.Drawing.Size(175, 20);
            this.CustomCharacterBox.TabIndex = 39;
            // 
            // ShowMeStatusBox
            // 
            this.ShowMeStatusBox.Location = new System.Drawing.Point(498, 535);
            this.ShowMeStatusBox.Multiline = true;
            this.ShowMeStatusBox.Name = "ShowMeStatusBox";
            this.ShowMeStatusBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowMeStatusBox.Size = new System.Drawing.Size(443, 407);
            this.ShowMeStatusBox.TabIndex = 40;
            // 
            // MyPicture
            // 
            this.MyPicture.Image = global::DMAssistant.Properties.Resources.mass_effect_title_screen_by_tes331_dcc3zqt_fullview;
            this.MyPicture.Location = new System.Drawing.Point(12, 589);
            this.MyPicture.Name = "MyPicture";
            this.MyPicture.Size = new System.Drawing.Size(480, 353);
            this.MyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPicture.TabIndex = 41;
            this.MyPicture.TabStop = false;
            // 
            // ChangeMyPicture
            // 
            this.ChangeMyPicture.Location = new System.Drawing.Point(40, 560);
            this.ChangeMyPicture.Name = "ChangeMyPicture";
            this.ChangeMyPicture.Size = new System.Drawing.Size(90, 23);
            this.ChangeMyPicture.TabIndex = 42;
            this.ChangeMyPicture.Text = "Change Picture";
            this.ChangeMyPicture.UseVisualStyleBackColor = true;
            this.ChangeMyPicture.Click += new System.EventHandler(this.ChangeMyPicture_Click);
            // 
            // MovePictureToGroup
            // 
            this.MovePictureToGroup.Location = new System.Drawing.Point(40, 535);
            this.MovePictureToGroup.Name = "MovePictureToGroup";
            this.MovePictureToGroup.Size = new System.Drawing.Size(90, 23);
            this.MovePictureToGroup.TabIndex = 43;
            this.MovePictureToGroup.Text = "Show Them Pic";
            this.MovePictureToGroup.UseVisualStyleBackColor = true;
            this.MovePictureToGroup.Click += new System.EventHandler(this.MovePictureToGroup_Click);
            // 
            // PictureList
            // 
            this.PictureList.FormattingEnabled = true;
            this.PictureList.Location = new System.Drawing.Point(1230, 12);
            this.PictureList.Name = "PictureList";
            this.PictureList.Size = new System.Drawing.Size(187, 602);
            this.PictureList.TabIndex = 44;
            this.PictureList.SelectedIndexChanged += new System.EventHandler(this.PictureList_SelectedIndexChanged);
            // 
            // HideUnhide
            // 
            this.HideUnhide.Location = new System.Drawing.Point(1423, 12);
            this.HideUnhide.Name = "HideUnhide";
            this.HideUnhide.Size = new System.Drawing.Size(78, 38);
            this.HideUnhide.TabIndex = 45;
            this.HideUnhide.Text = "Hide/Unhide Selected";
            this.HideUnhide.UseVisualStyleBackColor = true;
            this.HideUnhide.Click += new System.EventHandler(this.HideUnhide_Click);
            // 
            // HideAll
            // 
            this.HideAll.Location = new System.Drawing.Point(1423, 56);
            this.HideAll.Name = "HideAll";
            this.HideAll.Size = new System.Drawing.Size(75, 23);
            this.HideAll.TabIndex = 46;
            this.HideAll.Text = "Hide All";
            this.HideAll.UseVisualStyleBackColor = true;
            this.HideAll.Click += new System.EventHandler(this.HideAll_Click);
            // 
            // UnhideAll
            // 
            this.UnhideAll.Location = new System.Drawing.Point(1423, 86);
            this.UnhideAll.Name = "UnhideAll";
            this.UnhideAll.Size = new System.Drawing.Size(75, 23);
            this.UnhideAll.TabIndex = 47;
            this.UnhideAll.Text = "Unhide All";
            this.UnhideAll.UseVisualStyleBackColor = true;
            this.UnhideAll.Click += new System.EventHandler(this.UnhideAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 954);
            this.Controls.Add(this.UnhideAll);
            this.Controls.Add(this.HideAll);
            this.Controls.Add(this.HideUnhide);
            this.Controls.Add(this.PictureList);
            this.Controls.Add(this.MovePictureToGroup);
            this.Controls.Add(this.ChangeMyPicture);
            this.Controls.Add(this.MyPicture);
            this.Controls.Add(this.ShowMeStatusBox);
            this.Controls.Add(this.CustomCharacterBox);
            this.Controls.Add(this.AddCustomCharacter);
            this.Controls.Add(this.LoadEncounter);
            this.Controls.Add(this.SaveEncounter);
            this.Controls.Add(this.PickNewImage);
            this.Controls.Add(this.ClearImage);
            this.Controls.Add(this.UnhideAllCharacters);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClassAbilitySelect);
            this.Controls.Add(this.ShowAbility);
            this.Controls.Add(this.AbilityList);
            this.Controls.Add(this.SetToTop);
            this.Controls.Add(this.ResourceList);
            this.Controls.Add(this.PreviousCharacter);
            this.Controls.Add(this.LoadBattle);
            this.Controls.Add(this.ShowStatus);
            this.Controls.Add(this.NextCharacter);
            this.Controls.Add(this.CharacterNameText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CharacterHidden);
            this.Controls.Add(this.CharacterNotes);
            this.Controls.Add(this.CharacterStatus);
            this.Controls.Add(this.CharacterBarrier);
            this.Controls.Add(this.CharacterRegen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharacterShields);
            this.Controls.Add(this.CharacterHP);
            this.Controls.Add(this.CharacterAC);
            this.Controls.Add(this.CharacterInitiative);
            this.Controls.Add(this.CharacterName);
            this.Controls.Add(this.CharacterEdit);
            this.Controls.Add(this.RemoveCharacter);
            this.Controls.Add(this.AddCharacter);
            this.Controls.Add(this.DMInitiativeList);
            this.Name = "Form1";
            this.Text = "DMView";
            ((System.ComponentModel.ISupportInitialize)(this.CharacterInitiative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterShields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterRegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterBarrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DMInitiativeList;
        private System.Windows.Forms.Button AddCharacter;
        private System.Windows.Forms.Button RemoveCharacter;
        private System.Windows.Forms.Button CharacterEdit;
        private System.Windows.Forms.Label CharacterName;
        private System.Windows.Forms.NumericUpDown CharacterInitiative;
        private System.Windows.Forms.NumericUpDown CharacterAC;
        private System.Windows.Forms.NumericUpDown CharacterHP;
        private System.Windows.Forms.NumericUpDown CharacterShields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CharacterRegen;
        private System.Windows.Forms.NumericUpDown CharacterBarrier;
        private System.Windows.Forms.TextBox CharacterStatus;
        private System.Windows.Forms.TextBox CharacterNotes;
        private System.Windows.Forms.CheckBox CharacterHidden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CharacterNameText;
        private System.Windows.Forms.Button NextCharacter;
        private System.Windows.Forms.Button ShowStatus;
        private System.Windows.Forms.Button LoadBattle;
        private System.Windows.Forms.Button PreviousCharacter;
        private System.Windows.Forms.ListBox ResourceList;
        private System.Windows.Forms.Button SetToTop;
        private System.Windows.Forms.ListBox AbilityList;
        private System.Windows.Forms.Button ShowAbility;
        private System.Windows.Forms.CheckedListBox ClassAbilitySelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UnhideAllCharacters;
        private System.Windows.Forms.Button ClearImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button PickNewImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button SaveEncounter;
        private System.Windows.Forms.Button LoadEncounter;
        private System.Windows.Forms.Button AddCustomCharacter;
        private System.Windows.Forms.TextBox CustomCharacterBox;
        private System.Windows.Forms.TextBox ShowMeStatusBox;
        private System.Windows.Forms.PictureBox MyPicture;
        private System.Windows.Forms.Button ChangeMyPicture;
        private System.Windows.Forms.Button MovePictureToGroup;
        private System.Windows.Forms.ListBox PictureList;
        private System.Windows.Forms.Button HideUnhide;
        private System.Windows.Forms.Button HideAll;
        private System.Windows.Forms.Button UnhideAll;
    }
}

