using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermExpressRouteCircuit
{
    [JsiiByValue(fqn: "azurerm.dataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitTimeouts")]
    public class DataAzurermExpressRouteCircuitTimeouts : azurerm.DataAzurermExpressRouteCircuit.IDataAzurermExpressRouteCircuitTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit#read DataAzurermExpressRouteCircuit#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
