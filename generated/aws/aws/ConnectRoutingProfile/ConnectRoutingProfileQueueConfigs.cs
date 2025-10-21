using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectRoutingProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectRoutingProfile.ConnectRoutingProfileQueueConfigs")]
    public class ConnectRoutingProfileQueueConfigs : aws.ConnectRoutingProfile.IConnectRoutingProfileQueueConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#channel ConnectRoutingProfile#channel}.</summary>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        public string Channel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#delay ConnectRoutingProfile#delay}.</summary>
        [JsiiProperty(name: "delay", typeJson: "{\"primitive\":\"number\"}")]
        public double Delay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#priority ConnectRoutingProfile#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#queue_id ConnectRoutingProfile#queue_id}.</summary>
        [JsiiProperty(name: "queueId", typeJson: "{\"primitive\":\"string\"}")]
        public string QueueId
        {
            get;
            set;
        }
    }
}
