using System;
using System.Windows.Forms;
using TsSoft.AspNet.Utils.Services;

namespace TsSoft.AspNet.Utils
{
    public partial class GeneratorForm : Form
    {
        private readonly IPasswordGenerator _passwordGenerator;

        public GeneratorForm(IPasswordGenerator passwordGenerator)
        {
            _passwordGenerator = passwordGenerator;
            InitializeComponent();
            providerTypeComboBox.DataSource = Enum.GetValues(typeof (MembershipProviderType));
            providerTypeComboBox.SelectedIndex = 0;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var input = inputPasswordTextBox.Text;
            if (string.IsNullOrEmpty(input))
            {
                return;
            }
            var generateResult = _passwordGenerator.Generate(input, providerTypeComboBox.SelectedItem.ToString());
            outputPasswordTextBox.Text = generateResult;
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputPasswordTextBox.Text);
        }
    }
}
