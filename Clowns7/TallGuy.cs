namespace Clowns7
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            System.Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
        }

        public string FunnyThingIHave
        {
            get { return "big shoes"; }
        }

        public void Honk()
        {
            System.Console.WriteLine("Honk Honk!");
        }
    }
}
