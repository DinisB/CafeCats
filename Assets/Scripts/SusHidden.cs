using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SusHidden : MonoBehaviour
{
    public GameObject Sus;
    public GameObject Button;
    public GameObject Storyblockedsuscat;
    public float timer = 0; // temporizador
    public float timecheck = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buysuscat.Suscat == 0)
        {
            Button.SetActive(true);
            Sus.SetActive(false);
            Storyblockedsuscat.SetActive(true);

        }
        if (Buysuscat.Suscat == 1)
        {
            Button.SetActive(false);
            Sus.SetActive(true);
            Storyblockedsuscat.SetActive(false);
            SusWorking();




        }
    }
    public void SusWorking()
    {
        timer = timer + 1 * Time.deltaTime;
        if (timer >= timecheck)
        {
            ShowMoneyOnUI.money += 5;
            timer = 0;
            SusWorking();
        }

    }

}
