using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeSubscriber
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securitylakeSubscriber.SecuritylakeSubscriberSourceCustomLogSourceResource")]
    public class SecuritylakeSubscriberSourceCustomLogSourceResource : aws.SecuritylakeSubscriber.ISecuritylakeSubscriberSourceCustomLogSourceResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#source_name SecuritylakeSubscriber#source_name}.</summary>
        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_subscriber#source_version SecuritylakeSubscriber#source_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceVersion
        {
            get;
            set;
        }
    }
}
