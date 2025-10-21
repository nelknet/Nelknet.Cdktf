using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectQuickConnect
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigUserConfig")]
    public class ConnectQuickConnectQuickConnectConfigUserConfig : aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfigUserConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#contact_flow_id ConnectQuickConnect#contact_flow_id}.</summary>
        [JsiiProperty(name: "contactFlowId", typeJson: "{\"primitive\":\"string\"}")]
        public string ContactFlowId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#user_id ConnectQuickConnect#user_id}.</summary>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public string UserId
        {
            get;
            set;
        }
    }
}
