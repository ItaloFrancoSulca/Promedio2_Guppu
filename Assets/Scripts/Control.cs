using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Control : MonoBehaviour {

	public void CambiarEscena(string nombre)
	{
      print("Cambiando a la escena" + nombre);
	  SceneManager.LoadScene(nombre);
	}

}
