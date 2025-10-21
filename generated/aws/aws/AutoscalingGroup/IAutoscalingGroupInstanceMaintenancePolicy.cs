using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupInstanceMaintenancePolicy), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceMaintenancePolicy")]
    public interface IAutoscalingGroupInstanceMaintenancePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#max_healthy_percentage AutoscalingGroup#max_healthy_percentage}.</summary>
        [JsiiProperty(name: "maxHealthyPercentage", typeJson: "{\"primitive\":\"number\"}")]
        double MaxHealthyPercentage
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#min_healthy_percentage AutoscalingGroup#min_healthy_percentage}.</summary>
        [JsiiProperty(name: "minHealthyPercentage", typeJson: "{\"primitive\":\"number\"}")]
        double MinHealthyPercentage
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupInstanceMaintenancePolicy), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceMaintenancePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingGroup.IAutoscalingGroupInstanceMaintenancePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#max_healthy_percentage AutoscalingGroup#max_healthy_percentage}.</summary>
            [JsiiProperty(name: "maxHealthyPercentage", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxHealthyPercentage
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#min_healthy_percentage AutoscalingGroup#min_healthy_percentage}.</summary>
            [JsiiProperty(name: "minHealthyPercentage", typeJson: "{\"primitive\":\"number\"}")]
            public double MinHealthyPercentage
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
