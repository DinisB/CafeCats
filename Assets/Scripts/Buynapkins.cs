using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buynapkins : MonoBehaviour
    
{
    public GameObject Advice;
    public static int Napkins = 0;
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
    public void BuyNapkins()
    {
        if (ShowMoneyOnUI.money < 400)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 400)
        {
            ShowMoneyOnUI.money -= 400;
            Napkins = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ShowMoneyOnUI.MainHallComplete();
        }


    }
}

