using System;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;
using Grgl.Dialog;
using GrglTestApp.Dialog;

namespace GrglTestApp
{
   

    public partial class DialogTestForm : Form
    {

        public delegate void ButtonClickDelegate();

        private readonly DialogTree _tree;
        private ButtonClickDelegate _buttonFunc;
        private IDialogNode _currentNode;

        
        

        public DialogTestForm()
        {
            InitializeComponent();
            _tree = new DialogTree();
            _buttonFunc = FuncNextNpcDialogLine;

        }

        private void DialogTestForm_Load(object sender, EventArgs e)
        {
            _currentNode = _tree.Root;
            this.ProcessNodes();


        }

        private void ProcessNodes()
        {
            // process first node

            // if first node is dialog line
            if (_currentNode is DialogLine)
            {
                DialogLine lineCurrentNode = _currentNode as DialogLine;
                // set NPC dialog text
                LabelNpcDialog.Text = lineCurrentNode.Text;

                // if second node is also a dialog line
                if (lineCurrentNode.Next is DialogLine)
                {
                    // set button to "continue" to next dialog line
                    ButtonContextual.Text = "Continue";
                    _buttonFunc = FuncNextNpcDialogLine;

                }
                else if (lineCurrentNode.Next is DialogChoiceNode) // if second node is choice node
                {
                    DialogChoiceNode choiceNextNode = lineCurrentNode.Next as DialogChoiceNode;


                    // clear combobox
                    this.ComboBoxChoice.Items.Clear();
                    // add choices to combobox
                    foreach (IDialogLine d in choiceNextNode.Choices.Values)
                    {
                        this.ComboBoxChoice.Items.Add(d.Text);
                    }

                    // select first item
                    ComboBoxChoice.SelectedIndex = 0;

                    // set button to "confirm" combobox choice
                    ButtonContextual.Text = "Say This!";
                    _buttonFunc = FuncConfirmChoice;

                    // set this to current node
                    _currentNode = choiceNextNode;
                }
                else // if second node is null
                {
                    ComboBoxChoice.Visible = false;
                    // set button to "restart"
                    ButtonContextual.Text = "Restart";
                    _buttonFunc = FuncRestart;
                }
                

            }
            else // if first node is choice node
            {
                DialogChoiceNode choiceCurrentNode = _currentNode as DialogChoiceNode;

                // clear combobox
                this.ComboBoxChoice.Items.Clear();

                // add choices to combobox
                foreach (IDialogLine d in choiceCurrentNode.Choices.Values)
                {
                    this.ComboBoxChoice.Items.Add(d.Text);
                }

                // select first item
                ComboBoxChoice.SelectedIndex = 0; 

                // set button to "confirm" combobox choice
                ButtonContextual.Text = "Say This!";
                _buttonFunc = FuncConfirmChoice;

            }

        }

        private void ButtonContextual_Click(object sender, EventArgs e)
        {
            _buttonFunc.Invoke();
            
        }

        private void FuncNextNpcDialogLine()
        {
            // next line
            _currentNode = (_currentNode as DialogLine).Next;
            ProcessNodes();
        }

        private void FuncConfirmChoice()
        {
            // confirm choice
            DialogChoiceNode choiceCurrentNode = _currentNode as DialogChoiceNode;
            _currentNode = choiceCurrentNode.Choices[ComboBoxChoice.SelectedItem.ToString()].Next;
            ProcessNodes();
        }

        private void FuncRestart()
        {
            _currentNode = _tree.Root;
            ComboBoxChoice.Visible = true;
            ProcessNodes();
        }


    }// end partial class
}
