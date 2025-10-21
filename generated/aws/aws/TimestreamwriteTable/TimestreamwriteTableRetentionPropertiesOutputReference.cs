using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamwriteTable
{
    [JsiiClass(nativeType: typeof(aws.TimestreamwriteTable.TimestreamwriteTableRetentionPropertiesOutputReference), fullyQualifiedName: "aws.timestreamwriteTable.TimestreamwriteTableRetentionPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TimestreamwriteTableRetentionPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TimestreamwriteTableRetentionPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected TimestreamwriteTableRetentionPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TimestreamwriteTableRetentionPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "magneticStoreRetentionPeriodInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MagneticStoreRetentionPeriodInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryStoreRetentionPeriodInHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryStoreRetentionPeriodInHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "magneticStoreRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MagneticStoreRetentionPeriodInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryStoreRetentionPeriodInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryStoreRetentionPeriodInHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableRetentionProperties\"}", isOptional: true)]
        public virtual aws.TimestreamwriteTable.ITimestreamwriteTableRetentionProperties? InternalValue
        {
            get => GetInstanceProperty<aws.TimestreamwriteTable.ITimestreamwriteTableRetentionProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
