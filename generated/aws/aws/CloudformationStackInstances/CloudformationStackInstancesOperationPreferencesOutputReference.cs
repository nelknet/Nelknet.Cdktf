using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudformationStackInstances
{
    [JsiiClass(nativeType: typeof(aws.CloudformationStackInstances.CloudformationStackInstancesOperationPreferencesOutputReference), fullyQualifiedName: "aws.cloudformationStackInstances.CloudformationStackInstancesOperationPreferencesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudformationStackInstancesOperationPreferencesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudformationStackInstancesOperationPreferencesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudformationStackInstancesOperationPreferencesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudformationStackInstancesOperationPreferencesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConcurrencyMode")]
        public virtual void ResetConcurrencyMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailureToleranceCount")]
        public virtual void ResetFailureToleranceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailureTolerancePercentage")]
        public virtual void ResetFailureTolerancePercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxConcurrentCount")]
        public virtual void ResetMaxConcurrentCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxConcurrentPercentage")]
        public virtual void ResetMaxConcurrentPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegionConcurrencyType")]
        public virtual void ResetRegionConcurrencyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegionOrder")]
        public virtual void ResetRegionOrder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "concurrencyModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConcurrencyModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failureToleranceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FailureToleranceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failureTolerancePercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FailureTolerancePercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConcurrentCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConcurrentPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionConcurrencyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionConcurrencyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionOrderInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RegionOrderInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "concurrencyMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConcurrencyMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "failureToleranceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailureToleranceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "failureTolerancePercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailureTolerancePercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxConcurrentCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConcurrentCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxConcurrentPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConcurrentPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "regionConcurrencyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionConcurrencyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "regionOrder", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RegionOrder
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesOperationPreferences\"}", isOptional: true)]
        public virtual aws.CloudformationStackInstances.ICloudformationStackInstancesOperationPreferences? InternalValue
        {
            get => GetInstanceProperty<aws.CloudformationStackInstances.ICloudformationStackInstancesOperationPreferences?>();
            set => SetInstanceProperty(value);
        }
    }
}
