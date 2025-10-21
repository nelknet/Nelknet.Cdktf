using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbTargetGroup
{
    [JsiiInterface(nativeType: typeof(IAlbTargetGroupTargetGroupHealthDnsFailover), fullyQualifiedName: "aws.albTargetGroup.AlbTargetGroupTargetGroupHealthDnsFailover")]
    public interface IAlbTargetGroupTargetGroupHealthDnsFailover
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#minimum_healthy_targets_count AlbTargetGroup#minimum_healthy_targets_count}.</summary>
        [JsiiProperty(name: "minimumHealthyTargetsCount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinimumHealthyTargetsCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#minimum_healthy_targets_percentage AlbTargetGroup#minimum_healthy_targets_percentage}.</summary>
        [JsiiProperty(name: "minimumHealthyTargetsPercentage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinimumHealthyTargetsPercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbTargetGroupTargetGroupHealthDnsFailover), fullyQualifiedName: "aws.albTargetGroup.AlbTargetGroupTargetGroupHealthDnsFailover")]
        internal sealed class _Proxy : DeputyBase, aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthDnsFailover
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#minimum_healthy_targets_count AlbTargetGroup#minimum_healthy_targets_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumHealthyTargetsCount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinimumHealthyTargetsCount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#minimum_healthy_targets_percentage AlbTargetGroup#minimum_healthy_targets_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumHealthyTargetsPercentage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinimumHealthyTargetsPercentage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
