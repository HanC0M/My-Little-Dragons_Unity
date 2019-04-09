using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateEvent : MonoBehaviour
{
    System.DateTime oldDay;
    System.DateTime curDay;
    System.TimeSpan OneDay;
    // Start is called before the first frame update
    void Start()
    {
        OneDay = System.TimeSpan.FromDays(1);
        curDay = System.DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
