using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public static Player singlton;

    public static int score = 0;

    public static List<Square> squares;
    public int squaresCount;

    void Awake()
    {
        singlton = this;
        squares = new List<Square>();
    }

    void Update()
    {
        // Проверяем, собралили ли мы все квадраты
        if (squares.Count == 0)
        {
            Victory();
        }

        squaresCount = squares.Count;
    }


    public static void Defeat()
    {
        UI.ShowDefeatPanel();
        score = 0;
    }

    public static void Victory()
    {
        UI.ShowVictoryPanel();
    }

    public static void Restart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
