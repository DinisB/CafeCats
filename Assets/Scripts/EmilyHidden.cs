using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmilyHidden : MonoBehaviour
{
    public GameObject Emily;
    public GameObject Button;
    public GameObject Storyblockedemily;
    public float timer = 0; // temporizador
    public float timecheck = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buyemily.Emily == 0)
        {
            Button.SetActive(true);
            Emily.SetActive(false);
            Storyblockedemily.SetActive(true);
        }
        if (Buyemily.Emily == 1)
        {
            Button.SetActive(false);
            Emily.SetActive(true);
            Storyblockedemily.SetActive(false);
            EmilyWorking();



        }
    }
    public void EmilyWorking()
    {
        timer = timer + 1 * Time.deltaTime;
        if (timer >= timecheck)
        {
            ShowMoneyOnUI.money += 5;
            timer = 0;
            EmilyWorking();
        }

    }

}
