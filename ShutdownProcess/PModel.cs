using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownProcess
{
    class PModel
    {
        private ShutdownModel _model = new ShutdownModel();
        private bool _okayButton;
        private bool _cancelButton;
        private bool _pickerEnable;

        private BindingList<int> _dayList = new BindingList<int>();
        private BindingList<int> _hourList = new BindingList<int>();
        private BindingList<int> _minList = new BindingList<int>();
        private BindingList<int> _secList = new BindingList<int>();

        public PModel()
        {
            this.Init();
        }

        public void Init()
        {
            _okayButton = true;
            _cancelButton = false;
            _pickerEnable = true;

            this.InitList(30, _dayList);
            this.InitList(24, _hourList);
            this.InitList(60, _minList);
            this.InitList(60, _secList);
        }

        public void InitList(int num, BindingList<int> inputList)
        {
            for (int i = 0; i <= num; i++)
            {
                inputList.Add(i);
            }
        }

        public void ShowShutdownInfo()
        {
            string infoString = _model.CountdownInfo();
            DialogResult result = MessageBox.Show(infoString, "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            switch (result)
            {
                case DialogResult.OK:
                    CancelButton = true;
                    OkayButton = false;
                    PickerEnable = false;
                    _model.InitiateShutdown();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        public void CancelShutdown()
        {
            DialogResult result = MessageBox.Show("您確定要終止定時關機程序 ?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            switch (result)
            {
                case DialogResult.OK:
                    CancelButton = false;
                    OkayButton = true;
                    PickerEnable = true;
                    _model.AbordShutdown();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        public ShutdownModel ShutdownModel
        {
            get { return _model; }
            set { _model = value; }
        }

        public BindingList<int> DayList
        {
            get { return _dayList; }
        }

        public BindingList<int> HourList
        {
            get { return _hourList; }
        }

        public BindingList<int> MinList
        {
            get { return _minList; }
        }

        public BindingList<int> SecList
        {
            get { return _secList; }
        }

        public bool OkayButton
        {
            get { return _okayButton; }
            set { _okayButton = value; }
        }

        public bool CancelButton
        {
            get { return _cancelButton; }
            set { _cancelButton = value; }
        }

        public bool PickerEnable
        {
            get { return _pickerEnable; }
            set { _pickerEnable = value; }
        }

    }
}
