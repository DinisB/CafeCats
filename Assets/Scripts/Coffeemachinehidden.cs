using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffeemachinehidden : MonoBehaviour
{
    public GameObject CoffeeMachine;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buycoffeemachine.CoffeeMachine == 0)
        {
            Button.SetActive(true);
            CoffeeMachine.SetActive(false);
        }
        if (Buycoffeemachine.CoffeeMachine == 1)
        {
            Button.SetActive(false);
            CoffeeMachine.SetActive(true);
        }
    }
}
