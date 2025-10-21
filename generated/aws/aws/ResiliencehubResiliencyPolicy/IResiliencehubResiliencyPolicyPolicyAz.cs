using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ResiliencehubResiliencyPolicy
{
    [JsiiInterface(nativeType: typeof(IResiliencehubResiliencyPolicyPolicyAz), fullyQualifiedName: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz")]
    public interface IResiliencehubResiliencyPolicyPolicyAz
    {
        /// <summary>Recovery Point Objective (RPO) as a Go duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#rpo ResiliencehubResiliencyPolicy#rpo}
        /// </remarks>
        [JsiiProperty(name: "rpo", typeJson: "{\"primitive\":\"string\"}")]
        string Rpo
        {
            get;
        }

        /// <summary>Recovery Time Objective (RTO) as a Go duration.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#rto ResiliencehubResiliencyPolicy#rto}
        /// </remarks>
        [JsiiProperty(name: "rto", typeJson: "{\"primitive\":\"string\"}")]
        string Rto
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubResiliencyPolicyPolicyAz), fullyQualifiedName: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz")]
        internal sealed class _Proxy : DeputyBase, aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Recovery Point Objective (RPO) as a Go duration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#rpo ResiliencehubResiliencyPolicy#rpo}
            /// </remarks>
            [JsiiProperty(name: "rpo", typeJson: "{\"primitive\":\"string\"}")]
            public string Rpo
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Recovery Time Objective (RTO) as a Go duration.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#rto ResiliencehubResiliencyPolicy#rto}
            /// </remarks>
            [JsiiProperty(name: "rto", typeJson: "{\"primitive\":\"string\"}")]
            public string Rto
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
