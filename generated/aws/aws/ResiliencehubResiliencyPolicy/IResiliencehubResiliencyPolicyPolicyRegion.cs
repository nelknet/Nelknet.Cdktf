using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ResiliencehubResiliencyPolicy
{
    [JsiiInterface(nativeType: typeof(IResiliencehubResiliencyPolicyPolicyRegion), fullyQualifiedName: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion")]
    public interface IResiliencehubResiliencyPolicyPolicyRegion
    {
        /// <summary>Recovery Point Objective (RPO) as a Go duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#rpo ResiliencehubResiliencyPolicy#rpo}
        /// </remarks>
        [JsiiProperty(name: "rpo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Rpo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Recovery Time Objective (RTO) as a Go duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#rto ResiliencehubResiliencyPolicy#rto}
        /// </remarks>
        [JsiiProperty(name: "rto", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Rto
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubResiliencyPolicyPolicyRegion), fullyQualifiedName: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion")]
        internal sealed class _Proxy : DeputyBase, aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Recovery Point Objective (RPO) as a Go duration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#rpo ResiliencehubResiliencyPolicy#rpo}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rpo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Rpo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Recovery Time Objective (RTO) as a Go duration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#rto ResiliencehubResiliencyPolicy#rto}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rto", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Rto
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
