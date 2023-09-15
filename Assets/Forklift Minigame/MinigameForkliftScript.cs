using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MinigameForkliftScript : MonoBehaviour
{
    public float timer = 0; // temporizador
    public int timecheck = 5;
    public static int score = 0;
    public TMP_Text timeCounter;
    public static bool GameStarted = false;
    public GameObject Menu;
    public BoxesOrder BoxesOrder;
    public Box1Change Box1Change;
    public Box2Change Box2Change;
    public Box3Change Box3Change;
    public Box4Change Box4Change;
    // Start is called before the first frame update
    void Start()
    {
        timeCounter.SetText(timer.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStarted == true)
        {
            timer = timer + 1 * Time.deltaTime;
            timeCounter.SetText(timer.ToString());
            if (timer >= timecheck)
            {
                Debug.Log("Works");
                timer = 0;
                CheckForkliftScore();
            }
        }
    }



    public void StartMinigameForklift()
    {
        timer = 0;
        score = 0;
        timer = timer + 1 * Time.deltaTime;
        GameStarted = true;
    }

    public void CheckForkliftScore()
    {
        if (Box1Change.Box1Changer == BoxesOrder.Box1 && Box2Change.Box2Changer == BoxesOrder.Box2 && Box3Change.Box3Changer == BoxesOrder.Box3 && Box4Change.Box4Changer == BoxesOrder.Box4)
        {
            Debug.Log("All Equal");
            score += 1;
            ContinueForklift();
            BoxesOrder.RandomizeBoxes();
        }

        else
        {
            Debug.Log("Not Equal");
            StopForkliftMinigame();
        }
    }

    public void ContinueForklift()
    {
        if (timer >= timecheck)
        {
            timer = 0;
            CheckForkliftScore();
        }
    }

    public void StopForkliftMinigame()
    {
        GameStarted = false;
        ShowMoneyOnUI.money += score * 10;
        Menu.SetActive(true);
    }
}
