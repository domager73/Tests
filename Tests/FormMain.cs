using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace Tests
{
    public partial class FormMain : Form
    {
        private string _fileName;
        private List<Test> _tests;
        private int _countCorrectAnswers;
        private List<TextBox> _answers;

        private void FormMain_Load(object sender, EventArgs e)
        {
            _countCorrectAnswers = 0;
            _answers = new List<TextBox>();
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttomNext_Click(object sender, EventArgs e)
        {
            _fileName = maskedTextBoxFileName.Text;

            if (!File.Exists(_fileName))
            {
                MessageBox.Show("������ ����� �� ����������", "Error");
                maskedTextBoxFileName.Text = string.Empty;

                return;
            }
            _tests = TxtxReader.LoadFromFile(_fileName);

            Controls.Clear();
            Button buttomRes;

            for (int i = 0; i < _tests.Count; i++)
            {
                AddLable(i, "question");

                for (int j = 0; j < _tests[i].Answers.Count; j++)
                {
                    AddLable(i, j, "answer");
                }

                var textBox = AddTextBox(i, "textBox");

                Controls.Add(textBox);
                _answers.Add(textBox);
            }

            buttomRes = new Button
            {
                Text = "���������� ����������",
                Size = new Size(85, 80),
                Location = new Point(200, 200),
            };
            buttomRes.Click += buttomRes_Click;

            Controls.Add(buttomRes);
        }

        private void buttomRes_Click(object sender, EventArgs e)
        {
            Controls.Clear();

            for (var i = 0; i < _answers.Count; i++)
            {
                if (_tests[i].CurrentAnswerIndex == int.Parse(_answers[i].Text))
                {
                    _countCorrectAnswers++;
                }
            }

            Controls.Clear();
            AddLable($"����� ���������� ��������: {_answers.Count}\n���������� ������ �������: {_countCorrectAnswers}", new Size(200, 200));
        }

        #region Helper Methods
        private void AddLable(string text, Size size)
        {
            Controls.Add(new Label
            {
                Text = text,
                Size = size,
            });
        }

        private void AddLable(int num, string text) 
        {
            Controls.Add(new Label
            {
                Text = _tests[num].Question,
                Location = new Point(10, 110 * num),
                Name = text + num,
            });
        }

        private void AddLable(int firstNum, int secondNum, string text)
        {
            Controls.Add(new Label
            {
                Text = secondNum + ": " + _tests[firstNum].Answers[secondNum],
                Location = new Point(10, 110 * firstNum + 20 * (secondNum + 1)),
                Name = text + secondNum,
            });
        }

        private TextBox AddTextBox(int num, string text)
        {
            return new TextBox
            {
                Name = text + num,
                Location = new Point(10, 110 * num + 82),
                Size = new Size(121, 42),
            };
        }
        #endregion
    }
}