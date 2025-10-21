using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiByValue(fqn: "aws.quicksightDashboard.QuicksightDashboardSourceEntity")]
    public class QuicksightDashboardSourceEntity : aws.QuicksightDashboard.IQuicksightDashboardSourceEntity
    {
        /// <summary>source_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#source_template QuicksightDashboard#source_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceTemplate", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplate\"}", isOptional: true)]
        public aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplate? SourceTemplate
        {
            get;
            set;
        }
    }
}
