using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buysuscat : MonoBehaviour
    
{
    public GameObject Advice;
    public static int Suscat = 0;
    public GameObject Shop;
    public GameObject SusCatStory;
    public MultiAudioSource RegisterSound;
    public ShowMoneyOnUI ShowMoneyOnUI;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Buysus()
    {
        if (ShowMoneyOnUI.money < 1000)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 1000)
        {
            RegisterSound.Play();
            ShowMoneyOnUI.money -= 1000;
            Suscat = 1;
            SusCatStory.SetActive(true);
            Shop.SetActive(false);
            ShowMoneyOnUI.MainHallComplete();
        }


    }
}

