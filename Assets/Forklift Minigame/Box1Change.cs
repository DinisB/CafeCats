using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box1Change : MonoBehaviour
{
    public SpriteRenderer sr;
    public Color color_1;
    public Color color_2;
    public Color color_3;
    public Color color_4;
    public static int Box1Changer = 0;

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
        Box1Changer += 1;
        ChangeColorBox1();
        if (Box1Changer >= 4)
        {
            Box1Changer = 0;
            ChangeColorBox1();
        }
    }

    public void ChangeColorBox1()
    {
        if (Box1Changer == 0)
        {
            sr.color = color_1;
        }
        if (Box1Changer == 1)
        {
            sr.color = color_2;
        }
        if (Box1Changer == 2)
        {
            sr.color = color_3;
        }
        if (Box1Changer == 3)
        {
            sr.color = color_4;
        }
    }
}
