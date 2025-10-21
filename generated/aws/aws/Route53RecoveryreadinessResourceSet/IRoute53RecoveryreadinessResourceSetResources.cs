using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecoveryreadinessResourceSet
{
    [JsiiInterface(nativeType: typeof(IRoute53RecoveryreadinessResourceSetResources), fullyQualifiedName: "aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResources")]
    public interface IRoute53RecoveryreadinessResourceSetResources
    {
        /// <summary>dns_target_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#dns_target_resource Route53RecoveryreadinessResourceSet#dns_target_resource}
        /// </remarks>
        [JsiiProperty(name: "dnsTargetResource", typeJson: "{\"fqn\":\"aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResourcesDnsTargetResource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResource? DnsTargetResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#readiness_scopes Route53RecoveryreadinessResourceSet#readiness_scopes}.</summary>
        [JsiiProperty(name: "readinessScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ReadinessScopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#resource_arn Route53RecoveryreadinessResourceSet#resource_arn}.</summary>
        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecoveryreadinessResourceSetResources), fullyQualifiedName: "aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResources")]
        internal sealed class _Proxy : DeputyBase, aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dns_target_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#dns_target_resource Route53RecoveryreadinessResourceSet#dns_target_resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsTargetResource", typeJson: "{\"fqn\":\"aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResourcesDnsTargetResource\"}", isOptional: true)]
            public aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResource? DnsTargetResource
            {
                get => GetInstanceProperty<aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResource?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#readiness_scopes Route53RecoveryreadinessResourceSet#readiness_scopes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readinessScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ReadinessScopes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#resource_arn Route53RecoveryreadinessResourceSet#resource_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
