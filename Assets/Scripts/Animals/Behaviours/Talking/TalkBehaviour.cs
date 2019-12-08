using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkBehaviour : MonoBehaviour, ITrickObservable
{
    [CannotBeNullObjectField]
    [SerializeField]
    protected GameObject textBalloon;
    [CannotBeNullObjectField]
    [SerializeField]
    protected Text textObject;

    private void Start()
    {
        ZooManager.Instance.AddNewTalkObservable(this);
    }

    public void Notify()
    {
        Speak();
    }

    protected virtual void Speak()
    {

    }
}
