using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FunctionAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.FunctionAppSlot.FunctionAppSlotAuthSettingsTwitterOutputReference), fullyQualifiedName: "azurerm.functionAppSlot.FunctionAppSlotAuthSettingsTwitterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FunctionAppSlotAuthSettingsTwitterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FunctionAppSlotAuthSettingsTwitterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FunctionAppSlotAuthSettingsTwitterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionAppSlotAuthSettingsTwitterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "consumerKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConsumerKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "consumerSecretInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConsumerSecretInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerSecret
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.functionAppSlot.FunctionAppSlotAuthSettingsTwitter\"}", isOptional: true)]
        public virtual azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsTwitter? InternalValue
        {
            get => GetInstanceProperty<azurerm.FunctionAppSlot.IFunctionAppSlotAuthSettingsTwitter?>();
            set => SetInstanceProperty(value);
        }
    }
}
