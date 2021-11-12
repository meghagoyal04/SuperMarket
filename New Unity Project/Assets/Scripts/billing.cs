using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using UnityEngine.UI;
using System;

public class billing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bill;
    private int quant;
    private int price;
    private string name= "";
    private int calciumtotal= 0;
    private int totalCost=0;
    private Text item_cost;
    //public List<Item> items = new List<Item>();
    private List<Item>items = new List<Item>();
    
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        //item_cost.text = totalCost.ToString();

    }
    public void bills()
    {
        items = bill.GetComponent<Items_List>().items;

         for (int i = 0; i < items.Count; i++)
         {
            string name = items[i].itemName;
            quant = items[i].quant;
            price = items[i].itemPrice;
            calciumtotal += items[i].calcium * quant;
            totalCost += quant * price;
            //Debug.Log(name);
            //Debug.Log(quant);

        }
        
    }
}
