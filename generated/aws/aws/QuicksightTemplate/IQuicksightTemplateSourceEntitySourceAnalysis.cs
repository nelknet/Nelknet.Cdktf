using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTemplate
{
    [JsiiInterface(nativeType: typeof(IQuicksightTemplateSourceEntitySourceAnalysis), fullyQualifiedName: "aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysis")]
    public interface IQuicksightTemplateSourceEntitySourceAnalysis
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#arn QuicksightTemplate#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>data_set_references block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#data_set_references QuicksightTemplate#data_set_references}
        /// </remarks>
        [JsiiProperty(name: "dataSetReferences", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisDataSetReferences\"},\"kind\":\"array\"}}]}}")]
        object DataSetReferences
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightTemplateSourceEntitySourceAnalysis), fullyQualifiedName: "aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysis")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysis
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#arn QuicksightTemplate#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>data_set_references block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#data_set_references QuicksightTemplate#data_set_references}
            /// </remarks>
            [JsiiProperty(name: "dataSetReferences", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisDataSetReferences\"},\"kind\":\"array\"}}]}}")]
            public object DataSetReferences
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
