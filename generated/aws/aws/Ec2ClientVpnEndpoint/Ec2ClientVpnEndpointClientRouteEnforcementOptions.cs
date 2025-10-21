using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2ClientVpnEndpoint
{
    [JsiiByValue(fqn: "aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientRouteEnforcementOptions")]
    public class Ec2ClientVpnEndpointClientRouteEnforcementOptions : aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientRouteEnforcementOptions
    {
        private object? _enforced;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#enforced Ec2ClientVpnEndpoint#enforced}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enforced", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enforced
        {
            get => _enforced;
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
                _enforced = value;
            }
        }
    }
}
