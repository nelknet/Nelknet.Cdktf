using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecoveryreadinessResourceSet
{
    [JsiiByValue(fqn: "aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResources")]
    public class Route53RecoveryreadinessResourceSetResources : aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResources
    {
        /// <summary>dns_target_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#dns_target_resource Route53RecoveryreadinessResourceSet#dns_target_resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dnsTargetResource", typeJson: "{\"fqn\":\"aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResourcesDnsTargetResource\"}", isOptional: true)]
        public aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResource? DnsTargetResource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#readiness_scopes Route53RecoveryreadinessResourceSet#readiness_scopes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readinessScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ReadinessScopes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#resource_arn Route53RecoveryreadinessResourceSet#resource_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceArn
        {
            get;
            set;
        }
    }
}
