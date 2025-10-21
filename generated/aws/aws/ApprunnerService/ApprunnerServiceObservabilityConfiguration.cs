using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apprunnerService.ApprunnerServiceObservabilityConfiguration")]
    public class ApprunnerServiceObservabilityConfiguration : aws.ApprunnerService.IApprunnerServiceObservabilityConfiguration
    {
        private object _observabilityEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#observability_enabled ApprunnerService#observability_enabled}.</summary>
        [JsiiProperty(name: "observabilityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object ObservabilityEnabled
        {
            get => _observabilityEnabled;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _observabilityEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#observability_configuration_arn ApprunnerService#observability_configuration_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "observabilityConfigurationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObservabilityConfigurationArn
        {
            get;
            set;
        }
    }
}
