using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2InstanceType
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2InstanceType.DataAwsEc2InstanceTypeNeuronDevicesOutputReference), fullyQualifiedName: "aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeNeuronDevicesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsEc2InstanceTypeNeuronDevicesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsEc2InstanceTypeNeuronDevicesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2InstanceTypeNeuronDevicesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2InstanceTypeNeuronDevicesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "coreVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoreVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Count
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeNeuronDevices\"}", isOptional: true)]
        public virtual aws.DataAwsEc2InstanceType.IDataAwsEc2InstanceTypeNeuronDevices? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsEc2InstanceType.IDataAwsEc2InstanceTypeNeuronDevices?>();
            set => SetInstanceProperty(value);
        }
    }
}
