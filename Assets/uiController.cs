using UnityEngine;
using UnityEngine.UI;

public class PetUIController : MonoBehaviour
{
    public Slider energySlider;
    public static PetUIController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one PetUIController in the Scene");
    }

    public void setValue(int food, int happiness, int energy)
    {
        energySlider.value = food;
        
    }
}

