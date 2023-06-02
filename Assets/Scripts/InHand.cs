using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class InHand : MonoBehaviour
    {
        public int money;
        public List<GameObject> _noSheep;
        public int noSheep;
        public List<GameObject> _noWorkers;
        public int noWorkers;
        public float time = 0;
        public float seconds = 0;
        public SheepPen sp;
        public Transform pos1;
        public bool day;
        public Text text;

        private void Update()
        {
            seconds += Time.deltaTime;
            if (time <= 12)
            {
                for (int i = 0; i < sp._noCaretakers.Count; i++)
                {
                    var worker = sp._noCaretakers[0];
                    _noWorkers.Add(worker);
                    sp._noCaretakers.Remove(worker);
                    worker.transform.parent = pos1;
                    noWorkers--;
                }

                day = false;
            }
            else day = true;

            if (time == 24)
            {
                time = 0;
            }
            if (seconds > 59)
            {
                seconds = 0;
                time++;
            }

            
            string clock = time.ToString("F0") + ":" + seconds.ToString("F0");
            text.text = clock;
        }
    }
}