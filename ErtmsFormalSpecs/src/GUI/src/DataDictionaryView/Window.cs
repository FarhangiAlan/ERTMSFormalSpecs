// ------------------------------------------------------------------------------
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
using System.Windows.Forms;
using DataDictionary;

namespace GUI.DataDictionaryView
{
    public partial class Window : BaseForm
    {
        public override MyPropertyGrid Properties
        {
            get { return dataDictPropertyGrid; }
        }

        public override RichTextBox MessagesTextBox
        {
            get
            {
                if (messagesRichTextBox != null)
                {
                    return messagesRichTextBox.TextBox;
                }
                else
                {
                    return null;
                }
            }
        }

        public override EditorTextBox RequirementsTextBox
        {
            get { return requirementsTextBox; }
        }

        public override EditorTextBox ExpressionEditorTextBox
        {
            get { return expressionEditorTextBox; }
        }

        public override BaseTreeView TreeView
        {
            get { return dataDictTree; }
        }

        public override BaseTreeView subTreeView
        {
            get { return usageTreeView; }
        }

        public override ExplainTextBox ExplainTextBox
        {
            get { return ruleExplainTextBox; }
        }

        /// <summary>
        /// The Dictionary handled by this view
        /// </summary>
        private DataDictionary.Dictionary dictionary;
        public DataDictionary.Dictionary Dictionary
        {
            get { return dictionary; }
            set
            {
                dictionary = value;
                dataDictTree.Root = dictionary;
                Text = dictionary.Name + " model view";
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dictionary"></param>
        public Window(DataDictionary.Dictionary dictionary)
        {
            InitializeComponent();

            messagesRichTextBox.AutoComplete = false;
            requirementsTextBox.AutoComplete = false;
            ruleExplainTextBox.AutoComplete = false;

            ruleExplainTextBox.ReadOnly = true;
            requirementsTextBox.ReadOnly = true;

            FormClosed += new FormClosedEventHandler(Window_FormClosed);
            expressionEditorTextBox.TextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            Visible = false;
            Dictionary = dictionary;

            // TODO : Does not work yet
            // GUIUtils.ResizePropertyGridSplitter(Properties, 25);
            Refresh();
        }

        void TextBox_TextChanged(object sender, EventArgs e)
        {
            IExpressionable expressionable = Selected as IExpressionable;
            if (expressionable != null)
            {
                expressionable.ExpressionText = expressionEditorTextBox.Text;
            }
        }

        /// <summary>
        /// Handles the close event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Window_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIWindow.HandleSubWindowClosed(this);
        }

        public override void Refresh()
        {
            dataDictTree.Refresh();
            base.Refresh();
        }

        /// <summary>
        /// Refreshes the model of the window
        /// </summary>
        public override void RefreshModel()
        {
            dataDictTree.RefreshModel();
        }

        /// <summary>
        /// Finds the tree node which corresponds to the model element
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseTreeNode FindNode(Utils.IModelElement model)
        {
            return TreeView.FindNode(model);
        }

        /// <summary>
        /// Selects the next node where error message is available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextErrortoolStripButton_Click(object sender, EventArgs e)
        {
            TreeView.SelectNext(Utils.ElementLog.LevelEnum.Error);
        }

        /// <summary>
        /// Selects the next node where warning message is available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextWarningToolStripButton_Click(object sender, EventArgs e)
        {
            TreeView.SelectNext(Utils.ElementLog.LevelEnum.Warning);
        }

        /// <summary>
        /// Selects the next node where info message is available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextInfoToolStripButton_Click(object sender, EventArgs e)
        {
            TreeView.SelectNext(Utils.ElementLog.LevelEnum.Info);
        }

        /// <summary>
        /// Refreshes the window after a step (=> variable changes) has been performed
        /// </summary>
        public void RefreshAfterStep()
        {
            dataDictTree.RefreshAfterStep();
        }
    }
}
