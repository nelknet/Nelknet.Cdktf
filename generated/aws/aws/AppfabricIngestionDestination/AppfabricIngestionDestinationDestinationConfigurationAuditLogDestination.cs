using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricIngestionDestination
{
    [JsiiByValue(fqn: "aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestination")]
    public class AppfabricIngestionDestinationDestinationConfigurationAuditLogDestination : aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestination
    {
        private object? _firehoseStream;

        /// <summary>firehose_stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#firehose_stream AppfabricIngestionDestination#firehose_stream}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firehoseStream", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FirehoseStream
        {
            get => _firehoseStream;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationFirehoseStream).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _firehoseStream = value;
            }
        }

        private object? _s3Bucket;

        /// <summary>s3_bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_ingestion_destination#s3_bucket AppfabricIngestionDestination#s3_bucket}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricIngestionDestination.AppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationS3Bucket\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3Bucket
        {
            get => _s3Bucket;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationS3Bucket[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricIngestionDestination.IAppfabricIngestionDestinationDestinationConfigurationAuditLogDestinationS3Bucket).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3Bucket = value;
            }
        }
    }
}
