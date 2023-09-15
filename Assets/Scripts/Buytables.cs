using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buytables : MonoBehaviour
    
{
    public GameObject Advice;
    public static int Tables = 0;
    public GameObject Shop;
    public MultiAudioSource RegisterSound;
    public ShowMoneyOnUI ShowMoneyOnUI;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyTables()
    {
        if (ShowMoneyOnUI.money < 200)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 200)
        {
            ShowMoneyOnUI.money -= 200;
            Tables = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ShowMoneyOnUI.MainHallComplete();
        }


    }
}

