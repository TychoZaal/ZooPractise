using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Mike : Animal, IPerformTrick // Mike is so dissapointed, he doesn't eat or do cool tricks, all he does is stare 👀
    {
        public IEnumerator PerformTrick() // Mike stares deep
        {
            for (int i = 0; i < 3; i++)
            {
                transform.localScale += new Vector3(i, i, i);
                StopAllCoroutines();
                StartCoroutine(Shrink());
                yield return new WaitForEndOfFrame();
            }
        }

        private IEnumerator Shrink() // Mike has seen enough
        {
            yield return new WaitForSeconds(3);
            transform.localScale = new Vector3(1, 1, 1);
            yield return new WaitForEndOfFrame();
        }

        public override void SayHello()
        {
            Balloon.SetActive(true);
            text.text = ".........bruh..........";
        }
    }
}
