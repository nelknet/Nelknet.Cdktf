using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GameliftGameServerGroup
{
    [JsiiClass(nativeType: typeof(aws.GameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyOutputReference), fullyQualifiedName: "aws.gameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GameliftGameServerGroupAutoScalingPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GameliftGameServerGroupAutoScalingPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftGameServerGroupAutoScalingPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GameliftGameServerGroupAutoScalingPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTargetTrackingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration\"}}]")]
        public virtual void PutTargetTrackingConfiguration(aws.GameliftGameServerGroup.IGameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GameliftGameServerGroup.IGameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEstimatedInstanceWarmup")]
        public virtual void ResetEstimatedInstanceWarmup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "targetTrackingConfiguration", typeJson: "{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyTargetTrackingConfigurationOutputReference\"}")]
        public virtual aws.GameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyTargetTrackingConfigurationOutputReference TargetTrackingConfiguration
        {
            get => GetInstanceProperty<aws.GameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyTargetTrackingConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "estimatedInstanceWarmupInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EstimatedInstanceWarmupInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetTrackingConfigurationInput", typeJson: "{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration\"}", isOptional: true)]
        public virtual aws.GameliftGameServerGroup.IGameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration? TargetTrackingConfigurationInput
        {
            get => GetInstanceProperty<aws.GameliftGameServerGroup.IGameliftGameServerGroupAutoScalingPolicyTargetTrackingConfiguration?>();
        }

        [JsiiProperty(name: "estimatedInstanceWarmup", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EstimatedInstanceWarmup
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.gameliftGameServerGroup.GameliftGameServerGroupAutoScalingPolicy\"}", isOptional: true)]
        public virtual aws.GameliftGameServerGroup.IGameliftGameServerGroupAutoScalingPolicy? InternalValue
        {
            get => GetInstanceProperty<aws.GameliftGameServerGroup.IGameliftGameServerGroupAutoScalingPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
