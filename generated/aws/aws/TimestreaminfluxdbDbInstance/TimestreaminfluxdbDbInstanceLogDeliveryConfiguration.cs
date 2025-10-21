using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreaminfluxdbDbInstance
{
    [JsiiByValue(fqn: "aws.timestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstanceLogDeliveryConfiguration")]
    public class TimestreaminfluxdbDbInstanceLogDeliveryConfiguration : aws.TimestreaminfluxdbDbInstance.ITimestreaminfluxdbDbInstanceLogDeliveryConfiguration
    {
        private object? _s3Configuration;

        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreaminfluxdb_db_instance#s3_configuration TimestreaminfluxdbDbInstance#s3_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.timestreaminfluxdbDbInstance.TimestreaminfluxdbDbInstanceLogDeliveryConfigurationS3Configuration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3Configuration
        {
            get => _s3Configuration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.TimestreaminfluxdbDbInstance.ITimestreaminfluxdbDbInstanceLogDeliveryConfigurationS3Configuration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.TimestreaminfluxdbDbInstance.ITimestreaminfluxdbDbInstanceLogDeliveryConfigurationS3Configuration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3Configuration = value;
            }
        }
    }
}
