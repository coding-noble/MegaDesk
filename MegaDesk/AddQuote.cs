using System;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            cancelButton.CausesValidation = false;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            MegaDesk viewMegaDeskForm = (MegaDesk)Tag;
            viewMegaDeskForm.Show();
            base.OnFormClosed(e);
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            MegaDesk viewMegaDeskForm = (MegaDesk)Tag;
            viewMegaDeskForm.Show();
            this.Close();
        }

        private void widthSelection_Validating(object sender, System.ComponentModel.CancelEventArgs cancelEventArgs)
        {
            widthInvalidType.Visible = !Int32.TryParse(widthSelection.Text, out int var);
            if (widthInvalidType.Visible == false)
            {
                widthToSmallLabel.Visible = Int32.Parse(widthSelection.Text) < Desk.MINWIDTH;
                widthToBigLabel.Visible = Int32.Parse(widthSelection.Text) > Desk.MAXWIDTH;
            }
        }

        private void depthSelection_KeyUp(object sender, KeyEventArgs e)
        {
            depthTypeInvalid.Visible = !Int32.TryParse(depthSelection.Text, out int val);
            if (depthTypeInvalid.Visible == false)
            {
                depthToBigLabel.Visible = Int32.Parse(depthSelection.Text) > Desk.MAXDEPTH;
                depthToSmallLabel.Visible = Int32.Parse(depthSelection.Text) < Desk.MINDEPTH;
            }
        }

        private void numDrawersSelection_Validating(object sender, System.ComponentModel.CancelEventArgs cancelEventArgs)
        {
            materialTypeInvalid.Visible = !Int32.TryParse(numDrawersSelection.Text, out int var);
            if (materialTypeInvalid.Visible == false)
            {
                tooManyDrawersLabel.Visible = Int32.Parse(numDrawersSelection.Text) > Desk.MAXDRAWERCOUNT;
                notEnoughDrawersLabel.Visible = Int32.Parse(numDrawersSelection.Text) < Desk.MINDRAWERCOUNT;
            }
        }

        private void rushDaySelection_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            rushInvalidType.Visible = !Int32.TryParse(rushDaySelection.Text, out int var);
        }

        private void submitButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Desk newDesk = new Desk(
                    Int32.Parse(widthSelection.Text),
                    Int32.Parse(depthSelection.Text),
                    Int32.Parse(numDrawersSelection.Text),
                    materialSelection.Text);

                DeskQuote newDeskQuote = new DeskQuote(
                    nameInput.Text,
                    newDesk,
                    Int32.Parse(rushDaySelection.Text));

                DisplayQuote displayQuote = new DisplayQuote(newDeskQuote);
                displayQuote.Show();

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show($"Error: Please fill out all parts of the form with valid information.");
            }
        }
    }
}