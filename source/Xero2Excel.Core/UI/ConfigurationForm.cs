using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Xero2Excel.Contracts.Interfaces;
using Xero2Excel.Core.Utilitys;

namespace Xero2Excel.Core.UI
{
    public partial class ConfigurationForm : Form
    {
        private readonly IConnectionManager _connectionManager;

        public ConfigurationForm()
        {
            InitializeComponent();
        }

        public ConfigurationForm(IConnectionManager connectionManager)
            : this()
        {
            _connectionManager = connectionManager;
        }

        private void ConfigurationFormLoad(object sender, System.EventArgs e)
        {
            if (!_connectionManager.VerifyConnection())
            {
                ShowPanel(NotConnectedPanel, new Point(6, 86));
            }
            else
            {
                ShowPanel(ConnectionDetailsPanel, new Point(6, 9));
                RefreshCurrentConnectionDetails();
            }
        }

        private void ConnectButtonClick(object sender, System.EventArgs e)
        {
            var authorisationUri = _connectionManager.InitialiseConnection();

            System.Diagnostics.Process.Start(authorisationUri.ToString());

            ShowPanel(VerificationCodePanel, new Point(6, 86));
        }
       
        private void ShowPanel(Panel panel, Point atLocation = default(Point))
        {
            if (atLocation != default(Point))
            {
                panel.Location = atLocation;
            }

            var all = AllPanels().ToList();

            all.Where(p => !p.Equals(panel)).ForEach(p => p.Hide());
            all.Where(p => p.Equals(panel)).ForEach(p => p.Show());
        }

        private IEnumerable<Panel> AllPanels()
        {
            yield return VerificationCodePanel;
            yield return NotConnectedPanel;
            yield return ConnectionDetailsPanel;
        }

        private void CancelAuthorisationCodeButtonClick(object sender, System.EventArgs e)
        {
            _connectionManager.ResetConnection();

            ShowPanel(NotConnectedPanel, new Point(6, 86));
        }

        private void ConfirmAuthorisationCodeButtonClick(object sender, System.EventArgs e)
        {
            var authorisationCode = authorisationCodeTextBox.Text;

            _connectionManager.FinaliseConnection(authorisationCode);

            ShowPanel(ConnectionDetailsPanel, new Point(6, 9));

            RefreshCurrentConnectionDetails();
        }

        private void RefreshCurrentConnectionDetails()
        {
            var details = _connectionManager.GetCurrentConnectionDetails();

            currentAuthorisationExpiresTextBox.Text = details.AccessTokenExpiresUtc.FormatUtcTimeForUser();
            currentAuthorisationGrantedTextBox.Text = details.AccessTokenCreatedUtc.FormatUtcTimeForUser();
            currentAccessTokenTextBox.Text = details.AccessToken;
            currentOrganisationNameTextbox.Text = details.OrganisationName;
        }

        private void DisconnectButtonClick(object sender, System.EventArgs e)
        {
            _connectionManager.ResetConnection();

            ShowPanel(NotConnectedPanel, new Point(6, 86));
        }
    }
}
