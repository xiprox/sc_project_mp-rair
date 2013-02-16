#include <Servo.h> 
//#include <SoftwareSerial.h>
#include <TinyGPS.h>




Servo L1;
Servo L2;
Servo L3;

Servo R1;
Servo R2;
Servo R3;
Servo CAM;

  int L1restpos = 96;
  int L2restpos = 95;
  int L3restpos = 87;
  
  int R1restpos = 93;
  int R2restpos = 92;
  int R3restpos = 93;
  
TinyGPS gpss;

  int temps = 0;
  int temp;  
  
  int mdetect;
  
  int gpsspeed;
  int gpscoord;
  //String[] Coords = ;
  
  void setup()  
{
  Serial.begin(9600);
  Serial1.begin(9600);
  //GPS.begin(9600);
 


  L2.attach(4);
  L3.attach(6);  

  R1.attach(3);
  R2.attach(5);
  R3.attach(7);  
  

  CAM.attach(24);  

 
}

void loop()
{

 
  
//READ AND SEND TEMPERATURE DATA TO COMPUTER  
temp = analogRead(temps);        
temp = (5.0 * temp * 100.0)/1024.0;
//Serial.println();
//Serial.println("$temp$" + temp);
 //Serial.println((byte)temp);   


//READ FROM GPS
gpsspeed = gpss.f_speed_kmph();
//Serial.write("speed%" + gpsspeed);

 
//METAL DETECTION
mdetect = analogRead(1);

if(mdetect>1000)
{
 
  //gpscoord = GPS.read();
//exapmple coord 43.817297,18.301398
  
//  coords = 
Serial.println("$Mine detected at 43.817297,18.301398");
 // Serial.println("Mine Detected!");
//  Serial.print(GPS.read()); 
  
}


//CONNECTION TEST FROM PC
char serialtest;
serialtest = Serial.read();
if(serialtest == '0')
{
  digitalWrite(12, HIGH);
  delay(1000);
  digitalWrite(12, LOW);
}
      digitalWrite(13, HIGH);

//IR LEDS
char serialir;
serialir = Serial.read();
if(serialir=='i')
{
  

}

//MOTOR CONTROL

/*MOTOR CHARS: 

FORWARD = 'W'
FORWARD FULLPOWER = 'U'
BACKWARD = 'S'
BACKWARD FULLPOWER = 'J'
LEFT = 'A'
LEFT FULLPOWER = 'H'
RIGHT  = 'D'
RIGHT FULLPOWER = 'K'

FORWARD + LEFT = 'Q'
FORWARD + RIGHT = 'E'

BACKWARD + LEFT = 'Z'
BACKWARD + RIGHT = 'C'

*/
char serialmotor;
serialmotor = Serial1.read();

//FORWARD
//Serial.println("FORWARD " + Serial.read());
if(serialmotor == 'U'){

  L1.write(45);
  L2.write(45);
  L3.write(45);
  R1.write(135);
  R2.write(135);
  R3.write(135);

}
//FORWARD FULLPOWER
if(serialmotor == 'b'){
  L1.write(0);
  L2.write(0);
  L3.write(0);
  R1.write(180);
  R2.write(180);
  R3.write(180);
}
//BACKWARD
if(serialmotor == 'D'){
  L1.write(135);
  L2.write(135);
  L3.write(135);
  R1.write(45);
  R2.write(45);
  R3.write(45);
}
//BACKWARD FULLPOWER
if(serialmotor == 'c'){
  L1.write(180);
  L2.write(180);
  L3.write(180);
  R1.write(0);
  R2.write(0);
  R3.write(0);
}

//LEFT FULLPOWER
if(serialmotor == 'L'){
  L1.write(180);
  L2.write(180);
  L3.write(180);
  R1.write(180);
  R2.write(180);
  R3.write(180);
}

//RIGHT FULLPOWER
if(serialmotor == 'R'){
  L1.write(0);
  L2.write(0);
  L3.write(0);
  R1.write(0);
  R2.write(0);
  R3.write(0);
}
//FORWARD + LEFT
if(serialmotor == 'a'){
  L1.write(45);
  L2.write(45);
  L3.write(45);
  R1.write(180);
  R2.write(180);
  R3.write(180);
}
//FORWARD + RIGHT
if(serialmotor == 'e'){
  L1.write(0);
  L2.write(0);
  L3.write(0);
  R1.write(135);
  R2.write(135);
  R3.write(135);
}
//BACKWARD + LEFT
if(serialmotor == 'd'){
  L1.write(135);
  L2.write(135);
  L3.write(135);
  R1.write(0);
  R2.write(0);
  R3.write(0);
}
//BACKWARD + RIGHT
if(serialmotor == 'h'){
  L1.write(180);
  L2.write(180);
  L3.write(180);
  R1.write(45);
  R2.write(45);
  R3.write(45);
}
//STOP
if(serialmotor == 'C'){
  L1.write(L1restpos);
  L2.write(L2restpos);
  L3.write(L3restpos);
  R1.write(R1restpos);
  R2.write(R2restpos);
  R3.write(R3restpos);
}




}
