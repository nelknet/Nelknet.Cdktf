using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksGangliaLayer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opsworksGangliaLayer.OpsworksGangliaLayerCloudwatchConfigurationLogStreams")]
    public class OpsworksGangliaLayerCloudwatchConfigurationLogStreams : aws.OpsworksGangliaLayer.IOpsworksGangliaLayerCloudwatchConfigurationLogStreams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#file OpsworksGangliaLayer#file}.</summary>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        public string File
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#log_group_name OpsworksGangliaLayer#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#batch_count OpsworksGangliaLayer#batch_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#batch_size OpsworksGangliaLayer#batch_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#buffer_duration OpsworksGangliaLayer#buffer_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#datetime_format OpsworksGangliaLayer#datetime_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "datetimeFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatetimeFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#encoding OpsworksGangliaLayer#encoding}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Encoding
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#file_fingerprint_lines OpsworksGangliaLayer#file_fingerprint_lines}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileFingerprintLines", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileFingerprintLines
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#initial_position OpsworksGangliaLayer#initial_position}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InitialPosition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#multiline_start_pattern OpsworksGangliaLayer#multiline_start_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multilineStartPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MultilineStartPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#time_zone OpsworksGangliaLayer#time_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZone
        {
            get;
            set;
        }
    }
}
