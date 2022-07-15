using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] Text pauseText;

    public void PauseUnpause()
    {
        if(Time.timeScale == 0)
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
            pauseText.text = "II";
        }
        else
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
            pauseText.text = "X";
        }
    }
}
