using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmincidentsResponsePlan
{
    [JsiiInterface(nativeType: typeof(ISsmincidentsResponsePlanIntegration), fullyQualifiedName: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIntegration")]
    public interface ISsmincidentsResponsePlanIntegration
    {
        /// <summary>pagerduty block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#pagerduty SsmincidentsResponsePlan#pagerduty}
        /// </remarks>
        [JsiiProperty(name: "pagerduty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIntegrationPagerduty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Pagerduty
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmincidentsResponsePlanIntegration), fullyQualifiedName: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIntegration")]
        internal sealed class _Proxy : DeputyBase, aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanIntegration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>pagerduty block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#pagerduty SsmincidentsResponsePlan#pagerduty}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pagerduty", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanIntegrationPagerduty\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Pagerduty
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
