using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AppLock
{
    public partial class Form1 : Form
    {
        private Dictionary<string, INetFwRule> ruleDictionary;
        private string selectedAppPath = null;

        public Form1()
        {
            InitializeComponent();
            ruleDictionary = new Dictionary<string, INetFwRule>();
            LoadFirewallRules();
        }

        private void LoadFirewallRules()
        {
            try
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

                foreach (INetFwRule2 fwRule in firewallPolicy.Rules.OfType<INetFwRule2>())
                {
                    if (!ruleDictionary.ContainsKey(fwRule.Name))
                    {
                        ruleDictionary.Add(fwRule.Name, fwRule);
                        listView1.Items.Add(fwRule.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading firewall rules: {ex.Message}");
            }
        }


        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Kural adını doldurunuz!");
            else
            {
                try
                {
                    if (selectedAppPath != null)
                    {
                        INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                        INetFwRule rule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                        
                        rule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                        rule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                        rule.Enabled = true;
                        rule.ApplicationName = selectedAppPath;
                        rule.Name = textBox1.Text;

                        firewallPolicy.Rules.Add(rule);
                        MessageBox.Show("Kural başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFirewallRules();
                    }
                    else
                    {
                        MessageBox.Show("Uygulama adını doldurunuz!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string selectedRuleName = selectedItem.Text;

                if (MessageBox.Show($"Seçilen kuralı silmek istediğinizden emin misiniz?\n\nKural Adı: {selectedRuleName}", "Kuralı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        INetFwRule ruleToRemove = ruleDictionary[selectedRuleName];
                        INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                        firewallPolicy.Rules.Remove(ruleToRemove.Name);
                        listView1.Items.Remove(selectedItem);
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

        private void lollipopSmallCard1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedAppPath = openFileDialog.FileName;
                    string selectedAppName = Path.GetFileName(selectedAppPath);
                    lollipopSmallCard1.Text = selectedAppName;
                    lollipopSmallCard1.Info = selectedAppPath;
                    FileAttributes attributes = File.GetAttributes(openFileDialog.FileName);
                    if ((attributes & FileAttributes.Archive) == FileAttributes.Archive)
                    {
                        try
                        {
                            Icon icon = Icon.ExtractAssociatedIcon(openFileDialog.FileName);
                            lollipopSmallCard1.Image = icon.ToBitmap();
                        }
                        catch (Exception) { }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
