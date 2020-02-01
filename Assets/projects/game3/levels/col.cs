using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class col : MonoBehaviour
{
  
    public GameObject win;
     int x;
    int[] arr = { 0, 0, 0, 0, 0, 0,0 };

    void Update()
    {
        
       

    }


    void Start()
    {
        this.GetComponent<AudioSource>().Stop();        
    }



    int ons(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 1)
                sum++;
        }
        return sum;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
    
            if (other.gameObject.tag == "1")
            {
                //Debug.Log("ddddddddd1");
                arr[0] = 1;
            x = ons(arr);
            }
            if (other.gameObject.tag == "2")
            {
                //Debug.Log("ddddddddd2");

                arr[1] = 1;
            x = ons(arr);
        }
            if (other.gameObject.tag == "3")
            {
              //  Debug.Log("ddddddddd3");

                arr[2] = 1;
            x = ons(arr);
        }
            if (other.gameObject.tag == "4")
            {
            //    Debug.Log("ddddddddd4");

                arr[3] = 1;
            x = ons(arr);
        }
            if (other.gameObject.tag == "5")
            {
                //Debug.Log("ddddddddd5");

                arr[4] = 1;
            x = ons(arr);
        }
            if (other.gameObject.tag == "6")
            {
                //Debug.Log("ddddddddd6");

                arr[5] = 1;
            x = ons(arr);
        }
            if (other.gameObject.tag == "7")
            {
              //  Debug.Log("ddddddddd7");

                arr[6] = 1;
            x = ons(arr);

        }


        if (x == 7)
        {
            Instantiate(win);
            this.GetComponent<AudioSource>().Play();
            //Debug.Log("salmawin");
        }


    } 
}