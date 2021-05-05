using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColliderClick : MonoBehaviour
{

    public Text txt;
    //TIMER
    private bool isLooked = false;

    public GameObject gameObject;
    public float timerDuration = 3f;

    private float lookTimer = 0f;

    void Start()
    {
    }

    void Update()
    {
        if (isLooked)
        {
            lookTimer += Time.deltaTime;

            if (lookTimer > timerDuration)
            {
                lookTimer = 0f;
                Debug.Log("Object timer click");
                OnPointerClick();
            }
        }
        else
        {
            lookTimer = 0f;
        }
    }

    public void setIsLooked(bool looked)
    {
        isLooked = looked;
    }

    public void OnPointerClick()
    {
         String str = "Click " + gameObject.name;
         Debug.Log(str);
         txt.text = str;
		 SceneManager.LoadScene("Principal");
    }

}
