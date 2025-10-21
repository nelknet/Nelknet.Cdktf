using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigAppServiceLogsOutputReference), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigAppServiceLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxFunctionAppSlotSiteConfigAppServiceLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxFunctionAppSlotSiteConfigAppServiceLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxFunctionAppSlotSiteConfigAppServiceLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxFunctionAppSlotSiteConfigAppServiceLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDiskQuotaMb")]
        public virtual void ResetDiskQuotaMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionPeriodDays")]
        public virtual void ResetRetentionPeriodDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskQuotaMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DiskQuotaMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionPeriodDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "diskQuotaMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DiskQuotaMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retentionPeriodDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionPeriodDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotSiteConfigAppServiceLogs\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfigAppServiceLogs? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotSiteConfigAppServiceLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
