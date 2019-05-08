#include <Servo.h>
const byte ledPin = 13;
const byte pin = 2;
volatile byte state = LOW;



void setup()
{
  //Set up PWM pins
  pinMode(13, OUTPUT); //Test LED
  

}


void loop() {
 digitalWrite(13, HIGH);

 delay (5000);

 digitalWrite(13, LOW); 

 delay (5000);
    
  }

 
      
  
