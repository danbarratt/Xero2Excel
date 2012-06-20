using System.Windows.Forms;
using Xero2Excel.Contracts.Interfaces;

namespace Xero2Excel.Core.UI
{
    public partial class ConfigurationForm : Form
    {
        private readonly IServiceLocator _serviceLocator;

        public ConfigurationForm()
        {
            InitializeComponent();
        }

        public ConfigurationForm(IServiceLocator serviceLocator) : this()
        {
            _serviceLocator = serviceLocator;
        }

        private void ConfigurationForm_Load(object sender, System.EventArgs e)
        {
            var configuration = _serviceLocator.Get<IConnectionManager>();

            if (!configuration.VerifyConnection())
            {
                notConnectedPanel.Visible = true;
            }
        }

        private void connectButton_Click(object sender, System.EventArgs e)
        {

        }
        
    }
}
