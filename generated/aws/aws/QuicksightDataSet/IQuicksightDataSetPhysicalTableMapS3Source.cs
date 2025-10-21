using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetPhysicalTableMapS3Source), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3Source")]
    public interface IQuicksightDataSetPhysicalTableMapS3Source
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_source_arn QuicksightDataSet#data_source_arn}.</summary>
        [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string DataSourceArn
        {
            get;
        }

        /// <summary>input_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#input_columns QuicksightDataSet#input_columns}
        /// </remarks>
        [JsiiProperty(name: "inputColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceInputColumns\"},\"kind\":\"array\"}}]}}")]
        object InputColumns
        {
            get;
        }

        /// <summary>upload_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#upload_settings QuicksightDataSet#upload_settings}
        /// </remarks>
        [JsiiProperty(name: "uploadSettings", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceUploadSettings\"}")]
        aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceUploadSettings UploadSettings
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetPhysicalTableMapS3Source), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3Source")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_source_arn QuicksightDataSet#data_source_arn}.</summary>
            [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSourceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>input_columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#input_columns QuicksightDataSet#input_columns}
            /// </remarks>
            [JsiiProperty(name: "inputColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceInputColumns\"},\"kind\":\"array\"}}]}}")]
            public object InputColumns
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>upload_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#upload_settings QuicksightDataSet#upload_settings}
            /// </remarks>
            [JsiiProperty(name: "uploadSettings", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceUploadSettings\"}")]
            public aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceUploadSettings UploadSettings
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceUploadSettings>()!;
            }
        }
    }
}
