using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class AnimalInfo : MonoBehaviour
{
    public Animals_so _animalsSo;
    public int hp;
    public Image image;
    public SheepPen sp;
    public InHand ih;
    public float careTimer = 10;
    public float attentionTimer = 5;
    public int attention;
    public int hunger;
    public int energy;
    public int cleanliness;
    public float hungerTimer = 10;
    public float energyTimer = 2;
    public float cleanlinessTimer = 8;

    public void Start()
    {
        hp = _animalsSo.hp;
        image = _animalsSo.image;
        attention = _animalsSo.attention;
        hunger = _animalsSo.hunger;
        energy = _animalsSo.energy;
        cleanliness = _animalsSo.cleanliness;
    }

    private void Update()
    {
        hp = _animalsSo.hpCalculate(attention, hunger, energy, cleanliness);
        if (sp.takenCareOf)
        {
            careTimer -= Time.deltaTime;
            if (careTimer <= 0)
            {
                careTimer = 10;
                if (hp > 70)
                {
                    ih.money += 2 * sp._noCaretakers.Count;
                }
            }
            attentionTimer -= Time.deltaTime;
            hungerTimer -= Time.deltaTime;
            energyTimer -= Time.deltaTime;
            cleanlinessTimer -= Time.deltaTime;
            if (attentionTimer <= 0 && sp.hasAttention)
            {
                attentionTimer = 5;
                if (attention < 100)
                {
                    attention += 5;
                }
            }
            if (hungerTimer <= 0 && sp.hasHunger)
            {
                hungerTimer = 10;
                if (hunger < 100)
                {
                    hunger += 4;
                }
            }
            if (energyTimer <= 0 && sp.hasEnergy)
            {
                energyTimer = 2;
                if (energy < 100)
                {
                    energy += 3;
                }
            }
            if (cleanlinessTimer <= 0 && sp.hasCleanliness)
            {
                cleanlinessTimer = 8;
                if (cleanliness < 100)
                {
                    cleanliness += 2;
                }
            }
        }
        else
        {
            attentionTimer -= Time.deltaTime;
            hungerTimer -= Time.deltaTime;
            energyTimer -= Time.deltaTime;
            cleanlinessTimer -= Time.deltaTime;
            if (attentionTimer <= 0)
            {
                attentionTimer = 5;
                if (attention > 0)
                {
                    attention -= 5;
                }
            }
            if (hungerTimer <= 0)
            {
                hungerTimer = 10;
                if (hunger > 0)
                {
                    hunger -= 4;
                }
            }
            if (energyTimer <= 0)
            {
                energyTimer = 2;
                if (energy > 0)
                {
                    energy -= 3;
                }
            }
            if (cleanlinessTimer <= 0)
            {
                cleanlinessTimer = 8;
                if (cleanliness > 0)
                {
                    cleanliness -= 2;
                }
            }
        }
    }
}
