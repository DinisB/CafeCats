using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box3Script : MonoBehaviour
{
    public Image Box3;
    // Start is called before the first frame update
    void Start()
    {
        if (BoxesOrder.Box3 == 0)
        {
            Box3.color = new Color32(175, 155, 142, 225);
        }
        if (BoxesOrder.Box3 == 1)
        {
            Box3.color = new Color32(96, 82, 72, 225);
        }
        if (BoxesOrder.Box3 == 2)
        {
            Box3.color = new Color32(245, 163, 112, 225);
        }
        if (BoxesOrder.Box3 == 3)
        {
            Box3.color = new Color32(212, 191, 81, 225);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeImageBox3()
    {
        if (BoxesOrder.Box3 == 0)
        {
            Box3.color = new Color32(175, 155, 142, 225);
        }
        if (BoxesOrder.Box3 == 1)
        {
            Box3.color = new Color32(96, 82, 72, 225);
        }
        if (BoxesOrder.Box3 == 2)
        {
            Box3.color = new Color32(245, 163, 112, 225);
        }
        if (BoxesOrder.Box3 == 3)
        {
            Box3.color = new Color32(212, 191, 81, 225);
        }
    }
}
