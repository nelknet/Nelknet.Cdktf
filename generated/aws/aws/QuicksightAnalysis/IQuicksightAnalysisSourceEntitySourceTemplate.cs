using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    [JsiiInterface(nativeType: typeof(IQuicksightAnalysisSourceEntitySourceTemplate), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplate")]
    public interface IQuicksightAnalysisSourceEntitySourceTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#arn QuicksightAnalysis#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>data_set_references block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#data_set_references QuicksightAnalysis#data_set_references}
        /// </remarks>
        [JsiiProperty(name: "dataSetReferences", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateDataSetReferences\"},\"kind\":\"array\"}}]}}")]
        object DataSetReferences
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightAnalysisSourceEntitySourceTemplate), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#arn QuicksightAnalysis#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>data_set_references block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#data_set_references QuicksightAnalysis#data_set_references}
            /// </remarks>
            [JsiiProperty(name: "dataSetReferences", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateDataSetReferences\"},\"kind\":\"array\"}}]}}")]
            public object DataSetReferences
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
