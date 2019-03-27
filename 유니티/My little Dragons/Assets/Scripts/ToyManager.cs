using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToyManager : MonoBehaviour
{
    public Text itemName;
    public Text description;

    void Update()
    {

        switch (DataController.GetInstance().GetToyCode())
        {
            case 0:
                //gameObject.GetComponent<Image>().sprite = salty[1];
                itemName.text = "테니스공";
                description.text = "던지고 놀기 좋은 테니스공.";
                break;

            case 1:
                // gameObject.GetComponent<Image>().sprite = goso[1];
                itemName.text = "원반";
                description.text = "날리면 돌아오는 재밌는 장난감.";
                break;

            case 2:
                // gameObject.GetComponent<Image>().sprite = spicy[1];
                itemName.text = "새끼용 돌";
                description.text = "새끼용과 똑닮은 인형이다.";
                break;

            case 3:
                //gameObject.GetComponent<Image>().sprite = sinmat[1];
                itemName.text = "불의 여의주";
                description.text = "불꽃의 드래곤에서 나타나는 보석. 사용하면 어떤 일이 일어날까?";
                break;

            case 4:
                //gameObject.GetComponent<Image>().sprite = sseunmat[1];
                itemName.text = "얼음의 여의주";
                description.text = "얼음의 드래곤에서 나타나는 보석. 사용하면 어떤 일이 일어날까?";
                break;
            
        }

    }
}
