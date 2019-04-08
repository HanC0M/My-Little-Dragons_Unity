using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCount : MonoBehaviour
{
    public Text itemCount;
    public int i;
    int count;
    void Update()
    {
        count = DataController.GetInstance().GetItemCount(i);
        itemCount.text = count.ToString();
    }
}
