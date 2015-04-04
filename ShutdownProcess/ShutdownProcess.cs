using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownProcess
{
    public partial class ShutdownProcess : Form
    {
        private PModel _pModel = new PModel();

        private void ShutdownProcess_Load(object sender, EventArgs e)
        {

        }

        public ShutdownProcess()
        {
            InitializeComponent();
            _okayButton.Enabled = _pModel.OkayButton;
            _cancelButton.Enabled = _pModel.CancelButton;
            _dayComboBox.DataSource = _pModel.DayList;
            _hourComboBox.DataSource = _pModel.HourList;
            _minComboBox.DataSource = _pModel.MinList;
            _secComboBox.DataSource = _pModel.SecList;
        }

        private void RefreshView()
        {
            _okayButton.Enabled = _pModel.OkayButton;
            _cancelButton.Enabled = _pModel.CancelButton;
            _dayComboBox.Enabled = _pModel.PickerEnable;
            _hourComboBox.Enabled = _pModel.PickerEnable;
            _minComboBox.Enabled = _pModel.PickerEnable;
            _secComboBox.Enabled = _pModel.PickerEnable;
        }

        #region Events

        private void ClickOkButton(object sender, EventArgs e)
        {
            _pModel.ShowShutdownInfo();
            RefreshView();
        }

        private void ClickCancelButton(object sender, EventArgs e)
        {
            _pModel.CancelShutdown();
            RefreshView();
        }

        private void ChangeDayCombobox(object sender, EventArgs e)
        {
            _pModel.ShutdownModel.Day = Convert.ToInt32(_dayComboBox.SelectedValue);
        }

        private void ChangeHourCombobox(object sender, EventArgs e)
        {
            _pModel.ShutdownModel.Hour = Convert.ToInt32(_hourComboBox.SelectedValue);
        }

        private void ChangeMinCombobox(object sender, EventArgs e)
        {
            _pModel.ShutdownModel.Min = Convert.ToInt32(_minComboBox.SelectedValue);
        }

        private void ChangeSecCombobox(object sender, EventArgs e)
        {
            _pModel.ShutdownModel.Sec = Convert.ToInt32(_secComboBox.SelectedValue);
        }


        private void CheckExiting(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("離開本程式將會終止正在進行的關機程序，確定繼續 ?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            switch (result)
            {
                case DialogResult.OK:
                    _pModel.ShutdownModel.AbordShutdown();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        #endregion
    }
}
