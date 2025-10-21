using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTemplate
{
    [JsiiInterface(nativeType: typeof(IQuicksightTemplateSourceEntitySourceAnalysisDataSetReferences), fullyQualifiedName: "aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisDataSetReferences")]
    public interface IQuicksightTemplateSourceEntitySourceAnalysisDataSetReferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#data_set_arn QuicksightTemplate#data_set_arn}.</summary>
        [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}")]
        string DataSetArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#data_set_placeholder QuicksightTemplate#data_set_placeholder}.</summary>
        [JsiiProperty(name: "dataSetPlaceholder", typeJson: "{\"primitive\":\"string\"}")]
        string DataSetPlaceholder
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightTemplateSourceEntitySourceAnalysisDataSetReferences), fullyQualifiedName: "aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisDataSetReferences")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysisDataSetReferences
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#data_set_arn QuicksightTemplate#data_set_arn}.</summary>
            [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSetArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#data_set_placeholder QuicksightTemplate#data_set_placeholder}.</summary>
            [JsiiProperty(name: "dataSetPlaceholder", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSetPlaceholder
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
