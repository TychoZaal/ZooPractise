namespace Zoo
{
    class Zebra : Animal, IHerbivore // Zebra's eat leaves and cannot perform tricks
    {
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "zebra zebra";
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch zank yee bra";
        }
    }
}
