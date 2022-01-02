namespace ScriptEditor
{
    partial class FormEventEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventEditor));
            this.lstEvents = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCreatureId = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblCreatureId = new System.Windows.Forms.Label();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.btnEventPhaseMask = new System.Windows.Forms.Button();
            this.lblEventComment = new System.Windows.Forms.Label();
            this.txtEventComment = new System.Windows.Forms.TextBox();
            this.lblScriptId3 = new System.Windows.Forms.Label();
            this.lblScriptId2 = new System.Windows.Forms.Label();
            this.lblScriptId1 = new System.Windows.Forms.Label();
            this.grpEventFlags = new System.Windows.Forms.GroupBox();
            this.chkEventFlag4 = new System.Windows.Forms.CheckBox();
            this.chkEventFlag2 = new System.Windows.Forms.CheckBox();
            this.chkEventFlag1 = new System.Windows.Forms.CheckBox();
            this.btnEditScript3 = new System.Windows.Forms.Button();
            this.btnEditScript2 = new System.Windows.Forms.Button();
            this.btnEditScript1 = new System.Windows.Forms.Button();
            this.txtScriptId3 = new System.Windows.Forms.TextBox();
            this.txtScriptId2 = new System.Windows.Forms.TextBox();
            this.txtScriptId1 = new System.Windows.Forms.TextBox();
            this.lblEventCondition = new System.Windows.Forms.Label();
            this.btnEventCondition = new System.Windows.Forms.Button();
            this.lblEventPhaseMask = new System.Windows.Forms.Label();
            this.lblEventChance = new System.Windows.Forms.Label();
            this.txtEventChance = new System.Windows.Forms.TextBox();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblEventId = new System.Windows.Forms.Label();
            this.txtEventId = new System.Windows.Forms.TextBox();
            this.frmEventTimerCombat = new System.Windows.Forms.Panel();
            this.txtTimerRepeatMax = new System.Windows.Forms.TextBox();
            this.lblTimerRepeatMax = new System.Windows.Forms.Label();
            this.txtTimerRepeatMin = new System.Windows.Forms.TextBox();
            this.txtTimerInitialMax = new System.Windows.Forms.TextBox();
            this.txtTimerInitialMin = new System.Windows.Forms.TextBox();
            this.lblTimerRepeatMin = new System.Windows.Forms.Label();
            this.lblTimerInitialMin = new System.Windows.Forms.Label();
            this.lblTimerInitialMax = new System.Windows.Forms.Label();
            this.lblEventTimerCombatTooltip = new System.Windows.Forms.Label();
            this.lblCurrentCreature = new System.Windows.Forms.Label();
            this.btnEventCopy = new System.Windows.Forms.Button();
            this.btnEventAdd = new System.Windows.Forms.Button();
            this.btnEventDelete = new System.Windows.Forms.Button();
            this.btnViewRaw = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNoEvent = new System.Windows.Forms.Label();
            this.frmEventAggro = new System.Windows.Forms.Panel();
            this.lblEventAggroTooltip = new System.Windows.Forms.Label();
            this.frmEventSpellHit = new System.Windows.Forms.Panel();
            this.btnSpellHitSpellId = new System.Windows.Forms.Button();
            this.txtSpellHitRepeatMax = new System.Windows.Forms.TextBox();
            this.lblSpellHitRepeatMax = new System.Windows.Forms.Label();
            this.txtSpellHitRepeatMin = new System.Windows.Forms.TextBox();
            this.txtSpellHitSchoolMask = new System.Windows.Forms.TextBox();
            this.lblSpellHitRepeatMin = new System.Windows.Forms.Label();
            this.lblSpellHitSpellId = new System.Windows.Forms.Label();
            this.lblSpellHitSchoolMask = new System.Windows.Forms.Label();
            this.lblEventSpellHitTooltip = new System.Windows.Forms.Label();
            this.frmEventEnterLOS = new System.Windows.Forms.Panel();
            this.cmbEnterLOSFaction = new System.Windows.Forms.ComboBox();
            this.txtEnterLOSRepeatMax = new System.Windows.Forms.TextBox();
            this.lblEnterLOSRepeatMax = new System.Windows.Forms.Label();
            this.txtEnterLOSRepeatMin = new System.Windows.Forms.TextBox();
            this.txtEnterLOSDistance = new System.Windows.Forms.TextBox();
            this.lblEnterLOSRepeatMin = new System.Windows.Forms.Label();
            this.lblEnterLOSFaction = new System.Windows.Forms.Label();
            this.lblEnterLOSDistance = new System.Windows.Forms.Label();
            this.lblEventEnterLOSTooltip = new System.Windows.Forms.Label();
            this.frmEventSummonedUnit = new System.Windows.Forms.Panel();
            this.btnSummonedUnitId = new System.Windows.Forms.Button();
            this.txtSummonedUnitRepeatMax = new System.Windows.Forms.TextBox();
            this.txtSummonedUnitRepeatMin = new System.Windows.Forms.TextBox();
            this.lblSummonedUnitRepeatMax = new System.Windows.Forms.Label();
            this.lblSummonedUnitId = new System.Windows.Forms.Label();
            this.lblSummonedUnitRepeatMin = new System.Windows.Forms.Label();
            this.lblEventSummonedUnitTooltip = new System.Windows.Forms.Label();
            this.frmEventReceiveEmote = new System.Windows.Forms.Panel();
            this.cmbReceiveEmoteId = new System.Windows.Forms.ComboBox();
            this.lblReceiveEmoteId = new System.Windows.Forms.Label();
            this.lblEventReceiveEmoteTooltip = new System.Windows.Forms.Label();
            this.frmEventMovementInform = new System.Windows.Forms.Panel();
            this.cmbMovementInformType = new System.Windows.Forms.ComboBox();
            this.txtMovementInformRepeatMax = new System.Windows.Forms.TextBox();
            this.lblMovementInformRepeatMax = new System.Windows.Forms.Label();
            this.txtMovementInformRepeatMin = new System.Windows.Forms.TextBox();
            this.txtMovementInformPoint = new System.Windows.Forms.TextBox();
            this.lblMovementInformRepeatMin = new System.Windows.Forms.Label();
            this.lblMovementInformType = new System.Windows.Forms.Label();
            this.lblMovementInformPoint = new System.Windows.Forms.Label();
            this.lblEventMovementInformTooltip = new System.Windows.Forms.Label();
            this.frmEventGroupMemberDied = new System.Windows.Forms.Panel();
            this.cmbGroupMemberDiedIsLeader = new System.Windows.Forms.ComboBox();
            this.btnGroupMemberDiedCreatureId = new System.Windows.Forms.Button();
            this.lblGroupMemberDiedCreatureId = new System.Windows.Forms.Label();
            this.lblGroupMemberDiedIsLeader = new System.Windows.Forms.Label();
            this.lblGroupMemberDiedTooltip = new System.Windows.Forms.Label();
            this.frmEventKilledUnit = new System.Windows.Forms.Panel();
            this.cmbKilledUnitTarget = new System.Windows.Forms.ComboBox();
            this.txtKilledUnitRepeatMax = new System.Windows.Forms.TextBox();
            this.txtKilledUnitRepeatMin = new System.Windows.Forms.TextBox();
            this.lblKilledUnitRepeatMax = new System.Windows.Forms.Label();
            this.lblKilledUnitTarget = new System.Windows.Forms.Label();
            this.lblKilledUnitRepeatMin = new System.Windows.Forms.Label();
            this.lblKilledUnitTooltip = new System.Windows.Forms.Label();
            this.frmUnsupportedEvent = new System.Windows.Forms.Panel();
            this.txtUnkParam1 = new System.Windows.Forms.TextBox();
            this.txtUnkParam4 = new System.Windows.Forms.TextBox();
            this.lblUnkParam4 = new System.Windows.Forms.Label();
            this.txtUnkParam3 = new System.Windows.Forms.TextBox();
            this.txtUnkParam2 = new System.Windows.Forms.TextBox();
            this.lblUnkParam3 = new System.Windows.Forms.Label();
            this.lblUnkParam1 = new System.Windows.Forms.Label();
            this.lblUnkParam2 = new System.Windows.Forms.Label();
            this.lvlUnsupportedEventTooltip = new System.Windows.Forms.Label();
            this.frmEventHitByAura = new System.Windows.Forms.Panel();
            this.cmbHitByAuraType = new System.Windows.Forms.ComboBox();
            this.txtHitByAuraRepeatMax = new System.Windows.Forms.TextBox();
            this.lblHitByAuraRepeatMax = new System.Windows.Forms.Label();
            this.txtHitByAuraRepeatMin = new System.Windows.Forms.TextBox();
            this.txtHitByAuraUnused = new System.Windows.Forms.TextBox();
            this.lblHitByAuraRepeatMin = new System.Windows.Forms.Label();
            this.lblHitByAuraType = new System.Windows.Forms.Label();
            this.lblHitByAuraUnused = new System.Windows.Forms.Label();
            this.lblHitByAuraTooltip = new System.Windows.Forms.Label();
            this.grpGeneral.SuspendLayout();
            this.grpEventFlags.SuspendLayout();
            this.frmEventTimerCombat.SuspendLayout();
            this.frmEventAggro.SuspendLayout();
            this.frmEventSpellHit.SuspendLayout();
            this.frmEventEnterLOS.SuspendLayout();
            this.frmEventSummonedUnit.SuspendLayout();
            this.frmEventReceiveEmote.SuspendLayout();
            this.frmEventMovementInform.SuspendLayout();
            this.frmEventGroupMemberDied.SuspendLayout();
            this.frmEventKilledUnit.SuspendLayout();
            this.frmUnsupportedEvent.SuspendLayout();
            this.frmEventHitByAura.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEvents
            // 
            this.lstEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnType,
            this.columnComment});
            this.lstEvents.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEvents.FullRowSelect = true;
            this.lstEvents.GridLines = true;
            this.lstEvents.HideSelection = false;
            this.lstEvents.Location = new System.Drawing.Point(16, 97);
            this.lstEvents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstEvents.MultiSelect = false;
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(519, 588);
            this.lstEvents.TabIndex = 0;
            this.lstEvents.UseCompatibleStateImageBehavior = false;
            this.lstEvents.View = System.Windows.Forms.View.Details;
            this.lstEvents.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstEvents_ColumnClick);
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 100;
            // 
            // columnComment
            // 
            this.columnComment.Text = "Comment";
            this.columnComment.Width = 225;
            // 
            // txtCreatureId
            // 
            this.txtCreatureId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatureId.Location = new System.Drawing.Point(876, 67);
            this.txtCreatureId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCreatureId.Name = "txtCreatureId";
            this.txtCreatureId.Size = new System.Drawing.Size(252, 26);
            this.txtCreatureId.TabIndex = 1;
            this.txtCreatureId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreatureId_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(1137, 65);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 27);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblCreatureId
            // 
            this.lblCreatureId.AutoSize = true;
            this.lblCreatureId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatureId.Location = new System.Drawing.Point(787, 72);
            this.lblCreatureId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatureId.Name = "lblCreatureId";
            this.lblCreatureId.Size = new System.Drawing.Size(81, 18);
            this.lblCreatureId.TabIndex = 3;
            this.lblCreatureId.Text = "Creature Id:";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.btnEventPhaseMask);
            this.grpGeneral.Controls.Add(this.lblEventComment);
            this.grpGeneral.Controls.Add(this.txtEventComment);
            this.grpGeneral.Controls.Add(this.lblScriptId3);
            this.grpGeneral.Controls.Add(this.lblScriptId2);
            this.grpGeneral.Controls.Add(this.lblScriptId1);
            this.grpGeneral.Controls.Add(this.grpEventFlags);
            this.grpGeneral.Controls.Add(this.btnEditScript3);
            this.grpGeneral.Controls.Add(this.btnEditScript2);
            this.grpGeneral.Controls.Add(this.btnEditScript1);
            this.grpGeneral.Controls.Add(this.txtScriptId3);
            this.grpGeneral.Controls.Add(this.txtScriptId2);
            this.grpGeneral.Controls.Add(this.txtScriptId1);
            this.grpGeneral.Controls.Add(this.lblEventCondition);
            this.grpGeneral.Controls.Add(this.btnEventCondition);
            this.grpGeneral.Controls.Add(this.lblEventPhaseMask);
            this.grpGeneral.Controls.Add(this.lblEventChance);
            this.grpGeneral.Controls.Add(this.txtEventChance);
            this.grpGeneral.Controls.Add(this.cmbEventType);
            this.grpGeneral.Controls.Add(this.lblEventType);
            this.grpGeneral.Controls.Add(this.lblEventId);
            this.grpGeneral.Controls.Add(this.txtEventId);
            this.grpGeneral.Enabled = false;
            this.grpGeneral.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGeneral.Location = new System.Drawing.Point(577, 98);
            this.grpGeneral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpGeneral.Size = new System.Drawing.Size(660, 263);
            this.grpGeneral.TabIndex = 4;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General Settings";
            // 
            // btnEventPhaseMask
            // 
            this.btnEventPhaseMask.Location = new System.Drawing.Point(437, 148);
            this.btnEventPhaseMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEventPhaseMask.Name = "btnEventPhaseMask";
            this.btnEventPhaseMask.Size = new System.Drawing.Size(193, 27);
            this.btnEventPhaseMask.TabIndex = 35;
            this.btnEventPhaseMask.Text = "-NONE-";
            this.btnEventPhaseMask.UseVisualStyleBackColor = true;
            this.btnEventPhaseMask.Click += new System.EventHandler(this.btnEventPhaseMask_Click);
            // 
            // lblEventComment
            // 
            this.lblEventComment.AutoSize = true;
            this.lblEventComment.Location = new System.Drawing.Point(27, 227);
            this.lblEventComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventComment.Name = "lblEventComment";
            this.lblEventComment.Size = new System.Drawing.Size(73, 18);
            this.lblEventComment.TabIndex = 34;
            this.lblEventComment.Text = "Comment:";
            // 
            // txtEventComment
            // 
            this.txtEventComment.Location = new System.Drawing.Point(123, 224);
            this.txtEventComment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEventComment.Name = "txtEventComment";
            this.txtEventComment.Size = new System.Drawing.Size(507, 26);
            this.txtEventComment.TabIndex = 33;
            this.txtEventComment.Leave += new System.EventHandler(this.txtEventComment_Leave);
            // 
            // lblScriptId3
            // 
            this.lblScriptId3.AutoSize = true;
            this.lblScriptId3.Location = new System.Drawing.Point(27, 190);
            this.lblScriptId3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScriptId3.Name = "lblScriptId3";
            this.lblScriptId3.Size = new System.Drawing.Size(57, 18);
            this.lblScriptId3.TabIndex = 32;
            this.lblScriptId3.Text = "Script 3:";
            // 
            // lblScriptId2
            // 
            this.lblScriptId2.AutoSize = true;
            this.lblScriptId2.Location = new System.Drawing.Point(27, 152);
            this.lblScriptId2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScriptId2.Name = "lblScriptId2";
            this.lblScriptId2.Size = new System.Drawing.Size(57, 18);
            this.lblScriptId2.TabIndex = 31;
            this.lblScriptId2.Text = "Script 2:";
            // 
            // lblScriptId1
            // 
            this.lblScriptId1.AutoSize = true;
            this.lblScriptId1.Location = new System.Drawing.Point(27, 112);
            this.lblScriptId1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScriptId1.Name = "lblScriptId1";
            this.lblScriptId1.Size = new System.Drawing.Size(57, 18);
            this.lblScriptId1.TabIndex = 30;
            this.lblScriptId1.Text = "Script 1:";
            // 
            // grpEventFlags
            // 
            this.grpEventFlags.Controls.Add(this.chkEventFlag4);
            this.grpEventFlags.Controls.Add(this.chkEventFlag2);
            this.grpEventFlags.Controls.Add(this.chkEventFlag1);
            this.grpEventFlags.Location = new System.Drawing.Point(345, 22);
            this.grpEventFlags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpEventFlags.Name = "grpEventFlags";
            this.grpEventFlags.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpEventFlags.Size = new System.Drawing.Size(285, 82);
            this.grpEventFlags.TabIndex = 10;
            this.grpEventFlags.TabStop = false;
            this.grpEventFlags.Text = "Event Flags";
            // 
            // chkEventFlag4
            // 
            this.chkEventFlag4.AutoSize = true;
            this.chkEventFlag4.Location = new System.Drawing.Point(155, 23);
            this.chkEventFlag4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkEventFlag4.Name = "chkEventFlag4";
            this.chkEventFlag4.Size = new System.Drawing.Size(102, 22);
            this.chkEventFlag4.TabIndex = 2;
            this.chkEventFlag4.Text = "Debug Only";
            this.chkEventFlag4.UseVisualStyleBackColor = true;
            this.chkEventFlag4.CheckedChanged += new System.EventHandler(this.chkEventFlag4_CheckedChanged);
            // 
            // chkEventFlag2
            // 
            this.chkEventFlag2.AutoSize = true;
            this.chkEventFlag2.Location = new System.Drawing.Point(8, 50);
            this.chkEventFlag2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkEventFlag2.Name = "chkEventFlag2";
            this.chkEventFlag2.Size = new System.Drawing.Size(174, 22);
            this.chkEventFlag2.TabIndex = 1;
            this.chkEventFlag2.Text = "Chooses Random Script";
            this.chkEventFlag2.UseVisualStyleBackColor = true;
            this.chkEventFlag2.CheckedChanged += new System.EventHandler(this.chkEventFlag2_CheckedChanged);
            // 
            // chkEventFlag1
            // 
            this.chkEventFlag1.AutoSize = true;
            this.chkEventFlag1.Location = new System.Drawing.Point(8, 23);
            this.chkEventFlag1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkEventFlag1.Name = "chkEventFlag1";
            this.chkEventFlag1.Size = new System.Drawing.Size(101, 22);
            this.chkEventFlag1.TabIndex = 0;
            this.chkEventFlag1.Text = "Repeatable";
            this.chkEventFlag1.UseVisualStyleBackColor = true;
            this.chkEventFlag1.CheckedChanged += new System.EventHandler(this.chkEventFlag1_CheckedChanged);
            // 
            // btnEditScript3
            // 
            this.btnEditScript3.Location = new System.Drawing.Point(255, 182);
            this.btnEditScript3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditScript3.Name = "btnEditScript3";
            this.btnEditScript3.Size = new System.Drawing.Size(59, 25);
            this.btnEditScript3.TabIndex = 29;
            this.btnEditScript3.Text = "Edit";
            this.btnEditScript3.UseVisualStyleBackColor = true;
            this.btnEditScript3.Click += new System.EventHandler(this.btnEditScript3_Click);
            // 
            // btnEditScript2
            // 
            this.btnEditScript2.Location = new System.Drawing.Point(255, 144);
            this.btnEditScript2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditScript2.Name = "btnEditScript2";
            this.btnEditScript2.Size = new System.Drawing.Size(59, 25);
            this.btnEditScript2.TabIndex = 28;
            this.btnEditScript2.Text = "Edit";
            this.btnEditScript2.UseVisualStyleBackColor = true;
            this.btnEditScript2.Click += new System.EventHandler(this.btnEditScript2_Click);
            // 
            // btnEditScript1
            // 
            this.btnEditScript1.Location = new System.Drawing.Point(256, 106);
            this.btnEditScript1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditScript1.Name = "btnEditScript1";
            this.btnEditScript1.Size = new System.Drawing.Size(59, 25);
            this.btnEditScript1.TabIndex = 27;
            this.btnEditScript1.Text = "Edit";
            this.btnEditScript1.UseVisualStyleBackColor = true;
            this.btnEditScript1.Click += new System.EventHandler(this.btnEditScript1_Click);
            // 
            // txtScriptId3
            // 
            this.txtScriptId3.Location = new System.Drawing.Point(123, 182);
            this.txtScriptId3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtScriptId3.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtScriptId3.Name = "txtScriptId3";
            this.txtScriptId3.Size = new System.Drawing.Size(119, 26);
            this.txtScriptId3.TabIndex = 26;
            this.txtScriptId3.Leave += new System.EventHandler(this.txtScriptId3_Leave);
            // 
            // txtScriptId2
            // 
            this.txtScriptId2.Location = new System.Drawing.Point(123, 144);
            this.txtScriptId2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtScriptId2.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtScriptId2.Name = "txtScriptId2";
            this.txtScriptId2.Size = new System.Drawing.Size(119, 26);
            this.txtScriptId2.TabIndex = 25;
            this.txtScriptId2.Leave += new System.EventHandler(this.txtScriptId2_Leave);
            // 
            // txtScriptId1
            // 
            this.txtScriptId1.Location = new System.Drawing.Point(123, 106);
            this.txtScriptId1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtScriptId1.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtScriptId1.Name = "txtScriptId1";
            this.txtScriptId1.Size = new System.Drawing.Size(119, 26);
            this.txtScriptId1.TabIndex = 24;
            this.txtScriptId1.Leave += new System.EventHandler(this.txtScriptId1_Leave);
            // 
            // lblEventCondition
            // 
            this.lblEventCondition.AutoSize = true;
            this.lblEventCondition.Location = new System.Drawing.Point(341, 188);
            this.lblEventCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventCondition.Name = "lblEventCondition";
            this.lblEventCondition.Size = new System.Drawing.Size(72, 18);
            this.lblEventCondition.TabIndex = 9;
            this.lblEventCondition.Text = "Condition:";
            // 
            // btnEventCondition
            // 
            this.btnEventCondition.Location = new System.Drawing.Point(437, 182);
            this.btnEventCondition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEventCondition.Name = "btnEventCondition";
            this.btnEventCondition.Size = new System.Drawing.Size(193, 27);
            this.btnEventCondition.TabIndex = 8;
            this.btnEventCondition.Text = "-NONE-";
            this.btnEventCondition.UseVisualStyleBackColor = true;
            this.btnEventCondition.Click += new System.EventHandler(this.btnEventCondition_Click);
            // 
            // lblEventPhaseMask
            // 
            this.lblEventPhaseMask.AutoSize = true;
            this.lblEventPhaseMask.Location = new System.Drawing.Point(341, 151);
            this.lblEventPhaseMask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventPhaseMask.Name = "lblEventPhaseMask";
            this.lblEventPhaseMask.Size = new System.Drawing.Size(84, 18);
            this.lblEventPhaseMask.TabIndex = 7;
            this.lblEventPhaseMask.Text = "Phase Mask:";
            // 
            // lblEventChance
            // 
            this.lblEventChance.AutoSize = true;
            this.lblEventChance.Location = new System.Drawing.Point(341, 115);
            this.lblEventChance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventChance.Name = "lblEventChance";
            this.lblEventChance.Size = new System.Drawing.Size(57, 18);
            this.lblEventChance.TabIndex = 5;
            this.lblEventChance.Text = "Chance:";
            // 
            // txtEventChance
            // 
            this.txtEventChance.Location = new System.Drawing.Point(437, 112);
            this.txtEventChance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEventChance.Name = "txtEventChance";
            this.txtEventChance.Size = new System.Drawing.Size(192, 26);
            this.txtEventChance.TabIndex = 4;
            this.txtEventChance.Leave += new System.EventHandler(this.txtEventChance_Leave);
            // 
            // cmbEventType
            // 
            this.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Location = new System.Drawing.Point(123, 69);
            this.cmbEventType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(192, 26);
            this.cmbEventType.TabIndex = 3;
            this.cmbEventType.SelectedIndexChanged += new System.EventHandler(this.cmbEventType_SelectedIndexChanged);
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(27, 73);
            this.lblEventType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(41, 18);
            this.lblEventType.TabIndex = 2;
            this.lblEventType.Text = "Type:";
            // 
            // lblEventId
            // 
            this.lblEventId.AutoSize = true;
            this.lblEventId.Location = new System.Drawing.Point(27, 37);
            this.lblEventId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventId.Name = "lblEventId";
            this.lblEventId.Size = new System.Drawing.Size(24, 18);
            this.lblEventId.TabIndex = 1;
            this.lblEventId.Text = "Id:";
            // 
            // txtEventId
            // 
            this.txtEventId.Location = new System.Drawing.Point(123, 33);
            this.txtEventId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.Size = new System.Drawing.Size(192, 26);
            this.txtEventId.TabIndex = 0;
            this.txtEventId.Leave += new System.EventHandler(this.txtEventId_Leave);
            // 
            // frmEventTimerCombat
            // 
            this.frmEventTimerCombat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventTimerCombat.Controls.Add(this.txtTimerRepeatMax);
            this.frmEventTimerCombat.Controls.Add(this.lblTimerRepeatMax);
            this.frmEventTimerCombat.Controls.Add(this.txtTimerRepeatMin);
            this.frmEventTimerCombat.Controls.Add(this.txtTimerInitialMax);
            this.frmEventTimerCombat.Controls.Add(this.txtTimerInitialMin);
            this.frmEventTimerCombat.Controls.Add(this.lblTimerRepeatMin);
            this.frmEventTimerCombat.Controls.Add(this.lblTimerInitialMin);
            this.frmEventTimerCombat.Controls.Add(this.lblTimerInitialMax);
            this.frmEventTimerCombat.Controls.Add(this.lblEventTimerCombatTooltip);
            this.frmEventTimerCombat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEventTimerCombat.Location = new System.Drawing.Point(577, 368);
            this.frmEventTimerCombat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmEventTimerCombat.Name = "frmEventTimerCombat";
            this.frmEventTimerCombat.Size = new System.Drawing.Size(659, 317);
            this.frmEventTimerCombat.TabIndex = 54;
            this.frmEventTimerCombat.Visible = false;
            // 
            // txtTimerRepeatMax
            // 
            this.txtTimerRepeatMax.Location = new System.Drawing.Point(132, 171);
            this.txtTimerRepeatMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimerRepeatMax.Name = "txtTimerRepeatMax";
            this.txtTimerRepeatMax.Size = new System.Drawing.Size(497, 26);
            this.txtTimerRepeatMax.TabIndex = 12;
            this.txtTimerRepeatMax.Leave += new System.EventHandler(this.txtTimerRepeatMax_Leave);
            // 
            // lblTimerRepeatMax
            // 
            this.lblTimerRepeatMax.AutoSize = true;
            this.lblTimerRepeatMax.Location = new System.Drawing.Point(40, 174);
            this.lblTimerRepeatMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimerRepeatMax.Name = "lblTimerRepeatMax";
            this.lblTimerRepeatMax.Size = new System.Drawing.Size(85, 18);
            this.lblTimerRepeatMax.TabIndex = 11;
            this.lblTimerRepeatMax.Text = "Repeat Max:";
            // 
            // txtTimerRepeatMin
            // 
            this.txtTimerRepeatMin.Location = new System.Drawing.Point(132, 136);
            this.txtTimerRepeatMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimerRepeatMin.Name = "txtTimerRepeatMin";
            this.txtTimerRepeatMin.Size = new System.Drawing.Size(497, 26);
            this.txtTimerRepeatMin.TabIndex = 10;
            this.txtTimerRepeatMin.Leave += new System.EventHandler(this.txtTimerRepeatMin_Leave);
            // 
            // txtTimerInitialMax
            // 
            this.txtTimerInitialMax.Location = new System.Drawing.Point(132, 102);
            this.txtTimerInitialMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimerInitialMax.Name = "txtTimerInitialMax";
            this.txtTimerInitialMax.Size = new System.Drawing.Size(497, 26);
            this.txtTimerInitialMax.TabIndex = 9;
            this.txtTimerInitialMax.Leave += new System.EventHandler(this.txtTimerInitialMax_Leave);
            // 
            // txtTimerInitialMin
            // 
            this.txtTimerInitialMin.Location = new System.Drawing.Point(132, 67);
            this.txtTimerInitialMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimerInitialMin.Name = "txtTimerInitialMin";
            this.txtTimerInitialMin.Size = new System.Drawing.Size(497, 26);
            this.txtTimerInitialMin.TabIndex = 8;
            this.txtTimerInitialMin.Leave += new System.EventHandler(this.txtTimerInitialMin_Leave);
            // 
            // lblTimerRepeatMin
            // 
            this.lblTimerRepeatMin.AutoSize = true;
            this.lblTimerRepeatMin.Location = new System.Drawing.Point(44, 140);
            this.lblTimerRepeatMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimerRepeatMin.Name = "lblTimerRepeatMin";
            this.lblTimerRepeatMin.Size = new System.Drawing.Size(83, 18);
            this.lblTimerRepeatMin.TabIndex = 6;
            this.lblTimerRepeatMin.Text = "Repeat Min:";
            // 
            // lblTimerInitialMin
            // 
            this.lblTimerInitialMin.AutoSize = true;
            this.lblTimerInitialMin.Location = new System.Drawing.Point(59, 70);
            this.lblTimerInitialMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimerInitialMin.Name = "lblTimerInitialMin";
            this.lblTimerInitialMin.Size = new System.Drawing.Size(74, 18);
            this.lblTimerInitialMin.TabIndex = 4;
            this.lblTimerInitialMin.Text = "Initial Min:";
            // 
            // lblTimerInitialMax
            // 
            this.lblTimerInitialMax.AutoSize = true;
            this.lblTimerInitialMax.Location = new System.Drawing.Point(55, 105);
            this.lblTimerInitialMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimerInitialMax.Name = "lblTimerInitialMax";
            this.lblTimerInitialMax.Size = new System.Drawing.Size(76, 18);
            this.lblTimerInitialMax.TabIndex = 3;
            this.lblTimerInitialMax.Text = "Initial Max:";
            // 
            // lblEventTimerCombatTooltip
            // 
            this.lblEventTimerCombatTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventTimerCombatTooltip.Location = new System.Drawing.Point(27, 12);
            this.lblEventTimerCombatTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventTimerCombatTooltip.Name = "lblEventTimerCombatTooltip";
            this.lblEventTimerCombatTooltip.Size = new System.Drawing.Size(604, 37);
            this.lblEventTimerCombatTooltip.TabIndex = 0;
            this.lblEventTimerCombatTooltip.Text = "A timed event that expires after the specified amount of miliseconds have passed." +
    " Only while the creature is in combat.";
            // 
            // lblCurrentCreature
            // 
            this.lblCurrentCreature.AutoSize = true;
            this.lblCurrentCreature.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCreature.Location = new System.Drawing.Point(16, 71);
            this.lblCurrentCreature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentCreature.Name = "lblCurrentCreature";
            this.lblCurrentCreature.Size = new System.Drawing.Size(137, 18);
            this.lblCurrentCreature.TabIndex = 55;
            this.lblCurrentCreature.Text = "No event list loaded.";
            // 
            // btnEventCopy
            // 
            this.btnEventCopy.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventCopy.Location = new System.Drawing.Point(124, 693);
            this.btnEventCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEventCopy.Name = "btnEventCopy";
            this.btnEventCopy.Size = new System.Drawing.Size(100, 27);
            this.btnEventCopy.TabIndex = 58;
            this.btnEventCopy.Text = "Copy";
            this.btnEventCopy.UseVisualStyleBackColor = true;
            this.btnEventCopy.Click += new System.EventHandler(this.btnEventCopy_Click);
            // 
            // btnEventAdd
            // 
            this.btnEventAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventAdd.Location = new System.Drawing.Point(16, 693);
            this.btnEventAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEventAdd.Name = "btnEventAdd";
            this.btnEventAdd.Size = new System.Drawing.Size(100, 27);
            this.btnEventAdd.TabIndex = 57;
            this.btnEventAdd.Text = "Add";
            this.btnEventAdd.UseVisualStyleBackColor = true;
            this.btnEventAdd.Click += new System.EventHandler(this.btnEventAdd_Click);
            // 
            // btnEventDelete
            // 
            this.btnEventDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventDelete.Location = new System.Drawing.Point(232, 693);
            this.btnEventDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEventDelete.Name = "btnEventDelete";
            this.btnEventDelete.Size = new System.Drawing.Size(100, 27);
            this.btnEventDelete.TabIndex = 56;
            this.btnEventDelete.Text = "Delete";
            this.btnEventDelete.UseVisualStyleBackColor = true;
            this.btnEventDelete.Click += new System.EventHandler(this.btnEventDelete_Click);
            // 
            // btnViewRaw
            // 
            this.btnViewRaw.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRaw.Location = new System.Drawing.Point(1031, 694);
            this.btnViewRaw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewRaw.Name = "btnViewRaw";
            this.btnViewRaw.Size = new System.Drawing.Size(100, 27);
            this.btnViewRaw.TabIndex = 60;
            this.btnViewRaw.Text = "View Raw";
            this.btnViewRaw.UseVisualStyleBackColor = true;
            this.btnViewRaw.Click += new System.EventHandler(this.btnViewRaw_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1137, 694);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNoEvent
            // 
            this.lblNoEvent.AutoSize = true;
            this.lblNoEvent.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEvent.Location = new System.Drawing.Point(801, 515);
            this.lblNoEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoEvent.Name = "lblNoEvent";
            this.lblNoEvent.Size = new System.Drawing.Size(121, 18);
            this.lblNoEvent.TabIndex = 61;
            this.lblNoEvent.Text = "No Event Selected";
            // 
            // frmEventAggro
            // 
            this.frmEventAggro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventAggro.Controls.Add(this.lblEventAggroTooltip);
            this.frmEventAggro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEventAggro.Location = new System.Drawing.Point(577, 368);
            this.frmEventAggro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmEventAggro.Name = "frmEventAggro";
            this.frmEventAggro.Size = new System.Drawing.Size(659, 317);
            this.frmEventAggro.TabIndex = 62;
            this.frmEventAggro.Visible = false;
            // 
            // lblEventAggroTooltip
            // 
            this.lblEventAggroTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventAggroTooltip.Location = new System.Drawing.Point(27, 12);
            this.lblEventAggroTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventAggroTooltip.Name = "lblEventAggroTooltip";
            this.lblEventAggroTooltip.Size = new System.Drawing.Size(604, 37);
            this.lblEventAggroTooltip.TabIndex = 0;
            this.lblEventAggroTooltip.Text = "Expires upon initial aggro, does not repeat. This event has no additional paramet" +
    "ers.";
            // 
            // frmEventSpellHit
            // 
            this.frmEventSpellHit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventSpellHit.Controls.Add(this.btnSpellHitSpellId);
            this.frmEventSpellHit.Controls.Add(this.txtSpellHitRepeatMax);
            this.frmEventSpellHit.Controls.Add(this.lblSpellHitRepeatMax);
            this.frmEventSpellHit.Controls.Add(this.txtSpellHitRepeatMin);
            this.frmEventSpellHit.Controls.Add(this.txtSpellHitSchoolMask);
            this.frmEventSpellHit.Controls.Add(this.lblSpellHitRepeatMin);
            this.frmEventSpellHit.Controls.Add(this.lblSpellHitSpellId);
            this.frmEventSpellHit.Controls.Add(this.lblSpellHitSchoolMask);
            this.frmEventSpellHit.Controls.Add(this.lblEventSpellHitTooltip);
            this.frmEventSpellHit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEventSpellHit.Location = new System.Drawing.Point(577, 368);
            this.frmEventSpellHit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmEventSpellHit.Name = "frmEventSpellHit";
            this.frmEventSpellHit.Size = new System.Drawing.Size(659, 317);
            this.frmEventSpellHit.TabIndex = 63;
            this.frmEventSpellHit.Visible = false;
            // 
            // btnSpellHitSpellId
            // 
            this.btnSpellHitSpellId.Location = new System.Drawing.Point(132, 67);
            this.btnSpellHitSpellId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSpellHitSpellId.Name = "btnSpellHitSpellId";
            this.btnSpellHitSpellId.Size = new System.Drawing.Size(499, 27);
            this.btnSpellHitSpellId.TabIndex = 13;
            this.btnSpellHitSpellId.Text = "-NONE-";
            this.btnSpellHitSpellId.UseVisualStyleBackColor = true;
            this.btnSpellHitSpellId.Click += new System.EventHandler(this.btnSpellHitSpellId_Click);
            // 
            // txtSpellHitRepeatMax
            // 
            this.txtSpellHitRepeatMax.Location = new System.Drawing.Point(132, 171);
            this.txtSpellHitRepeatMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSpellHitRepeatMax.Name = "txtSpellHitRepeatMax";
            this.txtSpellHitRepeatMax.Size = new System.Drawing.Size(497, 26);
            this.txtSpellHitRepeatMax.TabIndex = 12;
            this.txtSpellHitRepeatMax.Leave += new System.EventHandler(this.txtSpellHitRepeatMax_Leave);
            // 
            // lblSpellHitRepeatMax
            // 
            this.lblSpellHitRepeatMax.AutoSize = true;
            this.lblSpellHitRepeatMax.Location = new System.Drawing.Point(36, 174);
            this.lblSpellHitRepeatMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpellHitRepeatMax.Name = "lblSpellHitRepeatMax";
            this.lblSpellHitRepeatMax.Size = new System.Drawing.Size(85, 18);
            this.lblSpellHitRepeatMax.TabIndex = 11;
            this.lblSpellHitRepeatMax.Text = "Repeat Max:";
            // 
            // txtSpellHitRepeatMin
            // 
            this.txtSpellHitRepeatMin.Location = new System.Drawing.Point(132, 136);
            this.txtSpellHitRepeatMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSpellHitRepeatMin.Name = "txtSpellHitRepeatMin";
            this.txtSpellHitRepeatMin.Size = new System.Drawing.Size(497, 26);
            this.txtSpellHitRepeatMin.TabIndex = 10;
            this.txtSpellHitRepeatMin.Leave += new System.EventHandler(this.txtSpellHitRepeatMin_Leave);
            // 
            // txtSpellHitSchoolMask
            // 
            this.txtSpellHitSchoolMask.Location = new System.Drawing.Point(132, 102);
            this.txtSpellHitSchoolMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSpellHitSchoolMask.Name = "txtSpellHitSchoolMask";
            this.txtSpellHitSchoolMask.Size = new System.Drawing.Size(497, 26);
            this.txtSpellHitSchoolMask.TabIndex = 9;
            this.txtSpellHitSchoolMask.Leave += new System.EventHandler(this.txtSpellHitSchoolMask_Leave);
            // 
            // lblSpellHitRepeatMin
            // 
            this.lblSpellHitRepeatMin.AutoSize = true;
            this.lblSpellHitRepeatMin.Location = new System.Drawing.Point(40, 140);
            this.lblSpellHitRepeatMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpellHitRepeatMin.Name = "lblSpellHitRepeatMin";
            this.lblSpellHitRepeatMin.Size = new System.Drawing.Size(83, 18);
            this.lblSpellHitRepeatMin.TabIndex = 6;
            this.lblSpellHitRepeatMin.Text = "Repeat Min:";
            // 
            // lblSpellHitSpellId
            // 
            this.lblSpellHitSpellId.AutoSize = true;
            this.lblSpellHitSpellId.Location = new System.Drawing.Point(67, 70);
            this.lblSpellHitSpellId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpellHitSpellId.Name = "lblSpellHitSpellId";
            this.lblSpellHitSpellId.Size = new System.Drawing.Size(58, 18);
            this.lblSpellHitSpellId.TabIndex = 4;
            this.lblSpellHitSpellId.Text = "Spell Id:";
            // 
            // lblSpellHitSchoolMask
            // 
            this.lblSpellHitSchoolMask.AutoSize = true;
            this.lblSpellHitSchoolMask.Location = new System.Drawing.Point(31, 105);
            this.lblSpellHitSchoolMask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpellHitSchoolMask.Name = "lblSpellHitSchoolMask";
            this.lblSpellHitSchoolMask.Size = new System.Drawing.Size(88, 18);
            this.lblSpellHitSchoolMask.TabIndex = 3;
            this.lblSpellHitSchoolMask.Text = "School Mask:";
            // 
            // lblEventSpellHitTooltip
            // 
            this.lblEventSpellHitTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventSpellHitTooltip.Location = new System.Drawing.Point(27, 12);
            this.lblEventSpellHitTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventSpellHitTooltip.Name = "lblEventSpellHitTooltip";
            this.lblEventSpellHitTooltip.Size = new System.Drawing.Size(604, 37);
            this.lblEventSpellHitTooltip.TabIndex = 0;
            this.lblEventSpellHitTooltip.Text = "Expires when the creature is hit by a spell. If a spell Id is set, it will only e" +
    "xpire when hit by that spell. Same logic applies when a school mask is set.";
            // 
            // frmEventEnterLOS
            // 
            this.frmEventEnterLOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventEnterLOS.Controls.Add(this.cmbEnterLOSFaction);
            this.frmEventEnterLOS.Controls.Add(this.txtEnterLOSRepeatMax);
            this.frmEventEnterLOS.Controls.Add(this.lblEnterLOSRepeatMax);
            this.frmEventEnterLOS.Controls.Add(this.txtEnterLOSRepeatMin);
            this.frmEventEnterLOS.Controls.Add(this.txtEnterLOSDistance);
            this.frmEventEnterLOS.Controls.Add(this.lblEnterLOSRepeatMin);
            this.frmEventEnterLOS.Controls.Add(this.lblEnterLOSFaction);
            this.frmEventEnterLOS.Controls.Add(this.lblEnterLOSDistance);
            this.frmEventEnterLOS.Controls.Add(this.lblEventEnterLOSTooltip);
            this.frmEventEnterLOS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEventEnterLOS.Location = new System.Drawing.Point(577, 368);
            this.frmEventEnterLOS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmEventEnterLOS.Name = "frmEventEnterLOS";
            this.frmEventEnterLOS.Size = new System.Drawing.Size(659, 317);
            this.frmEventEnterLOS.TabIndex = 64;
            this.frmEventEnterLOS.Visible = false;
            // 
            // cmbEnterLOSFaction
            // 
            this.cmbEnterLOSFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnterLOSFaction.FormattingEnabled = true;
            this.cmbEnterLOSFaction.Items.AddRange(new object[] {
            "Any",
            "Hostile",
            "Non Hostile"});
            this.cmbEnterLOSFaction.Location = new System.Drawing.Point(132, 67);
            this.cmbEnterLOSFaction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEnterLOSFaction.Name = "cmbEnterLOSFaction";
            this.cmbEnterLOSFaction.Size = new System.Drawing.Size(497, 26);
            this.cmbEnterLOSFaction.TabIndex = 14;
            this.cmbEnterLOSFaction.SelectedIndexChanged += new System.EventHandler(this.cmbEnterLOSFaction_SelectedIndexChanged);
            // 
            // txtEnterLOSRepeatMax
            // 
            this.txtEnterLOSRepeatMax.Location = new System.Drawing.Point(132, 171);
            this.txtEnterLOSRepeatMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEnterLOSRepeatMax.Name = "txtEnterLOSRepeatMax";
            this.txtEnterLOSRepeatMax.Size = new System.Drawing.Size(497, 26);
            this.txtEnterLOSRepeatMax.TabIndex = 12;
            this.txtEnterLOSRepeatMax.Leave += new System.EventHandler(this.txtEnterLOSRepeatMax_Leave);
            // 
            // lblEnterLOSRepeatMax
            // 
            this.lblEnterLOSRepeatMax.AutoSize = true;
            this.lblEnterLOSRepeatMax.Location = new System.Drawing.Point(36, 174);
            this.lblEnterLOSRepeatMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterLOSRepeatMax.Name = "lblEnterLOSRepeatMax";
            this.lblEnterLOSRepeatMax.Size = new System.Drawing.Size(85, 18);
            this.lblEnterLOSRepeatMax.TabIndex = 11;
            this.lblEnterLOSRepeatMax.Text = "Repeat Max:";
            // 
            // txtEnterLOSRepeatMin
            // 
            this.txtEnterLOSRepeatMin.Location = new System.Drawing.Point(132, 136);
            this.txtEnterLOSRepeatMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEnterLOSRepeatMin.Name = "txtEnterLOSRepeatMin";
            this.txtEnterLOSRepeatMin.Size = new System.Drawing.Size(497, 26);
            this.txtEnterLOSRepeatMin.TabIndex = 10;
            this.txtEnterLOSRepeatMin.Leave += new System.EventHandler(this.txtEnterLOSRepeatMin_Leave);
            // 
            // txtEnterLOSDistance
            // 
            this.txtEnterLOSDistance.Location = new System.Drawing.Point(132, 102);
            this.txtEnterLOSDistance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEnterLOSDistance.Name = "txtEnterLOSDistance";
            this.txtEnterLOSDistance.Size = new System.Drawing.Size(497, 26);
            this.txtEnterLOSDistance.TabIndex = 9;
            this.txtEnterLOSDistance.Leave += new System.EventHandler(this.txtEnterLOSDistance_Leave);
            // 
            // lblEnterLOSRepeatMin
            // 
            this.lblEnterLOSRepeatMin.AutoSize = true;
            this.lblEnterLOSRepeatMin.Location = new System.Drawing.Point(40, 140);
            this.lblEnterLOSRepeatMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterLOSRepeatMin.Name = "lblEnterLOSRepeatMin";
            this.lblEnterLOSRepeatMin.Size = new System.Drawing.Size(83, 18);
            this.lblEnterLOSRepeatMin.TabIndex = 6;
            this.lblEnterLOSRepeatMin.Text = "Repeat Min:";
            // 
            // lblEnterLOSFaction
            // 
            this.lblEnterLOSFaction.AutoSize = true;
            this.lblEnterLOSFaction.Location = new System.Drawing.Point(67, 70);
            this.lblEnterLOSFaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterLOSFaction.Name = "lblEnterLOSFaction";
            this.lblEnterLOSFaction.Size = new System.Drawing.Size(56, 18);
            this.lblEnterLOSFaction.TabIndex = 4;
            this.lblEnterLOSFaction.Text = "Faction:";
            // 
            // lblEnterLOSDistance
            // 
            this.lblEnterLOSDistance.AutoSize = true;
            this.lblEnterLOSDistance.Location = new System.Drawing.Point(57, 105);
            this.lblEnterLOSDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterLOSDistance.Name = "lblEnterLOSDistance";
            this.lblEnterLOSDistance.Size = new System.Drawing.Size(65, 18);
            this.lblEnterLOSDistance.TabIndex = 3;
            this.lblEnterLOSDistance.Text = "Distance:";
            // 
            // lblEventEnterLOSTooltip
            // 
            this.lblEventEnterLOSTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventEnterLOSTooltip.Location = new System.Drawing.Point(27, 12);
            this.lblEventEnterLOSTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventEnterLOSTooltip.Name = "lblEventEnterLOSTooltip";
            this.lblEventEnterLOSTooltip.Size = new System.Drawing.Size(604, 37);
            this.lblEventEnterLOSTooltip.TabIndex = 0;
            this.lblEventEnterLOSTooltip.Text = "Expires when an unit moves within visible distance of the creature. Only while th" +
    "e creature is out of combat.";
            // 
            // frmEventSummonedUnit
            // 
            this.frmEventSummonedUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventSummonedUnit.Controls.Add(this.btnSummonedUnitId);
            this.frmEventSummonedUnit.Controls.Add(this.txtSummonedUnitRepeatMax);
            this.frmEventSummonedUnit.Controls.Add(this.txtSummonedUnitRepeatMin);
            this.frmEventSummonedUnit.Controls.Add(this.lblSummonedUnitRepeatMax);
            this.frmEventSummonedUnit.Controls.Add(this.lblSummonedUnitId);
            this.frmEventSummonedUnit.Controls.Add(this.lblSummonedUnitRepeatMin);
            this.frmEventSummonedUnit.Controls.Add(this.lblEventSummonedUnitTooltip);
            this.frmEventSummonedUnit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEventSummonedUnit.Location = new System.Drawing.Point(577, 368);
            this.frmEventSummonedUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmEventSummonedUnit.Name = "frmEventSummonedUnit";
            this.frmEventSummonedUnit.Size = new System.Drawing.Size(659, 317);
            this.frmEventSummonedUnit.TabIndex = 65;
            this.frmEventSummonedUnit.Visible = false;
            // 
            // btnSummonedUnitId
            // 
            this.btnSummonedUnitId.Location = new System.Drawing.Point(132, 67);
            this.btnSummonedUnitId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSummonedUnitId.Name = "btnSummonedUnitId";
            this.btnSummonedUnitId.Size = new System.Drawing.Size(499, 27);
            this.btnSummonedUnitId.TabIndex = 13;
            this.btnSummonedUnitId.Text = "-NONE-";
            this.btnSummonedUnitId.UseVisualStyleBackColor = true;
            this.btnSummonedUnitId.Click += new System.EventHandler(this.btnSummonedUnitId_Click);
            // 
            // txtSummonedUnitRepeatMax
            // 
            this.txtSummonedUnitRepeatMax.Location = new System.Drawing.Point(132, 136);
            this.txtSummonedUnitRepeatMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummonedUnitRepeatMax.Name = "txtSummonedUnitRepeatMax";
            this.txtSummonedUnitRepeatMax.Size = new System.Drawing.Size(497, 26);
            this.txtSummonedUnitRepeatMax.TabIndex = 10;
            this.txtSummonedUnitRepeatMax.Leave += new System.EventHandler(this.txtSummonedUnitRepeatMax_Leave);
            // 
            // txtSummonedUnitRepeatMin
            // 
            this.txtSummonedUnitRepeatMin.Location = new System.Drawing.Point(132, 102);
            this.txtSummonedUnitRepeatMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummonedUnitRepeatMin.Name = "txtSummonedUnitRepeatMin";
            this.txtSummonedUnitRepeatMin.Size = new System.Drawing.Size(497, 26);
            this.txtSummonedUnitRepeatMin.TabIndex = 9;
            this.txtSummonedUnitRepeatMin.Leave += new System.EventHandler(this.txtSummonedUnitRepeatMin_Leave);
            // 
            // lblSummonedUnitRepeatMax
            // 
            this.lblSummonedUnitRepeatMax.AutoSize = true;
            this.lblSummonedUnitRepeatMax.Location = new System.Drawing.Point(36, 140);
            this.lblSummonedUnitRepeatMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummonedUnitRepeatMax.Name = "lblSummonedUnitRepeatMax";
            this.lblSummonedUnitRepeatMax.Size = new System.Drawing.Size(85, 18);
            this.lblSummonedUnitRepeatMax.TabIndex = 6;
            this.lblSummonedUnitRepeatMax.Text = "Repeat Max:";
            // 
            // lblSummonedUnitId
            // 
            this.lblSummonedUnitId.AutoSize = true;
            this.lblSummonedUnitId.Location = new System.Drawing.Point(44, 70);
            this.lblSummonedUnitId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummonedUnitId.Name = "lblSummonedUnitId";
            this.lblSummonedUnitId.Size = new System.Drawing.Size(81, 18);
            this.lblSummonedUnitId.TabIndex = 4;
            this.lblSummonedUnitId.Text = "Creature Id:";
            // 
            // lblSummonedUnitRepeatMin
            // 
            this.lblSummonedUnitRepeatMin.AutoSize = true;
            this.lblSummonedUnitRepeatMin.Location = new System.Drawing.Point(40, 105);
            this.lblSummonedUnitRepeatMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummonedUnitRepeatMin.Name = "lblSummonedUnitRepeatMin";
            this.lblSummonedUnitRepeatMin.Size = new System.Drawing.Size(83, 18);
            this.lblSummonedUnitRepeatMin.TabIndex = 3;
            this.lblSummonedUnitRepeatMin.Text = "Repeat Min:";
            // 
            // lblEventSummonedUnitTooltip
            // 
            this.lblEventSummonedUnitTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventSummonedUnitTooltip.Location = new System.Drawing.Point(27, 12);
            this.lblEventSummonedUnitTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventSummonedUnitTooltip.Name = "lblEventSummonedUnitTooltip";
            this.lblEventSummonedUnitTooltip.Size = new System.Drawing.Size(604, 37);
            this.lblEventSummonedUnitTooltip.TabIndex = 0;
            this.lblEventSummonedUnitTooltip.Text = "Expires after summoning another creature with the given Id.";
            // 
            // frmEventReceiveEmote
            // 
            this.frmEventReceiveEmote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventReceiveEmote.Controls.Add(this.cmbReceiveEmoteId);
            this.frmEventReceiveEmote.Controls.Add(this.lblReceiveEmoteId);
            this.frmEventReceiveEmote.Controls.Add(this.lblEventReceiveEmoteTooltip);
            this.frmEventReceiveEmote.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEventReceiveEmote.Location = new System.Drawing.Point(577, 368);
            this.frmEventReceiveEmote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmEventReceiveEmote.Name = "frmEventReceiveEmote";
            this.frmEventReceiveEmote.Size = new System.Drawing.Size(659, 317);
            this.frmEventReceiveEmote.TabIndex = 66;
            this.frmEventReceiveEmote.Visible = false;
            // 
            // cmbReceiveEmoteId
            // 
            this.cmbReceiveEmoteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceiveEmoteId.FormattingEnabled = true;
            this.cmbReceiveEmoteId.Items.AddRange(new object[] {
            "Hostile",
            "Friendly"});
            this.cmbReceiveEmoteId.Location = new System.Drawing.Point(132, 67);
            this.cmbReceiveEmoteId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbReceiveEmoteId.Name = "cmbReceiveEmoteId";
            this.cmbReceiveEmoteId.Size = new System.Drawing.Size(499, 26);
            this.cmbReceiveEmoteId.TabIndex = 14;
            this.cmbReceiveEmoteId.SelectedIndexChanged += new System.EventHandler(this.cmbReceiveEmoteId_SelectedIndexChanged);
            // 
            // lblReceiveEmoteId
            // 
            this.lblReceiveEmoteId.AutoSize = true;
            this.lblReceiveEmoteId.Location = new System.Drawing.Point(60, 70);
            this.lblReceiveEmoteId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiveEmoteId.Name = "lblReceiveEmoteId";
            this.lblReceiveEmoteId.Size = new System.Drawing.Size(67, 18);
            this.lblReceiveEmoteId.TabIndex = 4;
            this.lblReceiveEmoteId.Text = "Emote Id:";
            // 
            // lblEventReceiveEmoteTooltip
            // 
            this.lblEventReceiveEmoteTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventReceiveEmoteTooltip.Location = new System.Drawing.Point(27, 12);
            this.lblEventReceiveEmoteTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventReceiveEmoteTooltip.Name = "lblEventReceiveEmoteTooltip";
            this.lblEventReceiveEmoteTooltip.Size = new System.Drawing.Size(604, 37);
            this.lblEventReceiveEmoteTooltip.TabIndex = 0;
            this.lblEventReceiveEmoteTooltip.Text = "Expires when the creature receives a text emote with the specified id.";
            // 
            // frmEventMovementInform
            // 
            this.frmEventMovementInform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventMovementInform.Controls.Add(this.cmbMovementInformType);
            this.frmEventMovementInform.Controls.Add(this.txtMovementInformRepeatMax);
            this.frmEventMovementInform.Controls.Add(this.lblMovementInformRepeatMax);
            this.frmEventMovementInform.Controls.Add(this.txtMovementInformRepeatMin);
            this.frmEventMovementInform.Controls.Add(this.txtMovementInformPoint);
            this.frmEventMovementInform.Controls.Add(this.lblMovementInformRepeatMin);
            this.frmEventMovementInform.Controls.Add(this.lblMovementInformType);
            this.frmEventMovementInform.Controls.Add(this.lblMovementInformPoint);
            this.frmEventMovementInform.Controls.Add(this.lblEventMovementInformTooltip);
            this.frmEventMovementInform.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEventMovementInform.Location = new System.Drawing.Point(577, 368);
            this.frmEventMovementInform.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmEventMovementInform.Name = "frmEventMovementInform";
            this.frmEventMovementInform.Size = new System.Drawing.Size(659, 317);
            this.frmEventMovementInform.TabIndex = 67;
            this.frmEventMovementInform.Visible = false;
            // 
            // cmbMovementInformType
            // 
            this.cmbMovementInformType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovementInformType.FormattingEnabled = true;
            this.cmbMovementInformType.Location = new System.Drawing.Point(132, 67);
            this.cmbMovementInformType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbMovementInformType.Name = "cmbMovementInformType";
            this.cmbMovementInformType.Size = new System.Drawing.Size(497, 26);
            this.cmbMovementInformType.TabIndex = 14;
            this.cmbMovementInformType.SelectedIndexChanged += new System.EventHandler(this.cmbMovementInformType_SelectedIndexChanged);
            // 
            // txtMovementInformRepeatMax
            // 
            this.txtMovementInformRepeatMax.Location = new System.Drawing.Point(132, 171);
            this.txtMovementInformRepeatMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMovementInformRepeatMax.Name = "txtMovementInformRepeatMax";
            this.txtMovementInformRepeatMax.Size = new System.Drawing.Size(497, 26);
            this.txtMovementInformRepeatMax.TabIndex = 12;
            this.txtMovementInformRepeatMax.Leave += new System.EventHandler(this.txtMovementInformRepeatMax_Leave);
            // 
            // lblMovementInformRepeatMax
            // 
            this.lblMovementInformRepeatMax.AutoSize = true;
            this.lblMovementInformRepeatMax.Location = new System.Drawing.Point(36, 174);
            this.lblMovementInformRepeatMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovementInformRepeatMax.Name = "lblMovementInformRepeatMax";
            this.lblMovementInformRepeatMax.Size = new System.Drawing.Size(85, 18);
            this.lblMovementInformRepeatMax.TabIndex = 11;
            this.lblMovementInformRepeatMax.Text = "Repeat Max:";
            // 
            // txtMovementInformRepeatMin
            // 
            this.txtMovementInformRepeatMin.Location = new System.Drawing.Point(132, 136);
            this.txtMovementInformRepeatMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMovementInformRepeatMin.Name = "txtMovementInformRepeatMin";
            this.txtMovementInformRepeatMin.Size = new System.Drawing.Size(497, 26);
            this.txtMovementInformRepeatMin.TabIndex = 10;
            this.txtMovementInformRepeatMin.Leave += new System.EventHandler(this.txtMovementInformRepeatMin_Leave);
            // 
            // txtMovementInformPoint
            // 
            this.txtMovementInformPoint.Location = new System.Drawing.Point(132, 102);
            this.txtMovementInformPoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMovementInformPoint.Name = "txtMovementInformPoint";
            this.txtMovementInformPoint.Size = new System.Drawing.Size(497, 26);
            this.txtMovementInformPoint.TabIndex = 9;
            this.txtMovementInformPoint.Leave += new System.EventHandler(this.txtMovementInformPoint_Leave);
            // 
            // lblMovementInformRepeatMin
            // 
            this.lblMovementInformRepeatMin.AutoSize = true;
            this.lblMovementInformRepeatMin.Location = new System.Drawing.Point(40, 140);
            this.lblMovementInformRepeatMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovementInformRepeatMin.Name = "lblMovementInformRepeatMin";
            this.lblMovementInformRepeatMin.Size = new System.Drawing.Size(83, 18);
            this.lblMovementInformRepeatMin.TabIndex = 6;
            this.lblMovementInformRepeatMin.Text = "Repeat Min:";
            // 
            // lblMovementInformType
            // 
            this.lblMovementInformType.AutoSize = true;
            this.lblMovementInformType.Location = new System.Drawing.Point(35, 70);
            this.lblMovementInformType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovementInformType.Name = "lblMovementInformType";
            this.lblMovementInformType.Size = new System.Drawing.Size(88, 18);
            this.lblMovementInformType.TabIndex = 4;
            this.lblMovementInformType.Text = "Motion Type:";
            // 
            // lblMovementInformPoint
            // 
            this.lblMovementInformPoint.AutoSize = true;
            this.lblMovementInformPoint.Location = new System.Drawing.Point(65, 105);
            this.lblMovementInformPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovementInformPoint.Name = "lblMovementInformPoint";
            this.lblMovementInformPoint.Size = new System.Drawing.Size(60, 18);
            this.lblMovementInformPoint.TabIndex = 3;
            this.lblMovementInformPoint.Text = "Point Id:";
            // 
            // lblEventMovementInformTooltip
            // 
            this.lblEventMovementInformTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEventMovementInformTooltip.Location = new System.Drawing.Point(27, 12);
            this.lblEventMovementInformTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventMovementInformTooltip.Name = "lblEventMovementInformTooltip";
            this.lblEventMovementInformTooltip.Size = new System.Drawing.Size(604, 37);
            this.lblEventMovementInformTooltip.TabIndex = 0;
            this.lblEventMovementInformTooltip.Text = "Expires upon reaching a waypoint or finishing point movement.";
            // 
            // frmEventGroupMemberDied
            // 
            this.frmEventGroupMemberDied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventGroupMemberDied.Controls.Add(this.cmbGroupMemberDiedIsLeader);
            this.frmEventGroupMemberDied.Controls.Add(this.btnGroupMemberDiedCreatureId);
            this.frmEventGroupMemberDied.Controls.Add(this.lblGroupMemberDiedCreatureId);
            this.frmEventGroupMemberDied.Controls.Add(this.lblGroupMemberDiedIsLeader);
            this.frmEventGroupMemberDied.Controls.Add(this.lblGroupMemberDiedTooltip);
            this.frmEventGroupMemberDied.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEventGroupMemberDied.Location = new System.Drawing.Point(577, 368);
            this.frmEventGroupMemberDied.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmEventGroupMemberDied.Name = "frmEventGroupMemberDied";
            this.frmEventGroupMemberDied.Size = new System.Drawing.Size(659, 317);
            this.frmEventGroupMemberDied.TabIndex = 68;
            this.frmEventGroupMemberDied.Visible = false;
            // 
            // cmbGroupMemberDiedIsLeader
            // 
            this.cmbGroupMemberDiedIsLeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupMemberDiedIsLeader.FormattingEnabled = true;
            this.cmbGroupMemberDiedIsLeader.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbGroupMemberDiedIsLeader.Location = new System.Drawing.Point(132, 102);
            this.cmbGroupMemberDiedIsLeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbGroupMemberDiedIsLeader.Name = "cmbGroupMemberDiedIsLeader";
            this.cmbGroupMemberDiedIsLeader.Size = new System.Drawing.Size(497, 26);
            this.cmbGroupMemberDiedIsLeader.TabIndex = 14;
            this.cmbGroupMemberDiedIsLeader.SelectedIndexChanged += new System.EventHandler(this.cmbGroupMemberDiedIsLeader_SelectedIndexChanged);
            // 
            // btnGroupMemberDiedCreatureId
            // 
            this.btnGroupMemberDiedCreatureId.Location = new System.Drawing.Point(132, 67);
            this.btnGroupMemberDiedCreatureId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGroupMemberDiedCreatureId.Name = "btnGroupMemberDiedCreatureId";
            this.btnGroupMemberDiedCreatureId.Size = new System.Drawing.Size(499, 27);
            this.btnGroupMemberDiedCreatureId.TabIndex = 13;
            this.btnGroupMemberDiedCreatureId.Text = "-NONE-";
            this.btnGroupMemberDiedCreatureId.UseVisualStyleBackColor = true;
            this.btnGroupMemberDiedCreatureId.Click += new System.EventHandler(this.btnGroupMemberDiedCreatureId_Click);
            // 
            // lblGroupMemberDiedCreatureId
            // 
            this.lblGroupMemberDiedCreatureId.AutoSize = true;
            this.lblGroupMemberDiedCreatureId.Location = new System.Drawing.Point(44, 70);
            this.lblGroupMemberDiedCreatureId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupMemberDiedCreatureId.Name = "lblGroupMemberDiedCreatureId";
            this.lblGroupMemberDiedCreatureId.Size = new System.Drawing.Size(81, 18);
            this.lblGroupMemberDiedCreatureId.TabIndex = 4;
            this.lblGroupMemberDiedCreatureId.Text = "Creature Id:";
            // 
            // lblGroupMemberDiedIsLeader
            // 
            this.lblGroupMemberDiedIsLeader.AutoSize = true;
            this.lblGroupMemberDiedIsLeader.Location = new System.Drawing.Point(55, 105);
            this.lblGroupMemberDiedIsLeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupMemberDiedIsLeader.Name = "lblGroupMemberDiedIsLeader";
            this.lblGroupMemberDiedIsLeader.Size = new System.Drawing.Size(67, 18);
            this.lblGroupMemberDiedIsLeader.TabIndex = 3;
            this.lblGroupMemberDiedIsLeader.Text = "Is Leader:";
            // 
            // lblGroupMemberDiedTooltip
            // 
            this.lblGroupMemberDiedTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGroupMemberDiedTooltip.Location = new System.Drawing.Point(27, 12);
            this.lblGroupMemberDiedTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupMemberDiedTooltip.Name = "lblGroupMemberDiedTooltip";
            this.lblGroupMemberDiedTooltip.Size = new System.Drawing.Size(604, 37);
            this.lblGroupMemberDiedTooltip.TabIndex = 0;
            this.lblGroupMemberDiedTooltip.Text = "Expires when a member of the creature\'s group dies. The group must have the appop" +
    "riate flag for the event to trigger.";
            // 
            // frmEventKilledUnit
            // 
            this.frmEventKilledUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventKilledUnit.Controls.Add(this.cmbKilledUnitTarget);
            this.frmEventKilledUnit.Controls.Add(this.txtKilledUnitRepeatMax);
            this.frmEventKilledUnit.Controls.Add(this.txtKilledUnitRepeatMin);
            this.frmEventKilledUnit.Controls.Add(this.lblKilledUnitRepeatMax);
            this.frmEventKilledUnit.Controls.Add(this.lblKilledUnitTarget);
            this.frmEventKilledUnit.Controls.Add(this.lblKilledUnitRepeatMin);
            this.frmEventKilledUnit.Controls.Add(this.lblKilledUnitTooltip);
            this.frmEventKilledUnit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEventKilledUnit.Location = new System.Drawing.Point(577, 368);
            this.frmEventKilledUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmEventKilledUnit.Name = "frmEventKilledUnit";
            this.frmEventKilledUnit.Size = new System.Drawing.Size(659, 317);
            this.frmEventKilledUnit.TabIndex = 69;
            this.frmEventKilledUnit.Visible = false;
            // 
            // cmbKilledUnitTarget
            // 
            this.cmbKilledUnitTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKilledUnitTarget.FormattingEnabled = true;
            this.cmbKilledUnitTarget.Items.AddRange(new object[] {
            "Any Unit",
            "Only Player"});
            this.cmbKilledUnitTarget.Location = new System.Drawing.Point(132, 67);
            this.cmbKilledUnitTarget.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbKilledUnitTarget.Name = "cmbKilledUnitTarget";
            this.cmbKilledUnitTarget.Size = new System.Drawing.Size(497, 26);
            this.cmbKilledUnitTarget.TabIndex = 14;
            this.cmbKilledUnitTarget.SelectedIndexChanged += new System.EventHandler(this.cmbKilledUnitTarget_SelectedIndexChanged);
            // 
            // txtKilledUnitRepeatMax
            // 
            this.txtKilledUnitRepeatMax.Location = new System.Drawing.Point(132, 136);
            this.txtKilledUnitRepeatMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKilledUnitRepeatMax.Name = "txtKilledUnitRepeatMax";
            this.txtKilledUnitRepeatMax.Size = new System.Drawing.Size(497, 26);
            this.txtKilledUnitRepeatMax.TabIndex = 10;
            this.txtKilledUnitRepeatMax.Leave += new System.EventHandler(this.txtKilledUnitRepeatMax_Leave);
            // 
            // txtKilledUnitRepeatMin
            // 
            this.txtKilledUnitRepeatMin.Location = new System.Drawing.Point(132, 102);
            this.txtKilledUnitRepeatMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKilledUnitRepeatMin.Name = "txtKilledUnitRepeatMin";
            this.txtKilledUnitRepeatMin.Size = new System.Drawing.Size(497, 26);
            this.txtKilledUnitRepeatMin.TabIndex = 9;
            this.txtKilledUnitRepeatMin.Leave += new System.EventHandler(this.txtKilledUnitRepeatMin_Leave);
            // 
            // lblKilledUnitRepeatMax
            // 
            this.lblKilledUnitRepeatMax.AutoSize = true;
            this.lblKilledUnitRepeatMax.Location = new System.Drawing.Point(36, 140);
            this.lblKilledUnitRepeatMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilledUnitRepeatMax.Name = "lblKilledUnitRepeatMax";
            this.lblKilledUnitRepeatMax.Size = new System.Drawing.Size(85, 18);
            this.lblKilledUnitRepeatMax.TabIndex = 6;
            this.lblKilledUnitRepeatMax.Text = "Repeat Max:";
            // 
            // lblKilledUnitTarget
            // 
            this.lblKilledUnitTarget.AutoSize = true;
            this.lblKilledUnitTarget.Location = new System.Drawing.Point(72, 70);
            this.lblKilledUnitTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilledUnitTarget.Name = "lblKilledUnitTarget";
            this.lblKilledUnitTarget.Size = new System.Drawing.Size(50, 18);
            this.lblKilledUnitTarget.TabIndex = 4;
            this.lblKilledUnitTarget.Text = "Target:";
            // 
            // lblKilledUnitRepeatMin
            // 
            this.lblKilledUnitRepeatMin.AutoSize = true;
            this.lblKilledUnitRepeatMin.Location = new System.Drawing.Point(40, 105);
            this.lblKilledUnitRepeatMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilledUnitRepeatMin.Name = "lblKilledUnitRepeatMin";
            this.lblKilledUnitRepeatMin.Size = new System.Drawing.Size(83, 18);
            this.lblKilledUnitRepeatMin.TabIndex = 3;
            this.lblKilledUnitRepeatMin.Text = "Repeat Min:";
            // 
            // lblKilledUnitTooltip
            // 
            this.lblKilledUnitTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKilledUnitTooltip.Location = new System.Drawing.Point(27, 12);
            this.lblKilledUnitTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilledUnitTooltip.Name = "lblKilledUnitTooltip";
            this.lblKilledUnitTooltip.Size = new System.Drawing.Size(604, 37);
            this.lblKilledUnitTooltip.TabIndex = 0;
            this.lblKilledUnitTooltip.Text = "Expires upon killing an unit.";
            // 
            // frmUnsupportedEvent
            // 
            this.frmUnsupportedEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmUnsupportedEvent.Controls.Add(this.txtUnkParam1);
            this.frmUnsupportedEvent.Controls.Add(this.txtUnkParam4);
            this.frmUnsupportedEvent.Controls.Add(this.lblUnkParam4);
            this.frmUnsupportedEvent.Controls.Add(this.txtUnkParam3);
            this.frmUnsupportedEvent.Controls.Add(this.txtUnkParam2);
            this.frmUnsupportedEvent.Controls.Add(this.lblUnkParam3);
            this.frmUnsupportedEvent.Controls.Add(this.lblUnkParam1);
            this.frmUnsupportedEvent.Controls.Add(this.lblUnkParam2);
            this.frmUnsupportedEvent.Controls.Add(this.lvlUnsupportedEventTooltip);
            this.frmUnsupportedEvent.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmUnsupportedEvent.Location = new System.Drawing.Point(577, 368);
            this.frmUnsupportedEvent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmUnsupportedEvent.Name = "frmUnsupportedEvent";
            this.frmUnsupportedEvent.Size = new System.Drawing.Size(659, 317);
            this.frmUnsupportedEvent.TabIndex = 70;
            this.frmUnsupportedEvent.Visible = false;
            // 
            // txtUnkParam1
            // 
            this.txtUnkParam1.Location = new System.Drawing.Point(132, 67);
            this.txtUnkParam1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUnkParam1.Name = "txtUnkParam1";
            this.txtUnkParam1.Size = new System.Drawing.Size(497, 26);
            this.txtUnkParam1.TabIndex = 1;
            this.txtUnkParam1.Leave += new System.EventHandler(this.txtUnkParam1_Leave);
            // 
            // txtUnkParam4
            // 
            this.txtUnkParam4.Location = new System.Drawing.Point(132, 171);
            this.txtUnkParam4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUnkParam4.Name = "txtUnkParam4";
            this.txtUnkParam4.Size = new System.Drawing.Size(497, 26);
            this.txtUnkParam4.TabIndex = 4;
            this.txtUnkParam4.Leave += new System.EventHandler(this.txtUnkParam4_Leave);
            // 
            // lblUnkParam4
            // 
            this.lblUnkParam4.AutoSize = true;
            this.lblUnkParam4.Location = new System.Drawing.Point(61, 174);
            this.lblUnkParam4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnkParam4.Name = "lblUnkParam4";
            this.lblUnkParam4.Size = new System.Drawing.Size(61, 18);
            this.lblUnkParam4.TabIndex = 8;
            this.lblUnkParam4.Text = "Param 4:";
            // 
            // txtUnkParam3
            // 
            this.txtUnkParam3.Location = new System.Drawing.Point(132, 136);
            this.txtUnkParam3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUnkParam3.Name = "txtUnkParam3";
            this.txtUnkParam3.Size = new System.Drawing.Size(497, 26);
            this.txtUnkParam3.TabIndex = 3;
            this.txtUnkParam3.Leave += new System.EventHandler(this.txtUnkParam3_Leave);
            // 
            // txtUnkParam2
            // 
            this.txtUnkParam2.Location = new System.Drawing.Point(132, 102);
            this.txtUnkParam2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUnkParam2.Name = "txtUnkParam2";
            this.txtUnkParam2.Size = new System.Drawing.Size(497, 26);
            this.txtUnkParam2.TabIndex = 2;
            this.txtUnkParam2.Leave += new System.EventHandler(this.txtUnkParam2_Leave);
            // 
            // lblUnkParam3
            // 
            this.lblUnkParam3.AutoSize = true;
            this.lblUnkParam3.Location = new System.Drawing.Point(61, 140);
            this.lblUnkParam3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnkParam3.Name = "lblUnkParam3";
            this.lblUnkParam3.Size = new System.Drawing.Size(61, 18);
            this.lblUnkParam3.TabIndex = 7;
            this.lblUnkParam3.Text = "Param 3:";
            // 
            // lblUnkParam1
            // 
            this.lblUnkParam1.AutoSize = true;
            this.lblUnkParam1.Location = new System.Drawing.Point(61, 70);
            this.lblUnkParam1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnkParam1.Name = "lblUnkParam1";
            this.lblUnkParam1.Size = new System.Drawing.Size(61, 18);
            this.lblUnkParam1.TabIndex = 5;
            this.lblUnkParam1.Text = "Param 1:";
            // 
            // lblUnkParam2
            // 
            this.lblUnkParam2.AutoSize = true;
            this.lblUnkParam2.Location = new System.Drawing.Point(61, 105);
            this.lblUnkParam2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnkParam2.Name = "lblUnkParam2";
            this.lblUnkParam2.Size = new System.Drawing.Size(61, 18);
            this.lblUnkParam2.TabIndex = 6;
            this.lblUnkParam2.Text = "Param 2:";
            // 
            // lvlUnsupportedEventTooltip
            // 
            this.lvlUnsupportedEventTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lvlUnsupportedEventTooltip.Location = new System.Drawing.Point(27, 12);
            this.lvlUnsupportedEventTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlUnsupportedEventTooltip.Name = "lvlUnsupportedEventTooltip";
            this.lvlUnsupportedEventTooltip.Size = new System.Drawing.Size(604, 37);
            this.lvlUnsupportedEventTooltip.TabIndex = 0;
            this.lvlUnsupportedEventTooltip.Text = "This event type is not currently supported by the editor.";
            // 
            // frmEventHitByAura
            // 
            this.frmEventHitByAura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmEventHitByAura.Controls.Add(this.cmbHitByAuraType);
            this.frmEventHitByAura.Controls.Add(this.txtHitByAuraRepeatMax);
            this.frmEventHitByAura.Controls.Add(this.lblHitByAuraRepeatMax);
            this.frmEventHitByAura.Controls.Add(this.txtHitByAuraRepeatMin);
            this.frmEventHitByAura.Controls.Add(this.txtHitByAuraUnused);
            this.frmEventHitByAura.Controls.Add(this.lblHitByAuraRepeatMin);
            this.frmEventHitByAura.Controls.Add(this.lblHitByAuraType);
            this.frmEventHitByAura.Controls.Add(this.lblHitByAuraUnused);
            this.frmEventHitByAura.Controls.Add(this.lblHitByAuraTooltip);
            this.frmEventHitByAura.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEventHitByAura.Location = new System.Drawing.Point(577, 368);
            this.frmEventHitByAura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmEventHitByAura.Name = "frmEventHitByAura";
            this.frmEventHitByAura.Size = new System.Drawing.Size(659, 317);
            this.frmEventHitByAura.TabIndex = 71;
            this.frmEventHitByAura.Visible = false;
            // 
            // cmbHitByAuraType
            // 
            this.cmbHitByAuraType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHitByAuraType.FormattingEnabled = true;
            this.cmbHitByAuraType.Location = new System.Drawing.Point(132, 67);
            this.cmbHitByAuraType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbHitByAuraType.Name = "cmbHitByAuraType";
            this.cmbHitByAuraType.Size = new System.Drawing.Size(497, 26);
            this.cmbHitByAuraType.TabIndex = 9;
            this.cmbHitByAuraType.SelectedIndexChanged += new System.EventHandler(this.cmbHitByAuraType_SelectedIndexChanged);
            // 
            // txtHitByAuraRepeatMax
            // 
            this.txtHitByAuraRepeatMax.Location = new System.Drawing.Point(132, 171);
            this.txtHitByAuraRepeatMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHitByAuraRepeatMax.Name = "txtHitByAuraRepeatMax";
            this.txtHitByAuraRepeatMax.Size = new System.Drawing.Size(497, 26);
            this.txtHitByAuraRepeatMax.TabIndex = 4;
            this.txtHitByAuraRepeatMax.Leave += new System.EventHandler(this.txtHitByAuraRepeatMax_Leave);
            // 
            // lblHitByAuraRepeatMax
            // 
            this.lblHitByAuraRepeatMax.AutoSize = true;
            this.lblHitByAuraRepeatMax.Location = new System.Drawing.Point(36, 174);
            this.lblHitByAuraRepeatMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHitByAuraRepeatMax.Name = "lblHitByAuraRepeatMax";
            this.lblHitByAuraRepeatMax.Size = new System.Drawing.Size(85, 18);
            this.lblHitByAuraRepeatMax.TabIndex = 8;
            this.lblHitByAuraRepeatMax.Text = "Repeat Max:";
            // 
            // txtHitByAuraRepeatMin
            // 
            this.txtHitByAuraRepeatMin.Location = new System.Drawing.Point(132, 136);
            this.txtHitByAuraRepeatMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHitByAuraRepeatMin.Name = "txtHitByAuraRepeatMin";
            this.txtHitByAuraRepeatMin.Size = new System.Drawing.Size(497, 26);
            this.txtHitByAuraRepeatMin.TabIndex = 3;
            this.txtHitByAuraRepeatMin.Leave += new System.EventHandler(this.txtHitByAuraRepeatMin_Leave);
            // 
            // txtHitByAuraUnused
            // 
            this.txtHitByAuraUnused.Enabled = false;
            this.txtHitByAuraUnused.Location = new System.Drawing.Point(132, 102);
            this.txtHitByAuraUnused.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHitByAuraUnused.Name = "txtHitByAuraUnused";
            this.txtHitByAuraUnused.Size = new System.Drawing.Size(497, 26);
            this.txtHitByAuraUnused.TabIndex = 2;
            // 
            // lblHitByAuraRepeatMin
            // 
            this.lblHitByAuraRepeatMin.AutoSize = true;
            this.lblHitByAuraRepeatMin.Location = new System.Drawing.Point(40, 140);
            this.lblHitByAuraRepeatMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHitByAuraRepeatMin.Name = "lblHitByAuraRepeatMin";
            this.lblHitByAuraRepeatMin.Size = new System.Drawing.Size(83, 18);
            this.lblHitByAuraRepeatMin.TabIndex = 7;
            this.lblHitByAuraRepeatMin.Text = "Repeat Min:";
            // 
            // lblHitByAuraType
            // 
            this.lblHitByAuraType.AutoSize = true;
            this.lblHitByAuraType.Location = new System.Drawing.Point(81, 70);
            this.lblHitByAuraType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHitByAuraType.Name = "lblHitByAuraType";
            this.lblHitByAuraType.Size = new System.Drawing.Size(41, 18);
            this.lblHitByAuraType.TabIndex = 5;
            this.lblHitByAuraType.Text = "Type:";
            // 
            // lblHitByAuraUnused
            // 
            this.lblHitByAuraUnused.AutoSize = true;
            this.lblHitByAuraUnused.Location = new System.Drawing.Point(64, 105);
            this.lblHitByAuraUnused.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHitByAuraUnused.Name = "lblHitByAuraUnused";
            this.lblHitByAuraUnused.Size = new System.Drawing.Size(59, 18);
            this.lblHitByAuraUnused.TabIndex = 6;
            this.lblHitByAuraUnused.Text = "Unused:";
            // 
            // lblHitByAuraTooltip
            // 
            this.lblHitByAuraTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHitByAuraTooltip.Location = new System.Drawing.Point(27, 12);
            this.lblHitByAuraTooltip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHitByAuraTooltip.Name = "lblHitByAuraTooltip";
            this.lblHitByAuraTooltip.Size = new System.Drawing.Size(604, 37);
            this.lblHitByAuraTooltip.TabIndex = 0;
            this.lblHitByAuraTooltip.Text = "Expires when the creature is hit by a spell that applies an aura of a specific ty" +
    "pe.";
            // 
            // FormEventEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1271, 732);
            this.Controls.Add(this.frmEventHitByAura);
            this.Controls.Add(this.frmUnsupportedEvent);
            this.Controls.Add(this.frmEventKilledUnit);
            this.Controls.Add(this.frmEventGroupMemberDied);
            this.Controls.Add(this.frmEventMovementInform);
            this.Controls.Add(this.frmEventReceiveEmote);
            this.Controls.Add(this.frmEventSummonedUnit);
            this.Controls.Add(this.frmEventEnterLOS);
            this.Controls.Add(this.frmEventSpellHit);
            this.Controls.Add(this.frmEventAggro);
            this.Controls.Add(this.btnViewRaw);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEventCopy);
            this.Controls.Add(this.btnEventAdd);
            this.Controls.Add(this.btnEventDelete);
            this.Controls.Add(this.lblCurrentCreature);
            this.Controls.Add(this.frmEventTimerCombat);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.lblCreatureId);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtCreatureId);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.lblNoEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormEventEditor";
            this.Padding = new System.Windows.Forms.Padding(4, 74, 4, 3);
            this.Text = "Event Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEventEditor_FormClosing);
            this.Load += new System.EventHandler(this.FormEventEditor_Load);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpEventFlags.ResumeLayout(false);
            this.grpEventFlags.PerformLayout();
            this.frmEventTimerCombat.ResumeLayout(false);
            this.frmEventTimerCombat.PerformLayout();
            this.frmEventAggro.ResumeLayout(false);
            this.frmEventSpellHit.ResumeLayout(false);
            this.frmEventSpellHit.PerformLayout();
            this.frmEventEnterLOS.ResumeLayout(false);
            this.frmEventEnterLOS.PerformLayout();
            this.frmEventSummonedUnit.ResumeLayout(false);
            this.frmEventSummonedUnit.PerformLayout();
            this.frmEventReceiveEmote.ResumeLayout(false);
            this.frmEventReceiveEmote.PerformLayout();
            this.frmEventMovementInform.ResumeLayout(false);
            this.frmEventMovementInform.PerformLayout();
            this.frmEventGroupMemberDied.ResumeLayout(false);
            this.frmEventGroupMemberDied.PerformLayout();
            this.frmEventKilledUnit.ResumeLayout(false);
            this.frmEventKilledUnit.PerformLayout();
            this.frmUnsupportedEvent.ResumeLayout(false);
            this.frmUnsupportedEvent.PerformLayout();
            this.frmEventHitByAura.ResumeLayout(false);
            this.frmEventHitByAura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstEvents;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.TextBox txtCreatureId;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblCreatureId;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblEventId;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.Button btnEventCondition;
        private System.Windows.Forms.Label lblEventPhaseMask;
        private System.Windows.Forms.Label lblEventChance;
        private System.Windows.Forms.TextBox txtEventChance;
        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblEventCondition;
        private System.Windows.Forms.GroupBox grpEventFlags;
        private System.Windows.Forms.Button btnEditScript3;
        private System.Windows.Forms.Button btnEditScript2;
        private System.Windows.Forms.Button btnEditScript1;
        private System.Windows.Forms.TextBox txtScriptId3;
        private System.Windows.Forms.TextBox txtScriptId2;
        private System.Windows.Forms.TextBox txtScriptId1;
        private System.Windows.Forms.Label lblEventComment;
        private System.Windows.Forms.TextBox txtEventComment;
        private System.Windows.Forms.Label lblScriptId3;
        private System.Windows.Forms.Label lblScriptId2;
        private System.Windows.Forms.Label lblScriptId1;
        private System.Windows.Forms.CheckBox chkEventFlag1;
        private System.Windows.Forms.CheckBox chkEventFlag4;
        private System.Windows.Forms.CheckBox chkEventFlag2;
        private System.Windows.Forms.Panel frmEventTimerCombat;
        private System.Windows.Forms.Label lblTimerRepeatMin;
        private System.Windows.Forms.Label lblTimerInitialMin;
        private System.Windows.Forms.Label lblTimerInitialMax;
        private System.Windows.Forms.Label lblEventTimerCombatTooltip;
        private System.Windows.Forms.Label lblCurrentCreature;
        private System.Windows.Forms.Button btnEventCopy;
        private System.Windows.Forms.Button btnEventAdd;
        private System.Windows.Forms.Button btnEventDelete;
        private System.Windows.Forms.Button btnViewRaw;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTimerInitialMin;
        private System.Windows.Forms.TextBox txtTimerRepeatMin;
        private System.Windows.Forms.TextBox txtTimerInitialMax;
        private System.Windows.Forms.TextBox txtTimerRepeatMax;
        private System.Windows.Forms.Label lblTimerRepeatMax;
        private System.Windows.Forms.Label lblNoEvent;
        private System.Windows.Forms.Panel frmEventAggro;
        private System.Windows.Forms.Label lblEventAggroTooltip;
        private System.Windows.Forms.Panel frmEventSpellHit;
        private System.Windows.Forms.Button btnSpellHitSpellId;
        private System.Windows.Forms.TextBox txtSpellHitRepeatMax;
        private System.Windows.Forms.Label lblSpellHitRepeatMax;
        private System.Windows.Forms.TextBox txtSpellHitRepeatMin;
        private System.Windows.Forms.TextBox txtSpellHitSchoolMask;
        private System.Windows.Forms.Label lblSpellHitRepeatMin;
        private System.Windows.Forms.Label lblSpellHitSpellId;
        private System.Windows.Forms.Label lblSpellHitSchoolMask;
        private System.Windows.Forms.Label lblEventSpellHitTooltip;
        private System.Windows.Forms.Button btnEventPhaseMask;
        private System.Windows.Forms.Panel frmEventEnterLOS;
        private System.Windows.Forms.ComboBox cmbEnterLOSFaction;
        private System.Windows.Forms.TextBox txtEnterLOSRepeatMax;
        private System.Windows.Forms.Label lblEnterLOSRepeatMax;
        private System.Windows.Forms.TextBox txtEnterLOSRepeatMin;
        private System.Windows.Forms.TextBox txtEnterLOSDistance;
        private System.Windows.Forms.Label lblEnterLOSRepeatMin;
        private System.Windows.Forms.Label lblEnterLOSFaction;
        private System.Windows.Forms.Label lblEnterLOSDistance;
        private System.Windows.Forms.Label lblEventEnterLOSTooltip;
        private System.Windows.Forms.Panel frmEventSummonedUnit;
        private System.Windows.Forms.Button btnSummonedUnitId;
        private System.Windows.Forms.TextBox txtSummonedUnitRepeatMax;
        private System.Windows.Forms.TextBox txtSummonedUnitRepeatMin;
        private System.Windows.Forms.Label lblSummonedUnitRepeatMax;
        private System.Windows.Forms.Label lblSummonedUnitId;
        private System.Windows.Forms.Label lblSummonedUnitRepeatMin;
        private System.Windows.Forms.Label lblEventSummonedUnitTooltip;
        private System.Windows.Forms.Panel frmEventReceiveEmote;
        private System.Windows.Forms.ComboBox cmbReceiveEmoteId;
        private System.Windows.Forms.Label lblReceiveEmoteId;
        private System.Windows.Forms.Label lblEventReceiveEmoteTooltip;
        private System.Windows.Forms.Panel frmEventMovementInform;
        private System.Windows.Forms.ComboBox cmbMovementInformType;
        private System.Windows.Forms.TextBox txtMovementInformRepeatMax;
        private System.Windows.Forms.Label lblMovementInformRepeatMax;
        private System.Windows.Forms.TextBox txtMovementInformRepeatMin;
        private System.Windows.Forms.TextBox txtMovementInformPoint;
        private System.Windows.Forms.Label lblMovementInformRepeatMin;
        private System.Windows.Forms.Label lblMovementInformType;
        private System.Windows.Forms.Label lblMovementInformPoint;
        private System.Windows.Forms.Label lblEventMovementInformTooltip;
        private System.Windows.Forms.Panel frmEventGroupMemberDied;
        private System.Windows.Forms.ComboBox cmbGroupMemberDiedIsLeader;
        private System.Windows.Forms.Button btnGroupMemberDiedCreatureId;
        private System.Windows.Forms.Label lblGroupMemberDiedCreatureId;
        private System.Windows.Forms.Label lblGroupMemberDiedIsLeader;
        private System.Windows.Forms.Label lblGroupMemberDiedTooltip;
        private System.Windows.Forms.Panel frmEventKilledUnit;
        private System.Windows.Forms.ComboBox cmbKilledUnitTarget;
        private System.Windows.Forms.TextBox txtKilledUnitRepeatMax;
        private System.Windows.Forms.TextBox txtKilledUnitRepeatMin;
        private System.Windows.Forms.Label lblKilledUnitRepeatMax;
        private System.Windows.Forms.Label lblKilledUnitTarget;
        private System.Windows.Forms.Label lblKilledUnitRepeatMin;
        private System.Windows.Forms.Label lblKilledUnitTooltip;
        private System.Windows.Forms.Panel frmUnsupportedEvent;
        private System.Windows.Forms.TextBox txtUnkParam1;
        private System.Windows.Forms.TextBox txtUnkParam4;
        private System.Windows.Forms.Label lblUnkParam4;
        private System.Windows.Forms.TextBox txtUnkParam3;
        private System.Windows.Forms.TextBox txtUnkParam2;
        private System.Windows.Forms.Label lblUnkParam3;
        private System.Windows.Forms.Label lblUnkParam1;
        private System.Windows.Forms.Label lblUnkParam2;
        private System.Windows.Forms.Label lvlUnsupportedEventTooltip;
        private System.Windows.Forms.Panel frmEventHitByAura;
        private System.Windows.Forms.ComboBox cmbHitByAuraType;
        private System.Windows.Forms.TextBox txtHitByAuraRepeatMax;
        private System.Windows.Forms.Label lblHitByAuraRepeatMax;
        private System.Windows.Forms.TextBox txtHitByAuraRepeatMin;
        private System.Windows.Forms.TextBox txtHitByAuraUnused;
        private System.Windows.Forms.Label lblHitByAuraRepeatMin;
        private System.Windows.Forms.Label lblHitByAuraType;
        private System.Windows.Forms.Label lblHitByAuraUnused;
        private System.Windows.Forms.Label lblHitByAuraTooltip;
    }
}