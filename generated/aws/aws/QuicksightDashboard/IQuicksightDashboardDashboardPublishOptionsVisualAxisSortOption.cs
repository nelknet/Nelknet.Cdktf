using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiInterface(nativeType: typeof(IQuicksightDashboardDashboardPublishOptionsVisualAxisSortOption), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualAxisSortOption")]
    public interface IQuicksightDashboardDashboardPublishOptionsVisualAxisSortOption
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

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDashboardDashboardPublishOptionsVisualAxisSortOption), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsVisualAxisSortOption")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsVisualAxisSortOption
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
