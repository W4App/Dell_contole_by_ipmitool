using dell_fans_controller.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dell_fans_controller
{
    
    public partial class frmMain : Form
    {
        private static bool     powerOn=false;
        private static string version = "v1.0.0";

        private static string currentPath = Application.StartupPath; // System.Environment.CurrentDirectory;
        private static string configFileName = "\\config.ini";
        private static string explorer = "explorer";
        private static string ipmitoolPath = currentPath + "\\Dell\\SysMgt\\bmc\\ipmitool.exe";
        private static string configFilePath = currentPath + configFileName;

        private static string defaultIp = "127.0.0.1";
        private static string defaultUser = "root";
        private static string defaultPassword = "calvin";
        private static string defaultConfigSection = "ipmi";

       

        private void saveConfig()
        {
            string ip = txtIp.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;

            IniHelper.Write(defaultConfigSection, "ip", ip, configFilePath);
            IniHelper.Write(defaultConfigSection, "user", user, configFilePath);
            IniHelper.Write(defaultConfigSection, "password", password, configFilePath);
        }

        public frmMain()
        {
            InitializeComponent();


            if (File.Exists(configFilePath))
            {
                string ip = IniHelper.Read(defaultConfigSection, "ip", defaultIp, configFilePath);
                string user = IniHelper.Read(defaultConfigSection, "user", defaultUser, configFilePath);
                string password = IniHelper.Read(defaultConfigSection, "password", defaultPassword, configFilePath);
                txtIp.Text = ip;
                txtUser.Text = user;
                txtPassword.Text = password;
            }
            else
            {
                IniHelper.Write(defaultConfigSection, "ip", defaultIp, configFilePath);
                IniHelper.Write(defaultConfigSection, "user", defaultUser, configFilePath);
                IniHelper.Write(defaultConfigSection, "password", defaultPassword, configFilePath);
                txtIp.Text = defaultIp;
                txtUser.Text = defaultUser;
                txtPassword.Text = defaultPassword;
            }

        }

        private void nbrUpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            trkBarSpeed.Value = (int)nbrUpDownSpeed.Value;
        }

        private async void btnReset_Click(object sender, EventArgs e)
        {
            string ip = txtIp.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string parametersReset = string.Format("-I lanplus -H {0} -U {1} -P {2} raw 0x30 0x30 0x01 0x01", ip, user, password);
            string fullExecuteReset = ipmitoolPath + " " + parametersReset;
            await IMPI_helper.GetStatus(fullExecuteReset);
           //IMPI_helper.execute(fullExecuteReset);
        }

        private async void btnSet_Click(object sender, EventArgs e)
        {
            string ip = txtIp.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string percent = nbrUpDownSpeed.Text;
            int percentNum = int.Parse(percent);

            // string format = "%s/Dell/SysMgt/bmc/ipmitool.exe -I lanplus -H %s -U %s -P %s raw 0x30 0x30 0x01";
            string formatDisableAutoMode = "-I lanplus -H {0} -U {1} -P {2} raw 0x30 0x30 0x01 0x00";
            string parametersDisableAutoMode = string.Format(formatDisableAutoMode, ip, user, password);
            string fullExecuteDisableAutoMode = ipmitoolPath + " " + parametersDisableAutoMode;
            string resultDisableAutoMode = await IMPI_helper.GetStatus(fullExecuteDisableAutoMode);


            // format = "%s/Dell/SysMgt/bmc/ipmitool.exe -I lanplus -H %s -U %s -P %s raw 0x30 0x30 0x02 0xff 0x%02x";
            string formatSetSpeed = "-I lanplus -H {0} -U {1} -P {2} raw 0x30 0x30 0x02 0xff 0x{3:x2}";
            string parametersSetSpeed = string.Format(formatSetSpeed, ip, user, password, percentNum);

            string fullExecuteSetSpeed = ipmitoolPath + " " + parametersSetSpeed;
            string resultSetSpeed =await IMPI_helper.GetStatus(fullExecuteSetSpeed);

            // MessageBox.Show(resultDisableAutoMode + "-" + resultSetSpeed);

            //string cmdFormat = "/k \"{0} {1}\" & \"{2} {3}\"";
            //string cmdParameters = string.Format(cmdFormat, ipmitoolPath, parametersDisableAutoMode, ipmitoolPath, parametersSetSpeed);

            //Process.Start("cmd", cmdParameters);
        }

        private void lnkRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(explorer, lnkRepo.Text);
        }

        private void lnkMyWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(explorer, lnkMyWebsite.Text);
        }

        private void btnVisitDellService_Click(object sender, EventArgs e)
        {
            Process.Start(explorer, "http://" + txtIp.Text);
        }

        private void trkBarSpeed_Scroll(object sender, EventArgs e)
        {
            nbrUpDownSpeed.Value = trkBarSpeed.Value;
        }

        private async void  btnRefreshNow_Click(object sender, EventArgs e)
        {
            string ip = txtIp.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string formatSensor = "-I lanplus -H {0} -U {1} -P {2} sensor";
            string parametersSensor = string.Format(formatSensor, ip, user, password);
            string fullExecuteSensor = ipmitoolPath + " " + parametersSensor;
            string result = await IMPI_helper.GetStatus(fullExecuteSensor);
           // string result = IMPI_helper.execute(fullExecuteSensor);
            result = result.Replace("\r\n", "\n");
            string[] sensorList = result.Split('\n', '\r').Skip(4).ToArray();
            lstViewSensor.Items.Clear();
            foreach (var item in sensorList)
            {
                if(checkBox1.Checked)
                {
                    if (item.Contains("Temp") || item.Contains("RPM")|| item.Contains("Current"))
                    {
                        lstViewSensor.Items.Add(new ListViewItem(item.Split('|')));
                    }
                }
                else
                {
                    lstViewSensor.Items.Add(new ListViewItem(item.Split('|')));
                }
            }
            lstViewSensor.Refresh();
        }

        private void TxtIp_LostFocus(object sender, EventArgs e)
        {
            saveConfig();
        }

        private void TxtUser_LostFocus(object sender, EventArgs e)
        {
            saveConfig();
        }

        private void TxtPassword_LostFocus(object sender, EventArgs e)
        {
            saveConfig();
        }

        
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            timer2.Interval = 5000;
            timer2.Enabled = true;

            timer1.Interval = 1000*20;
            timer1.Enabled = true;            
            this.Text += " " + version;
            button1_Click(sender, e);

            if (powerOn)
            {
                up.BackColor = Color.Green;
                up.Text = "已开机";
            }
            else
            {
                up.BackColor= Color.Red;
                up.Text = "未开机";
            }
        }
        //硬件状态 --  >>  检查机器是否开机之类的
        private async void button1_Click(object sender, EventArgs e)
        {
            string ip = txtIp.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string formatSensor = "-I lanplus -H {0} -U {1} -P {2} chassis status";
            string parametersSensor = string.Format(formatSensor, ip, user, password);
            string fullExecuteSensor = ipmitoolPath + " " + parametersSensor;

            // string result = IMPI_helper.execute(fullExecuteSensor);

            string result = await IMPI_helper.GetStatus(fullExecuteSensor);


            string[] sensorList = result.Split('\n', '\r').Skip(8).ToArray();
            
            
            lstViewSensor.Items.Clear();
            foreach (var item in sensorList)
            {
                if (item.Contains("System Power"))
                {
                    string[] t = item.Split(':');
                    powerOn = t[1]=="off"? false: true;
                    if (powerOn)
                    {
                        up.BackColor = Color.Green;
                        up.Text = "已开机";
                    }
                    else
                    {
                        up.BackColor = Color.Red;
                        up.Text = "未开机";
                    }

                }
                lstViewSensor.Items.Add(new ListViewItem(item.Split(':')));
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (powerOn)
            {
                return;
            }
            string ip = txtIp.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;

            string formatSensor = "-I lanplus -H {0} -U {1} -P {2} power on";
            string parametersSensor = string.Format(formatSensor, ip, user, password);

            string fullExecuteSensor = ipmitoolPath + " " + parametersSensor;
            string result = IMPI_helper.execute(fullExecuteSensor);
            if(result== "Up/On")
            {
                powerOn = true;
            }
            else
            {
                powerOn = false;
            }
        }

       

     

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (checkBox3.Checked)
            {
                btnRefreshNow_Click(sender, e);
            }
           
            if (powerOn)
            {
                up.BackColor = Color.Green;
                up.Text = "已开机";
            }
            else
            {
                up.BackColor = Color.Red;
                up.Text = "未开机";
            }
        }

    

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked == true)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled= false;
            }                
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            string ip = txtIp.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string formatSensor = "-I lanplus -H {0} -U {1} -P {2} chassis status";
            string parametersSensor = string.Format(formatSensor, ip, user, password);
            string fullExecuteSensor = ipmitoolPath + " " + parametersSensor;
            // string result = IMPI_helper.execute(fullExecuteSensor);
            string result = await IMPI_helper.GetStatus(fullExecuteSensor);
            string[] sensorList = result.Split('\n', '\r').Skip(8).ToArray();
            
            foreach (var item in sensorList)
            {                
                if (item.Contains("System Power"))
                {
                    string[] t = item.Split(':');

                    powerOn = t[1].Contains("off") ? false : true;
                    if (powerOn)
                    {
                        up.BackColor = Color.Green;
                        up.Text = "已开机";
                    }
                    else
                    {
                        up.BackColor = Color.Red;
                        up.Text = "未开机";
                    }

                }
               

            }
        }
    }
}
