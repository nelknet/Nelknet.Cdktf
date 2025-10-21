using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    [JsiiClass(nativeType: typeof(azurerm.ApiManagementApi.ApiManagementApiImportOutputReference), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiImportOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiManagementApiImportOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiManagementApiImportOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiManagementApiImportOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementApiImportOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putWsdlSelector", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImportWsdlSelector\"}}]")]
        public virtual void PutWsdlSelector(azurerm.ApiManagementApi.IApiManagementApiImportWsdlSelector @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementApi.IApiManagementApiImportWsdlSelector)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetWsdlSelector")]
        public virtual void ResetWsdlSelector()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "wsdlSelector", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImportWsdlSelectorOutputReference\"}")]
        public virtual azurerm.ApiManagementApi.ApiManagementApiImportWsdlSelectorOutputReference WsdlSelector
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.ApiManagementApiImportWsdlSelectorOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "wsdlSelectorInput", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImportWsdlSelector\"}", isOptional: true)]
        public virtual azurerm.ApiManagementApi.IApiManagementApiImportWsdlSelector? WsdlSelectorInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiImportWsdlSelector?>();
        }

        [JsiiProperty(name: "contentFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImport\"}", isOptional: true)]
        public virtual azurerm.ApiManagementApi.IApiManagementApiImport? InternalValue
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiImport?>();
            set => SetInstanceProperty(value);
        }
    }
}
