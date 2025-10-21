using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsARecord
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDnsARecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsARecord.DataAzurermDnsARecordTimeouts")]
    public interface IDataAzurermDnsARecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_a_record#read DataAzurermDnsARecord#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDnsARecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsARecord.DataAzurermDnsARecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDnsARecord.IDataAzurermDnsARecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_a_record#read DataAzurermDnsARecord#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
