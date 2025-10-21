using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmPatchBaseline
{
    [JsiiInterface(nativeType: typeof(ISsmPatchBaselineApprovalRule), fullyQualifiedName: "aws.ssmPatchBaseline.SsmPatchBaselineApprovalRule")]
    public interface ISsmPatchBaselineApprovalRule
    {
        /// <summary>patch_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#patch_filter SsmPatchBaseline#patch_filter}
        /// </remarks>
        [JsiiProperty(name: "patchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmPatchBaseline.SsmPatchBaselineApprovalRulePatchFilter\"},\"kind\":\"array\"}}]}}")]
        object PatchFilter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#approve_after_days SsmPatchBaseline#approve_after_days}.</summary>
        [JsiiProperty(name: "approveAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ApproveAfterDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#approve_until_date SsmPatchBaseline#approve_until_date}.</summary>
        [JsiiProperty(name: "approveUntilDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApproveUntilDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#compliance_level SsmPatchBaseline#compliance_level}.</summary>
        [JsiiProperty(name: "complianceLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComplianceLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#enable_non_security SsmPatchBaseline#enable_non_security}.</summary>
        [JsiiProperty(name: "enableNonSecurity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableNonSecurity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmPatchBaselineApprovalRule), fullyQualifiedName: "aws.ssmPatchBaseline.SsmPatchBaselineApprovalRule")]
        internal sealed class _Proxy : DeputyBase, aws.SsmPatchBaseline.ISsmPatchBaselineApprovalRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>patch_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#patch_filter SsmPatchBaseline#patch_filter}
            /// </remarks>
            [JsiiProperty(name: "patchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmPatchBaseline.SsmPatchBaselineApprovalRulePatchFilter\"},\"kind\":\"array\"}}]}}")]
            public object PatchFilter
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#approve_after_days SsmPatchBaseline#approve_after_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "approveAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ApproveAfterDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#approve_until_date SsmPatchBaseline#approve_until_date}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "approveUntilDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApproveUntilDate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#compliance_level SsmPatchBaseline#compliance_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "complianceLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComplianceLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#enable_non_security SsmPatchBaseline#enable_non_security}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableNonSecurity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableNonSecurity
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
