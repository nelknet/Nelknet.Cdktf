using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementDiagnostic
{
    [JsiiClass(nativeType: typeof(azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticBackendResponseOutputReference), fullyQualifiedName: "azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiManagementDiagnosticBackendResponseOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiManagementDiagnosticBackendResponseOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiManagementDiagnosticBackendResponseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementDiagnosticBackendResponseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataMasking", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMasking\"}}]")]
        public virtual void PutDataMasking(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponseDataMasking @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponseDataMasking)}, new object[]{@value});
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

        [JsiiProperty(name: "dataMasking", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMaskingOutputReference\"}")]
        public virtual azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMaskingOutputReference DataMasking
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMaskingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BodyBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataMaskingInput", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseDataMasking\"}", isOptional: true)]
        public virtual azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponseDataMasking? DataMaskingInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponseDataMasking?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponse\"}", isOptional: true)]
        public virtual azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponse? InternalValue
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponse?>();
            set => SetInstanceProperty(value);
        }
    }
}
