using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProvisionsHidden : MonoBehaviour
{
    public GameObject Provisions1;
    public GameObject Provisions2;
    public GameObject Provisions3;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buyprovisions.Provisions == 0)
        {
            Button.SetActive(true);
            Provisions1.SetActive(false);
            Provisions2.SetActive(false);
            Provisions3.SetActive(false);
        }
        if (Buyprovisions.Provisions == 1)
        {
            Button.SetActive(false);
            Provisions1.SetActive(true);
            Provisions2.SetActive(true);
            Provisions3.SetActive(true);



        }
    }


}
