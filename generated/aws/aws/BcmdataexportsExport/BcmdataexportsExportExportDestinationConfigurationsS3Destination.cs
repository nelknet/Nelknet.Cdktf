using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BcmdataexportsExport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurationsS3Destination")]
    public class BcmdataexportsExportExportDestinationConfigurationsS3Destination : aws.BcmdataexportsExport.IBcmdataexportsExportExportDestinationConfigurationsS3Destination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_bucket BcmdataexportsExport#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_prefix BcmdataexportsExport#s3_prefix}.</summary>
        [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_region BcmdataexportsExport#s3_region}.</summary>
        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Region
        {
            get;
            set;
        }

        private object? _s3OutputConfigurations;

        /// <summary>s3_output_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_output_configurations BcmdataexportsExport#s3_output_configurations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3OutputConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3OutputConfigurations
        {
            get => _s3OutputConfigurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BcmdataexportsExport.IBcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BcmdataexportsExport.IBcmdataexportsExportExportDestinationConfigurationsS3DestinationS3OutputConfigurations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3OutputConfigurations = value;
            }
        }
    }
}
