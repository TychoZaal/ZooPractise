namespace Zoo
{
    class Lion : Animal, ICarnivore // Lions eat meat and can not do tricks
    {
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "roooaoaaaaar";
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx mate";
        }
    }
}
