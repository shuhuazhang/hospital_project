using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_event_System_SC : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            if(EventSystem.current.IsPointerOverGameObject())

				Debug.Log("当前触摸在UI上");
			
			else 
				Debug.Log("当前没有触摸在UI上");
        }//此处需要在Android上跑时需要进行修改 谨记
    }
}
