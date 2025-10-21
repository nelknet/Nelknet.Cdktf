using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GameliftGameServerGroup
{
    [JsiiInterface(nativeType: typeof(IGameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration), fullyQualifiedName: "aws.gameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration")]
    public interface IGameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#target_value GameliftGameServerGroup#target_value}.</summary>
        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        double TargetValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration), fullyQualifiedName: "aws.gameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.GameliftGameServerGroup.IGameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_server_group#target_value GameliftGameServerGroup#target_value}.</summary>
            [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
            public double TargetValue
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
