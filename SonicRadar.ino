#include <Servo.h>

#define SONIC_TRIG 6
#define SONIC_ECHO 7
#define SERVO_CTRL 9
#define SWITCH 8

Servo myservo;  // create servo object to control a servo

void setup()
{
    pinMode(13, OUTPUT);
    pinMode(SONIC_TRIG, OUTPUT);
    pinMode(SONIC_ECHO, INPUT);
    pinMode(SWITCH, INPUT_PULLUP);
    myservo.attach(SERVO_CTRL);
    myservo.writeMicroseconds(1460);
    Serial.begin(9600);
}

double distance(){
    digitalWrite(SONIC_TRIG, HIGH);
    delayMicroseconds(20);
    digitalWrite(SONIC_TRIG, LOW);

    unsigned long start = micros();
    int interval = pulseIn(SONIC_ECHO, HIGH, 25000);

    unsigned long wait = 30000 - (micros() - start);

    for (int i = 0; i < wait / 16000; i++)
    {
        delayMicroseconds(16000);
    }
    delayMicroseconds(wait % 16000);

    double distance = interval * 0.017;  // cm

    // Serial.print( interval, DEC );
    // Serial.print( "\t" );
    return distance;
}

void loop()
{
    Serial.println("R");
    myservo.writeMicroseconds(1382);
    delay(200);
    while(true){
        Serial.println(distance(), 4);
        if (digitalRead(SWITCH) == LOW){
            break;
        }
    }
    Serial.println("L");
    myservo.writeMicroseconds(1546);
    delay(200);
    while(true){
        Serial.println(distance(), 4);
        if (digitalRead(SWITCH) == LOW){
            break;
        }
    }
}

