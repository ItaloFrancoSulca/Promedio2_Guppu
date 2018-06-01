using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{


    public string[] text;
    Text firstTextComponent;
    Text secondTextComponent;
    Text thirdTextComponent;
    Text lastTextComponent;
    public GameObject[] theCanvas;

    private void Awake()
    {
        firstTextComponent = theCanvas[0].GetComponent<Text>();
        secondTextComponent = theCanvas[1].GetComponent<Text>();
        thirdTextComponent = theCanvas[2].GetComponent<Text>();
        lastTextComponent = theCanvas[3].GetComponent<Text>();
    }
    void Start()
    {
        text[0] = "Hola soy Guppu...";
        text[1] = "...Y esta es mi historia";
        text[2] = "Yo solía vivir en la Gran Mordistrón";
        text[3] = "La Gran Mordistrón queda cerca al Árbol de Uchucuta";

    }

    // Update is called once per frame
    void Update()
    {

        firstTextComponent.text = text[0];
        secondTextComponent.text = text[1];
        thirdTextComponent.text = text[2];
        lastTextComponent.text = text[3];


    }
}
