using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiClass(nativeType: typeof(aws.MskconnectConnector.MskconnectConnectorCapacityOutputReference), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorCapacityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskconnectConnectorCapacityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskconnectConnectorCapacityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MskconnectConnectorCapacityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectConnectorCapacityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoscaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscaling\"}}]")]
        public virtual void PutAutoscaling(aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProvisionedCapacity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityProvisionedCapacity\"}}]")]
        public virtual void PutProvisionedCapacity(aws.MskconnectConnector.IMskconnectConnectorCapacityProvisionedCapacity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MskconnectConnector.IMskconnectConnectorCapacityProvisionedCapacity)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoscaling")]
        public virtual void ResetAutoscaling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvisionedCapacity")]
        public virtual void ResetProvisionedCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorCapacityAutoscalingOutputReference Autoscaling
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorCapacityAutoscalingOutputReference>()!;
        }

        [JsiiProperty(name: "provisionedCapacity", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityProvisionedCapacityOutputReference\"}")]
        public virtual aws.MskconnectConnector.MskconnectConnectorCapacityProvisionedCapacityOutputReference ProvisionedCapacity
        {
            get => GetInstanceProperty<aws.MskconnectConnector.MskconnectConnectorCapacityProvisionedCapacityOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityAutoscaling\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling? AutoscalingInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscaling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisionedCapacityInput", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacityProvisionedCapacity\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorCapacityProvisionedCapacity? ProvisionedCapacityInput
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacityProvisionedCapacity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorCapacity\"}", isOptional: true)]
        public virtual aws.MskconnectConnector.IMskconnectConnectorCapacity? InternalValue
        {
            get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorCapacity?>();
            set => SetInstanceProperty(value);
        }
    }
}
