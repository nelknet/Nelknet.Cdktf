using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectRoutingProfile
{
    [JsiiInterface(nativeType: typeof(IConnectRoutingProfileMediaConcurrencies), fullyQualifiedName: "aws.connectRoutingProfile.ConnectRoutingProfileMediaConcurrencies")]
    public interface IConnectRoutingProfileMediaConcurrencies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#channel ConnectRoutingProfile#channel}.</summary>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        string Channel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#concurrency ConnectRoutingProfile#concurrency}.</summary>
        [JsiiProperty(name: "concurrency", typeJson: "{\"primitive\":\"number\"}")]
        double Concurrency
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectRoutingProfileMediaConcurrencies), fullyQualifiedName: "aws.connectRoutingProfile.ConnectRoutingProfileMediaConcurrencies")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectRoutingProfile.IConnectRoutingProfileMediaConcurrencies
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#concurrency ConnectRoutingProfile#concurrency}.</summary>
            [JsiiProperty(name: "concurrency", typeJson: "{\"primitive\":\"number\"}")]
            public double Concurrency
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
