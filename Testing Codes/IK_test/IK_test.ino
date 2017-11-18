#include <Servo.h>

#define c0 40
#define f0 42
#define t0 44


double Fix_Angle(double x){
  if(x<-1) return -1;
  if(x>1) return 1;
  return x;
  
}
const double Femur_Length= 92.852  ;
const double Tibia_Length= 164.695;
const double Coxa_Length= 23;
double Leg_Length;
Servo C0;
Servo F0;
Servo T0;

double adjust(double x){

  if(x>180){
    return 360-x;
  }
  return x;
}


double todeg(double rad){

  double ret = rad*180/PI;

  return ret;
}
void ik (double x, double y, double z){
  double coxa_angle;
  double femur_angle;
  double tibia_angle;
  double l1= sqrt(x*x+y*y);
  double l=sqrt(z*z+ (l1-Coxa_Length)*(l1-Coxa_Length));
  double t=Tibia_Length;
  double f=Femur_Length;
  
  coxa_angle=atan(x*100/(y*100));

  femur_angle= acos(Fix_Angle(z/l))+acos( Fix_Angle( (f*f+l*l-t*t)/(2*f*l)));

  tibia_angle= acos (Fix_Angle((f*f-l*l+t*t)/(2*f*t)));
  Serial.print(adjust(todeg(coxa_angle)+90));
  Serial.print("\t");
  Serial.print(adjust(todeg(femur_angle)));
  Serial.print("\t");
  Serial.print(todeg(tibia_angle));
  Serial.print("\t\t");
  Serial.print(x);
  Serial.print("\t");
  Serial.print(y);
  Serial.print("\t");
  Serial.print(z);
  Serial.print("\n");
  C0.write(adjust(todeg(coxa_angle)+90));
  F0.write(adjust(todeg(femur_angle)));
  T0.write(adjust(todeg(tibia_angle)));
}



void setup(){
  C0.attach(c0);
  F0.attach(f0);
  T0.attach(t0);
  Serial.begin(9600);
}



void loop(){
/*
for(int i=-50; i<50; i++){
  ik(i,140,2*i+50);
  delay(50);
 
}

for(int i=50; i>-50; i--){
  ik(i,140,2*i+50);
  delay(50);
 
}
delay(20);
*/
  for(int i=0; i<360; i++){ //draw a circle
    ik(40*cos(radians(i))+100,40*sin(radians(i))+100,100);
    if(i == 359) i = 0;
    delay(50);
  }
}

