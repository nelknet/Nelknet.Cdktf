using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyFilter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.guarddutyFilter.GuarddutyFilterFindingCriteria")]
    public class GuarddutyFilterFindingCriteria : aws.GuarddutyFilter.IGuarddutyFilterFindingCriteria
    {
        private object _criterion;

        /// <summary>criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#criterion GuarddutyFilter#criterion}
        /// </remarks>
        [JsiiProperty(name: "criterion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.guarddutyFilter.GuarddutyFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}]}}")]
        public object Criterion
        {
            get => _criterion;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.GuarddutyFilter.IGuarddutyFilterFindingCriteriaCriterion[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GuarddutyFilter.IGuarddutyFilterFindingCriteriaCriterion).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GuarddutyFilter.IGuarddutyFilterFindingCriteriaCriterion).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _criterion = value;
            }
        }
    }
}
