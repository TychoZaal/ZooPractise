using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrickBehaviour : MonoBehaviour, ITrickObservable
{
    private void Start()
    {
        ZooManager.Instance.AddNewTrickObservable(this);
    }

    public void Notify()
    {
        DoTrick();
    }

    protected virtual void DoTrick()
    {

    }
}
