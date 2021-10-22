using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MakeButton : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public GameObject button;
    private Transform ordersPanel;
    public int maxHappiness;
    public HappinessBar happinessBar;
    private float currentHappiness;
    Camera playerCam;

    private GameObject[] orders;
    public int maxOrders;
    public GameObject[] GetButton;
    private int currentOrder;
    public int kind;
    //public GameObject[] orderTypes;
    public GameObject panel;
   

    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject;
        playerCam = Camera.main;
        //ordersPanel = GameObject.Find("Panel").transform;
        currentOrder = 0;
        currentHappiness = 0;
        orders = new GameObject[maxOrders];
        ordersPanel = GameObject.Find("Inventory").transform;
        //findButton = GameObject.Find("MilkButton").GetComponent<Button>();
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
                //unityEvent.Invoke();
                //DoSomething(hit.transform.gameObject);
                ordersKind(hit.transform.gameObject);
            }
        }
    }

    public void ordersKind(GameObject obj1)
    {
        orders[currentOrder] = Instantiate(GetButton[kind], ordersPanel);
        if (obj1.tag == "Milk" || kind == 0)
        {
            orders[currentOrder].transform.localPosition = new Vector3(-68 + 45 * currentOrder, 105, 0);
            //currentHappiness += 8;

            if (panel != null)
            {
                panel.SetActive(true);
            }

            else
            {
                panel.SetActive(false);
            }
        }

        if (obj1.name == "Butter" || kind == 1)
        {
            orders[currentOrder].transform.localPosition = new Vector3(-68 + 45 * currentOrder, 40, 0);
            //currentHappiness += 8;
        }

        if (obj1.name == "Chip" || kind == 2)
        {
            orders[currentOrder].transform.localPosition = new Vector3(-68 + 45 * currentOrder, -20, 0);
        }

        currentOrder++;

        /* if(currentOrder == maxOrders)
         {
             foreach(GameObject orderButton in orderButtons)
             {
                 orderButton.GetComponent<Button>().interactable = false;
                 //orderButton.interactable = false;
             }
         }*/
    }

   /* public void OpenPanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }*/

    void DoSomething(GameObject obj1)
    {
        print(obj1.name);
        //Instantiate(obj1,ordersPanel);
        //Instantiate(findButton, new Vector3(0, 50,0), Quaternion.identity,ordersPanel);
    }
}
