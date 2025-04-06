namespace CamXucApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Load sample data
            var sampleData = new CamXucModel.ModelInput()
            {
                Col0 = txtReview.Text
            };

            //Load model and predict output
            var result = CamXucModel.Predict(sampleData);
            lblPositive.Text = "Tin này " + Math.Round(result.Score[0] * 100, 2) + "% tích cực";
            lblNagative.Text = "Tin này " + Math.Round(result.Score[1] * 100, 2) + "% tiêu cực";

        }

        private void lblPositive_Click(object sender, EventArgs e)
        {

        }

        private void lblNagative_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}