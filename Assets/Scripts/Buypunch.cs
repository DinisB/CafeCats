using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buypunch : MonoBehaviour
    
{
    public GameObject Advice;
    public static int punch = 0;
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
    public void Buythepunch()
    {
        if (ShowMoneyOnUI.money < 3500)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 3500)
        {
            ShowMoneyOnUI.money -= 3500;
            punch = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ShowMoneyOnUI.DiscoClubComplete();
        }


    }
}

