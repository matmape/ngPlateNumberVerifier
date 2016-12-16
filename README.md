# ngPlateNumberVerifier
this is a Nigerian Plate Number verification library

<p>Add reference to the PlateVerifier class</p>

Usage - <br/>
<code>
var plateNumber = "FST918EG";
</code>
<code>
var plateInfo = NgPlateVerifier.Verifier.GetPlateInfo(plateNumber);
</code>
<br/>
//returns a customized class container the plate info 
<br/>
You can get some information like chassis number . For example
<br/>
<code>Console.WriteLine(plateInfo.Chassis);
</code>
 

