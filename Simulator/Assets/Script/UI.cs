using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public static UI singlton;

    public Text scoreText;

    public GameObject panel;
    public Text panelScoreText;

    public Text defeatText;
    public Text victoryText;

    void Awake()
    {
        singlton = this;
    }

    void Update()
    {
        scoreText.text = Player.score.ToString();
    }

    public void OnClickRestart()
    {
        Player.Restart();
    }

    public static void ShowVictoryPanel()
    {
        singlton.panel.SetActive(true);
        singlton.victoryText.gameObject.SetActive(true);
        singlton.panelScoreText.text = Player.score.ToString();
    }

    public static void ShowDefeatPanel()
    {
        singlton.panel.SetActive(true);
        singlton.defeatText.gameObject.SetActive(true);
        singlton.panelScoreText.text = Player.score.ToString();
    }
}