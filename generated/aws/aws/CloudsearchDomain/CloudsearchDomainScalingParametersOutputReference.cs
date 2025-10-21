using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudsearchDomain
{
    [JsiiClass(nativeType: typeof(aws.CloudsearchDomain.CloudsearchDomainScalingParametersOutputReference), fullyQualifiedName: "aws.cloudsearchDomain.CloudsearchDomainScalingParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudsearchDomainScalingParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudsearchDomainScalingParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudsearchDomainScalingParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudsearchDomainScalingParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDesiredInstanceType")]
        public virtual void ResetDesiredInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesiredPartitionCount")]
        public virtual void ResetDesiredPartitionCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDesiredReplicationCount")]
        public virtual void ResetDesiredReplicationCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredInstanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DesiredInstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredPartitionCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredPartitionCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "desiredReplicationCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DesiredReplicationCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "desiredInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DesiredInstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "desiredPartitionCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredPartitionCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "desiredReplicationCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DesiredReplicationCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainScalingParameters\"}", isOptional: true)]
        public virtual aws.CloudsearchDomain.ICloudsearchDomainScalingParameters? InternalValue
        {
            get => GetInstanceProperty<aws.CloudsearchDomain.ICloudsearchDomainScalingParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
