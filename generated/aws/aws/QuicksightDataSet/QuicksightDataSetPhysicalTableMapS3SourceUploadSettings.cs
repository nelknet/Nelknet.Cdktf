using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3SourceUploadSettings")]
    public class QuicksightDataSetPhysicalTableMapS3SourceUploadSettings : aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3SourceUploadSettings
    {
        private object? _containsHeader;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#contains_header QuicksightDataSet#contains_header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containsHeader", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ContainsHeader
        {
            get => _containsHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _containsHeader = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#delimiter QuicksightDataSet#delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#format QuicksightDataSet#format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Format
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#start_from_row QuicksightDataSet#start_from_row}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startFromRow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartFromRow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#text_qualifier QuicksightDataSet#text_qualifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "textQualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TextQualifier
        {
            get;
            set;
        }
    }
}
