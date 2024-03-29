﻿using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Tiger : Animal, ICarnivore, IPerformTrick // Tigers eat meat and can perform tricks
    {
        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "rraaarww";
        }

        public IEnumerator PerformTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx wubalubadubdub";
        }
    }
}
