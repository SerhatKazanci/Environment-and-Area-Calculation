namespace PROJE_HESAP
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double kareKenarUzunluk = Convert.ToDouble(textBoxKenar.Text);
            double alanKare = Math.Pow(kareKenarUzunluk, 2);
            labelKare.Text = alanKare.ToString();

         
            double k�saKenarUzunluk = Convert.ToDouble(textBoxK�saKenar.Text);
            double uzunKenarUzunluk = Convert.ToDouble(textBoxUzunKenar.Text);
            double alanDikdortgen = k�saKenarUzunluk * uzunKenarUzunluk;
            labelDikdortgen.Text = alanDikdortgen.ToString();

          

            double yaricap = Convert.ToDouble(textBoxYaricap.Text);
            double alanDaire =Math.PI * (yaricap * yaricap);
            labelDaire.Text = alanDaire.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double kareKenar = Convert.ToDouble(textBoxKenar.Text);
            double cevreKare = kareKenar * 4;
            labelKareCevre.Text = cevreKare.ToString();

            double dikdortgenK�saKenar = Convert.ToDouble(textBoxK�saKenar.Text);
            double dikdortgenUzunKenar = Convert.ToDouble(textBoxUzunKenar.Text);
            double cevreDikdortgen = (dikdortgenK�saKenar + dikdortgenUzunKenar) * 2;
            labelDikdortgenCevre.Text = cevreDikdortgen.ToString();

            double yaricapp = Convert.ToDouble(textBoxYaricap.Text);
            double cevreDaire = Math.PI * 2 * yaricapp;
            labelDaireCevre.Text = cevreDaire.ToString();
        }
    }
}