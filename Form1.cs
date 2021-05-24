using System;
using System.Windows;
using System.Windows.Forms;
using HorizontalAlignment = System.Windows.Forms.HorizontalAlignment;
using MessageBox = System.Windows.MessageBox;

namespace SGPA_Calc {
    public partial class Form1 : Form {

        private SubjectEngine engine = new SubjectEngine();
        static readonly string[] GRADES = {
                "---",
                "A",
                "A-",
                "B+",
                "B",
                "B-",
                "C+",
                "C",
                "C-",
                "D+",
                "D",
                "F",
            };
        public Form1() {
            InitializeComponent();
            SubjectEngine.FieldsFilled = 0;
            foreach (ComboBox box in new ComboBox[] { APGrade,
            ENGGrade, CALCGrade, COMPGrade, COMPLABGrade, APLABGrade, ISLGrade,
            PROGGrade, PROGLABGrade}) {
                box.Items.AddRange(GRADES);
                box.SelectedIndex = 0;
            }
            ResultBox.SelectAll();
            ResultBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void CalculateButton_Click(object sender, EventArgs e) {
            if (SubjectEngine.FieldsFilled >= 18) {
                engine.ProcessSubject(APGrade, 2);
                engine.ProcessSubject(CALCGrade, 3);
                engine.ProcessSubject(ENGGrade, 3);
                engine.ProcessSubject(PROGGrade, 3);
                engine.ProcessSubject(COMPGrade, 2);
                engine.ProcessSubject(ISLGrade, 2);
                engine.ProcessSubject(COMPLABGrade);
                engine.ProcessSubject(PROGLABGrade);
                engine.ProcessSubject(APLABGrade);
                ResultBox.Text = $"{SubjectEngine.SGPA:0.00}";
                ResultBox.SelectAll();
                ResultBox.SelectionAlignment = HorizontalAlignment.Center;
            } else {
                MessageBox.Show("You need to fill all the grades with correct values", "Opsie!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            engine.ResetTotals();
        }

        private void APGrade_SelectionChanged(object sender, EventArgs e) {
            SubjectEngine.FieldsFilled++;
        }

        private void CALCGrade_SelectedValueChanged(object sender, EventArgs e) {
            SubjectEngine.FieldsFilled++;
        }

        private void ENGGrade_SelectedValueChanged(object sender, EventArgs e) {
            SubjectEngine.FieldsFilled++;
        }

        private void COMPGrade_SelectedValueChanged(object sender, EventArgs e) {
            SubjectEngine.FieldsFilled++;
        }

        private void PROGGrade_SelectedValueChanged(object sender, EventArgs e) {
            SubjectEngine.FieldsFilled++;
        }

        private void ISLGrade_SelectedValueChanged(object sender, EventArgs e) {
            SubjectEngine.FieldsFilled++;
        }

        private void COMPLABGrade_SelectedValueChanged(object sender, EventArgs e) {
            SubjectEngine.FieldsFilled++;
        }

        private void PROGLABGrade_SelectedValueChanged(object sender, EventArgs e) {
            SubjectEngine.FieldsFilled++;
        }

        private void APLABGrade_SelectedValueChanged(object sender, EventArgs e) {
            SubjectEngine.FieldsFilled++;
        }
    }
}
