using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMoney : MonoBehaviour
{
    // Start is called before the first frame update
    private int money;
    public Text moneyText;
    public int moneyToSub;
    void Start()
    {
        money = 100;
        moneyText.text = "Money : " + money.ToString();
        //subtractMoney(2);
    }
    public void Update_money()
    {
        
        moneyText.text = "Money : " + money;
        //Debug.Log(m)
    }

    public bool subtractMoney(int moneyToSub)
    {
        if (money - moneyToSub < 0)
        {
            Debug.Log("You don't have enough Money!");
            return false;
        }
        
        else
        {
            money -= moneyToSub;
        }

        return true;
    }
}