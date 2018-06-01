using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour {


    public string[] text;

	// Use this for initialization
	void Start () {
        text[0] = "Hola soy Guppu...";
        text[1] = "...Y esta es mi historia";
        text[2] = "Yo solía vivir en la Gran Mordistrón";
        text[3] = "La Gran Mordistrón queda cerca al Árbol de Uchucuta";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log (text[0]);
        }

	}
}
