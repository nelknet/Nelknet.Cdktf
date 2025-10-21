using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmincidentsResponsePlan
{
    [JsiiByValue(fqn: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIntegration")]
    public class SsmincidentsResponsePlanIntegration : aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIntegration
    {
        private object? _pagerduty;

        /// <summary>pagerduty block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#pagerduty SsmincidentsResponsePlan#pagerduty}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pagerduty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIntegrationPagerduty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Pagerduty
        {
            get => _pagerduty;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIntegrationPagerduty[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIntegrationPagerduty).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pagerduty = value;
            }
        }
    }
}
