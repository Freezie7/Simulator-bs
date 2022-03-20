using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour {
    public GameObject Menu;
    public GameObject minibox;
    public GameObject bigbox;
    public GameObject megabox;
    public GameObject addbox;
    private int gems = 0;
    private int coins;
    public Text gemsText;
    public Text coinsText;
    


    public void Start()
    {
       if (PlayerPrefs.HasKey("GEMS"))
        {
           gems = PlayerPrefs.GetInt("GEMS");
        }

        gemsText.text = gems.ToString();
        coinsText.text = coins.ToString();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            gems += 1000;
            gemsText.text = gems.ToString();

            PlayerPrefs.SetInt("GEMS", gems);
            PlayerPrefs.Save();
            
           // gemsText.text += gems;
        }
    }

    public void openMiniBox()
    {
        if (gems >= 0)
        {
            Menu.SetActive(false);
            minibox.SetActive(true);
            PlayerPrefs.SetInt("GEMS", gems);
            PlayerPrefs.Save();
        }
    }
  public void openBigBox()
    {
        if (gems >= 30)
        {
            Menu.SetActive(false);
            bigbox.SetActive(true);
            gems -= 30;
            gemsText.text = gems.ToString();
            PlayerPrefs.SetInt("GEMS", gems);
            PlayerPrefs.Save();
        }
    }
    public void openMegaBox()
    {
        if (gems >= 80)
        {
            Menu.SetActive(false);
            megabox.SetActive(true);
            gems -= 80;
            gemsText.text = gems.ToString();
            PlayerPrefs.SetInt("GEMS", gems);
            PlayerPrefs.Save();
        }
    }
    public void openAddBox()
    {
        Menu.SetActive(false);
        addbox.SetActive(true);
        PlayerPrefs.SetInt("GEMS", gems);
        PlayerPrefs.Save();
    }



}
