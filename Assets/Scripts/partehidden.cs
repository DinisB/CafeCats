using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partehidden : MonoBehaviour
{
    public GameObject Parte;
    public GameObject Button;
    public float timer = 0; // temporizador
    public float timecheck = 1;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

        if (Buyparte.Parte == 0)
        {
            Button.SetActive(true);
            Parte.SetActive(false);
        }
        if (Buyparte.Parte == 1)
        {
            Button.SetActive(false);
            Parte.SetActive(true);
            ParteWorking();
        }


    }

    public void ParteWorking()
    {
        timer = timer + 1 * Time.deltaTime;
        if (timer >= timecheck)
        {
            ShowMoneyOnUI.money += 5;
            timer = 0;
            ParteWorking();
        }

    }
}
