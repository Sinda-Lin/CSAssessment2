using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAssessment2
{
    public partial class frmNestedClasses : Form
    {
        public frmNestedClasses()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //The source of this nested classes is ChatGPT
        class Car
        {
            public string Model { get; set; }
            public EngineType Engine { get; set; }

            public Car(string model, EngineType engine)
            {
                Model = model;
                Engine = engine;
            }

            // Nested class representing different engine types
            public class EngineType
            {
                public string Type { get; set; }

                public EngineType(string type)
                {
                    Type = type;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string carModel = txtModel.Text;
            string carEngine = txtEngine.Text;
            if (carModel.Length == 0)
            {
                MessageBox.Show("Please provide a car model.");
            }
            if (carEngine.Length == 0)
            {
                MessageBox.Show("Please provide a car Engine.");
            }
            //get the car detail and store in the car class
            Car.EngineType Engine = new Car.EngineType(carEngine);
            Car myCar = new Car(carModel, Engine);
            //Display the details in a single line in a label.
            lblResult.Text = $"Your car's model is {myCar.Model} with {myCar.Engine.Type} engine.";
        }
    }
}
