using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ResiliencehubResiliencyPolicy
{
    [JsiiInterface(nativeType: typeof(IResiliencehubResiliencyPolicyPolicy), fullyQualifiedName: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicy")]
    public interface IResiliencehubResiliencyPolicyPolicy
    {
        /// <summary>az block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#az ResiliencehubResiliencyPolicy#az}
        /// </remarks>
        [JsiiProperty(name: "az", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz\"}")]
        aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz Az
        {
            get;
        }

        /// <summary>hardware block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#hardware ResiliencehubResiliencyPolicy#hardware}
        /// </remarks>
        [JsiiProperty(name: "hardware", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardware\"}")]
        aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware Hardware
        {
            get;
        }

        /// <summary>software block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#software ResiliencehubResiliencyPolicy#software}
        /// </remarks>
        [JsiiProperty(name: "softwareAttribute", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftware\"}")]
        aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware SoftwareAttribute
        {
            get;
        }

        /// <summary>region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#region ResiliencehubResiliencyPolicy#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResiliencehubResiliencyPolicyPolicy), fullyQualifiedName: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>az block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#az ResiliencehubResiliencyPolicy#az}
            /// </remarks>
            [JsiiProperty(name: "az", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz\"}")]
            public aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz Az
            {
                get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz>()!;
            }

            /// <summary>hardware block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#hardware ResiliencehubResiliencyPolicy#hardware}
            /// </remarks>
            [JsiiProperty(name: "hardware", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardware\"}")]
            public aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware Hardware
            {
                get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware>()!;
            }

            /// <summary>software block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#software ResiliencehubResiliencyPolicy#software}
            /// </remarks>
            [JsiiProperty(name: "softwareAttribute", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftware\"}")]
            public aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware SoftwareAttribute
            {
                get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware>()!;
            }

            /// <summary>region block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resiliencehub_resiliency_policy#region ResiliencehubResiliencyPolicy#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion\"}", isOptional: true)]
            public aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion? Region
            {
                get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion?>();
            }
        }
    }
}
