using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTargetGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lbTargetGroup.LbTargetGroupTargetHealthState")]
    public class LbTargetGroupTargetHealthState : aws.LbTargetGroup.ILbTargetGroupTargetHealthState
    {
        private object _enableUnhealthyConnectionTermination;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#enable_unhealthy_connection_termination LbTargetGroup#enable_unhealthy_connection_termination}.</summary>
        [JsiiProperty(name: "enableUnhealthyConnectionTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object EnableUnhealthyConnectionTermination
        {
            get => _enableUnhealthyConnectionTermination;
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
                _enableUnhealthyConnectionTermination = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#unhealthy_draining_interval LbTargetGroup#unhealthy_draining_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unhealthyDrainingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnhealthyDrainingInterval
        {
            get;
            set;
        }
    }
}
