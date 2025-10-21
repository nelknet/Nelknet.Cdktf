using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiClass(nativeType: typeof(aws.MskconnectConnector.MskconnectConnectorCapacityAutoscalingOutputReference), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskconnectConnectorCapacityAutoscalingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskconnectConnectorCapacityAutoscalingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskconnectConnectorCapacityAutoscalingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectConnectorCapacityAutoscalingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScaleInPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleInPolicy\"}}]")]
        public virtual void PutScaleInPolicy(aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleInPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleInPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScaleOutPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicy\"}}]")]
        public virtual void PutScaleOutPolicy(aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleOutPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleOutPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMcuCount")]
        public virtual void ResetMcuCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleInPolicy")]
        public virtual void ResetScaleInPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleOutPolicy")]
        public virtual void ResetScaleOutPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "scaleInPolicy", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleInPolicyOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleInPolicyOutputReference ScaleInPolicy
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleInPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "scaleOutPolicy", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicyOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicyOutputReference ScaleOutPolicy
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxWorkerCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxWorkerCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mcuCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? McuCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minWorkerCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinWorkerCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInPolicyInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleInPolicy\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleInPolicy? ScaleInPolicyInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleInPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleOutPolicyInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicy\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleOutPolicy? ScaleOutPolicyInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleOutPolicy?>();
        }

        [JsiiProperty(name: "maxWorkerCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxWorkerCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mcuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double McuCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minWorkerCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinWorkerCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscaling\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling? InternalValue
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling?>();
            set => SetInstanceProperty(value);
        }
    }
}
