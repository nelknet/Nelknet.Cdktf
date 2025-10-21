using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetRefreshPropertiesRefreshConfiguration), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfiguration")]
    public interface IQuicksightDataSetRefreshPropertiesRefreshConfiguration
    {
        /// <summary>incremental_refresh block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#incremental_refresh QuicksightDataSet#incremental_refresh}
        /// </remarks>
        [JsiiProperty(name: "incrementalRefresh", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh\"}")]
        aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh IncrementalRefresh
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetRefreshPropertiesRefreshConfiguration), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>incremental_refresh block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#incremental_refresh QuicksightDataSet#incremental_refresh}
            /// </remarks>
            [JsiiProperty(name: "incrementalRefresh", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh\"}")]
            public aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh IncrementalRefresh
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefresh>()!;
            }
        }
    }
}
