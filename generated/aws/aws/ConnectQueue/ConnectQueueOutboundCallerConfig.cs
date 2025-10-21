using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectQueue
{
    [JsiiByValue(fqn: "aws.connectQueue.ConnectQueueOutboundCallerConfig")]
    public class ConnectQueueOutboundCallerConfig : aws.ConnectQueue.IConnectQueueOutboundCallerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#outbound_caller_id_name ConnectQueue#outbound_caller_id_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outboundCallerIdName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutboundCallerIdName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#outbound_caller_id_number_id ConnectQueue#outbound_caller_id_number_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outboundCallerIdNumberId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutboundCallerIdNumberId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_queue#outbound_flow_id ConnectQueue#outbound_flow_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outboundFlowId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutboundFlowId
        {
            get;
            set;
        }
    }
}
