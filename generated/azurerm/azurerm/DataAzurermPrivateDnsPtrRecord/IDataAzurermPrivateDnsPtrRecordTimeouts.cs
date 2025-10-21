using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsPtrRecord
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPrivateDnsPtrRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsPtrRecord.DataAzurermPrivateDnsPtrRecordTimeouts")]
    public interface IDataAzurermPrivateDnsPtrRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_ptr_record#read DataAzurermPrivateDnsPtrRecord#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPrivateDnsPtrRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsPtrRecord.DataAzurermPrivateDnsPtrRecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPrivateDnsPtrRecord.IDataAzurermPrivateDnsPtrRecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_ptr_record#read DataAzurermPrivateDnsPtrRecord#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
