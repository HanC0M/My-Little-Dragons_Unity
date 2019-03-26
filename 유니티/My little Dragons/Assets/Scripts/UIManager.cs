using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
   
    public Text uiDisplayer;
    public DataController dataController;
    public GameObject levelUpPopUp;
   
    int maxExp = 0;

    List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();

    void Awake()
    {
        Debug.Log("스크립트 붙인 오브젝트 : " + this.gameObject.name);
        levelUpPopUp.SetActive(false);
        data = CSVReader.Read("Exp_LevelUp");
    }
    
    void Update()
    {
        //List<Dictionary<string, object>> data = CSVReader.Read("Exp_LevelUp");
        int level = DataController.GetInstance().GetLevel();
       // Debug.Log(maxExp + "  " + level);
        float gold = DataController.GetInstance().GetGold();
        float exp = DataController.GetInstance().GetExp();
        maxExp = (int)data[level-1]["Exp"];
        
        float favor = DataController.GetInstance().GetFavor();
        if (exp >= maxExp)
        {
            DataController.GetInstance().SubExp(maxExp);
          //  Debug.Log("빼짐" + maxExp+"  "+level);
            if (level < 10)
            {
                DataController.GetInstance().AddLevel(1);
                levelUpPopUp.gameObject.SetActive(true);
            }
          
        }
        if (level < 10)
        {
            uiDisplayer.text = "레벨 " + level + "\n골드 : " + Mathf.Round(gold) +
                "\n경험치 : " + Mathf.Round(exp) + "\n호감도 : " + Mathf.Round(favor);
        }
        else
        {
            uiDisplayer.text = "만렙이다 이.거.야☆"+ "\n골드 : " + Mathf.Round(gold) +
                "\n경험치 : 최대치다 이.거.야☆" + "\n호감도 : " + Mathf.Round(favor);
        }
    }
}
