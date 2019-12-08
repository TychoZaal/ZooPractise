using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatBehaviour : MonoBehaviour, IFoodObservable
{
    private void Start()
    {
        ZooManager.Instance.AddNewFoodObservable(this);
    }

    public void Notify()
    {
        EatFood();
    }

    protected virtual void EatFood()
    {

    }
}
