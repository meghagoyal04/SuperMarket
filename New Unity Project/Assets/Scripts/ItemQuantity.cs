using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemQuantity : MonoBehaviour
{
    private Text item_quantity;
    private int quantity;
    public int maxHappiness;
    private Transform ordersPanel;
    private GameObject[] orders;
    public GameObject[] GetButton;

    public int kind;
    private int currentOrder;

    public HappinessBar happinessBar;
    public int maxOrders;
    private float currentHappiness;

    void Start()
    {
        quantity = 0;
        item_quantity = GetComponent<Text>();
        currentOrder = 0;
        currentHappiness = 0;
        orders = new GameObject[maxOrders];
        ordersPanel = GameObject.Find("Inventory").transform;
    }

    // Update is called once per frame
    void Update()
    {
        item_quantity.text = quantity.ToString();
    }

    public void AddItem()
    {
        quantity += 1;
        currentHappiness += 8;
        AddToInventory();

        happinessBar.UpdateHappiness((float)currentHappiness / (float)maxHappiness);
        if (currentHappiness > maxHappiness)
        {
            currentHappiness = 0;
            happinessBar.UpdateHappiness((float)currentHappiness / (float)maxHappiness);
        }
    }

    public void RemoveItem()
    {
        if (quantity > 0)
        {
            quantity -= 1;
        }
        else
        {
            quantity = 0;
        }

        currentHappiness -= 8;

        happinessBar.UpdateHappiness((float)currentHappiness / (float)maxHappiness);
        if (currentHappiness > maxHappiness)
        {
            currentHappiness = 0;
            happinessBar.UpdateHappiness((float)currentHappiness / (float)maxHappiness);
        }

    }

    public void AddToInventory()
    {
        orders[currentOrder] = Instantiate(GetButton[kind], ordersPanel);
        if (kind == 0)
        {
            orders[currentOrder].transform.localPosition = new Vector3(-68 + 45 * currentOrder, 105, 0);
            //currentHappiness += 8;
        }
        currentOrder++;
    }
}
