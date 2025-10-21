using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSourceControl
{
    [JsiiClass(nativeType: typeof(azurerm.AutomationSourceControl.AutomationSourceControlSecurityOutputReference), fullyQualifiedName: "azurerm.automationSourceControl.AutomationSourceControlSecurityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutomationSourceControlSecurityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutomationSourceControlSecurityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutomationSourceControlSecurityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomationSourceControlSecurityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRefreshToken")]
        public virtual void ResetRefreshToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RefreshTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TokenTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "refreshToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefreshToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Token
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tokenType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.automationSourceControl.AutomationSourceControlSecurity\"}", isOptional: true)]
        public virtual azurerm.AutomationSourceControl.IAutomationSourceControlSecurity? InternalValue
        {
            get => GetInstanceProperty<azurerm.AutomationSourceControl.IAutomationSourceControlSecurity?>();
            set => SetInstanceProperty(value);
        }
    }
}
