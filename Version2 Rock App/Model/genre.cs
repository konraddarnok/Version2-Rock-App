namespace Version2_Rock_App.Model
{
    public class genre
    {
        
        private string _pop;
        private string _rock;
        private string _heavyMetal;
        public genre(string pop, string rock, string heavyMetal)
        {
            Pop = pop;
            Rock = rock;
            HeavyMetal = heavyMetal;

        }
        public string Pop { get; set; }
        public string Rock { get; set; }
        public string HeavyMetal { get; set; }

    }

}
