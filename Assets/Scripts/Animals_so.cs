using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Animal", menuName = "Animal")]
public class Animals_so : ScriptableObject
{
    public new string name;
    public Image image;
    public int attention = 100;
    public int hunger = 100;
    public int energy = 100;
    public int cleanliness = 100;
    public int hp = 100;

    public int hpCalculate(int att, int hun, int ene, int cle)
    {
        hp = 100 - (((100 - att) + (100 - hun) + (100 - ene) + (100 - cle)) / 4);
        return hp;
    }
}
