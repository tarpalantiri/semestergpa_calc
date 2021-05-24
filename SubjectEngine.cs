using System.Collections.Generic;

using System.Windows.Forms;

namespace SGPA_Calc
{
    internal sealed class SubjectEngine
    {
        private static Dictionary<string, double> GradesToPoints = new Dictionary<string, double>() {
            ["A"] = 4.0,
            ["A-"] = 3.7,
            ["B+"] = 3.3,
            ["B"] = 3.0,
            ["B-"] = 2.7,
            ["C+"] = 2.3,
            ["C"] = 2.0,
            ["C-"] = 1.7,
            ["D+"] = 1.3,
            ["D"] = 1.0,
            ["F"] = 0,
            [" "] = 0,
            ["---"] = 0
        };

        public static double TotalCreditHours = 0;
        public static double TotalWeight = 0;
        public static short FieldsFilled = 0;

        public ComboBox GradeComboBoxElement;

        public double CreditHours { get; set; }

        public double CurrentSubjectGradePoints
        {
            get
            {
                return GradesToPoints[GradeComboBoxElement.Text] * CreditHours;
            }
        }

        public static double SGPA
        {
            get
            {
                return SubjectEngine.TotalWeight / SubjectEngine.TotalCreditHours;
            }
        }

        public void ProcessSubject(ComboBox ReferenceToSubjectComboBox, short creditHours = 1)
        {
            GradeComboBoxElement = ReferenceToSubjectComboBox;
            CreditHours = creditHours;
            SubjectEngine.TotalCreditHours += CreditHours;
            SubjectEngine.TotalWeight += CurrentSubjectGradePoints;
        }

        public void ResetTotals()
        {
            SubjectEngine.TotalCreditHours = 0;
            SubjectEngine.TotalWeight = 0;
        }
    }
}

