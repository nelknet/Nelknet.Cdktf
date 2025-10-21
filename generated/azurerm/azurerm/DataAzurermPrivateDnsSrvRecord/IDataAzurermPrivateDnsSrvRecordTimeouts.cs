using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsSrvRecord
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPrivateDnsSrvRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsSrvRecord.DataAzurermPrivateDnsSrvRecordTimeouts")]
    public interface IDataAzurermPrivateDnsSrvRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_srv_record#read DataAzurermPrivateDnsSrvRecord#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPrivateDnsSrvRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsSrvRecord.DataAzurermPrivateDnsSrvRecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPrivateDnsSrvRecord.IDataAzurermPrivateDnsSrvRecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_srv_record#read DataAzurermPrivateDnsSrvRecord#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
