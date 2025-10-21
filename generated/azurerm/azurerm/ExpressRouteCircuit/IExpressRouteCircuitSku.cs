using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRouteCircuit
{
    [JsiiInterface(nativeType: typeof(IExpressRouteCircuitSku), fullyQualifiedName: "azurerm.expressRouteCircuit.ExpressRouteCircuitSku")]
    public interface IExpressRouteCircuitSku
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#family ExpressRouteCircuit#family}.</summary>
        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}")]
        string Family
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#tier ExpressRouteCircuit#tier}.</summary>
        [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
        string Tier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IExpressRouteCircuitSku), fullyQualifiedName: "azurerm.expressRouteCircuit.ExpressRouteCircuitSku")]
        internal sealed class _Proxy : DeputyBase, azurerm.ExpressRouteCircuit.IExpressRouteCircuitSku
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#family ExpressRouteCircuit#family}.</summary>
            [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}")]
            public string Family
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_circuit#tier ExpressRouteCircuit#tier}.</summary>
            [JsiiProperty(name: "tier", typeJson: "{\"primitive\":\"string\"}")]
            public string Tier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
