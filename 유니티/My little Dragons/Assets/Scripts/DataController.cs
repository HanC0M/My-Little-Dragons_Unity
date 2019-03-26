using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataController : MonoBehaviour


{
    private static DataController instance;

    public static DataController GetInstance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<DataController>();
            if (instance == null)
            {
                GameObject container = new GameObject("DataController");

                instance = container.AddComponent<DataController>();
            }
        }
        return instance;
    }
    // 골드
    private float m_gold = 0;
    private int m_goldPerClick = 0;

    // 파라미터값
    private float m_favor = 0.0f; // 호감도
    private float m_food = 0.0f; // 포만감
    private float m_clean = 0.0f; // 청결도 
    private float m_boredom = 0.0f; // 심심함
    private float m_exp = 0.0f; // 경험치

    private float m_stress = 0.0f; // 스트레스

    // 레벨
    private int m_level;

    // boolean
    bool washCheck=false;
    bool dragCheck = false;
    void Awake()
    {
        // KEY : VALUE
        // 골드와 터치 시 늘어나는 금액을 가져오는 부분(PlayerPrefs)
        m_gold = PlayerPrefs.GetFloat("Gold");
        m_goldPerClick = PlayerPrefs.GetInt("GoldPerClick",1); // 기본으로 가져오는 값이 1이다
        // 파라미터
        m_favor = PlayerPrefs.GetFloat("Favor",35);
        m_food = PlayerPrefs.GetFloat("Food",70f);
        m_clean = PlayerPrefs.GetFloat("Clean",70f);
        m_boredom = PlayerPrefs.GetFloat("Boredom");
        m_exp = PlayerPrefs.GetFloat("Exp");
    
        m_stress = PlayerPrefs.GetFloat("Stress");
        m_level = PlayerPrefs.GetInt("Level", 1);
    }
    public void SetLevel(int newLevel)
    {
        // 데이터 컨트롤러의 m_gold를 지정
        m_level = newLevel;
        PlayerPrefs.SetInt("Level", m_level); // Get에 쓰이는 키값과 Set에 쓰이는 키값이 같아야 함 // 플레이할 때마다 m_gold에 저장해줌
    }
    public void AddLevel(int newLevel)
    {
        m_level += newLevel;
        SetLevel(m_level);
    }
    public int GetLevel()
    {
        return m_level;
    }
    public void SetGold(float newGold)
    {
        // 데이터 컨트롤러의 m_gold를 지정
        m_gold = newGold;
        PlayerPrefs.SetFloat("Gold", m_gold); // Get에 쓰이는 키값과 Set에 쓰이는 키값이 같아야 함 // 플레이할 때마다 m_gold에 저장해줌
    }


    public void AddGold(float newGold)
    {
        // m_gold의 값에 추가된 골드 값을 더해줌
        m_gold += newGold;
        SetGold(m_gold);
    }


    public void SubGold(float newGold)
    {
        m_gold -= newGold;
        SetGold(m_gold);
    }


    public float GetGold()
    {
        return m_gold;
    }


    public void SetGoldPerClick(int newGoldPerClick)
    {
        // 데이터 컨트롤러의 m_goldPerClick 지정
        m_goldPerClick = newGoldPerClick;
        PlayerPrefs.SetInt("GoldPerClick", m_goldPerClick); // Get에 쓰이는 키값과 Set에 쓰이는 키값이 같아야 함 // 플레이할 때마다 m_goldPerClick에 저장해줌

    }


    public int GetGoldPerClick()
    {
        return m_goldPerClick;
    }


    public void AddGoldPerClick(int newGoldPerClick)
    {
        m_goldPerClick += newGoldPerClick;
        SetGoldPerClick(m_goldPerClick);
    }


    public void LoadUpgradeButton(UpgradeButton upgradeButton)
    {
        string key = upgradeButton.upgradeName;

        upgradeButton.level = PlayerPrefs.GetInt(key + "_level", 1);
        upgradeButton.goldByUpgrade = PlayerPrefs.GetInt(key+ "_goldByUpgrade", upgradeButton.startGoldByUpgrade);
        upgradeButton.currentCost = PlayerPrefs.GetInt(key + "_cost", upgradeButton.startCurrentCost);

    }


    public void SaveUpgradeButton(UpgradeButton upgradeButton)
    {
        string key = upgradeButton.upgradeName;

       PlayerPrefs.SetInt(key + "_level", upgradeButton.level);
       PlayerPrefs.SetInt(key + "_goldByUpgrade", upgradeButton.goldByUpgrade);
       PlayerPrefs.SetInt(key + "_cost", upgradeButton.currentCost);

    }


    public void SetFavor(float newFavor)
    {
        // 데이터 컨트롤러의 m_gold를 지정
        m_favor = newFavor;
        PlayerPrefs.SetFloat("Favor", m_favor); // Get에 쓰이는 키값과 Set에 쓰이는 키값이 같아야 함 // 플레이할 때마다 m_gold에 저장해줌
    }

    public void AddFavor(float newFavor)
    {
        // m_gold의 값에 추가된 골드 값을 더해줌
        m_favor += newFavor;
        SetFavor(m_favor);
    }

    public void SubFavor(float newFavor)
    {
        m_favor -= newFavor;
        SetFavor(m_favor);
    }

    public float GetFavor()
    {
        return m_favor;
    }


    public void SetFood(float newFood)
    {
        // 데이터 컨트롤러의 m_gold를 지정
        m_food = newFood;
        PlayerPrefs.SetFloat("Food", m_food); 
    }

    public void AddFood(float newFood)
    {
 
        m_food += newFood;
        SetFood(m_food);
    }

    public void SubFood(float newFood)
    {
        m_food -= newFood;
        SetFood(m_food);
    }

    public float GetFood()
    {
        return m_food;
    }


    public void SetClean(float newClean)
    {
        // 데이터 컨트롤러의 m_gold를 지정
        m_clean = newClean;
        PlayerPrefs.SetFloat("Clean", m_clean);
    }

    public void AddClean(float newClean)
    {

        m_clean += newClean;
        SetClean(m_clean);
    }

    public void SubClean(float newClean)
    {
        m_clean -= newClean;
        SetClean(m_clean);
    }

    public float GetClean()
    {
        return m_clean;
    }


    public void SetBoredom(float newBoredom)
    {
        // 데이터 컨트롤러의 m_gold를 지정
        m_boredom = newBoredom;
        PlayerPrefs.SetFloat("Boredom", m_boredom);
    }

    public void AddBoredom(float newBoredom)
    {

        m_boredom += newBoredom;
        SetBoredom(m_boredom);
    }

    public void SubBoredom(float newBoredom)
    {
        m_boredom -= newBoredom;
        SetBoredom(m_boredom);
    }

    public float GetBoredom()
    {
        return m_boredom;
    }


    public void SetExp(float newExp)
    {
        // 데이터 컨트롤러의 m_gold를 지정
        m_exp = newExp;
        PlayerPrefs.SetFloat("Exp", m_exp);
    }

    public void AddExp(float newExp)
    {

        m_exp += newExp;
        SetExp(m_exp);
    }

    public void SubExp(float newExp)
    {
        m_exp -= newExp;
        SetExp(m_exp);
    }

    public float GetExp()
    {
        return m_exp;
    }


    public void SetStress(float newStress)
    {
        // 데이터 컨트롤러의 m_gold를 지정
        m_stress = newStress;
        PlayerPrefs.SetFloat("Stress", m_stress);
    }

    public void AddStress(float newStress)
    {

        m_stress += newStress;
        SetStress(m_stress);
    }

    public void SubStress(float newStress)
    {
        m_stress -= newStress;
        SetStress(m_stress);
    }

    public float GetStress()
    {
        return m_stress;
    }
    
    public bool GetWashCheck()
    {
        return washCheck;
    }
    public void SetWashCheckTRUE()
    {
        washCheck = true;
    }
    public void SetWashCheckFALSE()
    {
        washCheck = false;
    }

    public void DragCheckTRUE()
    {
        dragCheck = true;
    }
    public void DragCheckFALSE()
    {
        dragCheck = false;
    }
    public bool GetDragCheck()
    {
        return dragCheck;
    }
}

