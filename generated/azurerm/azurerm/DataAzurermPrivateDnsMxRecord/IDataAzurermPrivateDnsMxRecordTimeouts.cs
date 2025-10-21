using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsMxRecord
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPrivateDnsMxRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsMxRecord.DataAzurermPrivateDnsMxRecordTimeouts")]
    public interface IDataAzurermPrivateDnsMxRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_mx_record#read DataAzurermPrivateDnsMxRecord#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPrivateDnsMxRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsMxRecord.DataAzurermPrivateDnsMxRecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPrivateDnsMxRecord.IDataAzurermPrivateDnsMxRecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_mx_record#read DataAzurermPrivateDnsMxRecord#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
