using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksJavaAppLayer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opsworksJavaAppLayer.OpsworksJavaAppLayerCloudwatchConfigurationLogStreams")]
    public class OpsworksJavaAppLayerCloudwatchConfigurationLogStreams : aws.OpsworksJavaAppLayer.IOpsworksJavaAppLayerCloudwatchConfigurationLogStreams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#file OpsworksJavaAppLayer#file}.</summary>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        public string File
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#log_group_name OpsworksJavaAppLayer#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#batch_count OpsworksJavaAppLayer#batch_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#batch_size OpsworksJavaAppLayer#batch_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#buffer_duration OpsworksJavaAppLayer#buffer_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#datetime_format OpsworksJavaAppLayer#datetime_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "datetimeFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatetimeFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#encoding OpsworksJavaAppLayer#encoding}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Encoding
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#file_fingerprint_lines OpsworksJavaAppLayer#file_fingerprint_lines}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileFingerprintLines", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileFingerprintLines
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#initial_position OpsworksJavaAppLayer#initial_position}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InitialPosition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#multiline_start_pattern OpsworksJavaAppLayer#multiline_start_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multilineStartPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MultilineStartPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_java_app_layer#time_zone OpsworksJavaAppLayer#time_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZone
        {
            get;
            set;
        }
    }
}
