# ngPlateNumberVerifier
this is a Nigerian Plate Number verification library

<p>Add reference to the PlateVerifier class</p>

Usage - 

var plateNumber = "FST918EG";
var plateInfo = NgPlateVerifier.Verifier.GetPlateInfo(plateNumber);
//returns a customized class container the plate info 
You can get some information like chassis number 

e.g Console.WriteLine(plateInfo.Chassis);
 

