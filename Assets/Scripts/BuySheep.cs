using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class BuySheep : MonoBehaviour
{
    public GameObject sheep;
    public GameObject pen;
    public SheepPen sp;
    public InHand ih;
    public Sprite image;

    public void SpawnSheep()
    {
        if (ih.money >= 5)
        {
            GameObject newSheep = Instantiate(sheep, pen.transform.position, quaternion.identity);
            newSheep.GetComponent<AnimalInfo>().sp = sp;
            newSheep.GetComponent<AnimalInfo>().ih = ih;
            var spriteRenderer = newSheep.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = image;
            ih.money -= 5;
            ih._noSheep.Add(newSheep);
        }

    }
}
