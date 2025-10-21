using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTemplate
{
    [JsiiByValue(fqn: "aws.quicksightTemplate.QuicksightTemplateSourceEntity")]
    public class QuicksightTemplateSourceEntity : aws.QuicksightTemplate.IQuicksightTemplateSourceEntity
    {
        /// <summary>source_analysis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#source_analysis QuicksightTemplate#source_analysis}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceAnalysis", typeJson: "{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysis\"}", isOptional: true)]
        public aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysis? SourceAnalysis
        {
            get;
            set;
        }

        /// <summary>source_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#source_template QuicksightTemplate#source_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceTemplate", typeJson: "{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceTemplate\"}", isOptional: true)]
        public aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceTemplate? SourceTemplate
        {
            get;
            set;
        }
    }
}
