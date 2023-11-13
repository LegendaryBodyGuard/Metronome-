using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class Touch : MonoBehaviour
{
    [SerializeField] private Button settings;
    [SerializeField] private Button Tap;
    [SerializeField] private Button TS;
    [SerializeField] private Button playbutton;
    [SerializeField] private Button increase;
    [SerializeField] private Button lower;
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchPosition, Color.magenta);
            if (settings)
            {
                Debug.Log("I am touching the settings" + settings);   
            }
            else if (Tap)
            {
                Debug.Log("I am touching the tap" + Tap);   
            }
            else if (TS)
            {
                Debug.Log("I am touching the TS" + TS);   
            }
            else if (playbutton)
            {
                Debug.Log("I am touching the play" + playbutton);
            }
            else if (increase)
            {
                Debug.Log("I am touching the increase" + increase);   
            }
            else if (lower)
            {
                Debug.Log("I am touching the decrease" + lower);   
            }
            else
            {
                Debug.Log("I am touching the background");
            }

        }
    }
}
