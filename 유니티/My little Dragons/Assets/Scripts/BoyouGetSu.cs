using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BoyouGetSu : MonoBehaviour
{
    public Text itemCount;
   
    int count;
    void Update()
    {
        count = DataController.GetInstance().GetItemCount(DataController.GetInstance().GetShopCode());
        //itemCount.text = count.ToString();
    }
}
