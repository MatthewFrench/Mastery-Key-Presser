using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;
using Gma.UserActivityMonitor;
using AutoItX3Lib;

using System.Reflection;
using System.Web;
using System.Runtime;
using System.Configuration;

using System.Threading;

namespace League_Auto_Key_Presser
{
    public partial class Form1 : Form
    {
        static AutoItX3 _autoIT = new AutoItX3();

        ATimer timer = null;

        Stopwatch lastPressedMastery = Stopwatch.StartNew();

        int pressSpell1Interval = 9*1000;
        
        bool autoKeyOnBool = true;

        [DllImport("ntdll.dll", SetLastError = true)]
        static extern int NtSetTimerResolution(int DesiredResolution, bool SetResolution, out int CurrentResolution);

        public Form1()
        {
            InitializeComponent();
            
            // The requested resolution in 100 ns units:
            int DesiredResolution = 1000;
            // Note: The supported resolutions can be obtained by a call to NtQueryTimerResolution()

            int CurrentResolution = 0;

            // 1. Requesting a higher resolution
            // Note: This call is similar to timeBeginPeriod.
            // However, it to to specify the resolution in 100 ns units.
            if (NtSetTimerResolution(DesiredResolution, true, out CurrentResolution) != 0)
            {
                Console.WriteLine("Setting resolution failed");
            }
            else
            {
                Console.WriteLine("CurrentResolution [100 ns units]: " + CurrentResolution);
            }

            ATimer.ElapsedTimerDelegate callback = timer_Tick;
            timer = new ATimer(3, 1, callback);
            timer.Start();
            

            _autoIT.AutoItSetOption("SendKeyDelay", 0);

            _autoIT.AutoItSetOption("SendKeyDownDelay", 0);
        }
        void timer_Tick()
        {
            if (autoKeyOnBool)
            {
                
                    if (lastPressedMastery.ElapsedMilliseconds >=1000)
                    {
                    lastPressedMastery.Restart();
                    tapMastery();
                    }
            }
        }
        
        void tapMastery()
        {
                _autoIT.Send("^6"); 
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        private void autoKeyOn_CheckedChanged(Object sender, EventArgs e)
        {
            autoKeyOnBool = ((CheckBox)sender).Checked;
        }
    }
    
}
