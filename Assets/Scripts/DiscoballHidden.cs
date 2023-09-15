using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoballHidden : MonoBehaviour
{
    public GameObject Discoball;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buydiscoball.discoball == 0)
        {
            Button.SetActive(true);
            Discoball.SetActive(false);
            Light1.SetActive(false);
            Light2.SetActive(false);
        }
        if (Buydiscoball.discoball == 1)
        {
            Button.SetActive(false);
            Discoball.SetActive(true);
            Light1.SetActive(true);
            Light2.SetActive(true);
        }
    }
}
