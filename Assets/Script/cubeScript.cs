using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{

    float min_Scale = 1;
    float max_Scale = 2;
    public float extend_speed = 5;
    public float shrink_speed = 5;

    float Cube_Scale_x = 1;
    float Cube_Scale_z = 1;
    float yellow_Cube_Scale_y = 1;
    float red_Cube_Scale_y = 1;
    float green_Cube_Scale_y = 1;
    float blue_Cube_Scale_y = 1;

    bool pushyellow = false;
    bool yellowDown = false;
    bool pushred = false;
    bool redDown = false;
    bool pushgreen = false;
    bool greenDown = false;
    bool pushblue = false;
    bool blueDown = false;

    GameObject[] y;
    GameObject[] r;
    GameObject[] g;
    GameObject[] b;

    // Start is called before the first frame update
    void Start()
    {
        y = GameObject.FindGameObjectsWithTag("Yellow");
        r = GameObject.FindGameObjectsWithTag("Red");
        g = GameObject.FindGameObjectsWithTag("Green");
        b = GameObject.FindGameObjectsWithTag("Blue");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Alpha1) && !pushred && !redDown)
        {
            red_Cube_Scale_y = min_Scale;
            pushred = true;
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2) && !pushyellow && !yellowDown)
        {
            yellow_Cube_Scale_y = min_Scale;
            pushyellow = true;
        }
        else if (Input.GetKeyUp(KeyCode.Alpha3) && !pushgreen && !greenDown)
        {
            green_Cube_Scale_y = min_Scale;
            pushgreen = true;
        }
        else if (Input.GetKeyUp(KeyCode.Alpha4) && !pushblue && !blueDown)
        {
            blue_Cube_Scale_y= min_Scale;
            pushblue = true;

        }


        if (pushyellow)
        {

            if (yellow_Cube_Scale_y < max_Scale)
            {

                yellow_Cube_Scale_y += Time.deltaTime * extend_speed;
                
            }
            else
            {
                yellowDown = true;
                pushyellow = false;
            }

            foreach (var obj in y)
            {
                obj.transform.localScale = new Vector3(Cube_Scale_x, yellow_Cube_Scale_y, Cube_Scale_z);
            }
        }
        else if(yellowDown)
        {
            if(yellow_Cube_Scale_y > min_Scale)
            {
                yellow_Cube_Scale_y -= Time.deltaTime * shrink_speed;
            }
            else
            {
                yellowDown = false;
            }

            foreach (var obj in y)
            {
                obj.transform.localScale = new Vector3(Cube_Scale_x, yellow_Cube_Scale_y, Cube_Scale_z);
            }
        }


        if (pushred)
        {
            if (red_Cube_Scale_y < max_Scale)
            {

                red_Cube_Scale_y += Time.deltaTime * extend_speed;

            }
            else
            {
                redDown = true;
                pushred = false;
            }

            foreach (var obj in r)
            {
                obj.transform.localScale = new Vector3(Cube_Scale_x, red_Cube_Scale_y, Cube_Scale_z);
            }
        }
        else if (redDown)
        {
            if (red_Cube_Scale_y > min_Scale)
            {
                red_Cube_Scale_y -= Time.deltaTime * shrink_speed;
            }
            else
            {
                redDown = false;
            }

            foreach (var obj in r)
            {
                obj.transform.localScale = new Vector3(Cube_Scale_x, red_Cube_Scale_y, Cube_Scale_z);
            }
        }

        if (pushgreen)
        {
            if (green_Cube_Scale_y < max_Scale)
            {

                green_Cube_Scale_y += Time.deltaTime * extend_speed;

            }
            else
            {
                greenDown = true;
                pushgreen = false;
            }

            foreach (var obj in g)
            {
                obj.transform.localScale = new Vector3(Cube_Scale_x, green_Cube_Scale_y, Cube_Scale_z);
            }
        }
        else if (greenDown)
        {
            if (green_Cube_Scale_y > min_Scale)
            {
                green_Cube_Scale_y -= Time.deltaTime * shrink_speed;
            }
            else
            {
                greenDown = false;
            }

            foreach (var obj in g)
            {
                obj.transform.localScale = new Vector3(Cube_Scale_x, green_Cube_Scale_y, Cube_Scale_z);
            }
        }

        if (pushblue)
        {

            if (blue_Cube_Scale_y < max_Scale)
            {

                blue_Cube_Scale_y += Time.deltaTime * extend_speed;

            }
            else
            {
                blueDown = true;
                pushblue = false;
            }

            foreach (var obj in b)
            {
                obj.transform.localScale = new Vector3(Cube_Scale_x, blue_Cube_Scale_y, Cube_Scale_z);
            }
        }
        else if (blueDown)
        {
            if (blue_Cube_Scale_y > min_Scale)
            {
                blue_Cube_Scale_y -= Time.deltaTime * shrink_speed;
            }
            else
            {
                blueDown = false;
            }

            foreach (var obj in b)
            {
                obj.transform.localScale = new Vector3(Cube_Scale_x, blue_Cube_Scale_y, Cube_Scale_z);
            }
        }

    }

    public void Button_Pushyellow()
    {

        if (!pushyellow && !yellowDown)
        {
            yellow_Cube_Scale_y = min_Scale;
            pushyellow = true;

        }
    }

    public void Button_Pushred()
    {
        if (!pushred && !redDown)
        {
            red_Cube_Scale_y = min_Scale;
            pushred = true;
        }
    }

    public void Button_Pushgreen()
    {
        if (!pushgreen && !greenDown)
        {
            green_Cube_Scale_y = min_Scale;
            pushgreen = true;
        }
    }

    public void Button_Pushblue()
    {
        if (!pushblue && !blueDown)
        {
            blue_Cube_Scale_y = min_Scale;
            pushblue = true;
        }
    }
}