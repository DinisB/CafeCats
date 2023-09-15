using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawersHidden : MonoBehaviour
{
    public GameObject Drawer1;
    public GameObject Drawer2;
    public GameObject Drawer3;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buydrawers.Drawers == 0)
        {
            Button.SetActive(true);
            Drawer1.SetActive(false);
            Drawer2.SetActive(false);
            Drawer3.SetActive(false);
        }
        if (Buydrawers.Drawers == 1)
        {
            Button.SetActive(false);
            Drawer1.SetActive(true);
            Drawer2.SetActive(true);
            Drawer3.SetActive(true);



        }
    }


}
