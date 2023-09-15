using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buykimiko : MonoBehaviour
    
{
    public GameObject Advice;
    public static int kimiko = 0;
    public GameObject Shop;
    public GameObject KimikoStory;
    public MultiAudioSource RegisterSound;
    public ShowMoneyOnUI ShowMoneyOnUI;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyKimiko()
    {
        if (ShowMoneyOnUI.money < 2500)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 2500)
        {
            RegisterSound.Play();
            ShowMoneyOnUI.money -= 2500;
            kimiko = 1;
            KimikoStory.SetActive(true);
            Shop.SetActive(false);
            ShowMoneyOnUI.GarageComplete();

        }


    }
}

