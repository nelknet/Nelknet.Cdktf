using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTargetGroup
{
    [JsiiInterface(nativeType: typeof(ILbTargetGroupTargetFailover), fullyQualifiedName: "aws.lbTargetGroup.LbTargetGroupTargetFailover")]
    public interface ILbTargetGroupTargetFailover
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#on_deregistration LbTargetGroup#on_deregistration}.</summary>
        [JsiiProperty(name: "onDeregistration", typeJson: "{\"primitive\":\"string\"}")]
        string OnDeregistration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#on_unhealthy LbTargetGroup#on_unhealthy}.</summary>
        [JsiiProperty(name: "onUnhealthy", typeJson: "{\"primitive\":\"string\"}")]
        string OnUnhealthy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbTargetGroupTargetFailover), fullyQualifiedName: "aws.lbTargetGroup.LbTargetGroupTargetFailover")]
        internal sealed class _Proxy : DeputyBase, aws.LbTargetGroup.ILbTargetGroupTargetFailover
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#on_deregistration LbTargetGroup#on_deregistration}.</summary>
            [JsiiProperty(name: "onDeregistration", typeJson: "{\"primitive\":\"string\"}")]
            public string OnDeregistration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#on_unhealthy LbTargetGroup#on_unhealthy}.</summary>
            [JsiiProperty(name: "onUnhealthy", typeJson: "{\"primitive\":\"string\"}")]
            public string OnUnhealthy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
