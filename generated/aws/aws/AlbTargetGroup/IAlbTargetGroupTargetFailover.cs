using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbTargetGroup
{
    [JsiiInterface(nativeType: typeof(IAlbTargetGroupTargetFailover), fullyQualifiedName: "aws.albTargetGroup.AlbTargetGroupTargetFailover")]
    public interface IAlbTargetGroupTargetFailover
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#on_deregistration AlbTargetGroup#on_deregistration}.</summary>
        [JsiiProperty(name: "onDeregistration", typeJson: "{\"primitive\":\"string\"}")]
        string OnDeregistration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#on_unhealthy AlbTargetGroup#on_unhealthy}.</summary>
        [JsiiProperty(name: "onUnhealthy", typeJson: "{\"primitive\":\"string\"}")]
        string OnUnhealthy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbTargetGroupTargetFailover), fullyQualifiedName: "aws.albTargetGroup.AlbTargetGroupTargetFailover")]
        internal sealed class _Proxy : DeputyBase, aws.AlbTargetGroup.IAlbTargetGroupTargetFailover
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#on_deregistration AlbTargetGroup#on_deregistration}.</summary>
            [JsiiProperty(name: "onDeregistration", typeJson: "{\"primitive\":\"string\"}")]
            public string OnDeregistration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#on_unhealthy AlbTargetGroup#on_unhealthy}.</summary>
            [JsiiProperty(name: "onUnhealthy", typeJson: "{\"primitive\":\"string\"}")]
            public string OnUnhealthy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
