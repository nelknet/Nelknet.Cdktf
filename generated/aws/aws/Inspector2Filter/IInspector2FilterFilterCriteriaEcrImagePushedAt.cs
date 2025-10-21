using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    [JsiiInterface(nativeType: typeof(IInspector2FilterFilterCriteriaEcrImagePushedAt), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImagePushedAt")]
    public interface IInspector2FilterFilterCriteriaEcrImagePushedAt
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#end_inclusive Inspector2Filter#end_inclusive}.</summary>
        [JsiiProperty(name: "endInclusive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndInclusive
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#start_inclusive Inspector2Filter#start_inclusive}.</summary>
        [JsiiProperty(name: "startInclusive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartInclusive
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInspector2FilterFilterCriteriaEcrImagePushedAt), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImagePushedAt")]
        internal sealed class _Proxy : DeputyBase, aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImagePushedAt
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#end_inclusive Inspector2Filter#end_inclusive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endInclusive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndInclusive
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#start_inclusive Inspector2Filter#start_inclusive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startInclusive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartInclusive
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
