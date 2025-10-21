using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecoveryreadinessReadinessCheck
{
    [JsiiByValue(fqn: "aws.route53RecoveryreadinessReadinessCheck.Route53RecoveryreadinessReadinessCheckTimeouts")]
    public class Route53RecoveryreadinessReadinessCheckTimeouts : aws.Route53RecoveryreadinessReadinessCheck.IRoute53RecoveryreadinessReadinessCheckTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_readiness_check#delete Route53RecoveryreadinessReadinessCheck#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
