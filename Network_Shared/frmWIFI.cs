using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// importation supplementaire
using System.Diagnostics;
using System.Security.Principal;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;

namespace Network_Shared
{
    public partial class frmWIFI : Form
    {
        // declaration de la variable du tye process
        Process NewProcess = new Process();

        public frmWIFI()
        {
            NewProcess.StartInfo.UseShellExecute = false;
            NewProcess.StartInfo.CreateNoWindow = true;
            NewProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            InitializeComponent();
        }

        public bool IsUserAdmin()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.AccountOperator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }
     
        private void ENEABLED()
        {
            txtNom.Enabled = true;
            txtPWD.Enabled = true;
            chkPartager.Enabled = true;
            cbListNetwork.Enabled = true;
            chkVisual.Enabled = true;
        }

        private void DESEABLED()
        {
            txtNom.Enabled = false;
            txtPWD.Enabled = false;
            chkPartager.Enabled = false;
            cbListNetwork.Enabled = false;
            chkVisual.Enabled = false;
        }

        public void StopBrodCasting()
        {
            NewProcess.StartInfo.FileName = "netsh";
            NewProcess.StartInfo.Arguments = "wlan stop hostednetwork";

            try
            {
                using (Process execute = Process.Start(NewProcess.StartInfo))
                {
                    execute.WaitForExit();
                    SetLanDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetLanDetails()
        {
            NewProcess.StartInfo.FileName = "netsh";
            NewProcess.StartInfo.Arguments = "wlan set hostednetwork mode=allow ssid=" + txtNom.Text + " key=" + txtPWD.Text;

            try
            {
                using (Process execute = Process.Start(NewProcess.StartInfo))
                {
                    execute.WaitForExit();
                    StartBrodCasting();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StartBrodCasting()
        {
            NewProcess.StartInfo.FileName = "netsh";
            NewProcess.StartInfo.Arguments = "wlan start hostednetwork";

            try
            {
                using (Process execute = Process.Start(NewProcess.StartInfo))
                {
                    execute.WaitForExit();
                    btnStart.Text = "STOP";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StopProcess()
        {
            NewProcess.StartInfo.FileName = "netsh";
            NewProcess.StartInfo.Arguments = "wlan stop hostednetwork";

            try
            {
                using (Process execute = Process.Start(NewProcess.StartInfo))
                {
                    execute.WaitForExit();
                    btnStart.Text = "STOP";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmWIFI_Load(object sender, EventArgs e)
        {
            txtNom.Text = "wifi";
            txtPWD.Text = "08042000";
            rbSetConfig.Checked = true;

            Initialiser();
            localhostip();
        }

        //
        //Fonction pour lister les adapter pour les reseau
        private void localhostip()
        {
            var mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var moc = mc.GetInstances();
            cbListNetwork.Items.Clear();

            foreach (var mo in moc)
            {
                if ((bool)mo["ipEnabled"])
                {
                    cbListNetwork.Items.Add(mo["Caption"].ToString());
                }
            }
        }

        //Selectionner l'ip de l'adapter network
        private void SetIp()
        {
            //ACQUIRE THE IP4 & IP6 ADDRESSES
            string host = Dns.GetHostName();
            IPAddress[] ips = Dns.GetHostAddresses(host);

            tblocalhost.CharacterCasing = CharacterCasing.Upper;
            tblocalip.CharacterCasing = CharacterCasing.Upper;
            tblocalhost.Text = host;


            if (cbListNetwork.SelectedIndex == 0)
            {
                tblocalip.Text = null;
                tblocalip6.Text = null;

                foreach (IPAddress ip4 in ips.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
                {
                    tblocalip.Text = ip4.ToString();
                }

                foreach (IPAddress ip6 in ips.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6))
                {
                    tblocalip6.Text = ip6.ToString();
                }
            }

            if (cbListNetwork.SelectedIndex == 1)
            {
                tblocalip.Text = null;
                tblocalip6.Text = null;

                foreach (IPAddress ip4 in ips.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
                {
                    tblocalip.Text = ip4.ToString();
                }

                foreach (IPAddress ip6 in ips.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6))
                {
                    tblocalip6.Text = ip6.ToString();
                }
            }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (txtNom.Text == string.Empty || txtPWD.Text == string.Empty)
            {
                MessageBox.Show("SSID et/ou mot de passe sont vides ?", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtPWD.Text.Length < 8)
                {
                    MessageBox.Show("Mot de passe non valide !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (btnStart.ButtonText == "START")
                        {
                            StopBrodCasting();
                            btnStart.ButtonText = "STOP";
                            rbBlocInterface.Checked = true;
                        }
                        else
                        {
                            StopProcess();
                            btnStart.ButtonText = "START";
                            rbSetConfig.Checked = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        StopProcess();
                        btnStart.ButtonText = "START";
                        rbSetConfig.Checked = true;
                        MessageBox.Show("Erreur " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void Initialiser()
        {

            if (rbSetConfig.Checked == true)
            {
                ENEABLED();
            }
            else
            {
                DESEABLED();
            }
        }

        private void rbSetConfig_CheckedChanged(object sender, EventArgs e)
        {
            Initialiser();
        }

        private void chkVisual_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVisual.Checked == true)
            {
                txtPWD.UseSystemPasswordChar = false;
            }
            else
            {
                txtPWD.UseSystemPasswordChar = true;
            }
        }

        private void cbListNetwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIp();
        }

        private void tabControlNet_SelectedIndexChanged(object sender, EventArgs e)
        {
            localhostip();
        }

        private void frmWIFI_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopProcess();
            Application.Exit();
        }
    }
}
