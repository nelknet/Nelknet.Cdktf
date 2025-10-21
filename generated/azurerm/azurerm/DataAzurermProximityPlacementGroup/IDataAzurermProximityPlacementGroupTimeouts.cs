using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermProximityPlacementGroup
{
    [JsiiInterface(nativeType: typeof(IDataAzurermProximityPlacementGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermProximityPlacementGroup.DataAzurermProximityPlacementGroupTimeouts")]
    public interface IDataAzurermProximityPlacementGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/proximity_placement_group#read DataAzurermProximityPlacementGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermProximityPlacementGroupTimeouts), fullyQualifiedName: "azurerm.dataAzurermProximityPlacementGroup.DataAzurermProximityPlacementGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermProximityPlacementGroup.IDataAzurermProximityPlacementGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/proximity_placement_group#read DataAzurermProximityPlacementGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
