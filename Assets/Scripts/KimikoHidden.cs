using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimikoHidden : MonoBehaviour
{
    public GameObject kimiko;
    public GameObject Button;
    public float timer = 0; // temporizador
    public float timecheck = 1;
    public GameObject Storyblockedkimiko;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buykimiko.kimiko == 0)
        {
            Button.SetActive(true);
            kimiko.SetActive(false);
            Storyblockedkimiko.SetActive(true);
        }
        if (Buykimiko.kimiko == 1)
        {
            Button.SetActive(false);
            kimiko.SetActive(true);
            Storyblockedkimiko.SetActive(false);
            KimikoWorking();



        }
    }
    public void KimikoWorking()
    {
        timer = timer + 1 * Time.deltaTime;
        if (timer >= timecheck)
        {
            ShowMoneyOnUI.money += 5;
            timer = 0;
            KimikoWorking();
        }

    }

}
