using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject PanelPause;
    public GameObject Player;
    
    public bool Paused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pause()
    {   
        if(Paused == false){
            PanelPause.SetActive(true);
            Player.SetActive(false);
            Paused = true;
        }
        else 
        {
            PanelPause.SetActive(false);
            Player.SetActive(true);
            Paused = false;  
        }
    }
}
