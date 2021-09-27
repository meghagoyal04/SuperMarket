using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    private GameObject[] orders;
    public int maxOrders;
    private int currentOrder;
    Camera playerCam;

    public Button[] orderButtons;
    private Transform ordersPanel;
    public GameObject[] orderTypes;
    // Start is called before the first frame update
    void Start()
    {
        currentOrder = 0;
        orders = new GameObject[maxOrders];
        ordersPanel = GameObject.Find("Inventory").transform;
        playerCam = Camera.main;

    }
    public void ordersKind(int kindNum)
    {
        orders[currentOrder] = Instantiate(orderTypes[kindNum], ordersPanel);
        orders[currentOrder].transform.localPosition = new Vector3(29, 50 - 30 * currentOrder,0);
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

    void DoSomething(GameObject obj1)
    {
        print(obj1.name);
        //Instantiate(obj1, ordersPanel);
        //Instantiate(findButton, new Vector3(0, 50,0), Quaternion.identity,ordersPanel);
    }
}
