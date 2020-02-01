using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class soundmanger : MonoBehaviour
{//sound and pause the game
    public float actualvolum = .5f;
    public Slider soundslider;
    public bool mute = false;
   
    public AudioClip gamesound;
    public static soundmanger instance;
    public Image fall;
    void Awake()
    {

        if (instance == null)

            instance = this;

        else if (instance != this)

            Destroy(gameObject);
    }
    //public void setvalum(float valume)
    //{
    //    actualvolum = valume;

    //}
    void Start()
    {
        GetComponent<AudioSource>().Play();
        soundslider.value = actualvolum;
        
        GetComponent<AudioSource>().volume = actualvolum;
    }

  public void clickmute() {


        GetComponent<AudioSource>().mute = true;
        fall.fillAmount = 0;
        soundslider.value = 0;
        mute = true;
    }
    public void clicksound() {

        GetComponent<AudioSource>().mute = false;
        soundslider.value = actualvolum;
        fall.fillAmount = actualvolum;
        mute = false;

    }
    void Update()
    {
        //fall.fillAmount = actualvolum;
       // GetComponent<AudioSource>().volume = actualvolum;
        if (Input.GetKey(KeyCode.RightArrow) && actualvolum < 1)
        {

            actualvolum += .02f;

            soundslider.value = actualvolum;
            fall.fillAmount = actualvolum;
            GetComponent<AudioSource>().volume = actualvolum;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && actualvolum > 0)
        {
            actualvolum -= .02f;
            soundslider.value = actualvolum;
            fall.fillAmount = actualvolum;
            GetComponent<AudioSource>().volume = actualvolum;
        }

        if (Input.GetKeyUp(KeyCode.M))
        {

            if (mute)
            {
                GetComponent<AudioSource>().mute = false;
                soundslider.value = actualvolum;
                fall.fillAmount = actualvolum;
                mute = false;
            }
            else
            {
                GetComponent<AudioSource>().mute = true;
                fall.fillAmount = 0;
                soundslider.value = 0;
                mute = true;
            }

        }
    }
}
