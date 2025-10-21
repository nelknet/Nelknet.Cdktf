using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotFleetRequest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfig")]
    public class SpotFleetRequestLaunchTemplateConfig : aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfig
    {
        /// <summary>launch_template_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#launch_template_specification SpotFleetRequest#launch_template_specification}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateSpecification", typeJson: "{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification\"}")]
        public aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigLaunchTemplateSpecification LaunchTemplateSpecification
        {
            get;
            set;
        }

        private object? _overrides;

        /// <summary>overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#overrides SpotFleetRequest#overrides}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "overrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.spotFleetRequest.SpotFleetRequestLaunchTemplateConfigOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Overrides
        {
            get => _overrides;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverrides[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SpotFleetRequest.ISpotFleetRequestLaunchTemplateConfigOverrides).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _overrides = value;
            }
        }
    }
}
