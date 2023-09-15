using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buyparte : MonoBehaviour
    
{
    public GameObject Advice;
    public static int Parte = 0;
    public GameObject Shop;
    public MultiAudioSource RegisterSound;
    public ParteAnim ParteAnim;
    public ShowMoneyOnUI ShowMoneyOnUI;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BuyParte()
    {
        if (ShowMoneyOnUI.money < 5000)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 5000)
        {
            ShowMoneyOnUI.money -= 5000;
            Parte = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ParteAnim.changeanimparte();
            ShowMoneyOnUI.DiscoClubComplete();
        }


    }
}

