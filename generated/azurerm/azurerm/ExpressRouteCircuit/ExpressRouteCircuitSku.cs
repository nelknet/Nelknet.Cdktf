using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRouteCircuit
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.expressRouteCircuit.ExpressRouteCircuitSku")]
    public class ExpressRouteCircuitSku : azurerm.ExpressRouteCircuit.IExpressRouteCircuitSku
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#family ExpressRouteCircuit#family}.</summary>
        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}")]
        public string Family
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#tier ExpressRouteCircuit#tier}.</summary>
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
        public string Tier
        {
            get;
            set;
        }
    }
}
