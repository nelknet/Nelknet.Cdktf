using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsAaaaRecord
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDnsAaaaRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsAaaaRecord.DataAzurermDnsAaaaRecordTimeouts")]
    public interface IDataAzurermDnsAaaaRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_aaaa_record#read DataAzurermDnsAaaaRecord#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDnsAaaaRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsAaaaRecord.DataAzurermDnsAaaaRecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDnsAaaaRecord.IDataAzurermDnsAaaaRecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_aaaa_record#read DataAzurermDnsAaaaRecord#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
