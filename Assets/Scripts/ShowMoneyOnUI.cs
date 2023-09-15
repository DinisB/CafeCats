using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ShowMoneyOnUI : MonoBehaviour
{
    private const string SAVE_SEPARATOR = "#SAVE-VALUE#";
    public static int money = 0; // variavel do dinheiro
    public static int MultiplierTouch = 1;
    public float timer = 0; // temporizador
    public float timecheck = 20;
    public bool SaveGame = false;
    public static int SawTutorial = 0;
    public ScrollRect Shop;
    public ScrollRect Settings;
    public ScrollRect Story;
    public ScrollRect Floors;
    public TMP_Text moneyCounter; // public text do dinheiro
    public GameObject tutorialpage1;

    // Start is called before the first frame update
    void Start()
    {
        Input.multiTouchEnabled = false;
        Application.targetFrameRate = 30;
        LoadGameFunc();
        MainHallComplete();
        GarageComplete();
        DiscoClubComplete();
        if (!PlayerPrefs.HasKey("FirstTime"))
        {
            tutorialpage1.SetActive(true);
            PlayerPrefs.SetInt("FirstTime", 1);
        }
        moneyCounter.SetText(money.ToString()); // MoneyText.text é o texto e money.ToString() é o de mostrar uma variavel
    }

    // Update is called once per frame
    void Update()
    {
        moneyCounter.SetText(money.ToString());
        timer = timer + 1 * Time.deltaTime;
        if (timer >= timecheck)
        {
            SaveGame = true;

        }

        if (SaveGame == true)
        {
            SaveGameFunc();
            LoadGameFunc();
            timer = 0f;
            SaveGame = false;
        }
    }
    public void SaveGameFunc()
    
    {
        Debug.Log("Saved");

        /*
        PlayerPrefs.SetInt("MoneySaved", money);
        PlayerPrefs.SetInt("CoffeeMachineBought", Buycoffeemachine.CoffeeMachine);
        PlayerPrefs.SetInt("EmilyBought", Buyemily.Emily);
        PlayerPrefs.SetInt("TablesBought", Buytables.Tables);
        PlayerPrefs.SetInt("NapkinsBought", Buynapkins.Napkins);
        PlayerPrefs.SetInt("SusCatBought", Buysuscat.Suscat);
        PlayerPrefs.SetInt("FoodProtectorBought", Buyfood.Food);
        PlayerPrefs.SetInt("GatoFringBought", Buygatofring.GatoFring);
        PlayerPrefs.SetInt("ProvisionsBought", Buyprovisions.Provisions);
        PlayerPrefs.SetInt("ForkliftBought", Buyforklift.Forklift);
        PlayerPrefs.SetInt("DrawersBought", Buydrawers.Drawers);
        PlayerPrefs.SetInt("KimikoBought", Buykimiko.kimiko);
        PlayerPrefs.SetInt("DiscoballBought", Buydiscoball.discoball);
        PlayerPrefs.SetInt("JukeboxBought", Buyjukebox.jukebox);
        */

        PlayerPrefs.SetInt("SawTutorial", SawTutorial);

        string[] contents = new string[]
        {
            ""+money,
            ""+Buycoffeemachine.CoffeeMachine,
            ""+Buyemily.Emily,
            ""+Buytables.Tables,
            ""+Buynapkins.Napkins,
            ""+Buysuscat.Suscat,
            ""+Buyfood.Food,
            ""+Buygatofring.GatoFring,
            ""+Buyprovisions.Provisions,
            ""+Buyforklift.Forklift,
            ""+Buydrawers.Drawers,
            ""+Buykimiko.kimiko,
            ""+Buydiscoball.discoball,
            ""+Buyjukebox.jukebox,
            ""+Buysayamese.SayameseCat,
            ""+Buypunch.punch,
            ""+Buyparte.Parte,
            ""+Buydjtable.Djtable
        };
        string saveString = string.Join(SAVE_SEPARATOR, contents);
        File.WriteAllText(Application.persistentDataPath + "/save.txt", saveString);
    }
    public void Clicked()
    {
        money += 1 * MultiplierTouch;
    }

    public void LoadGameFunc()
    {

        /*
       money = PlayerPrefs.GetInt("MoneySaved");
       Buycoffeemachine.CoffeeMachine = PlayerPrefs.GetInt("CoffeeMachineBought");
       Buyemily.Emily = PlayerPrefs.GetInt("EmilyBought");
       Buytables.Tables = PlayerPrefs.GetInt("TablesBought");
       Buynapkins.Napkins = PlayerPrefs.GetInt("NapkinsBought");
       Buysuscat.Suscat = PlayerPrefs.GetInt("SusCatBought");
       Buyfood.Food = PlayerPrefs.GetInt("FoodProtectorBought");
       Buygatofring.GatoFring = PlayerPrefs.GetInt("GatoFringBought");
       Buyprovisions.Provisions = PlayerPrefs.GetInt("ProvisionsBought");
       Buyforklift.Forklift = PlayerPrefs.GetInt("ForkliftBought");
       Buydrawers.Drawers = PlayerPrefs.GetInt("DrawersBought");
       Buykimiko.kimiko = PlayerPrefs.GetInt("KimikoBought");
       Buydiscoball.discoball = PlayerPrefs.GetInt("DiscoballBought");
       Buyjukebox.jukebox = PlayerPrefs.GetInt("JukeboxBought");
        */

        string saveString = File.ReadAllText(Application.persistentDataPath + "/save.txt");
       Debug.Log(saveString);
        string[] contents = saveString.Split(new[] { SAVE_SEPARATOR }, System.StringSplitOptions.None);
       money = int.Parse(contents[0]);
       Buycoffeemachine.CoffeeMachine = int.Parse(contents[1]);
       Buyemily.Emily = int.Parse(contents[2]);
       Buytables.Tables = int.Parse(contents[3]);
       Buynapkins.Napkins = int.Parse(contents[4]);
       Buysuscat.Suscat = int.Parse(contents[5]);
       Buyfood.Food = int.Parse(contents[6]);
       Buygatofring.GatoFring = int.Parse(contents[7]);
       Buyprovisions.Provisions = int.Parse(contents[8]);
       Buyforklift.Forklift = int.Parse(contents[9]);
       Buydrawers.Drawers = int.Parse(contents[10]);
       Buykimiko.kimiko = int.Parse(contents[11]);
       Buydiscoball.discoball = int.Parse(contents[12]);
       Buyjukebox.jukebox = int.Parse(contents[13]);
       Buysayamese.SayameseCat = int.Parse(contents[14]);
       Buypunch.punch = int.Parse(contents[15]);
       Buyparte.Parte = int.Parse(contents[16]);
       Buydjtable.Djtable = int.Parse(contents[17]);

    }
    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/cathulhugames");
    }

    public void ResetScrollview()
    {
        Shop.verticalNormalizedPosition = 1f;
        Settings.verticalNormalizedPosition = 1f;
        Story.verticalNormalizedPosition = 1f;
        Floors.verticalNormalizedPosition = 1f;
    }

    public void EndTutorial()
    {
        SawTutorial = 1;
    }

    public void MainHallComplete()
    {
        if (Buycoffeemachine.CoffeeMachine == 1 && Buyemily.Emily == 1 && Buytables.Tables == 1 && Buynapkins.Napkins == 1 && Buysuscat.Suscat == 1 && Buyfood.Food == 1)
        {
            MultiplierTouch += 1;
        }
    }

    public void GarageComplete()
    {
        if (Buygatofring.GatoFring == 1 && Buyprovisions.Provisions == 1 && Buyforklift.Forklift == 1 && Buydrawers.Drawers == 1 && Buykimiko.kimiko == 1)
        {
            MultiplierTouch += 1;
        }
    }

    public void DiscoClubComplete()
    {
        if (Buydiscoball.discoball == 1 && Buyjukebox.jukebox == 1 && Buysayamese.SayameseCat == 1 && Buypunch.punch == 1 && Buyparte.Parte == 1 && Buydjtable.Djtable == 1)
        {
            MultiplierTouch += 1;
        }
    }
}
