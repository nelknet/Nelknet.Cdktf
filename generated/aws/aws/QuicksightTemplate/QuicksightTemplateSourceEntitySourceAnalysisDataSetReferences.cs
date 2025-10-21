using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisDataSetReferences")]
    public class QuicksightTemplateSourceEntitySourceAnalysisDataSetReferences : aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysisDataSetReferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#data_set_arn QuicksightTemplate#data_set_arn}.</summary>
        [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSetArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_template#data_set_placeholder QuicksightTemplate#data_set_placeholder}.</summary>
        [JsiiProperty(name: "dataSetPlaceholder", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSetPlaceholder
        {
            get;
            set;
        }
    }
}
