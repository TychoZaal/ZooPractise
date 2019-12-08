using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Pig : MonoBehaviour, IAnimal
    {
        public string name;

        /*public void SayHello()
        {
            textBalloon.SetActive(true);
            textObject.text = "oink oink";
        }

        public void EatLeaves()
        {
            textBalloon.SetActive(true);
            textObject.text = "munch munch oink";
        }

        public void EatMeat()
        {
            textBalloon.SetActive(true);
            textObject.text = "nomnomnom oink thx";
        }

        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
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
