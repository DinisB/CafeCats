using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box4Script : MonoBehaviour
{
    public Image Box4;
    // Start is called before the first frame update
    void Start()
    {
        if (BoxesOrder.Box4 == 0)
        {
            Box4.color = new Color32(175, 155, 142, 225);
        }
        if (BoxesOrder.Box4 == 1)
        {
            Box4.color = new Color32(96, 82, 72, 225);
        }
        if (BoxesOrder.Box4 == 2)
        {
            Box4.color = new Color32(245, 163, 112, 225);
        }
        if (BoxesOrder.Box4 == 3)
        {
            Box4.color = new Color32(212, 191, 81, 225);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeImageBox4()
    {
        if (BoxesOrder.Box4 == 0)
        {
            Box4.color = new Color32(175, 155, 142, 225);
        }
        if (BoxesOrder.Box4 == 1)
        {
            Box4.color = new Color32(96, 82, 72, 225);
        }
        if (BoxesOrder.Box4 == 2)
        {
            Box4.color = new Color32(245, 163, 112, 225);
        }
        if (BoxesOrder.Box4 == 3)
        {
            Box4.color = new Color32(212, 191, 81, 225);
        }
    }
}
