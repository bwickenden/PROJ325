#include <Servo.h>
const byte ledPin = 13;
const byte pin = 2;
volatile byte state = LOW;
int t = HIGH;
String content = "";


void setup()
{
  //Set up PWM pins
  pinMode(13, OUTPUT); //Test LED
  

  
  //Begin serial input
  Serial.begin(9600); // Baud rate
  delay(100);
}


void loop() {

  while(Serial.available()) {
    content = Serial.readString();   
  }

  if(content.substring(0,5) == "Thumb") { 
    String Hand =  content.substring(5, (content.length())); 
   
    
      digitalWrite(13, HIGH); // LED ON
       delay(500);
      
      }

    if(content.substring(0,5) == "Index") {  
    String Hand =  content.substring(5, (content.length())); 
   
    
      digitalWrite(13, LOW); // LED OFF
       delay(500);
      
      }
    
      
      
  }
  
