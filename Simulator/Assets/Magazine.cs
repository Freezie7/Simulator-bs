using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : MonoBehaviour {
    public GameObject Menu;
    public GameObject Magaz;
   public AudioSource audio;
    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
	}
    private void OnMouseDown()
    {
        Menu.SetActive(false);
        Magaz.SetActive(true);
     

    }

    // Update is called once per frame
    void Update () {
		
	}
    void primer()
    {

    }
}
