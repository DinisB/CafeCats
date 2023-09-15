using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buycoffeemachine : MonoBehaviour
    
{
    public GameObject Advice;
    public static int CoffeeMachine = 0;
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
    public void BuyCoffeeMachine()
    {
        if (ShowMoneyOnUI.money < 750)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 750)
        {
            ShowMoneyOnUI.money -= 750;
            CoffeeMachine = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ShowMoneyOnUI.MainHallComplete();
        }


    }
}

