using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsZone
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDnsZoneTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsZone.DataAzurermDnsZoneTimeouts")]
    public interface IDataAzurermDnsZoneTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_zone#read DataAzurermDnsZone#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDnsZoneTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsZone.DataAzurermDnsZoneTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDnsZone.IDataAzurermDnsZoneTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_zone#read DataAzurermDnsZone#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
