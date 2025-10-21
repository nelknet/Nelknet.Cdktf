using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiClass(nativeType: typeof(aws.EmrCluster.EmrClusterMasterInstanceFleetOutputReference), fullyQualifiedName: "aws.emrCluster.EmrClusterMasterInstanceFleetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrClusterMasterInstanceFleetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrClusterMasterInstanceFleetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmrClusterMasterInstanceFleetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrClusterMasterInstanceFleetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstanceTypeConfigs", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInstanceTypeConfigs(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EmrCluster.IEmrClusterMasterInstanceFleetInstanceTypeConfigs[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterMasterInstanceFleetInstanceTypeConfigs).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterMasterInstanceFleetInstanceTypeConfigs).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLaunchSpecifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleetLaunchSpecifications\"}}]")]
        public virtual void PutLaunchSpecifications(aws.EmrCluster.IEmrClusterMasterInstanceFleetLaunchSpecifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrCluster.IEmrClusterMasterInstanceFleetLaunchSpecifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstanceTypeConfigs")]
        public virtual void ResetInstanceTypeConfigs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchSpecifications")]
        public virtual void ResetLaunchSpecifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetOnDemandCapacity")]
        public virtual void ResetTargetOnDemandCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetSpotCapacity")]
        public virtual void ResetTargetSpotCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceTypeConfigs", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleetInstanceTypeConfigsList\"}")]
        public virtual aws.EmrCluster.EmrClusterMasterInstanceFleetInstanceTypeConfigsList InstanceTypeConfigs
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterMasterInstanceFleetInstanceTypeConfigsList>()!;
        }

        [JsiiProperty(name: "launchSpecifications", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference\"}")]
        public virtual aws.EmrCluster.EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference LaunchSpecifications
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterMasterInstanceFleetLaunchSpecificationsOutputReference>()!;
        }

        [JsiiProperty(name: "provisionedOnDemandCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedOnDemandCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "provisionedSpotCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedSpotCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeConfigsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InstanceTypeConfigsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchSpecificationsInput", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleetLaunchSpecifications\"}", isOptional: true)]
        public virtual aws.EmrCluster.IEmrClusterMasterInstanceFleetLaunchSpecifications? LaunchSpecificationsInput
        {
            get => GetInstanceProperty<aws.EmrCluster.IEmrClusterMasterInstanceFleetLaunchSpecifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetOnDemandCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetOnDemandCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetSpotCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetSpotCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetOnDemandCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetOnDemandCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetSpotCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetSpotCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterMasterInstanceFleet\"}", isOptional: true)]
        public virtual aws.EmrCluster.IEmrClusterMasterInstanceFleet? InternalValue
        {
            get => GetInstanceProperty<aws.EmrCluster.IEmrClusterMasterInstanceFleet?>();
            set => SetInstanceProperty(value);
        }
    }
}
