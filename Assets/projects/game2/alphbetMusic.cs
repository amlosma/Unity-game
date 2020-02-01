using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class alphbetMusic : MonoBehaviour
{
   
    // Start is called before the first frame update
    public AudioSource[] Alphabet;
    public AudioSource good,bd;
    public GameObject right, wrong,note1,note2,note3;
    public Text[] texts = null;
    public int counter=0;
    public Button btn1,btn2,btn3;
    int[] rand = new int[4];
    public Sprite[] sp;
    public string[] words = { "apple", "bear", "car", "dog", "elephant", "frog", "girl", "hen", "ice cream", "jam", "king", "lion", "mouse", "nut", "orange", "plane", "quilt", "rabbit", "sun", "tiger", "umbrella", "vase", "whale", "x_ray", "yo_yo", "zebra" };
    void Start()
    {
        rand[0] = 0;
        rand[1] = 1; rand[2] = 2;
        wrong.SetActive(false); right.SetActive(false);
        good.GetComponent<AudioSource>().Stop();

        bd.GetComponent<AudioSource>().Stop();
        for(int i=0;i<26;i++)
       Alphabet[i].GetComponent<AudioSource>().Stop();
        note1.SetActive(true);
        note2.SetActive(true);
        note3.SetActive(true);
        //new WaitForSeconds(100.0f);
        StartCoroutine(sec());
    }
    IEnumerator sec()
    {
        for (int i = 0; i < 3; i++)
            yield return new WaitForSeconds(1f);
        note1.SetActive(false);
        note2.SetActive(false);
        note3.SetActive(false);
    }
   
    void Update()
    {
       
    }
    public void increase()
    {
        if (counter < 25)  counter++;
        wrong.SetActive(false); right.SetActive(false);
        create_random();
        findpermutation(Random.Range(1, 5));
    }
    public void decrease()
    {
        if(counter>0) counter--;
        wrong.SetActive(false); right.SetActive(false);
        create_random();
        findpermutation(Random.Range(1, 5));
    }
    public void swap(int i, int r)
    {
        int t = rand[i];
        rand[i] = rand[r];
        rand[r] = t;
    }
    public void findpermutation(int ind)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int r = i; r < 3; r++)
            {
                if (rand[i] > rand[r])

                {
                    swap(i, r);

                }

            }

        }
        if (ind == 1)
        {
            swap(0, 1);

        }
        if (ind == 2)
        {
            swap(0, 2);

        }
        if (ind == 3)
        {
            swap(1, 2);

        }
        if (ind == 4)
        {
            swap(0, 1);
            swap(0, 2);

        }

    }
    public void create_random()
    {

        rand[0] = counter;

        while (rand[1] == rand[0])
        {
            rand[1] = Random.Range(0, 26);
        }

        while (rand[0] == rand[2] || rand[1] == rand[2])
        {
            rand[2] = Random.Range(0, 26);

        }

    }
    public void Show_change()
    {
        wrong.SetActive(false);
        right.SetActive(false);
        good.GetComponent<AudioSource>().Stop();

        bd.GetComponent<AudioSource>().Stop();
        btn1.GetComponent<Image>().sprite = sp[rand[0]];
        btn2.GetComponent<Image>().sprite = sp[rand[1]];
        btn3.GetComponent<Image>().sprite = sp[rand[2]];

        texts[0].GetComponent<Text>().text = words[rand[0]];
        texts[1].GetComponent<Text>().text = words[rand[1]];
        texts[2].GetComponent<Text>().text = words[rand[2]];
        Alphabet[counter].Play();
            
        
    }
    void OnEnable()
    {
        //Register Button Events
        btn1.onClick.AddListener(() => buttonCallBack(btn1));
        btn2.onClick.AddListener(() => buttonCallBack(btn2));
        btn3.onClick.AddListener(() => buttonCallBack(btn3));

    }
   
    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == btn1)
        {
            if(texts[0].text==words[counter])
            {
                
                good.Play();
                wrong.SetActive(false);
                right.SetActive(true);
               
                
            }
            else
            {
                bd.Play();
                right.SetActive(false);

                wrong.SetActive(true);
                
            }
        }

        if (buttonPressed == btn2)
        {
            if (texts[1].text == words[counter])
            {
                good.Play();
                wrong.SetActive(false);
                right.SetActive(true);
                
                
            }
            else
            {
                bd.Play();
                right.SetActive(false);

                wrong.SetActive(true);
               
               
            }
        }

        if (buttonPressed == btn3)
        {
            if (texts[2].text == words[counter])
            {
                good.Play();
                wrong.SetActive(false);
                right.SetActive(true);
               // new    WaitForSeconds(2f);
               // right.SetActive(false);
            }
            else
            {
                bd.Play();
                right.SetActive(false);
                wrong.SetActive(true);
                
            }
        }
    }
    

}
