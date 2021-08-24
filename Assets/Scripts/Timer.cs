using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class Timer : MonoBehaviour
{
    public float time;
    public Text timeText;
    void Start()
    {
        
        timeText.text = "" + (int) time;
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeText.text = "" + (int) time;
        if (time <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
       
    }
}
