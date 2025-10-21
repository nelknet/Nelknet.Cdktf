using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRouteTable
{
    [JsiiByValue(fqn: "azurerm.dataAzurermRouteTable.DataAzurermRouteTableTimeouts")]
    public class DataAzurermRouteTableTimeouts : azurerm.DataAzurermRouteTable.IDataAzurermRouteTableTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_table#read DataAzurermRouteTable#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
