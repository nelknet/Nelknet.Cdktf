using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappSnapshotPolicy
{
    [JsiiClass(nativeType: typeof(azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyHourlyScheduleOutputReference), fullyQualifiedName: "azurerm.netappSnapshotPolicy.NetappSnapshotPolicyHourlyScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetappSnapshotPolicyHourlyScheduleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetappSnapshotPolicyHourlyScheduleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetappSnapshotPolicyHourlyScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappSnapshotPolicyHourlyScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "minuteInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinuteInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotsToKeepInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SnapshotsToKeepInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Minute
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotsToKeep", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SnapshotsToKeep
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyHourlySchedule\"}", isOptional: true)]
        public virtual azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyHourlySchedule? InternalValue
        {
            get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyHourlySchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
