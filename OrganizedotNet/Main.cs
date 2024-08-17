using System.Drawing.Text;
using System.Text.Json;

namespace OrganizedotNet {
    public partial class Main : Form {
        // public vars
        public List<Note> notes = new List<Note>();
        public int selectedNoteId;
        public string serializedNotes;

        private BindingSource notesBindingSource = new BindingSource(); // Add a BindingSource

        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            notesBindingSource.DataSource = notes;

            // Bind the ListBox to the BindingSource
            lb_notes.DataSource = notesBindingSource;
            lb_notes.DisplayMember = "NoteHeader"; // Display the NoteHeader
            lb_notes.ValueMember = "NoteID";
        }

        private void btn_addNote_Click(object sender, EventArgs e) {
            notes.Add(new Note() { NoteHeader = tb_NoteHeader.Text, NoteID = notes.Count, NoteText = rtb_noteText.Text });

            notesBindingSource.ResetBindings(false);

            tb_NoteHeader.Clear();
            rtb_noteText.Clear();
        }

        private void lb_notes_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                selectedNoteId = lb_notes.SelectedIndex;
                tb_NoteHeader.Text = notes[selectedNoteId].NoteHeader;
                rtb_noteText.Text = notes[selectedNoteId].NoteText;
                lbl_noteId.Text = notes[selectedNoteId].NoteID.ToString();
            } catch(ArgumentException ex) {
                lbl_status.Text = ex.Message;
            } catch(Exception ex) {
                lbl_status.Text += " & " + ex.Message;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e) {
            notes.RemoveAt(selectedNoteId);

            notesBindingSource.ResetBindings(false);

            tb_NoteHeader.Clear();
            rtb_noteText.Clear();
        }

        private void btn_replace_Click(object sender, EventArgs e) {
            notes[selectedNoteId].NoteText = rtb_noteText.Text;
            notes[selectedNoteId].NoteHeader = tb_NoteHeader.Text;

            notesBindingSource.ResetBindings(false);
        }

        private void btn_saveNotes_Click(object sender, EventArgs e) {
            // serialize the notes List as json and save that
            serializedNotes = JsonSerializer.Serialize<List<Note>>(notes, new JsonSerializerOptions() { WriteIndented = true });

            File.WriteAllText("notes.json", serializedNotes);
        }

        private void btn_open_Click(object sender, EventArgs e) {
            // read the json file
            serializedNotes = File.ReadAllText("notes.json");

            // deserialize from Json and create notes
            try {
                foreach(Note _note in JsonSerializer.Deserialize<List<Note>>(serializedNotes, new JsonSerializerOptions() { WriteIndented = true })) { // any clue how to fix the green lines here?
                    notes.Add(_note);
                }
            } catch(Exception ex) {
                lbl_status.Text = ex.Message;
            }

            notesBindingSource.ResetBindings(false);

        }
    }

    public class Note {
        public string NoteText { get; set; }
        public int NoteID { get; set; }
        public string NoteHeader { get; set; } 
    }
}
