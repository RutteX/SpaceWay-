using System;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public Text kilometersText;
    public Text meteorsText;
    public float kilometers = 360f;
    public static int countMeteors;
    
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Game"){
            kilometersText.text = kilometers.ToString(); 
        }
        if(SceneManager.GetActiveScene().name == "GameOver"){
            meteorsText.text = countMeteors.ToString();
        } 
        if(SceneManager.GetActiveScene().name == "victory"){
            meteorsText.text = countMeteors.ToString();  
        }
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Game"){
            kilometers -= Time.deltaTime * 12f;
            kilometersText.text = Mathf.Round(kilometers).ToString() + " км";
            if (kilometers <= 0f){
                SceneManager.LoadScene("victory");
            }
            meteorsText.text = countMeteors.ToString();
        }
    }
}
