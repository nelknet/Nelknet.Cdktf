using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiInterface(nativeType: typeof(IQuicksightDashboardDashboardPublishOptionsSheetControlsOption), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetControlsOption")]
    public interface IQuicksightDashboardDashboardPublishOptionsSheetControlsOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#visibility_state QuicksightDashboard#visibility_state}.</summary>
        [JsiiProperty(name: "visibilityState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VisibilityState
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDashboardDashboardPublishOptionsSheetControlsOption), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardDashboardPublishOptionsSheetControlsOption")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDashboard.IQuicksightDashboardDashboardPublishOptionsSheetControlsOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#visibility_state QuicksightDashboard#visibility_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "visibilityState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VisibilityState
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
