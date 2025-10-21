using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsPath
{
    [JsiiClass(nativeType: typeof(aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceOutputReference), fullyQualifiedName: "aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Ec2NetworkInsightsPathFilterAtSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Ec2NetworkInsightsPathFilterAtSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected Ec2NetworkInsightsPathFilterAtSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2NetworkInsightsPathFilterAtSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestinationPortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceDestinationPortRange\"}}]")]
        public virtual void PutDestinationPortRange(aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSourceDestinationPortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSourceDestinationPortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourcePortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceSourcePortRange\"}}]")]
        public virtual void PutSourcePortRange(aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSourceSourcePortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSourceSourcePortRange)}, new object[]{@value});
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

        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceDestinationPortRangeOutputReference\"}")]
        public virtual aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceDestinationPortRangeOutputReference DestinationPortRange
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceDestinationPortRangeOutputReference>()!;
        }

        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceSourcePortRangeOutputReference\"}")]
        public virtual aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceSourcePortRangeOutputReference SourcePortRange
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceSourcePortRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationPortRangeInput", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceDestinationPortRange\"}", isOptional: true)]
        public virtual aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSourceDestinationPortRange? DestinationPortRangeInput
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSourceDestinationPortRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourcePortRangeInput", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSourceSourcePortRange\"}", isOptional: true)]
        public virtual aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSourceSourcePortRange? SourcePortRangeInput
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSourceSourcePortRange?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtSource\"}", isOptional: true)]
        public virtual aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSource? InternalValue
        {
            get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
