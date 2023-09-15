using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buyjukebox : MonoBehaviour
    
{
    public GameObject Advice;
    public static int jukebox = 0;
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
    public void Buythejukebox()
    {
        if (ShowMoneyOnUI.money < 3250)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 3250)
        {
            ShowMoneyOnUI.money -= 3250;
            jukebox = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ShowMoneyOnUI.DiscoClubComplete();
        }


    }
}

