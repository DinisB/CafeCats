using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box4Change : MonoBehaviour
{
    public SpriteRenderer sr;
    public Color color_1;
    public Color color_2;
    public Color color_3;
    public Color color_4;
    public static int Box4Changer = 0;

    // Start is called before the first frame update
    void Start()
    {
        sr.color = color_1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Box4Changer += 1;
        ChangeColorBox4();
        if (Box4Changer >= 4)
        {
            Box4Changer = 0;
            ChangeColorBox4();
        }
    }

    public void ChangeColorBox4()
    {
        if (Box4Changer == 0)
        {
            sr.color = color_1;
        }
        if (Box4Changer == 1)
        {
            sr.color = color_2;
        }
        if (Box4Changer == 2)
        {
            sr.color = color_3;
        }
        if (Box4Changer == 3)
        {
            sr.color = color_4;
        }
    }
}
