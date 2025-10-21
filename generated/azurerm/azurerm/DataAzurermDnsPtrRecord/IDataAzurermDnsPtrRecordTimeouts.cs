using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsPtrRecord
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDnsPtrRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsPtrRecord.DataAzurermDnsPtrRecordTimeouts")]
    public interface IDataAzurermDnsPtrRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ptr_record#read DataAzurermDnsPtrRecord#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDnsPtrRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsPtrRecord.DataAzurermDnsPtrRecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDnsPtrRecord.IDataAzurermDnsPtrRecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_ptr_record#read DataAzurermDnsPtrRecord#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
