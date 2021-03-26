using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{

        public void inicio(string escena)
        {
        Screen.orientation = ScreenOrientation.Portrait;
        SceneManager.LoadScene(escena);
        }
    
}
