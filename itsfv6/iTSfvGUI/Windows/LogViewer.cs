﻿using iTSfvLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTSfvGUI
{
    public partial class LogViewer : Form
    {
        public HelpersLib.Logger Logger = new HelpersLib.Logger();

        public LogViewer()
        {
            InitializeComponent();
            Logger.MessageAdded += Logger_MessageAdded;
        }

        void Logger_MessageAdded(string message)
        {
            if (Program.TreadUI != null)
                Program.TreadUI.Post((x) => lbLogs.Items.Add(message), null);
        }

        private void LogViewer_Load(object sender, EventArgs e)
        {

        }

        public void BindWorker(BackgroundWorker worker)
        {
            worker.ProgressChanged += Program.LogViewer.Worker_ProgressChanged;
            worker.RunWorkerCompleted += Program.LogViewer.Worker_RunWorkerCompleted;
        }

        public void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tspbApp.Value = e.ProgressPercentage;
        }

        public void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ReportWriter report = e.Result as ReportWriter;

            if (Program.Config.UI.Checks_MissingTags)
            {
                tsslApp.Text = "Ready. Tracks with missing tags: " + report.TracksMissingTags.Count;
            }
            else
            {
                tsslApp.Text = "Ready.";
            }

            if (Program.Config.ProduceReport)
                report.Write(Program.LogsFolderPath);
        }
    }
}
