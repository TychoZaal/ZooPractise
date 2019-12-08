using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    internal class Lion : Animal, IAnimal
    {
        public string name;

        /*public void SayHello()
        {
            textBalloon.SetActive(true);
            textObject.text = "roooaoaaaaar";
        }

        public void EatMeat()
        {
            textBalloon.SetActive(true);
            textObject.text = "nomnomnom thx mate";
        }*/

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void SayHello()
        {
            throw new NotImplementedException();
        }
    }
}
