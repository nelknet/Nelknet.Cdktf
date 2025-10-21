using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2FindingsFilter
{
    [JsiiInterface(nativeType: typeof(IMacie2FindingsFilterFindingCriteria), fullyQualifiedName: "aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteria")]
    public interface IMacie2FindingsFilterFindingCriteria
    {
        /// <summary>criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#criterion Macie2FindingsFilter#criterion}
        /// </remarks>
        [JsiiProperty(name: "criterion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Criterion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2FindingsFilterFindingCriteria), fullyQualifiedName: "aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2FindingsFilter.IMacie2FindingsFilterFindingCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>criterion block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#criterion Macie2FindingsFilter#criterion}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "criterion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2FindingsFilter.Macie2FindingsFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Criterion
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
