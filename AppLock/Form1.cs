using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using NetFwTypeLib;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLock
{
    public partial class Form1 : Form
    {
        private Dictionary<string, INetFwRule> ruleDictionary;

        public Form1()
        {
            InitializeComponent();
            ruleDictionary = new Dictionary<string, INetFwRule>();
            LoadFirewallRules();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadFirewallRules();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }



        private void LoadFirewallRules()
        {
            // Windows Güvenlik Duvarı yöneticisi oluştur
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            // Tüm kuralları al
            foreach (INetFwRule rule in firewallPolicy.Rules)
            {
                try
                {
                    // INetFwRule2 arabirimiyle dönüştürme denemesi
                    INetFwRule2 fwRule = (INetFwRule2)rule;
                    if (!ruleDictionary.ContainsKey(fwRule.Name))
                    {
                        ruleDictionary.Add(fwRule.Name, fwRule);
                        listBox1.Items.Add(fwRule.Name);
                    }
                }
                catch (InvalidCastException)
                {
                    // Eğer INetFwRule2 arabirimine dönüştürme başarısız olursa devam et
                    continue;
                }
            }
        }


        private void kuralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text=="")
            {
                MessageBox.Show("Kural adını doldurunuz!");
            }
            else
            {
            try
                
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedAppPath = openFileDialog.FileName;
              
                   textBox2.Text = openFileDialog.FileName;

                    // Windows Güvenlik Duvarı yöneticisi oluştur
                    INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

                    // Yeni bir kural oluştur
                    INetFwRule rule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                    rule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK; // Bağlantıyı engelle
                    rule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT; // Giden bağlantıları engelle
                    rule.Enabled = true; // Kuralı etkinleştir
                    rule.ApplicationName = selectedAppPath; // Seçilen uygulamanın yolunu belirt
                    rule.Name = textBox1.Text; // Kural adını belirt

                    // Kuralı güvenlik duvarına ekle
                    firewallPolicy.Rules.Add(rule);
                    MessageBox.Show("Kural başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        private void kuralKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true; groupBox1.Visible = false;
            LoadFirewallRules();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedRuleName = listBox1.SelectedItem.ToString();

                if (MessageBox.Show($"Seçilen kuralı silmek istediğinizden emin misiniz?\n\nKural Adı: {selectedRuleName}", "Kuralı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        // Kuralı güvenlik duvarından kaldır
                        INetFwRule ruleToRemove = ruleDictionary[selectedRuleName];
                        INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                        firewallPolicy.Rules.Remove(ruleToRemove.Name);
                        listBox1.Items.Remove(selectedRuleName);
                        ruleDictionary.Remove(selectedRuleName);
                        MessageBox.Show("Kural başarıyla kaldırıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kural kaldırılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kuralı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
