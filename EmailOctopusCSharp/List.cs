using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EmailOctopusCSharp
{
    public class List
    {
        public string Id { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("double_opt_in")] public bool DoubleOptIn { get; set; }
        public List<Field> Fields { get; set; }
        public Counts Counts { get; set; }
    }
}