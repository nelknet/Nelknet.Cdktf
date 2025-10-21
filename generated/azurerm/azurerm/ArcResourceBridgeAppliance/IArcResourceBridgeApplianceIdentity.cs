using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcResourceBridgeAppliance
{
    [JsiiInterface(nativeType: typeof(IArcResourceBridgeApplianceIdentity), fullyQualifiedName: "azurerm.arcResourceBridgeAppliance.ArcResourceBridgeApplianceIdentity")]
    public interface IArcResourceBridgeApplianceIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#type ArcResourceBridgeAppliance#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcResourceBridgeApplianceIdentity), fullyQualifiedName: "azurerm.arcResourceBridgeAppliance.ArcResourceBridgeApplianceIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.ArcResourceBridgeAppliance.IArcResourceBridgeApplianceIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_resource_bridge_appliance#type ArcResourceBridgeAppliance#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
