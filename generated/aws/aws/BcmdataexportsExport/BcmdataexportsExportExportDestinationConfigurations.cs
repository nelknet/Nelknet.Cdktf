using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BcmdataexportsExport
{
    [JsiiByValue(fqn: "aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurations")]
    public class BcmdataexportsExportExportDestinationConfigurations : aws.BcmdataexportsExport.IBcmdataexportsExportExportDestinationConfigurations
    {
        private object? _s3Destination;

        /// <summary>s3_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#s3_destination BcmdataexportsExport#s3_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bcmdataexportsExport.BcmdataexportsExportExportDestinationConfigurationsS3Destination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3Destination
        {
            get => _s3Destination;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BcmdataexportsExport.IBcmdataexportsExportExportDestinationConfigurationsS3Destination[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BcmdataexportsExport.IBcmdataexportsExportExportDestinationConfigurationsS3Destination).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3Destination = value;
            }
        }
    }
}
