using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiClass(nativeType: typeof(aws.EmrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference), fullyQualifiedName: "aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrClusterCoreInstanceFleetLaunchSpecificationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOnDemandSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOnDemandSpecification(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpotSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSpotSpecification(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOnDemandSpecification")]
        public virtual void ResetOnDemandSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotSpecification")]
        public virtual void ResetSpotSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "onDemandSpecification", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecificationList\"}")]
        public virtual aws.EmrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecificationList OnDemandSpecification
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecificationList>()!;
        }

        [JsiiProperty(name: "spotSpecification", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecificationList\"}")]
        public virtual aws.EmrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecificationList SpotSpecification
        {
            get => GetInstanceProperty<aws.EmrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecificationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandSpecificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsOnDemandSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OnDemandSpecificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotSpecificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecificationsSpotSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SpotSpecificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterCoreInstanceFleetLaunchSpecifications\"}", isOptional: true)]
        public virtual aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecifications? InternalValue
        {
            get => GetInstanceProperty<aws.EmrCluster.IEmrClusterCoreInstanceFleetLaunchSpecifications?>();
            set => SetInstanceProperty(value);
        }
    }
}
