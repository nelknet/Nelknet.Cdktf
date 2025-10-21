using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectQuickConnect
{
    [JsiiInterface(nativeType: typeof(IConnectQuickConnectQuickConnectConfigQueueConfig), fullyQualifiedName: "aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigQueueConfig")]
    public interface IConnectQuickConnectQuickConnectConfigQueueConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#contact_flow_id ConnectQuickConnect#contact_flow_id}.</summary>
        [JsiiProperty(name: "contactFlowId", typeJson: "{\"primitive\":\"string\"}")]
        string ContactFlowId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#queue_id ConnectQuickConnect#queue_id}.</summary>
        [JsiiProperty(name: "queueId", typeJson: "{\"primitive\":\"string\"}")]
        string QueueId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectQuickConnectQuickConnectConfigQueueConfig), fullyQualifiedName: "aws.connectQuickConnect.ConnectQuickConnectQuickConnectConfigQueueConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectQuickConnect.IConnectQuickConnectQuickConnectConfigQueueConfig
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_quick_connect#queue_id ConnectQuickConnect#queue_id}.</summary>
            [JsiiProperty(name: "queueId", typeJson: "{\"primitive\":\"string\"}")]
            public string QueueId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
