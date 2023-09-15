using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box2Script : MonoBehaviour
{
    public Image Box2;
    // Start is called before the first frame update
    void Start()
    {
        if (BoxesOrder.Box2 == 0)
        {
            Box2.color = new Color32(175, 155, 142, 225);
        }
        if (BoxesOrder.Box2 == 1)
        {
            Box2.color = new Color32(96, 82, 72, 225);
        }
        if (BoxesOrder.Box2 == 2)
        {
            Box2.color = new Color32(245, 163, 112, 225);
        }
        if (BoxesOrder.Box2 == 3)
        {
            Box2.color = new Color32(212, 191, 81, 225);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeImageBox2()
    {
        if (BoxesOrder.Box2 == 0)
        {
            Box2.color = new Color32(175, 155, 142, 225);
        }
        if (BoxesOrder.Box2 == 1)
        {
            Box2.color = new Color32(96, 82, 72, 225);
        }
        if (BoxesOrder.Box2 == 2)
        {
            Box2.color = new Color32(245, 163, 112, 225);
        }
        if (BoxesOrder.Box2 == 3)
        {
            Box2.color = new Color32(212, 191, 81, 225);
        }
    }
}
