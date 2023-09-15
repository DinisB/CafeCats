using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlrPrefstoJSON : MonoBehaviour
{
    private const string SAVE_SEPARATOR = "#SAVE-VALUE#";
    public static int started;
    public GameObject Convert;
    public GameObject End;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
        Caching.ClearCache();
        started = Buyemily.Emily = PlayerPrefs.GetInt("EmilyBought");
        if (started == 1)
        {
            Convert.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Convertion()
    {
        string[] contents = new string[]
{
            ""+PlayerPrefs.GetInt("MoneySaved"),
            ""+PlayerPrefs.GetInt("CoffeeMachineBought"),
            ""+PlayerPrefs.GetInt("EmilyBought"),
            ""+PlayerPrefs.GetInt("TablesBought"),
            ""+PlayerPrefs.GetInt("NapkinsBought"),
            ""+PlayerPrefs.GetInt("SusCatBought"),
            ""+PlayerPrefs.GetInt("FoodProtectorBought"),
            ""+PlayerPrefs.GetInt("GatoFringBought"),
            ""+PlayerPrefs.GetInt("ProvisionsBought"),
            ""+PlayerPrefs.GetInt("ForkliftBought"),
            ""+PlayerPrefs.GetInt("DrawersBought"),
            ""+PlayerPrefs.GetInt("KimikoBought"),
            ""+PlayerPrefs.GetInt("DiscoballBought"),
            ""+PlayerPrefs.GetInt("JukeboxBought")
};
        string saveString = string.Join(SAVE_SEPARATOR, contents);
        File.WriteAllText(Application.persistentDataPath + "/save.txt", saveString);
        PlayerPrefs.SetInt("EmilyBought", 0);
        End.SetActive(true);
    }

}
