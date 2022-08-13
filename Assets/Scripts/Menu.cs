using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Para cargar escenas
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

// Función para asociar a botón de la interfaz
// Para poner funciones en botones
// LAS FUNCIONES TIENEN QUE SER PÚBLICAS
    public void LoadLevelScene()
    {
        // método cargar escena
        SceneManager.LoadScene("Level");

    }


}
