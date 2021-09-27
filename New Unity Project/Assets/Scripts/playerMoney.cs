using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoney : MonoBehaviour
{
    // Start is called before the first frame update
    public int money;
    public int moneyToAdd;
    public int moneyToSub;
    void Start()
    {
        money = 100;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void addMoney(int moneyToAdd)
    {
        money += moneyToAdd;
    }
    public void subtractMoney(int moneyToSub)
    {
        if (money - moneyToSub < 0)
        {
            Debug.Log("You don't have enough Money!");
        }
        else
        {
            money -= moneyToSub;
        }
    }
}