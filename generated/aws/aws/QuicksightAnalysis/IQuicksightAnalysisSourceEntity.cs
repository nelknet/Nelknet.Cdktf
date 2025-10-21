using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    [JsiiInterface(nativeType: typeof(IQuicksightAnalysisSourceEntity), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisSourceEntity")]
    public interface IQuicksightAnalysisSourceEntity
    {
        /// <summary>source_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#source_template QuicksightAnalysis#source_template}
        /// </remarks>
        [JsiiProperty(name: "sourceTemplate", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate? SourceTemplate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightAnalysisSourceEntity), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisSourceEntity")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>source_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#source_template QuicksightAnalysis#source_template}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceTemplate", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplate\"}", isOptional: true)]
            public aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate? SourceTemplate
            {
                get => GetInstanceProperty<aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate?>();
            }
        }
    }
}
