using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo : Animal, IAnimal
    {
        public string name;
        /*
        public void SayHello()
        {
            textBalloon.SetActive(true);
            textObject.text = "splash";
        }

        public void EatLeaves()
        {
            textBalloon.SetActive(true);
            textObject.text = "munch munch lovely";
        }*/

        public void Eat()
        {
            throw new System.NotImplementedException();
        }

        public void SayHello()
        {
            throw new System.NotImplementedException();
        }
    }
    
}
