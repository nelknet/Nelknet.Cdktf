using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermArcResourceBridgeAppliance
{
    [JsiiInterface(nativeType: typeof(IDataAzurermArcResourceBridgeApplianceTimeouts), fullyQualifiedName: "azurerm.dataAzurermArcResourceBridgeAppliance.DataAzurermArcResourceBridgeApplianceTimeouts")]
    public interface IDataAzurermArcResourceBridgeApplianceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_resource_bridge_appliance#read DataAzurermArcResourceBridgeAppliance#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermArcResourceBridgeApplianceTimeouts), fullyQualifiedName: "azurerm.dataAzurermArcResourceBridgeAppliance.DataAzurermArcResourceBridgeApplianceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermArcResourceBridgeAppliance.IDataAzurermArcResourceBridgeApplianceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_resource_bridge_appliance#read DataAzurermArcResourceBridgeAppliance#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
