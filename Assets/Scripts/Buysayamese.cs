using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buysayamese : MonoBehaviour
    
{
    public GameObject Advice;
    public static int SayameseCat = 0;
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
    public void BuySayameseCat()
    {
        if (ShowMoneyOnUI.money < 4000)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 4000)
        {
            ShowMoneyOnUI.money -= 4000;
            SayameseCat = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ShowMoneyOnUI.DiscoClubComplete();
        }


    }
}

