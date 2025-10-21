using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceParametersAwsIotAnalytics), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersAwsIotAnalytics")]
    public interface IQuicksightDataSourceParametersAwsIotAnalytics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#data_set_name QuicksightDataSource#data_set_name}.</summary>
        [JsiiProperty(name: "dataSetName", typeJson: "{\"primitive\":\"string\"}")]
        string DataSetName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceParametersAwsIotAnalytics), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersAwsIotAnalytics")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSource.IQuicksightDataSourceParametersAwsIotAnalytics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#data_set_name QuicksightDataSource#data_set_name}.</summary>
            [JsiiProperty(name: "dataSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSetName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
