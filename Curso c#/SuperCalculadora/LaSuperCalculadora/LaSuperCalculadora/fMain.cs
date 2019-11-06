using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaSuperCalculadora
{
    public partial class fMain : Form
    {
        private decimal _Operand;
        private string _OperandTxt;
        private string _Operator;


        public fMain()
        {
            InitializeComponent();
            Reset();
        }


        private void SetOperandTxt(string value)
        {
            //If value es numerico
            if (value == "9" || value == "8" || value == "7" || value == "6" || value == "5" || value == "4" || value == "3" || value == "2"
                 || value == "1" || value == "0")
            {
                if (_OperandTxt == "0")
                    _OperandTxt = "";

                _OperandTxt = _OperandTxt + value;
                txtResult.Text = _OperandTxt;
            }
            //If value es operador
            else if (value == "+" || value == "-" || value == "*" || value == "/")
            {
                if (_Operator != "" && _OperandTxt != "")
                {
                    DoOperation();
                }
                _Operator = value;

                if (_OperandTxt != "")
                {
                    _Operand = decimal.Parse(_OperandTxt);
                    _OperandTxt = "";
                }
            }
            else if (value == "=")
            {
                if (_Operator != "" && _OperandTxt != "")
                {
                    DoOperation();
                }
            }
            //If value es delete
            else if (value == "\b")
            {
                Delete();
            }
            //If value es reset ESC
            else if (value == "\u001b")
            {
                Reset();
            }
            //If value es decimal
            else if (value == "," || value == ".")
            {
                if (_OperandTxt.IndexOf(".") < 0)
                {
                    _OperandTxt = _OperandTxt + ".";
                    txtResult.Text = _OperandTxt;
                }
            }
            
        }

        private void DoOperation()
        {
            decimal result = 0;

            if(_Operator == "+")
            {
                result = _Operand + decimal.Parse(_OperandTxt);
            }
            else if(_Operator == "-")
            {
                result = _Operand - decimal.Parse(_OperandTxt);
            }
            else if (_Operator == "*")
            {
                result = _Operand * decimal.Parse(_OperandTxt);
            }
            else if (_Operator == "/")
            {
                result = _Operand / decimal.Parse(_OperandTxt);
            }

            _Operator = "";
            _OperandTxt = result.ToString();
            txtResult.Text = _OperandTxt;
        }


        private void Delete()
        {
            if (_OperandTxt.Length > 1)
            {
                _OperandTxt = _OperandTxt.Substring(0, _OperandTxt.Length - 1);
            }
            else
            {
                _OperandTxt = "0";
            }

            txtResult.Text = _OperandTxt;
        }


        private void Reset()
        {
            _OperandTxt = "0";
            _Operand = 0;
            _Operator = "";

            txtResult.Text = "0";
        }




        private void btnNumber9_Click(object sender, EventArgs e)
        {
            SetOperandTxt("9");
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            SetOperandTxt("8");
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            SetOperandTxt("7");
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            SetOperandTxt("4");
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            SetOperandTxt("5");
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            SetOperandTxt("6");
        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            SetOperandTxt("1");
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            SetOperandTxt("2");
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            SetOperandTxt("3");
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            SetOperandTxt("0");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            SetOperandTxt("=");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetOperandTxt("+");
        }

        private void fMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetOperandTxt(e.KeyChar.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            SetOperandTxt(",");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            SetOperandTxt("/");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            SetOperandTxt("*");
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            SetOperandTxt("-");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
