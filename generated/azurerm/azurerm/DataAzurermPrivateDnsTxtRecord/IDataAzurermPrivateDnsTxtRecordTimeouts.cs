using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsTxtRecord
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPrivateDnsTxtRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsTxtRecord.DataAzurermPrivateDnsTxtRecordTimeouts")]
    public interface IDataAzurermPrivateDnsTxtRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_txt_record#read DataAzurermPrivateDnsTxtRecord#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPrivateDnsTxtRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsTxtRecord.DataAzurermPrivateDnsTxtRecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPrivateDnsTxtRecord.IDataAzurermPrivateDnsTxtRecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_txt_record#read DataAzurermPrivateDnsTxtRecord#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
