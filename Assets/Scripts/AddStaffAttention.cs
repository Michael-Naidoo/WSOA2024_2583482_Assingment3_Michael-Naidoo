using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class AddStaffAttention : MonoBehaviour
{
    public InHand ih;
    public SheepPen sp;
    public Transform pos2;
    public void Attention()
    {
        if (ih.noWorkers > 0 && ih.day)
        {
            sp.noAttention++;
            var worker = ih._noWorkers[0];
            sp._noCaretakers.Add(worker);
            ih._noWorkers.Remove(worker);
            worker.transform.parent = pos2;
        }
    } 
    public void Hunger()
    {
        if (ih.noWorkers > 0 && ih.day)
        {
            sp.noHunger++;
            var worker = ih._noWorkers[0];
            sp._noCaretakers.Add(worker);
            ih._noWorkers.Remove(worker);
            worker.transform.parent = pos2;
        }
    }
    public void Energy()
    {
        if (ih._noWorkers.Count > 0 && ih.day)
        {
            sp.noEnergy++;
            var worker = ih._noWorkers[0];
            sp._noCaretakers.Add(worker);
            ih._noWorkers.Remove(worker);
            worker.transform.parent = pos2;
        }
    }
    public void Cleanliness()
    {
        if (ih.noWorkers > 0 && ih.day)
        {
            sp.noCleanliness++;
            var worker = ih._noWorkers[0];
            sp._noCaretakers.Add(worker);
            ih._noWorkers.Remove(worker);
            worker.transform.parent = pos2;
        }
    }
}
