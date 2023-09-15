using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreForklift : MonoBehaviour
{
    public TMP_Text scoreCounter;
    // Start is called before the first frame update
    void Start()
    {
        scoreCounter.SetText(MinigameForkliftScript.score.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        scoreCounter.SetText(MinigameForkliftScript.score.ToString());
    }
}
