# ngPlateNumberVerifier
this is a Nigerian Plate Number verification library

<p>Add reference to the PlateVerifier class</p>

Usage - 
<code>
var plateNumber = "FST918EG";
var plateInfo = NgPlateVerifier.Verifier.GetPlateInfo(plateNumber);
</code>
//returns a customized class container the plate info 
You can get some information like chassis number 

e.g 
<code>Console.WriteLine(plateInfo.Chassis);
</code>
 

