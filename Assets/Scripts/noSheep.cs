using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class noSheep : MonoBehaviour
{
    public InHand ih;
    public Text text;
    void Update()
    {
        text.text = ih._noSheep.Count.ToString();
    }
}
