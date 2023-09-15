using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buyforklift : MonoBehaviour
    
{
    public GameObject Advice;
    public GameObject MiniAdvice;
    public static int Forklift = 0;
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
    public void Buytheforklift()
    {
        if (ShowMoneyOnUI.money < 1300)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 1300)
        {
            ShowMoneyOnUI.money -= 1300;
            Forklift = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ShowMoneyOnUI.GarageComplete();
            MiniAdvice.SetActive(true);
        }


    }
}

