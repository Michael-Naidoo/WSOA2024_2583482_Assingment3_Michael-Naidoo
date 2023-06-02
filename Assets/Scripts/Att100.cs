using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Att100 : MonoBehaviour
{
    public AnimalInfo ai;
    public Text text;
    void Update()
    {
        text.text = ai.attention.ToString();
    }
}
