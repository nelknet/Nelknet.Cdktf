using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectRoutingProfile
{
    [JsiiInterface(nativeType: typeof(IConnectRoutingProfileQueueConfigs), fullyQualifiedName: "aws.connectRoutingProfile.ConnectRoutingProfileQueueConfigs")]
    public interface IConnectRoutingProfileQueueConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#channel ConnectRoutingProfile#channel}.</summary>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        string Channel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#delay ConnectRoutingProfile#delay}.</summary>
        [JsiiProperty(name: "delay", typeJson: "{\"primitive\":\"number\"}")]
        double Delay
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#priority ConnectRoutingProfile#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#queue_id ConnectRoutingProfile#queue_id}.</summary>
        [JsiiProperty(name: "queueId", typeJson: "{\"primitive\":\"string\"}")]
        string QueueId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectRoutingProfileQueueConfigs), fullyQualifiedName: "aws.connectRoutingProfile.ConnectRoutingProfileQueueConfigs")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectRoutingProfile.IConnectRoutingProfileQueueConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#channel ConnectRoutingProfile#channel}.</summary>
            [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
            public string Channel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#delay ConnectRoutingProfile#delay}.</summary>
            [JsiiProperty(name: "delay", typeJson: "{\"primitive\":\"number\"}")]
            public double Delay
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#priority ConnectRoutingProfile#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#queue_id ConnectRoutingProfile#queue_id}.</summary>
            [JsiiProperty(name: "queueId", typeJson: "{\"primitive\":\"string\"}")]
            public string QueueId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
