using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MakeButton : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public GameObject button;
    Camera playerCam;

    public GameObject panel;
   

    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject;
        playerCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = playerCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                ordersKind(hit.transform.gameObject);
            }
        }
    }

    public void ordersKind(GameObject obj1)
    {
        //Debug.Log(obj1.name);
        if (obj1.name.Equals("milk"))
        {

            if (panel != null)
            {
                panel.SetActive(true);
            }

            else
            {
                panel.SetActive(false);
            }
        }

        if (obj1.name.Equals("butter"))
        {
            if (panel != null)
            {
                panel.SetActive(true);
            }

            else
            {
                panel.SetActive(false);
            }
        }

        if (obj1.name.Equals("tea"))
        {
            if (panel != null)
            {
                panel.SetActive(true);
            }

            else
            {
                panel.SetActive(false);
            }
        }

        if (obj1.name.Equals("carrot"))
        {
            if (panel != null)
            {
                panel.SetActive(true);
            }

            else
            {
                panel.SetActive(false);
            }
        }

        /* if (obj1.name.Equals("cashout"))
         {
             if (panel != null)
             {
                 panel.SetActive(true);
             }

             else
             {
                 panel.SetActive(false);
             }
         }*/
    }

}
