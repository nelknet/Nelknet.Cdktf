using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmPatchBaseline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmPatchBaseline.SsmPatchBaselineApprovalRule")]
    public class SsmPatchBaselineApprovalRule : aws.SsmPatchBaseline.ISsmPatchBaselineApprovalRule
    {
        private object _patchFilter;

        /// <summary>patch_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#patch_filter SsmPatchBaseline#patch_filter}
        /// </remarks>
        [JsiiProperty(name: "patchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmPatchBaseline.SsmPatchBaselineApprovalRulePatchFilter\"},\"kind\":\"array\"}}]}}")]
        public object PatchFilter
        {
            get => _patchFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmPatchBaseline.ISsmPatchBaselineApprovalRulePatchFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmPatchBaseline.ISsmPatchBaselineApprovalRulePatchFilter).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmPatchBaseline.ISsmPatchBaselineApprovalRulePatchFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _patchFilter = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#approve_after_days SsmPatchBaseline#approve_after_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "approveAfterDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ApproveAfterDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#approve_until_date SsmPatchBaseline#approve_until_date}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "approveUntilDate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApproveUntilDate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#compliance_level SsmPatchBaseline#compliance_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "complianceLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComplianceLevel
        {
            get;
            set;
        }

        private object? _enableNonSecurity;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_patch_baseline#enable_non_security SsmPatchBaseline#enable_non_security}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableNonSecurity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableNonSecurity
        {
            get => _enableNonSecurity;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableNonSecurity = value;
            }
        }
    }
}
