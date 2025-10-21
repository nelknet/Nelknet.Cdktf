using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiClass(nativeType: typeof(azurerm.ApiManagement.ApiManagementSignUpOutputReference), fullyQualifiedName: "azurerm.apiManagement.ApiManagementSignUpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiManagementSignUpOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiManagementSignUpOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiManagementSignUpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementSignUpOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTermsOfService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementSignUpTermsOfService\"}}]")]
        public virtual void PutTermsOfService(azurerm.ApiManagement.IApiManagementSignUpTermsOfService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagement.IApiManagementSignUpTermsOfService)}, new object[]{@value});
        }

        [JsiiProperty(name: "termsOfService", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignUpTermsOfServiceOutputReference\"}")]
        public virtual azurerm.ApiManagement.ApiManagementSignUpTermsOfServiceOutputReference TermsOfService
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementSignUpTermsOfServiceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "termsOfServiceInput", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignUpTermsOfService\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementSignUpTermsOfService? TermsOfServiceInput
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementSignUpTermsOfService?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignUp\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementSignUp? InternalValue
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementSignUp?>();
            set => SetInstanceProperty(value);
        }
    }
}
