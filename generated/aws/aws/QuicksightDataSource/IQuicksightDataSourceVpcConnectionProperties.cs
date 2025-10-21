using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceVpcConnectionProperties), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceVpcConnectionProperties")]
    public interface IQuicksightDataSourceVpcConnectionProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#vpc_connection_arn QuicksightDataSource#vpc_connection_arn}.</summary>
        [JsiiProperty(name: "vpcConnectionArn", typeJson: "{\"primitive\":\"string\"}")]
        string VpcConnectionArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceVpcConnectionProperties), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceVpcConnectionProperties")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSource.IQuicksightDataSourceVpcConnectionProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#vpc_connection_arn QuicksightDataSource#vpc_connection_arn}.</summary>
            [JsiiProperty(name: "vpcConnectionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcConnectionArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
