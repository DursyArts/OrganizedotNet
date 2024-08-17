
namespace OrganizedotNet {
    partial class Main {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lbl_status = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btn_saveNotes = new ToolStripButton();
            btn_open = new ToolStripButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            btn_find = new Button();
            tb_search = new TextBox();
            lb_notes = new ListBox();
            btn_delete = new Button();
            btn_replace = new Button();
            btn_addNote = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            lbl_noteId = new Label();
            label2 = new Label();
            label1 = new Label();
            rtb_noteText = new RichTextBox();
            tb_NoteHeader = new TextBox();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lbl_status });
            statusStrip1.Location = new Point(0, 497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(718, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(42, 17);
            toolStripStatusLabel1.Text = "Status:";
            // 
            // lbl_status
            // 
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(12, 17);
            lbl_status.Text = "/";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_saveNotes, btn_open });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(718, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_saveNotes
            // 
            btn_saveNotes.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_saveNotes.Image = (Image) resources.GetObject("btn_saveNotes.Image");
            btn_saveNotes.ImageTransparentColor = Color.Magenta;
            btn_saveNotes.Name = "btn_saveNotes";
            btn_saveNotes.Size = new Size(34, 22);
            btn_saveNotes.Text = "save";
            btn_saveNotes.Click += btn_saveNotes_Click;
            // 
            // btn_open
            // 
            btn_open.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_open.Image = (Image) resources.GetObject("btn_open.Image");
            btn_open.ImageTransparentColor = Color.Magenta;
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(38, 22);
            btn_open.Text = "open";
            btn_open.Click += btn_open_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(718, 472);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(710, 444);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Notes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btn_find);
            splitContainer1.Panel1.Controls.Add(tb_search);
            splitContainer1.Panel1.Controls.Add(lb_notes);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btn_delete);
            splitContainer1.Panel2.Controls.Add(btn_replace);
            splitContainer1.Panel2.Controls.Add(btn_addNote);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(704, 438);
            splitContainer1.SplitterDistance = 218;
            splitContainer1.TabIndex = 0;
            // 
            // btn_find
            // 
            btn_find.BackgroundImageLayout = ImageLayout.Zoom;
            btn_find.Location = new Point(163, 412);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(52, 23);
            btn_find.TabIndex = 2;
            btn_find.Text = "find";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += btn_find_Click;
            // 
            // tb_search
            // 
            tb_search.Location = new Point(3, 412);
            tb_search.Name = "tb_search";
            tb_search.PlaceholderText = "Search Note";
            tb_search.Size = new Size(154, 23);
            tb_search.TabIndex = 1;
            // 
            // lb_notes
            // 
            lb_notes.FormattingEnabled = true;
            lb_notes.ItemHeight = 15;
            lb_notes.Location = new Point(0, 0);
            lb_notes.MultiColumn = true;
            lb_notes.Name = "lb_notes";
            lb_notes.Size = new Size(218, 409);
            lb_notes.TabIndex = 0;
            lb_notes.SelectedIndexChanged += lb_notes_SelectedIndexChanged;
            // 
            // btn_delete
            // 
            btn_delete.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
            btn_delete.Location = new Point(194, 412);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_replace
            // 
            btn_replace.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
            btn_replace.Location = new Point(84, 412);
            btn_replace.Name = "btn_replace";
            btn_replace.Size = new Size(104, 23);
            btn_replace.TabIndex = 2;
            btn_replace.Text = "replace current";
            btn_replace.UseVisualStyleBackColor = true;
            btn_replace.Click += btn_replace_Click;
            // 
            // btn_addNote
            // 
            btn_addNote.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
            btn_addNote.Location = new Point(3, 412);
            btn_addNote.Name = "btn_addNote";
            btn_addNote.Size = new Size(75, 23);
            btn_addNote.TabIndex = 1;
            btn_addNote.Text = "add new";
            btn_addNote.UseVisualStyleBackColor = true;
            btn_addNote.Click += btn_addNote_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbl_noteId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rtb_noteText);
            groupBox1.Controls.Add(tb_NoteHeader);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 403);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Content";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 369);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "NoteID:";
            // 
            // lbl_noteId
            // 
            lbl_noteId.AutoSize = true;
            lbl_noteId.Location = new Point(89, 369);
            lbl_noteId.Name = "lbl_noteId";
            lbl_noteId.Size = new Size(18, 15);
            lbl_noteId.TabIndex = 4;
            lbl_noteId.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Note Text:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "Note Header:";
            // 
            // rtb_noteText
            // 
            rtb_noteText.Location = new Point(89, 51);
            rtb_noteText.Name = "rtb_noteText";
            rtb_noteText.Size = new Size(381, 315);
            rtb_noteText.TabIndex = 1;
            rtb_noteText.Text = "";
            // 
            // tb_NoteHeader
            // 
            tb_NoteHeader.Location = new Point(89, 22);
            tb_NoteHeader.Name = "tb_NoteHeader";
            tb_NoteHeader.Size = new Size(381, 23);
            tb_NoteHeader.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 519);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Main";
            Text = "Notes";
            Load += Main_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer splitContainer1;
        private ListBox lb_notes;
        private GroupBox groupBox1;
        private Button btn_delete;
        private Button btn_replace;
        private Button btn_addNote;
        private Label label4;
        private Label lbl_noteId;
        private Label label2;
        private Label label1;
        private RichTextBox rtb_noteText;
        private TextBox tb_NoteHeader;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lbl_status;
        private ToolStripButton btn_saveNotes;
        private ToolStripButton btn_open;
        private Button btn_find;
        private TextBox tb_search;
    }
}
