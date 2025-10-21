using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDnsCaaRecord
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDnsCaaRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsCaaRecord.DataAzurermDnsCaaRecordTimeouts")]
    public interface IDataAzurermDnsCaaRecordTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_caa_record#read DataAzurermDnsCaaRecord#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDnsCaaRecordTimeouts), fullyQualifiedName: "azurerm.dataAzurermDnsCaaRecord.DataAzurermDnsCaaRecordTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDnsCaaRecord.IDataAzurermDnsCaaRecordTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/dns_caa_record#read DataAzurermDnsCaaRecord#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
