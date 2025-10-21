using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRouteFilter
{
    [JsiiByValue(fqn: "azurerm.dataAzurermRouteFilter.DataAzurermRouteFilterTimeouts")]
    public class DataAzurermRouteFilterTimeouts : azurerm.DataAzurermRouteFilter.IDataAzurermRouteFilterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/route_filter#read DataAzurermRouteFilter#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
