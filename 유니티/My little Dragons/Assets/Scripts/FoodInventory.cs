using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FoodInventory : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public static Vector2 defaultposition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData){//드래그 시작
        defaultposition=this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData){//드래그 중
        Vector2 currentPos = Input.mousePosition;
        this.transform.position=currentPos;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData){
        Vector2 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        this.transform.position=defaultposition;
    }

}