using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlot
{
    [JsiiClass(nativeType: typeof(azurerm.AppServiceSlot.AppServiceSlotLogsHttpLogsAzureBlobStorageOutputReference), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsAzureBlobStorageOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppServiceSlotLogsHttpLogsAzureBlobStorageOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppServiceSlotLogsHttpLogsAzureBlobStorageOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppServiceSlotLogsHttpLogsAzureBlobStorageOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppServiceSlotLogsHttpLogsAzureBlobStorageOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sasUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SasUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "retentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sasUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SasUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsAzureBlobStorage\"}", isOptional: true)]
        public virtual azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsAzureBlobStorage? InternalValue
        {
            get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogsAzureBlobStorage?>();
            set => SetInstanceProperty(value);
        }
    }
}
