using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeSubscriber
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securitylakeSubscriber.SecuritylakeSubscriberSubscriberIdentity")]
    public class SecuritylakeSubscriberSubscriberIdentity : aws.SecuritylakeSubscriber.ISecuritylakeSubscriberSubscriberIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#external_id SecuritylakeSubscriber#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#principal SecuritylakeSubscriber#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        public string Principal
        {
            get;
            set;
        }
    }
}
