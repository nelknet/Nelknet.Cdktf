using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiDiagnostic
{
    [JsiiClass(nativeType: typeof(azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseOutputReference), fullyQualifiedName: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiManagementApiDiagnosticBackendResponseOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiManagementApiDiagnosticBackendResponseOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiManagementApiDiagnosticBackendResponseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementApiDiagnosticBackendResponseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataMasking", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseDataMasking\"}}]")]
        public virtual void PutDataMasking(azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMasking @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMasking)}, new object[]{@value});
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

        [JsiiProperty(name: "dataMasking", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseDataMaskingOutputReference\"}")]
        public virtual azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseDataMaskingOutputReference DataMasking
        {
            get => GetInstanceProperty<azurerm.ApiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseDataMaskingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyBytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BodyBytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataMaskingInput", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseDataMasking\"}", isOptional: true)]
        public virtual azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMasking? DataMaskingInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMasking?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponse\"}", isOptional: true)]
        public virtual azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponse? InternalValue
        {
            get => GetInstanceProperty<azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponse?>();
            set => SetInstanceProperty(value);
        }
    }
}
