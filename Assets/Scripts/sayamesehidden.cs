using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayamesehidden : MonoBehaviour
{
    public GameObject Sayamese;
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

        if (Buysayamese.SayameseCat == 0)
        {
            Button.SetActive(true);
            Sayamese.SetActive(false);
        }
        if (Buysayamese.SayameseCat == 1)
        {
            Button.SetActive(false);
            Sayamese.SetActive(true);
            SayameseWorking();
        }
    }

    public void SayameseWorking()
    {
        timer = timer + 1 * Time.deltaTime;
        if (timer >= timecheck)
        {
            ShowMoneyOnUI.money += 5;
            timer = 0;
            SayameseWorking();
        }

    }
}
