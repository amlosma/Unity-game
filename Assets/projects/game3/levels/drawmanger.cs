using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawmanger : MonoBehaviour
{
    public GameObject draw;
    GameObject thetrail;
    Plane planeopj;
    Vector2 startpos;
    int[] arr = { 0, 0, 0, 0, 0, 0, 0 };

   // int counter = 0;
    void Start()
    {
        planeopj = new Plane(Camera.main.transform.forward * -1, this.transform.position);
    }

   



    









    void Update()
    {
        
       

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetMouseButtonDown(0))
        {

            thetrail = (GameObject)Instantiate(draw, this.transform.position, Quaternion.identity);
            Ray mouseray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float dis;
            if (planeopj.Raycast(mouseray, out dis))
            {
                startpos = mouseray.GetPoint(dis);
            }





        }



        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetMouseButton(0))
        {

            Ray mouseray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float dis;

            if (planeopj.Raycast(mouseray, out dis))
            {

                thetrail.transform.position = mouseray.GetPoint(dis);
            }


        }

    }
}
