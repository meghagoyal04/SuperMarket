using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberOnPanel : MonoBehaviour
{
    private Text item_quantity;
    private int quantity;
    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        quantity = 0;
        item_quantity = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        item_quantity.text = quantity.ToString();
    }
    

    public void AddText()
    {
        //Debug.Log(myObject.GetComponent<ItemQuantity>().PanelName);
        quantity = myObject.GetComponent<ItemQuantity>().quantity;
    }
}
