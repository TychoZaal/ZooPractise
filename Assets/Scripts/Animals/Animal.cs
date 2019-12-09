using UnityEngine;
using UnityEngine.UI;

public abstract class Animal : MonoBehaviour, IObserved // Every animal has to be subscribed to an observer, in this case the zoo keeper
{
    #region Variables
    [SerializeField]
    private string animalName;
    public string AnimalName { get => animalName;} // public getter for animal name. Used in the ZooKeeper's dictionary 

    [SerializeField]
    protected GameObject Balloon;
    [SerializeField]
    protected Text text;
    #endregion

    public abstract void SayHello(); // Empty method so that child classes have to implement and give context

    private void Start() 
    {
        SubscribeToObserver(); // Call method instead of calling AddListener() himself, if you ever want ignore an observer before a certain time in the game (Achievements, etc)
    }

    public void SubscribeToObserver()
    {
        ZooKeeper.Instance.AddListener(gameObject); 
    }
}
