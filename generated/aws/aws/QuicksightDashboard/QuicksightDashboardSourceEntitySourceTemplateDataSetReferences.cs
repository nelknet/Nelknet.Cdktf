using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplateDataSetReferences")]
    public class QuicksightDashboardSourceEntitySourceTemplateDataSetReferences : aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplateDataSetReferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_set_arn QuicksightDashboard#data_set_arn}.</summary>
        [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSetArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_set_placeholder QuicksightDashboard#data_set_placeholder}.</summary>
        [JsiiProperty(name: "dataSetPlaceholder", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSetPlaceholder
        {
            get;
            set;
        }
    }
}
