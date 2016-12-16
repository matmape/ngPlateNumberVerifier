# ngPlateNumberVerifier
this is a Nigerian Plate Number verification library

<p>Add reference to the PlateVerifier class</p>

## Usage 
<code>
var plateNumber = "FST918EG";
</code>
<br/>
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
<br/>
## Contributing

Please feel free to fork this package and contribute by submitting a pull request to enhance the functionalities.

## How can I thank you?

share the link for this repository on Twitter or other social platforms? Spread the word!

Don't forget to [follow me on twitter](https://twitter.com/matmape)!

Thanks!
<br/>
Matthew Idowu

## License

The MIT License (MIT). Please see [License File](LICENSE.md) for more information.

