
const int s0 = 1;  
const int s1 = 2;  
const int s2 = 3;  
const int s3 = 4;  
const int out = 5; 
const int PINSensorI = A0;
const int PINSensorF = A5;
const int LEDp = 0;
const int LEDData = 12;
const int LEDResp = 8;
int LecturaSensorI = 0;
int LecturaSensorF = 0;
int color_detector = 0;   
int rojo = 0;  
int verde = 0;  
int azul = 0; 
int aux = 0;
String colores = "";
String result = "";
String pausa = "1";
 

void setup(){  
  Serial.begin(9600); 
  pinMode(PINSensorI, INPUT);
  pinMode(PINSensorF, INPUT);
  pinMode(LEDData, OUTPUT);
  pinMode(LEDResp, OUTPUT);
  pinMode(s0,OUTPUT);  
  pinMode(s1,OUTPUT);  
  pinMode(s2,OUTPUT);  
  pinMode(s3,OUTPUT);  
  pinMode(out,INPUT);   
  pinMode(LEDp, OUTPUT);
  digitalWrite(s0,HIGH);  
  digitalWrite(s1,HIGH);  
  
}  

   
void loop(){  
  
  colores = "";
  LecturaSensorI = analogRead(PINSensorI);
  LecturaSensorF = analogRead(PINSensorF);
  colores.concat(1);
   colores.concat(",");
   color();
   colores.concat(rojo);
   colores.concat(",");
   colores.concat(verde);
   colores.concat(",");
   colores.concat(azul);
   
  if (LecturaSensorI > 710 && LecturaSensorF < 250)
  {
    digitalWrite(LEDResp, HIGH);
    Serial.println(colores);
    
    ObjetoEncontrado();
  }
  
  if (LecturaSensorF >200 && LecturaSensorI <660)
  {
    aux =0;
    Serial.println(0);
    
  }
  delay(500);
  /*
  Serial.print("   ");  
  Serial.print(rojo);  
  Serial.print("   ");  
  Serial.print(verde);  
  Serial.print("   ");  
  Serial.print(azul);*/
    
  /*
  if (rojo < azul && verde > azul && rojo < 35) 
  {  
   Serial.println("   Rojo");    
  }   
  else if (azul < rojo && azul < verde && verde < rojo)  
  {  
   Serial.println("   Azul");        
  }  

  else if (rojo > verde && azul > verde )  
  {  
   Serial.println("   Verde");       
  }  
  else{
  Serial.println(" otro ");  
  }*/    
 }  
void ObjetoEncontrado()
{
  char Resp = Serial.read();
  if (Resp == "1")
  {
    digitalWrite(LEDResp, HIGH);
  }
  else
  {
    digitalWrite(LEDResp, LOW);
  }
}
void color()  
{    
  digitalWrite(s2, LOW);  
  digitalWrite(s3, LOW);  
  rojo = pulseIn(out, LOW); 
  digitalWrite(s3, HIGH);   
  azul = pulseIn(out, LOW);  
  digitalWrite(s2, HIGH);    
  verde = pulseIn(out, LOW); 
}
