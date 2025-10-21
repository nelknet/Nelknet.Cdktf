using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksHaproxyLayer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.opsworksHaproxyLayer.OpsworksHaproxyLayerCloudwatchConfigurationLogStreams")]
    public class OpsworksHaproxyLayerCloudwatchConfigurationLogStreams : aws.OpsworksHaproxyLayer.IOpsworksHaproxyLayerCloudwatchConfigurationLogStreams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#file OpsworksHaproxyLayer#file}.</summary>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        public string File
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#log_group_name OpsworksHaproxyLayer#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#batch_count OpsworksHaproxyLayer#batch_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#batch_size OpsworksHaproxyLayer#batch_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#buffer_duration OpsworksHaproxyLayer#buffer_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bufferDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BufferDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#datetime_format OpsworksHaproxyLayer#datetime_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "datetimeFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatetimeFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#encoding OpsworksHaproxyLayer#encoding}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Encoding
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#file_fingerprint_lines OpsworksHaproxyLayer#file_fingerprint_lines}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileFingerprintLines", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileFingerprintLines
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#initial_position OpsworksHaproxyLayer#initial_position}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InitialPosition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#multiline_start_pattern OpsworksHaproxyLayer#multiline_start_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multilineStartPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MultilineStartPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_haproxy_layer#time_zone OpsworksHaproxyLayer#time_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZone
        {
            get;
            set;
        }
    }
}
