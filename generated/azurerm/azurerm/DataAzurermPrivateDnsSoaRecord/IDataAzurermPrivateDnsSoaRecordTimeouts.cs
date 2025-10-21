using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsSoaRecord
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPrivateDnsSoaRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsSoaRecord.DataAzurermPrivateDnsSoaRecordTimeouts")]
    public interface IDataAzurermPrivateDnsSoaRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_soa_record#read DataAzurermPrivateDnsSoaRecord#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPrivateDnsSoaRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsSoaRecord.DataAzurermPrivateDnsSoaRecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPrivateDnsSoaRecord.IDataAzurermPrivateDnsSoaRecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_soa_record#read DataAzurermPrivateDnsSoaRecord#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
