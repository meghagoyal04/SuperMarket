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

    private GameObject[] slots;

    public List<Text> amounts = new List<Text>();
    public List<Text> names = new List<Text>();
    private string name= "";
    private int calciumtotal= 0;
    private int carbtotal = 0;
    private int caltotal = 0;
    private int protientotal = 0;
    private int vitaminAtotal = 0;
    private int vitaminCtotal = 0;
    private int irontotal = 0;
    private List<int> totals = new List<int>();
    private int CostperItem=0;
    private int totalCost=0;
    private Text item_cost;
    Dictionary<string, double> dictNew = new Dictionary<string, double>()
    {
      {"calcium",0.7},
      {"protien",50.0},
      {"iron", 0.018},
      {"carbohydrates",275},
      {"vitamin_c", 0.07 },
      {"vitamin_a", 0.9 },
      {"calories", 2300 }
    };

    //public List<Item> items = new List<Item>();
    private List<Item>items = new List<Item>();

    public GameObject panel;
    
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
        items = Items_List.instance.items;
        slots = Items_List.instance.slots;

        int money;

         for (int i = 0; i < slots.Length; i++)
         {
            string name = slots[i].transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
            int quan;
            quan = Int32.Parse(slots[i].transform.GetChild(0).GetComponent<Text>().text);
            

            if (quan > 0)
            {
                price = items[i].itemPrice;
                calciumtotal += items[i].calcium * quan;
                caltotal += items[i].calories * quan;
                protientotal += items[i].protien * quan;
                vitaminAtotal += items[i].vitamin_a * quan;
                vitaminCtotal += items[i].vitamin_c * quan;
                irontotal += items[i].iron * quan;

                CostperItem = quan * price;

                totalCost += CostperItem;
                
                amounts[i].enabled = true;
                amounts[i].text = items[i].itemName;
                names[i].enabled = true;
                names[i].text =" : Rs." +  CostperItem.ToString();
                
                totals.Add(CostperItem);

                if (calciumtotal >= dictNew["calcium"] && carbtotal >= dictNew["carbohydrates"] &&
                    protientotal >= dictNew["protien"] && caltotal >= dictNew["calories"] &&
                    irontotal >= dictNew["iron"] && vitaminAtotal >= dictNew["vitamin_a"] &&
                    vitaminCtotal >= dictNew["vitamin_c"])
                {   

                }
            }
            //Debug.Log(name);
            //Debug.Log(quant);

        }
        
    }
}
