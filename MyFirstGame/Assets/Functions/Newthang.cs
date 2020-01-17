using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newthang : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 0;
        float money;
        int e = 1;
        int h = 2;
        money = a + e + h;
        Debug.Log(money);
        // debug.log?
        int CookieJar;
        CookieJar = h + a;
        float cookies = 0 + e;
        int pepsi;
        pepsi = 9 + e;
        float fridge;
        fridge = pepsi + cookies;
        double cookiecost;
        cookiecost = cookies * 1.5;
        double pepsicost;
        pepsicost = pepsi * .75;
        double totalcost;
        totalcost = pepsicost + cookiecost;
        int work;
        work = 8;
        int days;
        days = 30;
        int salary;
        salary = work * days;
        int rent;
        rent = 200;
        int budget;
        budget = salary - rent;
        double left_over;
        left_over = budget - totalcost;
        Debug.Log(left_over);
        Debug.Log(fridge);
        BroadcastMessage("Party time!");
    }
    


    // Update is called once per frame
    void Update()
    {

    }


  
}
