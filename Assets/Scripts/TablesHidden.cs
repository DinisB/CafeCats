using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablesHidden : MonoBehaviour
{
    public GameObject Table1;
    public GameObject Table2;
    public GameObject Table3;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buytables.Tables == 0)
        {
            Button.SetActive(true);
            Table1.SetActive(false);
            Table2.SetActive(false);
            Table3.SetActive(false);
        }
        if (Buytables.Tables == 1)
        {
            Button.SetActive(false);
            Table1.SetActive(true);
            Table2.SetActive(true);
            Table3.SetActive(true);



        }
    }


}
