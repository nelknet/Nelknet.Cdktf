using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchSchedulingPolicy
{
    [JsiiClass(nativeType: typeof(aws.BatchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyOutputReference), fullyQualifiedName: "aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchSchedulingPolicyFairSharePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchSchedulingPolicyFairSharePolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BatchSchedulingPolicyFairSharePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchSchedulingPolicyFairSharePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putShareDistribution", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyShareDistribution\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutShareDistribution(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.BatchSchedulingPolicy.IBatchSchedulingPolicyFairSharePolicyShareDistribution[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchSchedulingPolicy.IBatchSchedulingPolicyFairSharePolicyShareDistribution).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchSchedulingPolicy.IBatchSchedulingPolicyFairSharePolicyShareDistribution).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComputeReservation")]
        public virtual void ResetComputeReservation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareDecaySeconds")]
        public virtual void ResetShareDecaySeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareDistribution")]
        public virtual void ResetShareDistribution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "shareDistribution", typeJson: "{\"fqn\":\"aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyShareDistributionList\"}")]
        public virtual aws.BatchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyShareDistributionList ShareDistribution
        {
            get => GetInstanceProperty<aws.BatchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyShareDistributionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeReservationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ComputeReservationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareDecaySecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ShareDecaySecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareDistributionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyShareDistribution\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ShareDistributionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "computeReservation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputeReservation
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shareDecaySeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ShareDecaySeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicy\"}", isOptional: true)]
        public virtual aws.BatchSchedulingPolicy.IBatchSchedulingPolicyFairSharePolicy? InternalValue
        {
            get => GetInstanceProperty<aws.BatchSchedulingPolicy.IBatchSchedulingPolicyFairSharePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
