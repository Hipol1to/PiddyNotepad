namespace PiddyNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog piddy = new OpenFileDialog();
            piddy.Title = "Abrir";
            piddy.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (piddy.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(piddy.FileName, RichTextBoxStreamType.PlainText);
            this.Text = piddy.FileName;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog piddy = new SaveFileDialog();
            piddy.Title = "Abrir";
            piddy.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (piddy.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(piddy.FileName, RichTextBoxStreamType.PlainText);
            this.Text = piddy.FileName;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fechaHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = font.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog font = new ColorDialog();
            if(font.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = font.Color;
        }
    }
}