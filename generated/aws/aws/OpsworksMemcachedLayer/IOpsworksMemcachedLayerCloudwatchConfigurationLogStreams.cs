using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksMemcachedLayer
{
    [JsiiInterface(nativeType: typeof(IOpsworksMemcachedLayerCloudwatchConfigurationLogStreams), fullyQualifiedName: "aws.opsworksMemcachedLayer.OpsworksMemcachedLayerCloudwatchConfigurationLogStreams")]
    public interface IOpsworksMemcachedLayerCloudwatchConfigurationLogStreams
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#file OpsworksMemcachedLayer#file}.</summary>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        string File
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#log_group_name OpsworksMemcachedLayer#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#batch_count OpsworksMemcachedLayer#batch_count}.</summary>
        [JsiiProperty(name: "batchCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#batch_size OpsworksMemcachedLayer#batch_size}.</summary>
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#buffer_duration OpsworksMemcachedLayer#buffer_duration}.</summary>
        [JsiiProperty(name: "bufferDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufferDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#datetime_format OpsworksMemcachedLayer#datetime_format}.</summary>
        [JsiiProperty(name: "datetimeFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatetimeFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#encoding OpsworksMemcachedLayer#encoding}.</summary>
        [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Encoding
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#file_fingerprint_lines OpsworksMemcachedLayer#file_fingerprint_lines}.</summary>
        [JsiiProperty(name: "fileFingerprintLines", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileFingerprintLines
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#initial_position OpsworksMemcachedLayer#initial_position}.</summary>
        [JsiiProperty(name: "initialPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InitialPosition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#multiline_start_pattern OpsworksMemcachedLayer#multiline_start_pattern}.</summary>
        [JsiiProperty(name: "multilineStartPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MultilineStartPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#time_zone OpsworksMemcachedLayer#time_zone}.</summary>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeZone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksMemcachedLayerCloudwatchConfigurationLogStreams), fullyQualifiedName: "aws.opsworksMemcachedLayer.OpsworksMemcachedLayerCloudwatchConfigurationLogStreams")]
        internal sealed class _Proxy : DeputyBase, aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerCloudwatchConfigurationLogStreams
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#file OpsworksMemcachedLayer#file}.</summary>
            [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
            public string File
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#log_group_name OpsworksMemcachedLayer#log_group_name}.</summary>
            [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#batch_count OpsworksMemcachedLayer#batch_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#batch_size OpsworksMemcachedLayer#batch_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#buffer_duration OpsworksMemcachedLayer#buffer_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bufferDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufferDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#datetime_format OpsworksMemcachedLayer#datetime_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "datetimeFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatetimeFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#encoding OpsworksMemcachedLayer#encoding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Encoding
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#file_fingerprint_lines OpsworksMemcachedLayer#file_fingerprint_lines}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileFingerprintLines", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileFingerprintLines
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#initial_position OpsworksMemcachedLayer#initial_position}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "initialPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InitialPosition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#multiline_start_pattern OpsworksMemcachedLayer#multiline_start_pattern}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "multilineStartPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MultilineStartPattern
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#time_zone OpsworksMemcachedLayer#time_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeZone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
