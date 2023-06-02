using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Random = UnityEngine.Random;

public class Worker : MonoBehaviour
{
    public GameObject workerPoint1;
    public GameObject workerPoint2;
    public Transform par1;
    public Transform par2;
    

    private void Update()
    {
        var rand = Random.Range(-2, 2);
        var x = workerPoint2.transform.position.x ;
        var y = workerPoint2.transform.position.y + rand;
        var target = new Vector2(x, y);
        if (transform.parent == par1)
        {
            transform.position = Vector2.MoveTowards(transform.position, workerPoint1.transform.position, 30);
        }
        else if (transform.parent == par2)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, 30);
        }
    }
}
