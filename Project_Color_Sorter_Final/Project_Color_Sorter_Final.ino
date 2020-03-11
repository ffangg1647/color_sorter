#include <Wire.h>
#include "Adafruit_TCS34725.h"
#include <Servo.h>
Servo myservo;
Servo myservo2;

const int btnPin = 7;
int btnState = 0;
int systemstatus = 0;

int redPin = 10; // Red LED, connected to digital pin 9
int greenPin = 11; // Green LED, connected to digital pin 10
int bluePin = 12; // Blue LED, connected to digital pin 11

Adafruit_TCS34725 tcs = Adafruit_TCS34725(TCS34725_INTEGRATIONTIME_700MS, TCS34725_GAIN_1X);

void setup() {
  pinMode(btnPin,INPUT); 
  Serial.begin(9600);
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);
  myservo.attach(8); //กำหนดขา Servo ตัวเช็คสี
  myservo2.attach(9); //กำหนดขา Servo ตัวปล่อยขนม
  setColor(0, 0, 0);
}
void loop() {
  btnState = digitalRead(btnPin);
  delay(200);
  
  if(btnState == 1){ //เมื่อกดปุ่ม button
      systemstatus = 1;
      if(tcs.begin()){
        myservo2.write(90); //สั่งให้ servo ตัวปล่อยขนม หมุน 90 องศา เพื่อเตรียมพร้อม 
        myservo.write(180); //สั่งให้ servo ตัวเช็คสี หมุน 180 องศา เพื่อไปรับเม็ดขนม
        delay(1000);
        myservo.write(88); //สั่งให้ servo หมุน 88 องศา ไปเช็คค่าสีเม็ดขนม
        delay(1000);
      }else{
        while (1);
      }
  }

  while(systemstatus == 1){
    
    uint16_t r, g, b, c, colorTemp, lux;
    tcs.getRawData(&r, &g, &b, &c);
    delay(2000);
    if(r <= 1410 && r >=736 && g <=1030 && g >=300 && b<=920 && b>=235){ //ค่าสีแดง
    Serial.println("red");
    setColor(255, 0, 0); //แสดงค่าสีแดงบน LED RGB
    myservo2.write(35);
    delay(1000);
    myservo.write(25);
    delay(1000);
    myservo.write(180);
    delay(1000);
    myservo.write(88);
    delay(1000);
  }else if(r<=3460 && r>=1820 && g<=1700 &&g>=680 && b<=945 && b>=350){ //ค่าสีส้ม
    Serial.println("orange");
    setColor(255, 60, 0); //แสดงค่าสีส้มบน LED RGB
    myservo2.write(59);
    delay(1000);
    myservo.write(25);
    delay(1000);
    myservo.write(180);
    delay(1000);
    myservo.write(88);
    delay(1000);
  }else if(r<=4700 && r>=2740 && g<=6040 && g>=3150 &&b<=1870 && b>=840){ //ค่าสีเหลือง
    Serial.println("yellow"); 
    setColor(200, 80, 0); //แสดงค่าสีเหลืองบน LED RGB
    myservo2.write(83);
    delay(1000);
    myservo.write(25);
    delay(1000);
    myservo.write(180);
    delay(1000);
    myservo.write(88);
    delay(1000);
  }else if(r<=1960 && r>=990 && g<=4275 && g>=2370 && b<=2040 && b>=945) //ค่าสีเขียว
  {
    Serial.println("green");
    setColor(0, 255, 0); //แสดงค่าสีเขียวบน LED RGB
    myservo2.write(107);
    delay(1000);
    myservo.write(25);
    delay(1000);
    myservo.write(180);
    delay(1000);
    myservo.write(88);
    delay(1000);
  }else if(r<=800 && r>=240 && g<=2760 && g>=1095  && b<=3635 && b>=1730){ //ค่าสีฟ้า
    Serial.println("blue");
    setColor(0, 0, 255); //แสดงค่าสีฟ้าบน LED RGB
    myservo2.write(131);
    delay(1000);
    myservo.write(25);
    delay(1000);
    myservo.write(180);
    delay(1000);
    myservo.write(88);
    delay(1000);
  }else if(r<=810 && r>=270 && g<=920 && g>=260 && b<= 690 && b>=195){ //ค่าสีน้ำตาล
    Serial.println("brown");
    setColor(165, 45, 42); //แสดงค่าสีน้ำตาลบน LED RGB
    myservo2.write(155);
    delay(1000);
    myservo.write(25);
    delay(1000);
    myservo.write(180);
    delay(1000);
    myservo.write(88);
    delay(1000);
  }else{
    setColor(0, 0, 0);
  }
  
  //Serial.println(" ");
  }
  
  
}
void setColor(int red, int green, int blue)
{
  analogWrite(redPin, 255-red);
  analogWrite(greenPin, 255-green);
  analogWrite(bluePin, 255-blue);  
}
