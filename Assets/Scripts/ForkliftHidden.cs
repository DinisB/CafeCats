using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkliftHidden : MonoBehaviour
{
    public GameObject Forklift;
    public GameObject Button;
    public GameObject BlockedMinigame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buyforklift.Forklift == 0)
        {
            Button.SetActive(true);
            BlockedMinigame.SetActive(true);
            Forklift.SetActive(false);
        }
        if (Buyforklift.Forklift == 1)
        {
            Button.SetActive(false);
            BlockedMinigame.SetActive(false);
            Forklift.SetActive(true);
        }
    }
}
