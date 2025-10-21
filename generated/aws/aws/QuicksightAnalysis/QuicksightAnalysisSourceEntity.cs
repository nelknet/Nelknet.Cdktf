using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    [JsiiByValue(fqn: "aws.quicksightAnalysis.QuicksightAnalysisSourceEntity")]
    public class QuicksightAnalysisSourceEntity : aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntity
    {
        /// <summary>source_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#source_template QuicksightAnalysis#source_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceTemplate", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplate\"}", isOptional: true)]
        public aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate? SourceTemplate
        {
            get;
            set;
        }
    }
}
