﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemButton : MonoBehaviour
{
    public Text itemDisplayer; 
    public string itemName;

    public int level;

    [HideInInspector]
    public int currentCost;

    public int startCurrentCost = 1;
    [HideInInspector]
    public int goldPerSec;
    public int startGoldPerSec = 1;

    public float costPow = 3.14f;
    public float upgradePow = 1.07f;
    [HideInInspector]
    public bool isPurchased = false;

    void Start()
    {
        currentCost = startCurrentCost;
        goldPerSec = startGoldPerSec;
        StartCoroutine("AddGoldLoop");
        
        UpdateUI();
    }

    public void PurchaseItem()
    {
        if(DataController.GetInstance().GetGold()>= currentCost)
        {
            isPurchased = true;
            DataController.GetInstance().SubGold(currentCost);
            level++;

            UpdateItem();
            UpdateUI();
        }
    }
    
    IEnumerator AddGoldLoop() // 코루틴
    {
        while (true)
        {
            if (isPurchased)
            {
                
                DataController.GetInstance().AddGold(goldPerSec);
            }

            yield return new WaitForSeconds(1.0f);

        }
    }

    public void UpdateItem()
    {
        goldPerSec = goldPerSec+startGoldPerSec * (int)Mathf.Pow(upgradePow, level);
        currentCost = startCurrentCost * (int)Mathf.Pow(costPow , level);
    }

    public void UpdateUI()
    {
        itemDisplayer.text = itemName + "\nLevel : " + level+"\nCost : "+currentCost+"\nGoldPerSec : "+goldPerSec+"\nisPurchased : "
            +isPurchased;
    }
}