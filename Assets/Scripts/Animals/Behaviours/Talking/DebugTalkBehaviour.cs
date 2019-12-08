using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTalkBehaviour : TalkBehaviour
{
    [SerializeField]
    private string message;

    protected override void Speak()
    {
        textBalloon.SetActive(true);
        textObject.text = message;
    }
}
