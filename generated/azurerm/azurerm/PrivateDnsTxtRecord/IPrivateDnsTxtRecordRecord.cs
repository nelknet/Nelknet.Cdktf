using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PrivateDnsTxtRecord
{
    [JsiiInterface(nativeType: typeof(IPrivateDnsTxtRecordRecord), fullyQualifiedName: "azurerm.privateDnsTxtRecord.PrivateDnsTxtRecordRecord")]
    public interface IPrivateDnsTxtRecordRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_txt_record#value PrivateDnsTxtRecord#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrivateDnsTxtRecordRecord), fullyQualifiedName: "azurerm.privateDnsTxtRecord.PrivateDnsTxtRecordRecord")]
        internal sealed class _Proxy : DeputyBase, azurerm.PrivateDnsTxtRecord.IPrivateDnsTxtRecordRecord
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_dns_txt_record#value PrivateDnsTxtRecord#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
