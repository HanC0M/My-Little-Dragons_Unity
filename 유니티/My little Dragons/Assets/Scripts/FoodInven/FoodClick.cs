using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FoodClick : MonoBehaviour
{

    public void Salty()
    {
      
        DataController.GetInstance().SetItemCode(0);
        DataController.GetInstance().SetShopCode(0);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
    public void Goso()
    {
        
       
        
        DataController.GetInstance().SetItemCode(1);
        DataController.GetInstance().SetShopCode(1);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
    public void Spicy()
    {
               
        DataController.GetInstance().SetItemCode(2);
        DataController.GetInstance().SetShopCode(2);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
    public void Sinmat()
    {
        

        
        DataController.GetInstance().SetItemCode(3);
        DataController.GetInstance().SetShopCode(3);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
    public void Sseunmat()
    {
        
    
        
        DataController.GetInstance().SetItemCode(4);
        DataController.GetInstance().SetShopCode(4);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
    public void Sweet()
    {
       
  
        DataController.GetInstance().SetItemCode(5);
        DataController.GetInstance().SetShopCode(5);
        Debug.Log(DataController.GetInstance().GetItemCode());
    }
}
