using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJTableHidden : MonoBehaviour
{
    public GameObject DJTable;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buydjtable.Djtable == 0)
        {
            Button.SetActive(true);
            DJTable.SetActive(false);
        }
        if (Buydjtable.Djtable == 1)
        {
            Button.SetActive(false);
            DJTable.SetActive(true);
        }
    }
}
