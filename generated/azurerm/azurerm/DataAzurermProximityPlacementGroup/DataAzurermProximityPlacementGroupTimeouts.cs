using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermProximityPlacementGroup
{
    [JsiiByValue(fqn: "azurerm.dataAzurermProximityPlacementGroup.DataAzurermProximityPlacementGroupTimeouts")]
    public class DataAzurermProximityPlacementGroupTimeouts : azurerm.DataAzurermProximityPlacementGroup.IDataAzurermProximityPlacementGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/proximity_placement_group#read DataAzurermProximityPlacementGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
