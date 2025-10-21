using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceParametersTwitter), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersTwitter")]
    public interface IQuicksightDataSourceParametersTwitter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#max_rows QuicksightDataSource#max_rows}.</summary>
        [JsiiProperty(name: "maxRows", typeJson: "{\"primitive\":\"number\"}")]
        double MaxRows
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#query QuicksightDataSource#query}.</summary>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        string Query
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceParametersTwitter), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersTwitter")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSource.IQuicksightDataSourceParametersTwitter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#max_rows QuicksightDataSource#max_rows}.</summary>
            [JsiiProperty(name: "maxRows", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxRows
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#query QuicksightDataSource#query}.</summary>
            [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
            public string Query
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
