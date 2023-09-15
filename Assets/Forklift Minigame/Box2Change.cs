using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box2Change : MonoBehaviour
{
    public SpriteRenderer sr;
    public Color color_1;
    public Color color_2;
    public Color color_3;
    public Color color_4;
    public static int Box2Changer = 0;

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
        Box2Changer += 1;
        ChangeColorBox2();
        if (Box2Changer >= 4)
        {
            Box2Changer = 0;
            ChangeColorBox2();
        }
    }

    public void ChangeColorBox2()
    {
        if (Box2Changer == 0)
        {
            sr.color = color_1;
        }
        if (Box2Changer == 1)
        {
            sr.color = color_2;
        }
        if (Box2Changer == 2)
        {
            sr.color = color_3;
        }
        if (Box2Changer == 3)
        {
            sr.color = color_4;
        }
    }
}
