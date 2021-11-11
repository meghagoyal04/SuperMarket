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
    private string name;
    private int totalCost=0;
    private Text item_cost;
    //public List<Item> items = new List<Item>();
    public List<List<string>>itemAmount = new List<List<string>>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        item_cost.text = totalCost.ToString();

    }
    public void bills()
    {
        itemAmount = bill.GetComponent<Items_List>().Orders;
        foreach (var x in itemAmount)
        {
             string name = x[0];
             quant = Int32.Parse(x[1]);

             price = Convert.ToInt32(x[2]);
             totalCost += (quant * price);
            Debug.Log(totalCost);
        }
        
    }
}
