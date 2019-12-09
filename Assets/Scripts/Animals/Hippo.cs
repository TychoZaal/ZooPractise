namespace Zoo
{
    class Hippo : Animal, IHerbivore // Hippo's eat leaves and cannot perform tricks
    {
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "splash";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch lovely";
        }
    }
    
}
