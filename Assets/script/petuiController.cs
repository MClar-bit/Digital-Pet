using UnityEngine;
using UnityEngine.UI;

public class PetUIController : MonoBehaviour
{
    public Slider hungerSlider;
    public Slider energySlider;
    public Slider happySlider;
    public Slider cleanSlider;
    public static PetUIController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one PetUIController in the Scene");
    }

    public void setValue(int food, int energy, int happiness, int clean)
    {
        hungerSlider.value = food;
        energySlider.value = energy;
        happySlider.value = happiness;
        cleanSlider.value = clean;
        
    }
}

