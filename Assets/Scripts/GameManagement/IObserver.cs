using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Food
public interface IFoodObserver
{
    void NotifyAllFood(EatBehaviour eatBehaviour);
    void AddNewFoodObservable(EatBehaviour eater);
}

public interface IFoodObservable
{
    void Notify();
}
#endregion

#region Trick
public interface ITrickObserver
{
    void NotifyAllTrick(TrickBehaviour trickBehaviour);
    void AddNewTrickObservable(TrickBehaviour tricker);
}

public interface ITrickObservable
{
    void Notify();
}
#endregion

#region Talk
public interface ITalkObserver
{
    void NotifyAllTalk(TalkBehaviour talkBehaviour);
    void AddNewTalkObservable(TalkBehaviour talker);
}

public interface ITalkObservable
{
    void Notify();
}
#endregion
