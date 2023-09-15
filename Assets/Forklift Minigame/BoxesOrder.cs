using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxesOrder : MonoBehaviour

{
    public static int Box1 = 0;
    public static int Box2 = 0;
    public static int Box3 = 0;
    public static int Box4 = 0;
    public Box1Script Box1Script;
    public Box2Script Box2Script;
    public Box3Script Box3Script;
    public Box4Script Box4Script;

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomizeBoxes()
    {
        Box1 = Random.Range(0, 4);
        Box2 = Random.Range(0, 4);
        Box3 = Random.Range(0, 4);
        Box4 = Random.Range(0, 4);
        Box1Script.ChangeImageBox1();
        Box2Script.ChangeImageBox2();
        Box3Script.ChangeImageBox3();
        Box4Script.ChangeImageBox4();
        Debug.Log("Box1 is: " + Box1);
        Debug.Log("Box1 is: " + Box2);
        Debug.Log("Box1 is: " + Box3);
        Debug.Log("Box1 is: " + Box4);
    }
}
