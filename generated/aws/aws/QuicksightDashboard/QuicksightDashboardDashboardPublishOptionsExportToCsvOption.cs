using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiByValue(fqn: "aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsExportToCsvOption")]
    public class QuicksightDashboardDashboardPublishOptionsExportToCsvOption : aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsExportToCsvOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#availability_status QuicksightDashboard#availability_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityStatus
        {
            get;
            set;
        }
    }
}
