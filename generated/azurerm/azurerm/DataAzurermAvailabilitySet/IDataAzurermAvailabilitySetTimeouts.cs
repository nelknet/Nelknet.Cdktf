using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAvailabilitySet
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAvailabilitySetTimeouts), fullyQualifiedName: "azurerm.dataAzurermAvailabilitySet.DataAzurermAvailabilitySetTimeouts")]
    public interface IDataAzurermAvailabilitySetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/availability_set#read DataAzurermAvailabilitySet#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAvailabilitySetTimeouts), fullyQualifiedName: "azurerm.dataAzurermAvailabilitySet.DataAzurermAvailabilitySetTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAvailabilitySet.IDataAzurermAvailabilitySetTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/availability_set#read DataAzurermAvailabilitySet#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
