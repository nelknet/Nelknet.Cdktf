using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxFunctionApp.LinuxFunctionAppSiteConfigAppServiceLogsOutputReference), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppSiteConfigAppServiceLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxFunctionAppSiteConfigAppServiceLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxFunctionAppSiteConfigAppServiceLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxFunctionAppSiteConfigAppServiceLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxFunctionAppSiteConfigAppServiceLogsOutputReference(DeputyProps props): base(props)
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppSiteConfigAppServiceLogs\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionApp.ILinuxFunctionAppSiteConfigAppServiceLogs? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppSiteConfigAppServiceLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
