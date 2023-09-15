using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatoFringHidden : MonoBehaviour
{
    public GameObject fring;
    public GameObject Button;
    public float timer = 0; // temporizador
    public float timecheck = 1;
    public GameObject Storyblockedfring;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buygatofring.GatoFring == 0)
        {
            Button.SetActive(true);
            fring.SetActive(false);
            Storyblockedfring.SetActive(true);
        }
        if (Buygatofring.GatoFring == 1)
        {
            Button.SetActive(false);
            fring.SetActive(true);
            Storyblockedfring.SetActive(false);
            FringWorking();



        }
    }
    public void FringWorking()
    {
        timer = timer + 1 * Time.deltaTime;
        if (timer >= timecheck)
        {
            ShowMoneyOnUI.money += 5;
            timer = 0;
            FringWorking();
        }

    }

}
