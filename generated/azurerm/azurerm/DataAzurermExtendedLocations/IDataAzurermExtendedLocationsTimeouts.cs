using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermExtendedLocations
{
    [JsiiInterface(nativeType: typeof(IDataAzurermExtendedLocationsTimeouts), fullyQualifiedName: "azurerm.dataAzurermExtendedLocations.DataAzurermExtendedLocationsTimeouts")]
    public interface IDataAzurermExtendedLocationsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/extended_locations#read DataAzurermExtendedLocations#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermExtendedLocationsTimeouts), fullyQualifiedName: "azurerm.dataAzurermExtendedLocations.DataAzurermExtendedLocationsTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermExtendedLocations.IDataAzurermExtendedLocationsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/extended_locations#read DataAzurermExtendedLocations#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
