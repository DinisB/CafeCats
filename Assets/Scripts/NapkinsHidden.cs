using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NapkinsHidden : MonoBehaviour
{
    public GameObject Napkin1;
    public GameObject Napkin2;
    public GameObject Napkin3;
    public GameObject Button;
    public GameObject BlockedButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buynapkins.Napkins == 0)
        {
            Button.SetActive(true);
            Napkin1.SetActive(false);
            Napkin2.SetActive(false);
            Napkin3.SetActive(false);
        }
        if (Buynapkins.Napkins == 1)
        {
            Button.SetActive(false);
            Napkin1.SetActive(true);
            Napkin2.SetActive(true);
            Napkin3.SetActive(true);



        }
        if (Buytables.Tables == 0)
        {
            BlockedButton.SetActive(true);
        }
        if (Buytables.Tables == 1)
        {
            BlockedButton.SetActive(false);
        }
    }


}
