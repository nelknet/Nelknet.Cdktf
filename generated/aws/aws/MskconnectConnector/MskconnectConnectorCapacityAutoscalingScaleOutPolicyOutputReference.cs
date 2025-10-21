using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiClass(nativeType: typeof(aws.MskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicyOutputReference), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskconnectConnectorCapacityAutoscalingScaleOutPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskconnectConnectorCapacityAutoscalingScaleOutPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskconnectConnectorCapacityAutoscalingScaleOutPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectConnectorCapacityAutoscalingScaleOutPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCpuUtilizationPercentage")]
        public virtual void ResetCpuUtilizationPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuUtilizationPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CpuUtilizationPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "cpuUtilizationPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuUtilizationPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicy\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleOutPolicy? InternalValue
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleOutPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
