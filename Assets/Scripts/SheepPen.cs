using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SheepPen : MonoBehaviour
{
    public bool takenCareOf;
    public bool hasAttention;
    public bool hasHunger;
    public bool hasEnergy;
    public bool hasCleanliness;
    public List<GameObject> _noCaretakers;
    public int noCaretakers;
    public int noAttention;
    public int noHunger;
    public int noEnergy;
    public int noCleanliness;

    private void Update()
    {
        if (_noCaretakers.Count > 0)
        {
            takenCareOf = true;
        }
        else
        {
            takenCareOf = false;
        }
        if (noAttention > 0)
        {
            hasAttention = true;
        }
        else
        {
            hasAttention = false;
        }
        if (noHunger > 0)
        {
            hasHunger = true;
        }
        else
        {
            hasHunger = false;
        }
        if (noEnergy > 0)
        {
            hasEnergy = true;
        }
        else
        {
            hasEnergy = false;
        }
        if (noCleanliness > 0)
        {
            hasCleanliness = true;
        }
        else
        {
            hasCleanliness = false;
        }
    }
}
