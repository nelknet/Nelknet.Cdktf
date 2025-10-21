using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecification")]
    public class LaunchTemplateNetworkInterfacesEnaSrdSpecification : aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecification
    {
        private object? _enaSrdEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#ena_srd_enabled LaunchTemplate#ena_srd_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enaSrdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnaSrdEnabled
        {
            get => _enaSrdEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enaSrdEnabled = value;
            }
        }

        /// <summary>ena_srd_udp_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#ena_srd_udp_specification LaunchTemplate#ena_srd_udp_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enaSrdUdpSpecification", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification\"}", isOptional: true)]
        public aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification? EnaSrdUdpSpecification
        {
            get;
            set;
        }
    }
}
