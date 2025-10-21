using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermExpressRouteCircuit
{
    [JsiiInterface(nativeType: typeof(IDataAzurermExpressRouteCircuitTimeouts), fullyQualifiedName: "azurerm.dataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitTimeouts")]
    public interface IDataAzurermExpressRouteCircuitTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit#read DataAzurermExpressRouteCircuit#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermExpressRouteCircuitTimeouts), fullyQualifiedName: "azurerm.dataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermExpressRouteCircuit.IDataAzurermExpressRouteCircuitTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/express_route_circuit#read DataAzurermExpressRouteCircuit#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
