using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public InHand ih;
    public Text text;
    void Update()
    {
        text.text = ih.money.ToString();
    }
}
