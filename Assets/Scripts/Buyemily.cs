using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buyemily : MonoBehaviour
    
{
    public GameObject Advice;
    public static int Emily = 0;
    public GameObject Shop;
    public GameObject EmilyStory;
    public MultiAudioSource RegisterSound;
    public ShowMoneyOnUI ShowMoneyOnUI;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyEmily()
    {
        if (ShowMoneyOnUI.money < 100)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 100)
        {
            ShowMoneyOnUI.money -= 100;
            Emily = 1;
            Shop.SetActive(false);
            EmilyStory.SetActive(true);
            RegisterSound.Play();
            ShowMoneyOnUI.MainHallComplete();
        }


    }
}

