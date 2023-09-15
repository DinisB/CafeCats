using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buydrawers : MonoBehaviour
    
{
    public GameObject Advice;
    public static int Drawers = 0;
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
    public void BuyDrawers()
    {
        if (ShowMoneyOnUI.money < 1750)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 1750)
        {
            ShowMoneyOnUI.money -= 1750;
            Drawers = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ShowMoneyOnUI.GarageComplete();
        }


    }
}

