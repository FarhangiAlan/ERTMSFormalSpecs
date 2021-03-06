﻿// ------------------------------------------------------------------------------
// -- Copyright ERTMS Solutions
// -- Licensed under the EUPL V.1.1
// -- http://joinup.ec.europa.eu/software/page/eupl/licence-eupl
// --
// -- This file is part of ERTMSFormalSpec software and documentation
// --
// --  ERTMSFormalSpec is free software: you can redistribute it and/or modify
// --  it under the terms of the EUPL General Public License, v.1.1
// --
// -- ERTMSFormalSpec is distributed in the hope that it will be useful,
// -- but WITHOUT ANY WARRANTY; without even the implied warranty of
// -- MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// --
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataDictionary;
using Reports.ERTMSAcademy;

namespace GUI.Report
{
    public partial class ERTMSAcademyReport : Form
    {
        private ERTMSAcademyReportHandler reportHandler;


        public ERTMSAcademyReport(Dictionary dictionary)
        {
            InitializeComponent();
            reportHandler = new ERTMSAcademyReportHandler(dictionary);
            TxtB_Path.Text = reportHandler.FileName;

            List<string> userNames = new List<string>();
            userNames.Add("Diego");
            userNames.Add("Moritz");
            userNames.Add("Peyman");
            userNames.Add("Luis");
            Cbb_UserNames.DataSource = userNames;
        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                reportHandler.FileName = saveFileDialog.FileName;
                TxtB_Path.Text = reportHandler.FileName;
            }
        }

        private void Btn_CreateReport_Click(object sender, EventArgs e)
        {
            reportHandler.Name = "ERTMS Academy report";

            reportHandler.UserName = Cbb_UserNames.SelectedValue.ToString();

            Hide();

            ProgressDialog dialog = new ProgressDialog("Generating report", reportHandler);
            dialog.ShowDialog(Owner);
        }
    }
}
