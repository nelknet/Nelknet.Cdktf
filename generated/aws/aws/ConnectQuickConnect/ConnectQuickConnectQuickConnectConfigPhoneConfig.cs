using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectQuickConnect
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigPhoneConfig")]
    public class ConnectQuickConnectQuickConnectConfigPhoneConfig : aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfigPhoneConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#phone_number ConnectQuickConnect#phone_number}.</summary>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public string PhoneNumber
        {
            get;
            set;
        }
    }
}
