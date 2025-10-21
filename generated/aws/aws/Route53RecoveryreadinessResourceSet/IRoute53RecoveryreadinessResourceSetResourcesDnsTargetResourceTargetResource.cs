using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53RecoveryreadinessResourceSet
{
    [JsiiInterface(nativeType: typeof(IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource), fullyQualifiedName: "aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource")]
    public interface IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource
    {
        /// <summary>nlb_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#nlb_resource Route53RecoveryreadinessResourceSet#nlb_resource}
        /// </remarks>
        [JsiiProperty(name: "nlbResource", typeJson: "{\"fqn\":\"aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource? NlbResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>r53_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#r53_resource Route53RecoveryreadinessResourceSet#r53_resource}
        /// </remarks>
        [JsiiProperty(name: "r53Resource", typeJson: "{\"fqn\":\"aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource? R53Resource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource), fullyQualifiedName: "aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource")]
        internal sealed class _Proxy : DeputyBase, aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>nlb_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#nlb_resource Route53RecoveryreadinessResourceSet#nlb_resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nlbResource", typeJson: "{\"fqn\":\"aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource\"}", isOptional: true)]
            public aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource? NlbResource
            {
                get => GetInstanceProperty<aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource?>();
            }

            /// <summary>r53_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#r53_resource Route53RecoveryreadinessResourceSet#r53_resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "r53Resource", typeJson: "{\"fqn\":\"aws.route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource\"}", isOptional: true)]
            public aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource? R53Resource
            {
                get => GetInstanceProperty<aws.Route53RecoveryreadinessResourceSet.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource?>();
            }
        }
    }
}
