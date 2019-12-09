using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra, fourHead, bruh;
        private void Start()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            henk.name = "henk";
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            elsa.name = "elsa";
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            dora.name = "dora";
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            wally.name = "wally";
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            marty.name = "marty";
            Tyler1 tyler1 = Instantiate(fourHead, transform).GetComponent<Tyler1>();
            tyler1.name = "tyler1";
            Mike mike = Instantiate(bruh, transform).GetComponent<Mike>();
            mike.name = "mike";
        }
    }
}
