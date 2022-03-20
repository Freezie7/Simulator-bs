using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Magaz;
   public AudioSource audio;


    private void OnMouseDown()
    {
        Menu.SetActive(false);
        Magaz.SetActive(true);
     

    }

}
