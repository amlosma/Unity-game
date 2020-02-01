using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomevalue : MonoBehaviour
{
    //public GameObject win;
    // Start is called before the first frame update
    public char[] capchar = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'W', 'X', 'Y', 'Z', 'v' };
    public char[] smlchar = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'w', 'x', 'y', 'z', 'v' };
    public Button[] bb;
    public Button[] BB;
    public AudioSource good;
    int[] rand = new int[4];
    public Text[] Captail_txt = null;
    public Text[] Small_txt = null;
    public int counter;
    bool flag1, flag2;
    public string ToCheckAlphCaptail, ToCheckAlphSmall;
    int ind1 = -1, ind2 = -1;
    void Start()
    {
        good.GetComponent<AudioSource>().Stop();
        create_random();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void create_random()
    {

        rand[0] = Random.Range(0, 26);

        while (rand[1] == rand[0])
        {
            rand[1] = Random.Range(0, 26);
        }

        while (rand[0] == rand[2] || rand[1] == rand[2])
        {
            rand[2] = Random.Range(0, 26);

        }

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
    public void change_txtOfBtn()
    {
        counter = 0;
        for(int i=0;i<3;i++)
        {
            bb[i].GetComponent<Image>().color = Color.white;
            bb[i].interactable = true;
            BB[i].GetComponent<Image>().color = Color.white;
            BB[i].interactable = true;
        }
        //for captail letter
        create_random();
        int ind = Random.Range(1, 5);
        findpermutation(ind);

        Captail_txt[0].text = capchar[rand[0]].ToString();
        Captail_txt[1].text = capchar[rand[1]].ToString();
        Captail_txt[2].text = capchar[rand[2]].ToString();

        //for small letter
        int ind2 = ind;
        while (ind == ind2)
        {
            ind2 = Random.Range(1, 5);
        }
        findpermutation(ind2);
        Small_txt[0].text = smlchar[rand[0]].ToString();
        Small_txt[1].text = smlchar[rand[1]].ToString();
        Small_txt[2].text = smlchar[rand[2]].ToString();
    }
    void OnEnable()
    {
        //Register Button Events
        bb[0].onClick.AddListener(() => buttonCallBack(bb[0]));
        bb[1].onClick.AddListener(() => buttonCallBack(bb[1]));
        bb[2].onClick.AddListener(() => buttonCallBack(bb[2]));
        BB[0].onClick.AddListener(() => buttonCallBack(BB[0]));
        BB[1].onClick.AddListener(() => buttonCallBack(BB[1]));
        BB[2].onClick.AddListener(() => buttonCallBack(BB[2]));

    }
    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == bb[0])
        {
            if (flag1 == false)
            {
                bb[0].GetComponent<Image>().color = Color.blue;
                flag1 = true;
                ToCheckAlphSmall = Small_txt[0].text;
                ind1 = 0;
            }
            else
            {
                bb[ind1].GetComponent<Image>().color = Color.white;
                bb[0].GetComponent<Image>().color = Color.blue;
                flag1 = true;
                ToCheckAlphSmall = Small_txt[0].text;
                ind1 = 0;

            }
        }
        if (buttonPressed == bb[1])
        {
            if (flag1 == false)
            {
                bb[1].GetComponent<Image>().color = Color.blue;
                flag1 = true;
                ToCheckAlphSmall = Small_txt[1].text;
                ind1 = 1;
            }
            else
            {
                bb[ind1].GetComponent<Image>().color = Color.white;
                bb[1].GetComponent<Image>().color = Color.blue;
                flag1 = true;
                ToCheckAlphSmall = Small_txt[1].text;
                ind1 = 1;

            }
        }
        if (buttonPressed == bb[2])
        {
            if (flag1 == false)
            {
                bb[2].GetComponent<Image>().color = Color.blue;
                flag1 = true;
                ToCheckAlphSmall = Small_txt[2].text;
                ind1 = 2;
            }
            else
            {
                bb[ind1].GetComponent<Image>().color = Color.white;
                bb[2].GetComponent<Image>().color = Color.blue;
                flag1 = true;
                ToCheckAlphSmall = Small_txt[2].text;
                ind1 = 2;

            }
        }
        if (buttonPressed == BB[0])
        {
            if (flag2 == false)
            {
                BB[0].GetComponent<Image>().color = Color.blue;
                flag2 = true;
                ToCheckAlphCaptail = Captail_txt[0].text;
                ind2 = 0;
            }
            else
            {
                BB[ind2].GetComponent<Image>().color = Color.white;
                BB[0].GetComponent<Image>().color = Color.blue;
                flag2 = true;
                ToCheckAlphCaptail = Captail_txt[0].text;
                ind2 = 0;

            }
        }
        if (buttonPressed == BB[1])
        {
            if (flag2 == false)
            {
                BB[1].GetComponent<Image>().color = Color.blue;
                flag2 = true;
                ToCheckAlphCaptail = Captail_txt[1].text;
                ind2 = 1;
            }
            else
            {
                BB[ind2].GetComponent<Image>().color = Color.white;
                BB[1].GetComponent<Image>().color = Color.blue;
                flag2 = true;
                ToCheckAlphCaptail = Captail_txt[1].text;
                ind2 = 1;

            }
        }
        if (buttonPressed == BB[2])
        {
            if (flag2 == false)
            {
                BB[2].GetComponent<Image>().color = Color.blue;
                flag2 = true;
                ToCheckAlphCaptail = Captail_txt[2].text;
                ind2 = 2;
            }
            else
            {
                BB[ind2].GetComponent<Image>().color = Color.white;
                BB[2].GetComponent<Image>().color = Color.blue;
                flag2 = true;
                ToCheckAlphCaptail = Captail_txt[2].text;
                ind2 = 2;

            }
        }
        if (flag1 && flag2)
        {
            char cp = char.ToLower( ToCheckAlphCaptail[0]);
            char sm =ToCheckAlphSmall[0];
            if(sm == cp)
            {
                counter++;
                bb[ind1].GetComponent<Image>().color = Color.green;
                BB[ind2].GetComponent<Image>().color = Color.green;
                ToCheckAlphCaptail="";
                ToCheckAlphSmall="";
                bb[ind1].interactable = false;
                BB[ind2].interactable = false;
                flag1 = false;
                flag2 = false;
                ind1 = -1; 
                ind2 = -1;

            }
            else
            {

                bb[ind1].GetComponent<Image>().color = Color.white;
                BB[ind2].GetComponent<Image>().color = Color.white;
                ToCheckAlphCaptail = "";
                ToCheckAlphSmall = "";
                flag1 = false;
                    flag2 = false;
                ind1 = -1;
                    ind2 = -1;
            }

        }
        if(counter == 3)
        {
            good.Play();
            counter = 0;
           // Instantiate(win);
        }
    }
}
