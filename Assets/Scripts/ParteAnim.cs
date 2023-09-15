using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParteAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        changeanimparte();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeanimparte()
    {
        if (Buyparte.Parte == 1 && Buydjtable.Djtable == 0)
        {
            GetComponent<Animator>().Play("cant play", -1, 0f);
        }

        if (Buyparte.Parte == 1 && Buydjtable.Djtable == 1)
        {
            GetComponent<Animator>().Play("playing", -1, 0f);
        }
    }
}
