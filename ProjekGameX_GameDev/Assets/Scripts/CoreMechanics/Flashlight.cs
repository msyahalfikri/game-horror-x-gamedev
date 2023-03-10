using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;

    // public AudioSource turnOnSound;
    // public AudioSource turnOffSound;

    [HideInInspector] public bool flashlightIsOn = false;

    private void Start()
    {
        flashlightIsOn = false;
        flashlight.SetActive(false);
    }
    private void Update()
    {
        if (flashlightIsOn)
        {
            flashlight.SetActive(true);

        }
        else if (flashlightIsOn == false)
        {
            flashlight.SetActive(false);

        }
    }

    public void SetFlashlightState()
    {
        flashlightIsOn = !flashlightIsOn;
        //play flashlight sound
    }
}
