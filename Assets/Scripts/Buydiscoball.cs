using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buydiscoball : MonoBehaviour
    
{
    public GameObject Advice;
    public static int discoball = 0;
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
    public void Buythediscoball()
    {
        if (ShowMoneyOnUI.money < 3000)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 3000)
        {
            ShowMoneyOnUI.money -= 3000;
            discoball = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ShowMoneyOnUI.DiscoClubComplete();
        }


    }
}

