using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmincidentsResponsePlan
{
    [JsiiInterface(nativeType: typeof(ISsmincidentsResponsePlanAction), fullyQualifiedName: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanAction")]
    public interface ISsmincidentsResponsePlanAction
    {
        /// <summary>ssm_automation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#ssm_automation SsmincidentsResponsePlan#ssm_automation}
        /// </remarks>
        [JsiiProperty(name: "ssmAutomation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanActionSsmAutomation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SsmAutomation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmincidentsResponsePlanAction), fullyQualifiedName: "aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanAction")]
        internal sealed class _Proxy : DeputyBase, aws.SsmincidentsResponsePlan.ISsmincidentsResponsePlanAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ssm_automation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#ssm_automation SsmincidentsResponsePlan#ssm_automation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssmAutomation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmincidentsResponsePlan.SsmincidentsResponsePlanActionSsmAutomation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SsmAutomation
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
