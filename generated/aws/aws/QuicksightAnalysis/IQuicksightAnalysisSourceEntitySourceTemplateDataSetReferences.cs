using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    [JsiiInterface(nativeType: typeof(IQuicksightAnalysisSourceEntitySourceTemplateDataSetReferences), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateDataSetReferences")]
    public interface IQuicksightAnalysisSourceEntitySourceTemplateDataSetReferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#data_set_arn QuicksightAnalysis#data_set_arn}.</summary>
        [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}")]
        string DataSetArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#data_set_placeholder QuicksightAnalysis#data_set_placeholder}.</summary>
        [JsiiProperty(name: "dataSetPlaceholder", typeJson: "{\"primitive\":\"string\"}")]
        string DataSetPlaceholder
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightAnalysisSourceEntitySourceTemplateDataSetReferences), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateDataSetReferences")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplateDataSetReferences
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#data_set_arn QuicksightAnalysis#data_set_arn}.</summary>
            [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSetArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#data_set_placeholder QuicksightAnalysis#data_set_placeholder}.</summary>
            [JsiiProperty(name: "dataSetPlaceholder", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSetPlaceholder
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
