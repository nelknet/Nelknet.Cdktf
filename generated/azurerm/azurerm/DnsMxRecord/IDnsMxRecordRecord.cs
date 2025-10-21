using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DnsMxRecord
{
    [JsiiInterface(nativeType: typeof(IDnsMxRecordRecord), fullyQualifiedName: "azurerm.dnsMxRecord.DnsMxRecordRecord")]
    public interface IDnsMxRecordRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#exchange DnsMxRecord#exchange}.</summary>
        [JsiiProperty(name: "exchange", typeJson: "{\"primitive\":\"string\"}")]
        string Exchange
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#preference DnsMxRecord#preference}.</summary>
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}")]
        string Preference
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsMxRecordRecord), fullyQualifiedName: "azurerm.dnsMxRecord.DnsMxRecordRecord")]
        internal sealed class _Proxy : DeputyBase, azurerm.DnsMxRecord.IDnsMxRecordRecord
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#exchange DnsMxRecord#exchange}.</summary>
            [JsiiProperty(name: "exchange", typeJson: "{\"primitive\":\"string\"}")]
            public string Exchange
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dns_mx_record#preference DnsMxRecord#preference}.</summary>
            [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"string\"}")]
            public string Preference
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
