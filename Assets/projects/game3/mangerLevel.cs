using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class mangerLevel : MonoBehaviour
{
    public void changescens(string sence)
    {
        Application.LoadLevel(sence);
    }
    
   
}
