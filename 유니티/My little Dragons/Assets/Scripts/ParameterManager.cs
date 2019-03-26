using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParameterManager : MonoBehaviour
{
    public Text uiDisplayer;
    DataController datacontroller;
    [HideInInspector]
    public float favorPerSec;
    public float startFavorPerSec = 0f;

    [HideInInspector]
    public float foodPerSec;
    public float startFoodPerSec = 0.5f;
 
    [HideInInspector]
    public float cleanPerSec;
    public float startCleanPerSec = 0.5f;
  
    [HideInInspector]
    public float boredomPerSec;
    public float startBoredomPerSec = 0.3f;

    void Start()
    {

        boredomPerSec = startBoredomPerSec;
        cleanPerSec = startCleanPerSec;
        foodPerSec = startFoodPerSec;

        StartCoroutine("AddParameterLoop");

        UpdateUI();
    }

    IEnumerator AddParameterLoop() // 코루틴
    {
        while (true)
        {
            // 포만감쪽
            DataController.GetInstance().SubFood(foodPerSec);       // 기본적으로 포만감 빼는 부분
            if (DataController.GetInstance().GetFood() <= 0) {
                DataController.GetInstance().SetFood(0);
            }

            if (DataController.GetInstance().GetFood() <= 30&&DataController.GetInstance().GetFood()>10) // 포만감이 30 이하일 시 0.8씩 뺀다
            {
                DataController.GetInstance().SubFavor(0.8f);
                if (DataController.GetInstance().GetFavor() <= 0)
                {
                    DataController.GetInstance().SetFavor(0);
                }
            }
            else if (DataController.GetInstance().GetFood() <= 10) // 포만감이 10 이하일 시 2씩 뺀다
            {
                DataController.GetInstance().SubFavor(2f);
                if (DataController.GetInstance().GetFavor() <= 0)
                {
                    DataController.GetInstance().SetFavor(0);
                }
            }

            // 청결도쪽
            DataController.GetInstance().SubClean(cleanPerSec);
            if (DataController.GetInstance().GetClean() <= 0)
            {
                DataController.GetInstance().SetClean(0);
            }

            if (DataController.GetInstance().GetClean() <= 30 && DataController.GetInstance().GetClean() > 10) // 청결도가 30 이하일 시 0.4씩 뺀다
            {
                DataController.GetInstance().SubFavor(0.4f);
                if (DataController.GetInstance().GetFavor() <= 0)
                {
                    DataController.GetInstance().SetFavor(0);
                }
            }
            else if (DataController.GetInstance().GetClean() <= 10) // 청결도가 10 이하일 시 1.5씩 뺀다
            {
                DataController.GetInstance().SubFavor(1.5f);
                if (DataController.GetInstance().GetFavor() <= 0)
                {
                    DataController.GetInstance().SetFavor(0);
                }
            }

            // 심심함쪽
            DataController.GetInstance().AddBoredom(boredomPerSec); // 심심함 올라간다
            if (DataController.GetInstance().GetBoredom() >= 100)
            {
                DataController.GetInstance().SetBoredom(100);
            }

            if (DataController.GetInstance().GetBoredom() >= 60&& DataController.GetInstance().GetBoredom() < 80)   // 심심함이 60 이상 80 미만일 시 감소
            {
                DataController.GetInstance().SubFavor(0.5f);
                if (DataController.GetInstance().GetFavor() <= 0)
                {
                    DataController.GetInstance().SetFavor(0);
                }
            }
            else if (DataController.GetInstance().GetBoredom() >= 80 && DataController.GetInstance().GetBoredom() < 100)   // 심심함이 80 이상 100 미만일 시 감소
            {
                DataController.GetInstance().SubFavor(1f);
                if (DataController.GetInstance().GetFavor() <= 0)
                {
                    DataController.GetInstance().SetFavor(0);
                }
            }
            else if (DataController.GetInstance().GetBoredom() == 100)   // 심심함이 100일 시 감소
            {
                DataController.GetInstance().SubFavor(2f);
                if (DataController.GetInstance().GetFavor() <= 0)
                {
                    DataController.GetInstance().SetFavor(0);
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////
            UpdateUI();
            yield return new WaitForSeconds(1.0f);

        }
    }

    private void Update()
    {
    
    }

    public void UpdateUI()
    {
        uiDisplayer.text = "\n포만감 : " + Mathf.Round(DataController.GetInstance().GetFood()) + "\n청결도 : " +
            Mathf.Round(DataController.GetInstance().GetClean())
            + "\n심심함 : " + Mathf.Round(DataController.GetInstance().GetBoredom());
    }
}
