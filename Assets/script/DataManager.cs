using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    private Database database;
    
    public needsController needsController;
 

    private void Awake()
    {
        database = new Database();
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one DatabaseManager in the Scene");
    }

    private void Update()
    {
        if(TimingManager.instance.gameHourTimer < 0){
            Pet pet = new Pet(needsController.lastHunger.ToString(),
                needsController.lastEnergy.ToString(),
                needsController.lastHappy.ToString(),
                needsController.lastClean.ToString(),
                needsController.hunger,
                needsController.energy,
                needsController.happy,
                needsController.clean);
            SavePet(pet);  // Fix it keeps inputting values as 0 even when it's not 
        }
        
    }

    public void Start()
    {
        Pet pet = LoadPet();
        if (pet != null) Debug.Log(LoadPet().energy);
    }

    public void SavePet(Pet pet)
    {
        database.saveData("pet", pet);
    }

    public Pet LoadPet()
    {
        Pet returnValue = null;
        database.loadData<Pet>("pet", (pet) =>
        {
            returnValue = pet;
        });
        return returnValue;
    }

   
}
