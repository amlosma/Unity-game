using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{

    public void gotoscene(string namescene) {

        SceneManager.LoadScene(namescene);
    }
    public void quitgame() {

        Debug.Log("QUIT!!!!!");
        Application.Quit();
    }
}
