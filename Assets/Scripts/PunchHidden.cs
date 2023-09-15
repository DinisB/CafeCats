using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchHidden : MonoBehaviour
{
    public GameObject Punch;
    public GameObject Table;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buypunch.punch == 0)
        {
            Button.SetActive(true);
            Punch.SetActive(false);
            Table.SetActive(false);
        }
        if (Buypunch.punch == 1)
        {
            Button.SetActive(false);
            Punch.SetActive(true);
            Table.SetActive(true);
        }
    }


}
