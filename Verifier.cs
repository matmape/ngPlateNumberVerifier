using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NgPlateVerifier
{
    /// <summary>
    /// Contains the underlying method that provides the plate number info.
    /// </summary>
    public class Verifier
    {
        private static readonly string _baseurl = "https://mvrd.herokuapp.com/api/plates/";
        /// <summary>
        /// Gets the plate number info
        /// </summary>
        /// <param name="plateNumber">The Plate Number.</param>
        /// <returns>A class representing the plate info data</returns>
        public static PlateInfo GetPlateInfo(string plateNumber)
        {
            return JsonConvert.DeserializeObject<PlateInfo>(PlateWebRequest.GetResponse(_baseurl+plateNumber));
        }
    }
}
