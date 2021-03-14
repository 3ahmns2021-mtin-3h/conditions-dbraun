using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour
{
    public bool A = false;
    public bool B = false;
    public bool C = false;
    public bool D = false;

    public GameObject image;

    private float time;

    bool einsPress;
    bool zweiPress;
    bool dreiPress;
    bool vierPress;

    public void ButtonPress()
    {
        A = true;
        Debug.Log("Button is Pressed");
    }





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (A == true)
        {
            image.SetActive(false);
            B = true;
            Debug.Log("Active");
        }


        if (Input.GetKey(KeyCode.Space))
        {
            time += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            time = 0;
        }

        if (time > 3)
        {
            Debug.Log("3Seconds");
            C = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            einsPress = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            zweiPress = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            dreiPress = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            vierPress = true;
        }

        if (einsPress && zweiPress && dreiPress && vierPress)
        {
            D = true;
        }

        Debug.Log("zwei conitions erfüllt: " + ((A && B) | (B && C) | (C && D)));
    }
}
