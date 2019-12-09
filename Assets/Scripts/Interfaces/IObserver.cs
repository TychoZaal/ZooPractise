using UnityEngine;

public interface IObserver // Interface for the observer
{
    void AddListener(GameObject gameObject); // Ensures observables can be accessed
}
 
public interface IObserved // Interface for the to be observed object
{
    void SubscribeToObserver(); // Ensures observables are referenced to an observer
}

