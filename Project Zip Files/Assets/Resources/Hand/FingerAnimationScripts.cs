
using System;
using System.IO.Ports;
using UnityEngine;
using System.Collections;



public class FingerAnimationScripts : MonoBehaviour
{

    private Animator anim;
    private ArduinoComs arduino;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        arduino = GetComponent<ArduinoComs>();


    }

    // Update is called once per frame
    void Update()
    {

        // Nitinol Inputs
        if (Input.GetKeyDown(KeyCode.G)) // Press G to move Thumb
        {

            anim.Play("Thumb"); //Play Thumb Animation
            Debug.Log("G key detected " );
            arduino.SendString("Thumb"); //Send string to Arduino Via serial Port
            Debug.Log("String sent ");

        }


        if (Input.GetKeyDown(KeyCode.H)) // Press H to move Index Finger
        {
            anim.Play("Index"); //Play Index Finger Animation
            Debug.Log("H key detected ");
            arduino.SendString("Index"); //Send string to Arduino Via serial Port
            Debug.Log("String sent ");
        }


        if (Input.GetKeyDown(KeyCode.J)) // Press J to move Middle Finger
        {
            anim.Play("Middle"); // Play Middle Finger Animation
            arduino.SendString("Middle");  //Send string to Arduino Via serial Port
        }


        if (Input.GetKeyDown(KeyCode.K)) // Press K to move Ring Finger
        {
            anim.Play("Ring");  //Play Ring Finger Animation
            arduino.SendString("Ring");  //Send string to Arduino Via serial Port
        }


        if (Input.GetKeyDown(KeyCode.L)) // Press L to move Little Finger
        {
            anim.Play("Little"); // Play Little Finger Animation
            arduino.SendString("Little"); //Send string to Arduino Via serial Port
        }


        // Motor Inputs
        if (Input.GetKeyDown(KeyCode.Y)) // Press Y to Activiate Thumb Motor 
        {
           
            arduino.SendString("Motor1"); //Send string to Arduino Via serial Port
           

        }

        if (Input.GetKeyDown(KeyCode.U)) // Press U to Activiate Index Motor 
        {

            arduino.SendString("Motor2"); //Send string to Arduino Via serial Port
        }

        if (Input.GetKeyDown(KeyCode.I)) // Press I to Activiate Middle Motor 
        {

            arduino.SendString("Motor3"); //Send string to Arduino Via serial Port
        }

        if (Input.GetKeyDown(KeyCode.O)) // Press O to Activiate Ring Motor 
        {

            arduino.SendString("Motor4"); //Send string to Arduino Via serial Port
        }

        if (Input.GetKeyDown(KeyCode.P)) // Press P to Activiate Thumb Motor 
        {

            arduino.SendString("Motor5"); //Send string to Arduino Via serial Port
        }

        if (Input.GetKeyDown(KeyCode.F)) // Press P to Activiate Thumb Motor 
        {

            arduino.SendString("Stop"); //Send string to Arduino Via serial Port
        }

        /*else
        {
            anim.Play("Idle Hand"); //Play Idle Hand Animation

        }*/
    }
}
