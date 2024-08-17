using System.Drawing.Text;
using System.Text.Json;

// Todo: replace the listbox with smth else that can display the ID and the Header at the same time.
//       Prevent empty notes from being created
//       Add Metadata: Time created
//       Implement saving and Loading to SQLite table instead of JSON
//       Program Settings (save path, load path), Save and Load program settings on exit/start

namespace OrganizedotNet {
    public partial class Main : Form {
        // public vars
        public List<Note> notes = new List<Note>();
        public int selectedNoteId;
        public string serializedNotes;
        public string filenameJson = "notes.json";

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
            ChangeStatusLabel($"Created Note \"{notes[notes.Count - 1].NoteHeader}\".");

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

            File.WriteAllText(filenameJson, serializedNotes);
        }

        private void btn_open_Click(object sender, EventArgs e) {
            LoadNotes();
        }

        public void ChangeStatusLabel(string newStatus) {
            lbl_status.Text = newStatus;
        }

        public void AddToStatusLabel(string newStatus) {
            string _tmp = lbl_status.Text ?? "";
            lbl_status.Text = _tmp + "," + newStatus;
        }

        public bool LoadNotesFile() {
            // read the json file
            try {
                serializedNotes = File.ReadAllText(filenameJson);
            } catch(FileNotFoundException ex) {
                ChangeStatusLabel($"The file {filenameJson} was not found.");
                return false;
            } catch(Exception ex) {
                ChangeStatusLabel($"General error while loading occurred.");
                return false;
            }

            return true;
        }

        public void ParseNotesFile() {
            // deserialize from Json and create notes
            try {
                foreach(Note _note in JsonSerializer.Deserialize<List<Note>>(serializedNotes, new JsonSerializerOptions() { WriteIndented = true })) { // any clue how to fix the green lines here?
                    notes.Add(_note);
                }
            } catch(JsonException ex) {
                ChangeStatusLabel("Error while parsing json file. Json might be malformed.");
            } catch(Exception ex) {
                ChangeStatusLabel("General error while parsing json file occurred.");
            }

            notesBindingSource.ResetBindings(false);
        }

        public void LoadNotes() {
            bool LoadFile = LoadNotesFile();

            if(LoadFile) {
                ParseNotesFile();
            }
        }

        private void btn_find_Click(object sender, EventArgs e) {
            string searchString = tb_search.Text;
            Note test = new Note();

            try {
                test = notes.Find(x => x.NoteHeader.Contains(searchString));
            } catch(Exception ex) {
                ChangeStatusLabel($"Error while searching.");
            }

            if(test != null) {
                ChangeStatusLabel($"Note found at ID: {test.NoteID}");
            } else {
                ChangeStatusLabel($"Couldnt find a Note with specified Header \"{searchString}\"");
            }

        }
    }

    public class Note {
        public string NoteText { get; set; }
        public int NoteID { get; set; }
        public string NoteHeader { get; set; } 
    }
}
