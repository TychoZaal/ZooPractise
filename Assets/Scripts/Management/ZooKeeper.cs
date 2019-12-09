using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZooKeeper : MonoBehaviour, IObserver
{
    #region Variables
    [SerializeField]
    private Text inputField;

    private List<GameObject> animals = new List<GameObject>();

    private Dictionary<string, Animal> animalDictionary = new Dictionary<string, Animal>(); // Dictionary to easily access an object by a key (string in this case)
    #endregion

    #region Singleton
    private static ZooKeeper _instance;

    public static ZooKeeper Instance { get { return _instance; } }

    private void Awake() // Instantiate singleton if it does not already exist
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    #endregion

    #region Observer pattern
    public void AddListener(GameObject newAnimal) // Adds observable object to the list
    {
        animals.Add(newAnimal.gameObject);

        Animal animalComponent = newAnimal.GetComponent<Animal>();

        if (animalComponent != null) // If the object is also an animal, it will get added to the dictionary with its name as the key
        {
            if (animalDictionary.ContainsKey(animalComponent.AnimalName)) // Check for duplicates
            {
                Debug.LogError("Trying to add animal with a duplicate name");
                return;
            }
            if (animalComponent.AnimalName.Equals("")) // If it has no name
            {
                Debug.LogError("Trying to add animal without a name of type " + animalComponent);
                return;
            }
            else // If all is good, add it to the dictionary
            {
                animalDictionary.Add(animalComponent.AnimalName, animalComponent);
            }
        }
    }
    #endregion

    #region Perform animal actions
    public void GiveMeat() // Feed all animals that eat meat
    {
        foreach (GameObject animal in animals)
        {
            ICarnivore carnivoreTemp = animal.GetComponent<ICarnivore>();

            if (carnivoreTemp != null)
            {
                carnivoreTemp.EatMeat();
            }
        }
    }

    public void GiveLeaves() // Feed all animals that eat leaves 
    {
        foreach (GameObject animal in animals)
        {
            IHerbivore herbivoreTemp = animal.GetComponent<IHerbivore>();

            if (herbivoreTemp != null)
            {
                herbivoreTemp.EatLeaves();
            }
        }
    }

    public void InstructTrick() // Tell all animals that can do a trick to perform a trick
    {
        foreach (GameObject animal in animals)
        {
            IPerformTrick performTrickTemp = animal.GetComponent<IPerformTrick>();

            if (performTrickTemp != null)
            {
                StartCoroutine(performTrickTemp.PerformTrick());
            }
        }
    }

    public void InstructTalking() // Tell either one animal, or all animals to talk
    {
        Animal cacheObject;

        if (animalDictionary.TryGetValue(inputField.text, out cacheObject)) // If an animal with the name from the field exists
        {
            cacheObject.SayHello(); // Only this specific animal talk
        }
        else // If the field name does not exist, then all animals talk
        {
            foreach (GameObject animal in animals)
            {
                cacheObject = animal.GetComponent<Animal>();

                if (cacheObject != null)
                {
                    cacheObject.SayHello();
                }
            }
        }
    }
    #endregion
}
