using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementDiagnostic
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic azurerm_api_management_diagnostic}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ApiManagementDiagnostic.ApiManagementDiagnostic), fullyQualifiedName: "azurerm.apiManagementDiagnostic.ApiManagementDiagnostic", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticConfig\"}}]")]
    public class ApiManagementDiagnostic : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic azurerm_api_management_diagnostic} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApiManagementDiagnostic(Constructs.Construct scope, string id, azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementDiagnostic(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementDiagnostic(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ApiManagementDiagnostic resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ApiManagementDiagnostic to import.</param>
        /// <param name="importFromId">The id of the existing ApiManagementDiagnostic that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ApiManagementDiagnostic to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ApiManagementDiagnostic to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_diagnostic#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ApiManagementDiagnostic that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ApiManagementDiagnostic to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ApiManagementDiagnostic.ApiManagementDiagnostic), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBackendRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendRequest\"}}]")]
        public virtual void PutBackendRequest(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBackendResponse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponse\"}}]")]
        public virtual void PutBackendResponse(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponse)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFrontendRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendRequest\"}}]")]
        public virtual void PutFrontendRequest(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFrontendResponse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendResponse\"}}]")]
        public virtual void PutFrontendResponse(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponse)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlwaysLogErrors")]
        public virtual void ResetAlwaysLogErrors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackendRequest")]
        public virtual void ResetBackendRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackendResponse")]
        public virtual void ResetBackendResponse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrontendRequest")]
        public virtual void ResetFrontendRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrontendResponse")]
        public virtual void ResetFrontendResponse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpCorrelationProtocol")]
        public virtual void ResetHttpCorrelationProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogClientIp")]
        public virtual void ResetLogClientIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperationNameFormat")]
        public virtual void ResetOperationNameFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSamplingPercentage")]
        public virtual void ResetSamplingPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerbosity")]
        public virtual void ResetVerbosity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.ApiManagementDiagnostic.ApiManagementDiagnostic))!;

        [JsiiProperty(name: "backendRequest", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendRequestOutputReference\"}")]
        public virtual azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticBackendRequestOutputReference BackendRequest
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticBackendRequestOutputReference>()!;
        }

        [JsiiProperty(name: "backendResponse", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponseOutputReference\"}")]
        public virtual azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticBackendResponseOutputReference BackendResponse
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticBackendResponseOutputReference>()!;
        }

        [JsiiProperty(name: "frontendRequest", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendRequestOutputReference\"}")]
        public virtual azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticFrontendRequestOutputReference FrontendRequest
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticFrontendRequestOutputReference>()!;
        }

        [JsiiProperty(name: "frontendResponse", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendResponseOutputReference\"}")]
        public virtual azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticFrontendResponseOutputReference FrontendResponse
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticFrontendResponseOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticTimeoutsOutputReference\"}")]
        public virtual azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.ApiManagementDiagnosticTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alwaysLogErrorsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AlwaysLogErrorsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiManagementLoggerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiManagementLoggerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiManagementNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiManagementNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendRequestInput", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendRequest\"}", isOptional: true)]
        public virtual azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendRequest? BackendRequestInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendResponseInput", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticBackendResponse\"}", isOptional: true)]
        public virtual azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponse? BackendResponseInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticBackendResponse?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "frontendRequestInput", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendRequest\"}", isOptional: true)]
        public virtual azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequest? FrontendRequestInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "frontendResponseInput", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendResponse\"}", isOptional: true)]
        public virtual azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponse? FrontendResponseInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendResponse?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpCorrelationProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpCorrelationProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logClientIpInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LogClientIpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operationNameFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperationNameFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samplingPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SamplingPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verbosityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VerbosityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "alwaysLogErrors", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AlwaysLogErrors
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

        [JsiiProperty(name: "apiManagementLoggerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiManagementLoggerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiManagementName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpCorrelationProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpCorrelationProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logClientIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object LogClientIp
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

        [JsiiProperty(name: "operationNameFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationNameFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "samplingPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SamplingPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "verbosity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Verbosity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
