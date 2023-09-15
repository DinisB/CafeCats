using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buyfood : MonoBehaviour
    
{
    public GameObject Advice;
    public static int Food = 0;
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
    public void BuyFoodProtector()
    {
        if (ShowMoneyOnUI.money < 500)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 500)
        {
            ShowMoneyOnUI.money -= 500;
            Food = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ShowMoneyOnUI.MainHallComplete();
        }


    }
}

