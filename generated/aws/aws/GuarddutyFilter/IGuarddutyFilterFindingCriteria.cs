using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyFilter
{
    [JsiiInterface(nativeType: typeof(IGuarddutyFilterFindingCriteria), fullyQualifiedName: "aws.guarddutyFilter.GuarddutyFilterFindingCriteria")]
    public interface IGuarddutyFilterFindingCriteria
    {
        /// <summary>criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#criterion GuarddutyFilter#criterion}
        /// </remarks>
        [JsiiProperty(name: "criterion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.guarddutyFilter.GuarddutyFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}]}}")]
        object Criterion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyFilterFindingCriteria), fullyQualifiedName: "aws.guarddutyFilter.GuarddutyFilterFindingCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.GuarddutyFilter.IGuarddutyFilterFindingCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>criterion block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_filter#criterion GuarddutyFilter#criterion}
            /// </remarks>
            [JsiiProperty(name: "criterion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.guarddutyFilter.GuarddutyFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}]}}")]
            public object Criterion
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
