using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {

    public string limit;
    public float myTime;
    public Text textTime;
    private float starts;
    private bool finnished;
    private string seconds;
    private string minutes;
    void Awake()
    {
        textTime = GetComponent<Text>();    
    }
    void Start () {
        
        

    }

    void Update() {


        if (finnished) return;

            myTime -= Time.deltaTime;
            //Deel het door 60 zodat je weet hoeveel minuten eruit moeten geprint worden
            minutes = ((int)myTime / 60).ToString();
            //Pak de rest waarden van de minuten zodat je de secondes hebt
            string second = (myTime % 60).ToString("f0");
            //Check of het 2 decimalen bevat en anders sluit een '0' aan

        if (second.Length == 1) { seconds = "0" + second; } else { seconds = second; }

        //Text wordt vervangen met de recente tijd
        textTime.text = minutes + ":" + seconds;


            //Als de tijd om is activeer de Finnished functie
            if (myTime <= 0.0001f) Finnished();
    

    }
    public void Finnished()
    {
        finnished = true;
        textTime.color = Color.red;
    }
}
