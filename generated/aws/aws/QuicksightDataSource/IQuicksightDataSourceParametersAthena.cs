using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceParametersAthena), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersAthena")]
    public interface IQuicksightDataSourceParametersAthena
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#work_group QuicksightDataSource#work_group}.</summary>
        [JsiiProperty(name: "workGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceParametersAthena), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersAthena")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSource.IQuicksightDataSourceParametersAthena
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#work_group QuicksightDataSource#work_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
