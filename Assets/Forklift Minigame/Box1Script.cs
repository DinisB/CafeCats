using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box1Script : MonoBehaviour
{
    public Image Box1;
    // Start is called before the first frame update
    void Start()
    {
        if (BoxesOrder.Box1 == 0)
        {
            Box1.color = new Color32(175, 155, 142, 225);
        }
        if (BoxesOrder.Box1 == 1)
        {
            Box1.color = new Color32(96, 82, 72, 225);
        }
        if (BoxesOrder.Box1 == 2)
        {
            Box1.color = new Color32(245, 163, 112, 225);
        }
        if (BoxesOrder.Box1 == 3)
        {
            Box1.color = new Color32(212, 191, 81, 225);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeImageBox1()
    {
        if (BoxesOrder.Box1 == 0)
        {
            Box1.color = new Color32(175, 155, 142, 225);
        }
        if (BoxesOrder.Box1 == 1)
        {
            Box1.color = new Color32(96, 82, 72, 225);
        }
        if (BoxesOrder.Box1 == 2)
        {
            Box1.color = new Color32(245, 163, 112, 225);
        }
        if (BoxesOrder.Box1 == 3)
        {
            Box1.color = new Color32(212, 191, 81, 225);
        }
    }
}
