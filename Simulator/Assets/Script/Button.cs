using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Magaz;
    public GameObject Menu;

    private void OnMouseDown()
    {
        Menu.SetActive(true);
        Magaz.SetActive(false);
    }
}