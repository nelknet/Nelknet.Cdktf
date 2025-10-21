using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAutoscalingGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_group aws_autoscaling_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroup), fullyQualifiedName: "aws.dataAwsAutoscalingGroup.DataAwsAutoscalingGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsAutoscalingGroup.DataAwsAutoscalingGroupConfig\"}}]")]
    public class DataAwsAutoscalingGroup : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_group aws_autoscaling_group} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsAutoscalingGroup(Constructs.Construct scope, string id, aws.DataAwsAutoscalingGroup.IDataAwsAutoscalingGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsAutoscalingGroup.IDataAwsAutoscalingGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAutoscalingGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAutoscalingGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsAutoscalingGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsAutoscalingGroup to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsAutoscalingGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsAutoscalingGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsAutoscalingGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsAutoscalingGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsAutoscalingGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroup))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityZones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "defaultCooldown", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultCooldown
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "desiredCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "desiredCapacityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DesiredCapacityType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabledMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledMetrics
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "healthCheckGracePeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthCheckGracePeriod
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "healthCheckType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthCheckType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceMaintenancePolicy", typeJson: "{\"fqn\":\"aws.dataAwsAutoscalingGroup.DataAwsAutoscalingGroupInstanceMaintenancePolicyList\"}")]
        public virtual aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupInstanceMaintenancePolicyList InstanceMaintenancePolicy
        {
            get => GetInstanceProperty<aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupInstanceMaintenancePolicyList>()!;
        }

        [JsiiProperty(name: "launchConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchConfiguration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.dataAwsAutoscalingGroup.DataAwsAutoscalingGroupLaunchTemplateList\"}")]
        public virtual aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupLaunchTemplateList LaunchTemplate
        {
            get => GetInstanceProperty<aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupLaunchTemplateList>()!;
        }

        [JsiiProperty(name: "loadBalancers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LoadBalancers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maxInstanceLifetime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxInstanceLifetime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mixedInstancesPolicy", typeJson: "{\"fqn\":\"aws.dataAwsAutoscalingGroup.DataAwsAutoscalingGroupMixedInstancesPolicyList\"}")]
        public virtual aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupMixedInstancesPolicyList MixedInstancesPolicy
        {
            get => GetInstanceProperty<aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupMixedInstancesPolicyList>()!;
        }

        [JsiiProperty(name: "newInstancesProtectedFromScaleIn", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable NewInstancesProtectedFromScaleIn
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "predictedCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PredictedCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "serviceLinkedRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceLinkedRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "suspendedProcesses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SuspendedProcesses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tag", typeJson: "{\"fqn\":\"aws.dataAwsAutoscalingGroup.DataAwsAutoscalingGroupTagList\"}")]
        public virtual aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupTagList Tag
        {
            get => GetInstanceProperty<aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupTagList>()!;
        }

        [JsiiProperty(name: "targetGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetGroupArns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "terminationPolicies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TerminationPolicies
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "trafficSource", typeJson: "{\"fqn\":\"aws.dataAwsAutoscalingGroup.DataAwsAutoscalingGroupTrafficSourceList\"}")]
        public virtual aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupTrafficSourceList TrafficSource
        {
            get => GetInstanceProperty<aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupTrafficSourceList>()!;
        }

        [JsiiProperty(name: "vpcZoneIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcZoneIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "warmPool", typeJson: "{\"fqn\":\"aws.dataAwsAutoscalingGroup.DataAwsAutoscalingGroupWarmPoolList\"}")]
        public virtual aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupWarmPoolList WarmPool
        {
            get => GetInstanceProperty<aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupWarmPoolList>()!;
        }

        [JsiiProperty(name: "warmPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WarmPoolSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
