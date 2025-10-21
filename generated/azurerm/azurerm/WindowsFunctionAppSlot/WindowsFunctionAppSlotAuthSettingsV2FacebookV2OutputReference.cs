using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.WindowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettingsV2FacebookV2OutputReference), fullyQualifiedName: "azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettingsV2FacebookV2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WindowsFunctionAppSlotAuthSettingsV2FacebookV2OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WindowsFunctionAppSlotAuthSettingsV2FacebookV2OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WindowsFunctionAppSlotAuthSettingsV2FacebookV2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsFunctionAppSlotAuthSettingsV2FacebookV2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGraphApiVersion")]
        public virtual void ResetGraphApiVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoginScopes")]
        public virtual void ResetLoginScopes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "appIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appSecretSettingNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppSecretSettingNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "graphApiVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GraphApiVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginScopesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LoginScopesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "appSecretSettingName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppSecretSettingName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "graphApiVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GraphApiVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loginScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LoginScopes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.windowsFunctionAppSlot.WindowsFunctionAppSlotAuthSettingsV2FacebookV2\"}", isOptional: true)]
        public virtual azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotAuthSettingsV2FacebookV2? InternalValue
        {
            get => GetInstanceProperty<azurerm.WindowsFunctionAppSlot.IWindowsFunctionAppSlotAuthSettingsV2FacebookV2?>();
            set => SetInstanceProperty(value);
        }
    }
}
