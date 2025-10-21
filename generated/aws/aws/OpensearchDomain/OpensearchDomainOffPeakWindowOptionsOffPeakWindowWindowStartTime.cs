using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime")]
    public class OpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime : aws.OpensearchDomain.IOpensearchDomainOffPeakWindowOptionsOffPeakWindowWindowStartTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#hours OpensearchDomain#hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Hours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain#minutes OpensearchDomain#minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minutes
        {
            get;
            set;
        }
    }
}
