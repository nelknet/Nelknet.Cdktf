using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTargetGroup
{
    [JsiiInterface(nativeType: typeof(ILbTargetGroupTargetHealthState), fullyQualifiedName: "aws.lbTargetGroup.LbTargetGroupTargetHealthState")]
    public interface ILbTargetGroupTargetHealthState
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#enable_unhealthy_connection_termination LbTargetGroup#enable_unhealthy_connection_termination}.</summary>
        [JsiiProperty(name: "enableUnhealthyConnectionTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object EnableUnhealthyConnectionTermination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#unhealthy_draining_interval LbTargetGroup#unhealthy_draining_interval}.</summary>
        [JsiiProperty(name: "unhealthyDrainingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UnhealthyDrainingInterval
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbTargetGroupTargetHealthState), fullyQualifiedName: "aws.lbTargetGroup.LbTargetGroupTargetHealthState")]
        internal sealed class _Proxy : DeputyBase, aws.LbTargetGroup.ILbTargetGroupTargetHealthState
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#enable_unhealthy_connection_termination LbTargetGroup#enable_unhealthy_connection_termination}.</summary>
            [JsiiProperty(name: "enableUnhealthyConnectionTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object EnableUnhealthyConnectionTermination
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#unhealthy_draining_interval LbTargetGroup#unhealthy_draining_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unhealthyDrainingInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnhealthyDrainingInterval
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
