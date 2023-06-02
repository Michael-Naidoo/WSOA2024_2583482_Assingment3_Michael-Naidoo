using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.Mathematics;
using UnityEngine;

public class HireStaff : MonoBehaviour
{
    public GameObject worker;
    public GameObject pos1;
    public GameObject pos2;
    public InHand ih;
    public Sprite image;
    public Transform par1;
    public Transform par2;
    public void Hire()
    {
        
        if (ih.money >= 5)
        {
            ih.noWorkers++;
            ih.money -= 5;
            GameObject newWorker = Instantiate(worker, pos1.transform.position, quaternion.identity);
            newWorker.GetComponent<Worker>().workerPoint1 = pos1;
            newWorker.GetComponent<Worker>().workerPoint2 = pos2;
            newWorker.GetComponent<Worker>().par1 = par1;
            newWorker.GetComponent<Worker>().par2 = par2;
            newWorker.transform.parent = par1;
            var spriteRenderer = newWorker.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = image;
            ih._noWorkers.Add(newWorker);
        }
    }
}
