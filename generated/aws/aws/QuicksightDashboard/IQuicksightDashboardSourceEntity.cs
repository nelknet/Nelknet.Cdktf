using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiInterface(nativeType: typeof(IQuicksightDashboardSourceEntity), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardSourceEntity")]
    public interface IQuicksightDashboardSourceEntity
    {
        /// <summary>source_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#source_template QuicksightDashboard#source_template}
        /// </remarks>
        [JsiiProperty(name: "sourceTemplate", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplate? SourceTemplate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDashboardSourceEntity), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardSourceEntity")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDashboard.IQuicksightDashboardSourceEntity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>source_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#source_template QuicksightDashboard#source_template}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceTemplate", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplate\"}", isOptional: true)]
            public aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplate? SourceTemplate
            {
                get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplate?>();
            }
        }
    }
}
