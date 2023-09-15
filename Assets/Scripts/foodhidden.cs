using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodhidden : MonoBehaviour
{
    public GameObject FoodProtector;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buyfood.Food == 0)
        {
            Button.SetActive(true);
            FoodProtector.SetActive(false);
        }
        if (Buyfood.Food == 1)
        {
            Button.SetActive(false);
            FoodProtector.SetActive(true);
        }
    }
}
