using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectQuickConnect
{
    [JsiiInterface(nativeType: typeof(IConnectQuickConnectQuickConnectConfigUserConfig), fullyQualifiedName: "aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigUserConfig")]
    public interface IConnectQuickConnectQuickConnectConfigUserConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#contact_flow_id ConnectQuickConnect#contact_flow_id}.</summary>
        [JsiiProperty(name: "contactFlowId", typeJson: "{\"primitive\":\"string\"}")]
        string ContactFlowId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#user_id ConnectQuickConnect#user_id}.</summary>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        string UserId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectQuickConnectQuickConnectConfigUserConfig), fullyQualifiedName: "aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigUserConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfigUserConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#contact_flow_id ConnectQuickConnect#contact_flow_id}.</summary>
            [JsiiProperty(name: "contactFlowId", typeJson: "{\"primitive\":\"string\"}")]
            public string ContactFlowId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#user_id ConnectQuickConnect#user_id}.</summary>
            [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
