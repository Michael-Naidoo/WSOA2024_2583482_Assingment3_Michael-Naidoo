using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Care : MonoBehaviour
{
    public InHand ih;
    public void Cares()
    {
        ih.money += 2 * ih._noSheep.Count;
    }
}
