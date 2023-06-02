using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class RemoveStaff : MonoBehaviour
{
    public InHand ih;
    public SheepPen sp;
    public Transform pos1;
    public void Attention()
    {
        if (sp.noAttention > 0)
        {
            sp.noAttention--;
            var worker = sp._noCaretakers[0];
            ih._noWorkers.Add(worker);
            sp._noCaretakers.Remove(worker);
            worker.transform.parent = pos1;
        }
    } 
    public void Hunger()
    {
        if (sp.noHunger > 0)
        {
            sp.noHunger--;
            var worker = sp._noCaretakers[0];
            ih._noWorkers.Add(worker);
            sp._noCaretakers.Remove(worker);
            worker.transform.parent = pos1;
        }
    }
    public void Energy()
    {
        if (sp.noEnergy > 0)
        {
            sp.noEnergy--;
            var worker = sp._noCaretakers[0];
            ih._noWorkers.Add(worker);
            sp._noCaretakers.Remove(worker);
            worker.transform.parent = pos1;
        }
    }
    public void Cleanliness()
    {
        if (sp.noCleanliness > 0)
        {
            sp.noCleanliness--;
            var worker = sp._noCaretakers[0];
            ih._noWorkers.Add(worker);
            sp._noCaretakers.Remove(worker);
            worker.transform.parent = pos1;
        }
    }
}
