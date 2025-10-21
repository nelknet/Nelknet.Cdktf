using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2OutputReference), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WindowsFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WindowsFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WindowsFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2\"}", isOptional: true)]
        public virtual azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2? InternalValue
        {
            get => GetInstanceProperty<azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotAuthSettingsV2AzureStaticWebAppV2?>();
            set => SetInstanceProperty(value);
        }
    }
}
