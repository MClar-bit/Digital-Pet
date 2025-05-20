using System;
using UnityEngine;

public class needsController:MonoBehaviour
{
    public int hunger, energy, happy, clean;
    public int hungerTick, energyTick, happyTick, cleanTick;
    public DateTime lastHunger, lastEnergy, lastHappy, lastClean; 

    public void Initialize(int hunger, int energy, int happy, int clean, 
    int hungerTick, int energyTick, int happyTick, int cleanTick){
        lastHunger = DateTime.Now;
        lastEnergy = DateTime.Now;
        lastHappy = DateTime.Now;
        lastClean = DateTime.Now;

        this.hunger = hunger;
        this.energy = energy;
        this.happy = happy;
        this.clean = clean;
        this.hungerTick = hungerTick;
        this.energyTick = energyTick;
        this.happyTick = happyTick;
        this.cleanTick = cleanTick;

    }
    private void Update(){
        if (TimingManager.instance.gameHourTimer < 0){
            //make variations on the rate
            ChangeHunger(-hungerTick);
            ChangeEnergy(-energyTick);
            ChangeHappy(-happyTick);
            ChangeClean(-cleanTick);
            PetUIController.instance.setValue(hunger, energy, happy, clean);
        }
    }

    public void ChangeHunger(int amount){
        hunger += amount;
        if (amount>0){
            lastHunger = DateTime.Now;
        }
        if (hunger<0){
            PetManager.instance.Die();

        } else if (hunger>100){
            hunger =100;
        }
    }
    public void ChangeEnergy(int amount){
        energy += amount;
        if (amount>0){
            lastEnergy = DateTime.Now;
        }
        if (energy<0){
            PetManager.instance.Die();

        }else if (energy>100){
            energy =100;
        }
    }
    public void ChangeHappy(int amount){
        happy += amount;
        if (amount>0){
            lastHappy = DateTime.Now;
        }
        if (happy<0){
            PetManager.instance.Die();

        }else if (happy>100){
            happy =100;
        }
    }
    public void ChangeClean(int amount){
        clean += amount;
        if (amount>0){
            lastClean = DateTime.Now;
        }
        if (clean<0){
            PetManager.instance.Die();
        }else if (clean>100){
            clean =100;
        }
    }
}
