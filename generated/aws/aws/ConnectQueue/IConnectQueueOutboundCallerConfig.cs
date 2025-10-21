using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectQueue
{
    [JsiiInterface(nativeType: typeof(IConnectQueueOutboundCallerConfig), fullyQualifiedName: "aws.connectQueue.ConnectQueueOutboundCallerConfig")]
    public interface IConnectQueueOutboundCallerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#outbound_caller_id_name ConnectQueue#outbound_caller_id_name}.</summary>
        [JsiiProperty(name: "outboundCallerIdName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutboundCallerIdName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#outbound_caller_id_number_id ConnectQueue#outbound_caller_id_number_id}.</summary>
        [JsiiProperty(name: "outboundCallerIdNumberId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutboundCallerIdNumberId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#outbound_flow_id ConnectQueue#outbound_flow_id}.</summary>
        [JsiiProperty(name: "outboundFlowId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutboundFlowId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectQueueOutboundCallerConfig), fullyQualifiedName: "aws.connectQueue.ConnectQueueOutboundCallerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectQueue.IConnectQueueOutboundCallerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#outbound_caller_id_name ConnectQueue#outbound_caller_id_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outboundCallerIdName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutboundCallerIdName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#outbound_caller_id_number_id ConnectQueue#outbound_caller_id_number_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outboundCallerIdNumberId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutboundCallerIdNumberId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#outbound_flow_id ConnectQueue#outbound_flow_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outboundFlowId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutboundFlowId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
