#pragma strict


function GuiStart() {
   if(Time.time >= 20) // If more than 20 seconds has elapsed  
     GUI.TextArea(new Rect(10,10,100,100), "20 seconds has elapsed");
 }



