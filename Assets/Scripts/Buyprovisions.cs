using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buyprovisions : MonoBehaviour
    
{
    public GameObject Advice;
    public static int Provisions = 0;
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
    public void BuyProvisionBoxes()
    {
        if (ShowMoneyOnUI.money < 1000)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 1000)
        {
            ShowMoneyOnUI.money -= 1000;
            Provisions = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ShowMoneyOnUI.GarageComplete();
        }


    }
}

