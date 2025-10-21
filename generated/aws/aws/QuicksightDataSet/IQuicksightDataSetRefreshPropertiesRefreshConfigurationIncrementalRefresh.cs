using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh")]
    public interface IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh
    {
        /// <summary>lookback_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#lookback_window QuicksightDataSet#lookback_window}
        /// </remarks>
        [JsiiProperty(name: "lookbackWindow", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow\"}")]
        aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow LookbackWindow
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>lookback_window block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#lookback_window QuicksightDataSet#lookback_window}
            /// </remarks>
            [JsiiProperty(name: "lookbackWindow", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow\"}")]
            public aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow LookbackWindow
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow>()!;
            }
        }
    }
}
