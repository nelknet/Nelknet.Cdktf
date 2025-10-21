using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsSrvRecord
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDnsSrvRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsSrvRecord.DataAzurermDnsSrvRecordTimeouts")]
    public interface IDataAzurermDnsSrvRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_srv_record#read DataAzurermDnsSrvRecord#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDnsSrvRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsSrvRecord.DataAzurermDnsSrvRecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDnsSrvRecord.IDataAzurermDnsSrvRecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_srv_record#read DataAzurermDnsSrvRecord#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
