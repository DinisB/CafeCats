using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.MultiAudioListener;

public class Buydjtable : MonoBehaviour
    
{
    public GameObject Advice;
    public static int Djtable = 0;
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
    public void Buythedjtable()
    {
        if (ShowMoneyOnUI.money < 3750)
        {
            Advice.SetActive(true);
        }
        if (ShowMoneyOnUI.money >= 3750)
        {
            ShowMoneyOnUI.money -= 3750;
            Djtable = 1;
            Shop.SetActive(false);
            RegisterSound.Play();
            ParteAnim.changeanimparte();
            ShowMoneyOnUI.DiscoClubComplete();

        }


    }
}

