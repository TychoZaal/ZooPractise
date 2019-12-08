using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooManager : MonoBehaviour, IFoodObserver, ITrickObserver, ITalkObserver
{
    public List<EatBehaviour> eatingAnimals;
    public List<TrickBehaviour> trickingAnimals;
    public List<TalkBehaviour> talkingAnimals;

    private static ZooManager instance;
    public static ZooManager Instance { get { return instance; } }

    #region Singleton
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }
    #endregion

    #region Adding
    public void AddNewFoodObservable(EatBehaviour eater)
    {
        eatingAnimals.Add(eater);
    }

    public void AddNewTalkObservable(TalkBehaviour talker)
    {
        talkingAnimals.Add(talker);
    }

    public void AddNewTrickObservable(TrickBehaviour tricker)
    {
        trickingAnimals.Add(tricker);
    }
    #endregion

    #region Notifying
    public void NotifyAllFood(EatBehaviour eatBehaviour)
    {
        for (int i = 0; i < eatingAnimals.Count; i++)
        {
            if (eatingAnimals[i] == eatBehaviour)
            {
                eatingAnimals[i].Notify();
            }
        }
    }

    public void NotifyAllTalk(TalkBehaviour talkBehaviour)
    {
        for (int i = 0; i < talkingAnimals.Count; i++)
        {
            talkingAnimals[i].Notify();
        }
    }

    public void NotifyAllTrick(TrickBehaviour trickBehaviour)
    {
        for (int i = 0; i < trickingAnimals.Count; i++)
        {
            trickingAnimals[i].Notify();
        }
    }
    #endregion
}
