using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class InitializeAds : MonoBehaviour
{

    string gameId = "4775694";
    bool testMode = true;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }
    public void WatchFullscreenAd()
    {
        if (Advertisement.IsReady())
        {
        Advertisement.Show();
        ShowMoneyOnUI.money += 400;
        }

    }

}

