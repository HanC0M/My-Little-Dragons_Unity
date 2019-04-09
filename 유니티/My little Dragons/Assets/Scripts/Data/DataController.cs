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
    bool foodCheck = false;
    bool toyCheck = false;
    bool shopCheck = false;

    // 아이템
    int itemCode = 0;
    int toyCode = 0;
    int shopCode = 0;
    int itemCount = 0;
    int getCount = 0;

    int salty = 0;
    int goso = 0;
    int sweet = 0;
    int sinmat = 0;
    int spicy = 0;
    int sseunmat = 0;
    int tennis = 0;
    int wonban = 0;
    int doll = 0;
    int evo_1 = 0;
    int evo_2 = 0;

    // 가격
    int p_salty = 15;
    int p_goso = 15;
    int p_sweet = 15;
    int p_sinmat = 15;
    int p_spicy = 15;
    int p_sseunmat = 15;
    int p_tennis = 20;
    int p_wonban = 30;
    int p_doll = 50;
    int p_evo_1 = 0;
    int p_evo_2 = 0;
    int getPrice = 0;
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

        salty = PlayerPrefs.GetInt("Salty", 0);
        goso = PlayerPrefs.GetInt("Goso", 0);
        sweet = PlayerPrefs.GetInt("Sweet", 0);
        sinmat = PlayerPrefs.GetInt("Sinmat", 0);
        sseunmat = PlayerPrefs.GetInt("Sseunmat", 0);
        spicy = PlayerPrefs.GetInt("Spicy", 0);

        tennis = PlayerPrefs.GetInt("Tennis", 0);
        wonban = PlayerPrefs.GetInt("Wonban", 0);
        doll = PlayerPrefs.GetInt("Doll", 0);
        evo_1 = PlayerPrefs.GetInt("Evo_1", 0);
        evo_2 = PlayerPrefs.GetInt("Evo_2", 0);
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

    public bool GetFoodCheck()
    {
        return foodCheck;
    }
    public void SetFoodCheckTRUE()
    {
        foodCheck = true;
    }
    public void SetFoodCheckFALSE()
    {
        foodCheck = false;
    }

    public void SetItemCode(int Code)
    {
        itemCode = Code;
    }
    public int GetItemCode()
    {
        return itemCode;
    }

    public bool GetToyCheck()
    {
        return toyCheck;
    }
    public void SetToyCheckTRUE()
    {
        toyCheck = true;
    }
    public void SetToyCheckFALSE()
    {
        toyCheck = false;
    }

    public void SetToyCode(int Code)
    {
        toyCode = Code;
    }
    public int GetToyCode()
    {
        return toyCode;
    }

    public bool GetShopCheck()
    {
        return shopCheck;
    }
    public void SetShopCheckTRUE()
    {
        shopCheck = true;
    }
    public void SetShopCheckFALSE()
    {
        shopCheck = false;
    }

    public void SetShopCode(int Code)
    {
        shopCode = Code;
    }
    public int GetShopCode()
    {
        return shopCode;
    }

    public int GetItemCount(int  shopCode)
    {
        
        switch (shopCode)
        {
            case 0 :
                getCount = salty;
                break;
            case 1:
                getCount = goso;
                break;
            case 2:
                getCount = spicy;
                break;
            case 3:
                getCount = sinmat;
                break;
            case 4:
                getCount = sseunmat;
                break;
            case 5:
                getCount = sweet;
                break;
            case 6:
                getCount = tennis;
                break;
            case 7:
                getCount = wonban;
                break;
            case 8:
                getCount = doll;
                break;
            case 9:
                getCount = evo_1;
                break;
            case 10:
                getCount = evo_2;
                break;
        }
        return getCount;
    }
    public void AddItemCount(int shopCode)
    {
        switch (shopCode)
        {
            case 0:
                salty++;
                SubGold(DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode()));
                PlayerPrefs.SetInt("Salty", salty);
                break;
            case 1:
                goso++;
                SubGold(DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode()));
                PlayerPrefs.SetInt("Goso", goso);
                break;
            case 2:
                spicy++;
                SubGold(DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode()));
                PlayerPrefs.SetInt("Spicy", spicy);
                break;
            case 3:
                sinmat++;
                SubGold(DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode()));
                break;
            case 4:
                sseunmat++;
                SubGold(DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode()));
                PlayerPrefs.SetInt("Sseunmat", sseunmat);
                break;
            case 5:
                sweet++;
                SubGold(DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode()));
                PlayerPrefs.SetInt("Sweet", sweet);
                break;
            case 6:
                tennis++;
                SubGold(DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode()));
                PlayerPrefs.SetInt("Tennis", tennis);
                break;
            case 7:
                wonban++;
                SubGold(DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode()));
                PlayerPrefs.SetInt("Wonban", wonban);
                break;
            case 8:
                doll++;
                SubGold(DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode()));
                PlayerPrefs.SetInt("Doll", doll);
                break;
            case 9:
                evo_1++;
                SubGold(DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode()));
                PlayerPrefs.SetInt("Evo_1", evo_1);
                break;
            case 10:
                SubGold(DataController.GetInstance().GetPrice(DataController.GetInstance().GetShopCode()));
                
                break;
        }
    }
    public void UseFoodItem(int itemCode)
    {
        switch (itemCode)
        {
            case 0:
                if (salty >= 1)
                {
                    salty--;
                    PlayerPrefs.SetInt("Salty", salty);
                }
                else
                {
                    break;
                }
                break;
            case 1:
                if (goso >= 1)
                {
                    goso--;
                    PlayerPrefs.SetInt("Goso", goso);
                }
                else
                {
                    break;
                }
                break;
            case 2:
                if (spicy >= 1)
                {
                    spicy--;
                    PlayerPrefs.SetInt("Spicy", spicy);
                }
                else break;
                break;
            case 3:
                if (sinmat >= 1)
                {
                    sinmat--;
                    PlayerPrefs.SetInt("Sinmat", sinmat);
                }
                else break;
                break;
            case 4:
                if (sseunmat >= 1)
                {
                    sseunmat--;
                    PlayerPrefs.SetInt("Sseunmat", sseunmat);
                }
                else break;
                break;
            case 5:
                if (sweet >= 1)
                {
                    sweet--;
                    PlayerPrefs.SetInt("Sweet", sweet);
                }
                else break;
                break;
     
        }
    }
    public void UseToyItem(int itemCode)
    {
        switch (itemCode)
        {
            case 0:
                if (tennis >= 1)
                {
                    tennis--;
                    PlayerPrefs.SetInt("Tennis", tennis);
                }
                
                break;
            case 1:
                if (wonban >= 1)
                {
                    wonban--; PlayerPrefs.SetInt("Wonban", wonban);
                }
                else break;
                break;
            case 2:
                if (doll >= 1)
                {
                    doll--;
                    PlayerPrefs.SetInt("Doll", doll);
                }
                else break;
                break;
            case 3:
                if (evo_1 >= 1)
                {
                    evo_1--;
                    PlayerPrefs.SetInt("Evo_1", evo_1);
                }
                else break;
                break;
            case 4:
                if (evo_2 >= 1)
                    evo_2--;
                else break;
                break;
        }
    }

    public int GetPrice(int shopCode)
    {

        switch (shopCode)
        {
            case 0:
                getPrice = p_salty;
                break;
            case 1:
                getPrice = p_goso;
                break;
            case 2:
                getPrice = p_spicy;
                break;
            case 3:
                getPrice = p_sinmat;
                break;
            case 4:
                getPrice = p_sseunmat;
                break;
            case 5:
                getPrice = p_sweet;
                break;
            case 6:
                getPrice = p_tennis;
                break;
            case 7:
                getPrice = p_wonban;
                break;
            case 8:
                getPrice = p_doll;
                break;
            case 9:
                getPrice = p_evo_1;
                break;
            case 10:
                getPrice = p_evo_2;
                break;
        }
        return getPrice;
    }
}

