using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectRoutingProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectRoutingProfile.ConnectRoutingProfileMediaConcurrencies")]
    public class ConnectRoutingProfileMediaConcurrencies : aws.ConnectRoutingProfile.IConnectRoutingProfileMediaConcurrencies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#channel ConnectRoutingProfile#channel}.</summary>
        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        public string Channel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#concurrency ConnectRoutingProfile#concurrency}.</summary>
        [JsiiProperty(name: "concurrency", typeJson: "{\"primitive\":\"number\"}")]
        public double Concurrency
        {
            get;
            set;
        }
    }
}
