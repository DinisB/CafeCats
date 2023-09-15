using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JukeboxHidden : MonoBehaviour
{
    public GameObject Jukebox;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Buyjukebox.jukebox == 0)
        {
            Button.SetActive(true);
            Jukebox.SetActive(false);
        }
        if (Buyjukebox.jukebox == 1)
        {
            Button.SetActive(false);
            Jukebox.SetActive(true);
        }
    }
}
