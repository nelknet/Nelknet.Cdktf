using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsPath
{
    [JsiiClass(nativeType: typeof(aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationOutputReference), fullyQualifiedName: "aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Ec2NetworkInsightsPathFilterAtDestinationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Ec2NetworkInsightsPathFilterAtDestinationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Ec2NetworkInsightsPathFilterAtDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2NetworkInsightsPathFilterAtDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestinationPortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationDestinationPortRange\"}}]")]
        public virtual void PutDestinationPortRange(aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationDestinationPortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationDestinationPortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourcePortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationSourcePortRange\"}}]")]
        public virtual void PutSourcePortRange(aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationSourcePortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationSourcePortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationAddress")]
        public virtual void ResetDestinationAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationPortRange")]
        public virtual void ResetDestinationPortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceAddress")]
        public virtual void ResetSourceAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourcePortRange")]
        public virtual void ResetSourcePortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationDestinationPortRangeOutputReference\"}")]
        public virtual aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationDestinationPortRangeOutputReference DestinationPortRange
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationDestinationPortRangeOutputReference>()!;
        }

        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationSourcePortRangeOutputReference\"}")]
        public virtual aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationSourcePortRangeOutputReference SourcePortRange
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationSourcePortRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRangeInput", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationDestinationPortRange\"}", isOptional: true)]
        public virtual aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationDestinationPortRange? DestinationPortRangeInput
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationDestinationPortRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRangeInput", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationSourcePortRange\"}", isOptional: true)]
        public virtual aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationSourcePortRange? SourcePortRangeInput
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationSourcePortRange?>();
        }

        [JsiiProperty(name: "destinationAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestination\"}", isOptional: true)]
        public virtual aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestination? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
