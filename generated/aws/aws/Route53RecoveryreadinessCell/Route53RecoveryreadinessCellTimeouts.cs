using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecoveryreadinessCell
{
    [JsiiByValue(fqn: "aws.route53RecoveryreadinessCell.Route53RecoveryreadinessCellTimeouts")]
    public class Route53RecoveryreadinessCellTimeouts : aws.Route53RecoveryreadinessCell.IRoute53RecoveryreadinessCellTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_cell#delete Route53RecoveryreadinessCell#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
