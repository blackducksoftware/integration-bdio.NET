﻿using Newtonsoft.Json;
namespace Com.Blackducksoftware.Integration.Hub.Bdio.Simple.Model
{
    public class BdioBillOfMaterials : BdioNode
    {
        [JsonProperty(PropertyName = "specVersion")]
        public string BdioSpecificationVersion { get; set; }

        [JsonProperty(PropertyName = "spdx:name")]
        public string SpdxName { get; set; }

        public BdioBillOfMaterials()
        {
            Type = "BillOfMaterials";
        }

        public override bool Equals(object obj)
        {
            var other = obj as BdioBillOfMaterials;
            if (other == null)
                return false;
            return BdioSpecificationVersion == other.BdioSpecificationVersion && base.Equals(obj);
        }

        public override int GetHashCode()
        {
            int result = 31;
            result = 31 * result + BdioSpecificationVersion.GetHashCode();
            return result;
        }
    }
}