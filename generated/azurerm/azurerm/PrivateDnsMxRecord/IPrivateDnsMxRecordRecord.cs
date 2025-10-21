using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PrivateDnsMxRecord
{
    [JsiiInterface(nativeType: typeof(IPrivateDnsMxRecordRecord), fullyQualifiedName: "azurerm.privateDnsMxRecord.PrivateDnsMxRecordRecord")]
    public interface IPrivateDnsMxRecordRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#exchange PrivateDnsMxRecord#exchange}.</summary>
        [JsiiProperty(name: "exchange", typeJson: "{\"primitive\":\"string\"}")]
        string Exchange
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#preference PrivateDnsMxRecord#preference}.</summary>
        [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"number\"}")]
        double Preference
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrivateDnsMxRecordRecord), fullyQualifiedName: "azurerm.privateDnsMxRecord.PrivateDnsMxRecordRecord")]
        internal sealed class _Proxy : DeputyBase, azurerm.PrivateDnsMxRecord.IPrivateDnsMxRecordRecord
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#exchange PrivateDnsMxRecord#exchange}.</summary>
            [JsiiProperty(name: "exchange", typeJson: "{\"primitive\":\"string\"}")]
            public string Exchange
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_mx_record#preference PrivateDnsMxRecord#preference}.</summary>
            [JsiiProperty(name: "preference", typeJson: "{\"primitive\":\"number\"}")]
            public double Preference
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
