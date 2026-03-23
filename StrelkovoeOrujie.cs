namespace Console_App
{
    class StrelkovoeOrujie
    {
        private string nazvanie;
        private float kalibr;
        private double dalnost;
        public StrelkovoeOrujie()
        {
            nazvanie = "Не указано";
            kalibr = 00.00f;
            dalnost = 0.0;
        }
        public StrelkovoeOrujie(string nazvanie, float kalibr, double dalnost)
        {
            this.nazvanie = nazvanie;
            this.kalibr = kalibr;
            this.dalnost = dalnost;
        }
        public string Nazvanie
        {
            get { return nazvanie; }
            set { nazvanie = value; }
        }
        public float Kalibr
        {
            get { return kalibr; }
            set { kalibr = value; }
        }
        public double Dalnost
        {
            get { return dalnost; }
            set { dalnost = value; }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Название: {nazvanie}");
            Console.WriteLine($"Калибр: {kalibr} мм");
            Console.WriteLine($"Дальность стрельбы: {dalnost} м\n");
        }
    }
}