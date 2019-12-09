using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Tyler1 : Animal, ICarnivore, IPerformTrick // Tyler1 eats meat and can perform tricks
    {
        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "loltyler1.com discount code alpha";
        }

        public IEnumerator PerformTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(0, 0, i * 2);
                yield return new WaitForEndOfFrame();
            }
        }

        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "im tyler mfkn 1";
        }
    }
}
