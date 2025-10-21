using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiInterface(nativeType: typeof(IQuicksightDashboardDashboardPublishOptionsVisualMenuOption), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualMenuOption")]
    public interface IQuicksightDashboardDashboardPublishOptionsVisualMenuOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#availability_status QuicksightDashboard#availability_status}.</summary>
        [JsiiProperty(name: "availabilityStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDashboardDashboardPublishOptionsVisualMenuOption), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualMenuOption")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualMenuOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#availability_status QuicksightDashboard#availability_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityStatus
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
