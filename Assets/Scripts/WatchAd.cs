using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class WatchAd : MonoBehaviour

{

    public static int startad = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (startad >= 10)
        {
            WatchFullscreenAd();
            startad = 0;
        }
    }

    public void MenuClicked()
    {
        startad += 1;
    }

    public void WatchFullscreenAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }

    }
}
