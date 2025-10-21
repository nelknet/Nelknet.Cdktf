using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsTxtRecord
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDnsTxtRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsTxtRecord.DataAzurermDnsTxtRecordTimeouts")]
    public interface IDataAzurermDnsTxtRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_txt_record#read DataAzurermDnsTxtRecord#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDnsTxtRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsTxtRecord.DataAzurermDnsTxtRecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDnsTxtRecord.IDataAzurermDnsTxtRecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_txt_record#read DataAzurermDnsTxtRecord#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
