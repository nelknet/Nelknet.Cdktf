using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectQuickConnect
{
    [JsiiInterface(nativeType: typeof(IConnectQuickConnectQuickConnectConfigPhoneConfig), fullyQualifiedName: "aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigPhoneConfig")]
    public interface IConnectQuickConnectQuickConnectConfigPhoneConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#phone_number ConnectQuickConnect#phone_number}.</summary>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        string PhoneNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectQuickConnectQuickConnectConfigPhoneConfig), fullyQualifiedName: "aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigPhoneConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfigPhoneConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#phone_number ConnectQuickConnect#phone_number}.</summary>
            [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string PhoneNumber
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
