using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementDiagnostic
{
    [JsiiClass(nativeType: typeof(azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticFrontendResponseOutputReference), fullyQualifiedName: "azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendResponseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiManagementDiagnosticFrontendResponseOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiManagementDiagnosticFrontendResponseOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiManagementDiagnosticFrontendResponseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementDiagnosticFrontendResponseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataMasking", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendResponseDataMasking\"}}]")]
        public virtual void PutDataMasking(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponseDataMasking @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponseDataMasking)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBodyBytes")]
        public virtual void ResetBodyBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataMasking")]
        public virtual void ResetDataMasking()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeadersToLog")]
        public virtual void ResetHeadersToLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dataMasking", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendResponseDataMaskingOutputReference\"}")]
        public virtual azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticFrontendResponseDataMaskingOutputReference DataMasking
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticFrontendResponseDataMaskingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BodyBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataMaskingInput", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendResponseDataMasking\"}", isOptional: true)]
        public virtual azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponseDataMasking? DataMaskingInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponseDataMasking?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headersToLogInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? HeadersToLogInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "bodyBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BodyBytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "headersToLog", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HeadersToLog
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendResponse\"}", isOptional: true)]
        public virtual azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponse? InternalValue
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponse?>();
            set => SetInstanceProperty(value);
        }
    }
}
