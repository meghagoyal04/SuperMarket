using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using UnityEngine.UI;


public class Items_List : MonoBehaviour
{
    public GameObject myObject;
    public GameObject getKind;

    //public Image icon;
    public GameObject[] slots;

    //public GameObject panel;

    private string Panelnames;

    private string ItemName;
    private string ItemPrice;
    private int Quantity;

    public List<Item> items = new List<Item>();
    public List<int> itemNumber = new List<int>();

    public Dictionary<Item, int> itemDict = new Dictionary<Item, int>();

    public List<List<string>> Orders;

    public HappinessBar happinessBar;
    public int maxHappiness;
    private float currentHappiness;

    void Start()
    {
        currentHappiness = 0;
        Orders = new List<List<string>>();
        ItemName = "";
        ItemPrice = "";
    }


    public void AddToInventory()
    {
        Panelnames = myObject.GetComponent<ItemQuantity>().PanelName;
        Quantity = myObject.GetComponent<ItemQuantity>().quantity;


        foreach (Item x in items)
        {
            if (Panelnames.Contains("Milk"))
            {
                if (x.itemName.Equals("Milk"))
                {
                    AddItem(x,Quantity);
                    ItemName = x.itemName;
                    x.itemPrice.ToString();
                    break;
                }
            }


            else if (Panelnames.Contains("Butter"))
            {
                if (x.itemName.Equals("Butter"))
                {
                    AddItem(x, Quantity);
                    ItemName = x.itemName;
                    ItemPrice = x.itemPrice.ToString();
                    break;
                }
            }

            else if (Panelnames.Contains("Tea"))
            {
                if (x.itemName.Equals("Tea"))
                {
                    AddItem(x, Quantity);
                    ItemName = x.itemName;
                    ItemPrice = x.itemPrice.ToString();
                    break;
                }
            }
        }

        if (Orders.Count > 1)
        {
            for (int i = 0; i < Orders.Count; i++)
            {
                if (Orders[i][0].Contains(ItemName))
                {
                    Orders[i][1] = Quantity.ToString();
                }
                else
                {
                    Orders.Add(new List<string> { ItemName, Quantity.ToString(), ItemPrice });                 
                }
            }

        }

        else
        {
            Orders.Add(new List<string> { ItemName, Quantity.ToString(), ItemPrice });
        }
        
       
    }

    void updateHappinessbar(float currentHappiness)
    {
        happinessBar.UpdateHappiness((float)currentHappiness / (float)maxHappiness);
        if (currentHappiness > maxHappiness)
        {
            currentHappiness = 0;
            happinessBar.UpdateHappiness((float)currentHappiness / (float)maxHappiness);
        }
    }

    private void AddItem(Item exampleitem, int quant)
    {
        if (!items.Contains(exampleitem))
        {
            items.Add(exampleitem);
            itemNumber.Add(quant);
            //itemDict[exampleitem] += 1;
        }

        else
        {   
            for(int i = 0; i < items.Count; i++)
            {
                if(items[i] == exampleitem)
                {
                    itemNumber[i] = quant;
                    //Debug.Log(itemNumber[i]);
                }
            }
        }

        UpdateSlots(quant, exampleitem);
    }

    private void UpdateSlots(int quant, Item s)
    {
        int store;
        for(int i = 0; i < items.Count; i++)
        {
            int idx;
            idx = items.IndexOf(s);
            
            slots[i].transform.GetChild(1).GetComponent<Image>().enabled = true;
            
            slots[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = items[i].itemName;
            
            slots[i].transform.GetChild(1).GetComponent<Image>().sprite = items[i].itemSprite;

            currentHappiness +=5;

            if (int.Parse(slots[i].transform.GetChild(0).GetComponent<Text>().text) > 0 && !s.itemName.Equals(items[i].itemName))
            {
                store = int.Parse(slots[i].transform.GetChild(0).GetComponent<Text>().text);
                if(store != itemNumber[idx] && itemNumber[idx] != 0)
                {
                    slots[idx].transform.GetChild(0).GetComponent<Text>().text = itemNumber[idx].ToString();
                }
            }


            else {
                //Debug.Log(itemNumber[i]);
                slots[i].transform.GetChild(0).GetComponent<Text>().enabled = true;
                slots[i].transform.GetChild(0).GetComponent<Text>().text = itemNumber[i].ToString();
                updateHappinessbar(currentHappiness);
            }

         
        }
    }
}
