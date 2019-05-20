using UnityEngine;
using System.IO.Ports;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
   
public class ArduinoComs : MonoBehaviour
{
    [SerializeField]
    private int portNum;

    SerialPort stream;


    
    void Start() // Opening void 
    {
     
        for (int k = 0; k < 50; k++) // Number of serial ports to be checked 
        {
            portNum = k; // Update Port number 
            stream = new SerialPort("COM" + portNum, 9600); // COM port at 9600 baud rate

            if (!stream.IsOpen)
            {
                try
                {
                    Debug.Log("Attempting to open serial port: " + "COM" + k); //Debug for open serial port
                    stream.Open(); // Open serial port
                    Debug.Log("Serial Port Open"); // Confirm port is open

                    break;
                }
                catch (Exception ex)  // If serial port is not open send error message
                {
                    Debug.Log("Failed to open port. Error: " + ex);
                }
            }


        }


    }

    
    void Update()
    {

    }

    public void SendString(string message) // Send message to Arduino
    {
        try
        {
            stream.Open(); // Open stream
        }
        catch (Exception ex)
        {
            Debug.Log("Error: " + ex); // Error if steam not open
        }
        
        stream.Write(message);   //Send selected message to Arduino
        Debug.Log("Message was sent. Message was: " + message); // Erros message if string not sent 
        stream.Close(); // Close stream
    }
}