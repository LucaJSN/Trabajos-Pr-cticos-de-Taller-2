using Microsoft.VisualBasic;

namespace Practico3
{
    public partial class PequeñoFormulario : Form
    {
        public PequeñoFormulario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsAsciiLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsAsciiLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TDni.Text == "" || TNombre.Text == "" || TApellido.Text == "")
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask;
                ask = MessageBox.Show(
                    "Seguro que quieres inserta un nuevo cliente?",
                    "Confirma Insercion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (ask == DialogResult.Yes)
                {
                    LModificar.Text = TApellido.Text + " " + TNombre.Text;
                    DialogResult result = MessageBox.Show(
                        "El cliente: " + LModificar.Text + " se insertó correctamente",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (TDni.Text == "" || TNombre.Text == "" || TApellido.Text == "")
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult ask;
                ask = MessageBox.Show(
                    "Seguro que quieres eliminar a " + LModificar.Text,
                    "Confirma Eliminacion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {
                    LModificar.Text = "Modificar";
                    TDni.Clear();
                    TApellido.Clear();
                    TNombre.Clear();
                    DialogResult result = MessageBox.Show(
                        "El cliente se eliminó correctamente",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LTitulo_Click(object sender, EventArgs e)
        {

        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.Varon;
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.Mujer;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
