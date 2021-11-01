using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemQuantity : MonoBehaviour
{
    private Text item_quantity;
    public int quantity;
    public string PanelName;
    public int maxOrders;


    void Start()
    {
        quantity = 0;
        item_quantity = GetComponent<Text>();
        PanelName = item_quantity.transform.parent.name;
        //Debug.Log(PanelName);
    }

    // Update is called once per frame
    void Update()
    {
        item_quantity.text = quantity.ToString();
    }

    public void AddItem()
    {
        quantity += 1;
        
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

    }

}
