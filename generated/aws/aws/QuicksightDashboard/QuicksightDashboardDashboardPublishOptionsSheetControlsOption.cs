using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiByValue(fqn: "aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetControlsOption")]
    public class QuicksightDashboardDashboardPublishOptionsSheetControlsOption : aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetControlsOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#visibility_state QuicksightDashboard#visibility_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "visibilityState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VisibilityState
        {
            get;
            set;
        }
    }
}
