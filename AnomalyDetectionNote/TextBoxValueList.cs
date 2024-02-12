using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxValueListInGroupBox
{
    class TextBoxValueList
    {
        private GroupBox parentGroupBox;
        private TextBox textBox;
        List<string> _valueList;
        public char splitChar = ',';
        int _valueListIndex;

        public TextBoxValueList(GroupBox parentGroupBox)
        {
            this.parentGroupBox = parentGroupBox;
            _valueListIndex = 0;
            _valueList = new List<string>();
            Initialize();

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            _valueList = new List<string>(((string[])textBox.Text.Split(splitChar)));
        }

        private void Initialize()
        {
            parentGroupBox.Controls.Clear();

            parentGroupBox.Height = 50;
            textBox = new TextBox();

            this.textBox.Location = new System.Drawing.Point(15, 20);
            this.textBox.Name = parentGroupBox.Name + "_textBox";
            this.textBox.Size = new System.Drawing.Size(parentGroupBox.Width - 30, 22);
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);

            parentGroupBox.Controls.Add(textBox);

        }

        public string AllText
        {
            set
            {
                textBox.Text = value;
                _valueList = new List<string>(((string[])value.Split(splitChar)));
            }
            get
            {
                return textBox.Text;
            }
        }

        public string Text
        {
            set
            {
                textBox.Text = value;
                _valueList = new List<string>(((string[])value.Split(splitChar)));
            }
            get
            {
                //Update List Index
                if (_valueListIndex < _valueList.Count - 1) { _valueListIndex++; } else { _valueListIndex = 0; }

                //Return Text
                return _valueList[_valueListIndex];
            }

        }

        public double Value
        {
            get
            {
                //Update List Index
                if (_valueListIndex < _valueList.Count - 1) { _valueListIndex++; } else { _valueListIndex = 0; }

                //Return Value
                double outValue = double.NaN;
                double.TryParse(_valueList[_valueListIndex], out outValue);
                return outValue;
            }
        }

        public int Count
        {
            get { return _valueList.Count; }

        }

    }
}
