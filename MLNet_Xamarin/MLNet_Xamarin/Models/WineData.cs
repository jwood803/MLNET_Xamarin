using System.Text.Json.Serialization;

namespace MLNet_Xamarin.Models
{
    public class WineData
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("fixedacidity")]
        public float FixedAcidity { get; set; }
        [JsonPropertyName("volatileacidity")]
        public float VolatileAcidity { get; set; }
        [JsonPropertyName("citricacid")]
        public float CitricAcid { get; set; }
        [JsonPropertyName("residualsugar")]
        public float ResidualSugar { get; set; }
        [JsonPropertyName("chlorides")]
        public float Chlorides { get; set; }
        [JsonPropertyName("freesulfurdioxide")]
        public float FreeSulfurDioxide { get; set; }
        [JsonPropertyName("totalsulfurdioxide")]
        public float TotalSulfurDioxide { get; set; }
        [JsonPropertyName("density")]
        public float Density { get; set; }
        [JsonPropertyName("ph")]
        public float Ph { get; set; }
        [JsonPropertyName("sulphates")]
        public float Sulphates { get; set; }
        [JsonPropertyName("alcohol")]
        public float Alcohol { get; set; }

        [JsonIgnore]
        public float Quality { get; set; }
    }
}
