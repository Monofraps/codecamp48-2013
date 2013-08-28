/*
  Blink
 Turns on an LED on for one second, then off for one second, repeatedly.
 
 This example code is in the public domain.
 */

// Pin 13 has an LED connected on most Arduino boards.x
// give it a name:
int led = 13;

// the setup routine runs once when you press reset:
void setup() {                
  // initialize the digital pin as an output.
  Serial.begin(9600);
  pinMode(led, OUTPUT);     
}

void blinkIt() {
  digitalWrite(led, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(1000);               // wait for a second
  digitalWrite(led, LOW);    // turn the LED off by making the voltage LOW
  delay(1000);               // wait for a second
}

void processRequest(String request) {
  if(request.equals("ping")) {
    Serial.println("pong");
  }
  
  // get command first
  String command = request.substring(0, request.indexOf("/"));
  // pinmode command
  if(command.equalsIgnoreCase("pinmode")) {
    int pinNumber = request.substring(request.indexOf("/") + 1, request.lastIndexOf("/")).toInt();
    String mode = request.substring(request.lastIndexOf("/") + 1, request.length());

    if(mode.equalsIgnoreCase("out")) {
      pinMode(pinNumber, OUTPUT);
    } 
    else if(mode.equalsIgnoreCase("in")) {
      pinMode(pinNumber, INPUT);
    }
  }  

  // write command
  else if(command.equalsIgnoreCase("write")) {
    String modePinNumValue = request.substring(request.indexOf("/") + 1, request.length());
    String mode = modePinNumValue.substring(0, modePinNumValue.indexOf("/"));
    int pinNumber = modePinNumValue.substring(modePinNumValue.indexOf("/") + 1, modePinNumValue.lastIndexOf("/")).toInt();
    int value = modePinNumValue.substring(modePinNumValue.lastIndexOf("/") + 1, modePinNumValue.length()).toInt();

    if(mode.equalsIgnoreCase("digital")) {
      digitalWrite(pinNumber, value);
    } 
    else if(mode.equalsIgnoreCase("analog")) {
      // only on 3, 5, 6, 9, 10, and 11
      analogWrite(pinNumber, value);
    }
  }
  
  // pullups
  else if(command.equalsIgnoreCase("pullup")) {
    int pinNumber = request.substring(request.indexOf("/") + 1, request.lastIndexOf("/")).toInt();
    String state = request.substring(request.lastIndexOf("/") + 1, request.length());
    
    digitalWrite(pinNumber, state.equalsIgnoreCase("on") ? HIGH : LOW);
  }
  
  // read command
  else if(command.equalsIgnoreCase("read")) {
    String mode = request.substring(request.indexOf("/") + 1, request.lastIndexOf("/"));
    int pinNumber = request.substring(request.lastIndexOf("/") + 1, request.length()).toInt();
    
    if(mode.equalsIgnoreCase("digital")) {
      Serial.println(digitalRead(pinNumber));
    } 
    else if(mode.equalsIgnoreCase("analog")) {
      Serial.println(analogRead(pinNumber));
    }
  }
}

char inbyte = 0;
String request = "";

// the loop routine runs over and over again forever:
void loop() {


  while(Serial.available() > 0) {
    inbyte = Serial.read();
    if(inbyte == '\n') {
      processRequest(request);
      request = "";
      break;
    } 
    else {
      request += inbyte;
    }
  }    
}


