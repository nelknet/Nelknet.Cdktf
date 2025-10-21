using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2FindingsFilter
{
    [JsiiByValue(fqn: "aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteria")]
    public class Macie2FindingsFilterFindingCriteria : aws.Macie2FindingsFilter.IMacie2FindingsFilterFindingCriteria
    {
        private object? _criterion;

        /// <summary>criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#criterion Macie2FindingsFilter#criterion}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "criterion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Criterion
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
                        case aws.Macie2FindingsFilter.IMacie2FindingsFilterFindingCriteriaCriterion[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Macie2FindingsFilter.IMacie2FindingsFilterFindingCriteriaCriterion).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _criterion = value;
            }
        }
    }
}
