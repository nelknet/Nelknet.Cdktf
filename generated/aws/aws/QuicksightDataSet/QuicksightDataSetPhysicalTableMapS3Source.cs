using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3Source")]
    public class QuicksightDataSetPhysicalTableMapS3Source : aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_source_arn QuicksightDataSet#data_source_arn}.</summary>
        [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSourceArn
        {
            get;
            set;
        }

        private object _inputColumns;

        /// <summary>input_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#input_columns QuicksightDataSet#input_columns}
        /// </remarks>
        [JsiiProperty(name: "inputColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceInputColumns\"},\"kind\":\"array\"}}]}}")]
        public object InputColumns
        {
            get => _inputColumns;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceInputColumns[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceInputColumns).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceInputColumns).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inputColumns = value;
            }
        }

        /// <summary>upload_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#upload_settings QuicksightDataSet#upload_settings}
        /// </remarks>
        [JsiiProperty(name: "uploadSettings", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceUploadSettings\"}")]
        public aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceUploadSettings UploadSettings
        {
            get;
            set;
        }
    }
}
