using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buygatofring : MonoBehaviour
    
{
    public GameObject Advice;
    public static int GatoFring = 0;
    public GameObject Shop;
    public GameObject FringStory;
    public MultiAudioSource RegisterSound;
    public ShowMoneyOnUI ShowMoneyOnUI;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyGF()
    {
        if (ShowMoneyOnUI.money < 1500)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 1500)
        {
            RegisterSound.Play();
            ShowMoneyOnUI.money -= 1500;
            GatoFring = 1;
            FringStory.SetActive(true);
            Shop.SetActive(false);
            ShowMoneyOnUI.GarageComplete();

        }


    }
}

