using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api azurerm_api_management_api}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ApiManagementApi.ApiManagementApi), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApi", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiConfig\"}}]")]
    public class ApiManagementApi : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api azurerm_api_management_api} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApiManagementApi(Constructs.Construct scope, string id, azurerm.ApiManagementApi.IApiManagementApiConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ApiManagementApi.IApiManagementApiConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementApi(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagementApi(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ApiManagementApi resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ApiManagementApi to import.</param>
        /// <param name="importFromId">The id of the existing ApiManagementApi that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ApiManagementApi to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ApiManagementApi to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_api#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ApiManagementApi that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ApiManagementApi to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ApiManagementApi.ApiManagementApi), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putContact", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiContact\"}}]")]
        public virtual void PutContact(azurerm.ApiManagementApi.IApiManagementApiContact @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementApi.IApiManagementApiContact)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImport", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImport\"}}]")]
        public virtual void PutImport(azurerm.ApiManagementApi.IApiManagementApiImport @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementApi.IApiManagementApiImport)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLicense", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiLicense\"}}]")]
        public virtual void PutLicense(azurerm.ApiManagementApi.IApiManagementApiLicense @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementApi.IApiManagementApiLicense)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOauth2Authorization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOauth2Authorization\"}}]")]
        public virtual void PutOauth2Authorization(azurerm.ApiManagementApi.IApiManagementApiOauth2Authorization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementApi.IApiManagementApiOauth2Authorization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenidAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOpenidAuthentication\"}}]")]
        public virtual void PutOpenidAuthentication(azurerm.ApiManagementApi.IApiManagementApiOpenidAuthentication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementApi.IApiManagementApiOpenidAuthentication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubscriptionKeyParameterNames", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiSubscriptionKeyParameterNames\"}}]")]
        public virtual void PutSubscriptionKeyParameterNames(azurerm.ApiManagementApi.IApiManagementApiSubscriptionKeyParameterNames @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementApi.IApiManagementApiSubscriptionKeyParameterNames)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ApiManagementApi.IApiManagementApiTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagementApi.IApiManagementApiTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiType")]
        public virtual void ResetApiType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContact")]
        public virtual void ResetContact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImport")]
        public virtual void ResetImport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicense")]
        public virtual void ResetLicense()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauth2Authorization")]
        public virtual void ResetOauth2Authorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenidAuthentication")]
        public virtual void ResetOpenidAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocols")]
        public virtual void ResetProtocols()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRevisionDescription")]
        public virtual void ResetRevisionDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceUrl")]
        public virtual void ResetServiceUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceApiId")]
        public virtual void ResetSourceApiId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscriptionKeyParameterNames")]
        public virtual void ResetSubscriptionKeyParameterNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubscriptionRequired")]
        public virtual void ResetSubscriptionRequired()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTermsOfServiceUrl")]
        public virtual void ResetTermsOfServiceUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionDescription")]
        public virtual void ResetVersionDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionSetId")]
        public virtual void ResetVersionSetId()
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
        = GetStaticProperty<string>(typeof(azurerm.ApiManagementApi.ApiManagementApi))!;

        [JsiiProperty(name: "contact", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiContactOutputReference\"}")]
        public virtual azurerm.ApiManagementApi.ApiManagementApiContactOutputReference Contact
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.ApiManagementApiContactOutputReference>()!;
        }

        [JsiiProperty(name: "import", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImportOutputReference\"}")]
        public virtual azurerm.ApiManagementApi.ApiManagementApiImportOutputReference Import
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.ApiManagementApiImportOutputReference>()!;
        }

        [JsiiProperty(name: "isCurrent", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IsCurrent
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "isOnline", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable IsOnline
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "license", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiLicenseOutputReference\"}")]
        public virtual azurerm.ApiManagementApi.ApiManagementApiLicenseOutputReference License
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.ApiManagementApiLicenseOutputReference>()!;
        }

        [JsiiProperty(name: "oauth2Authorization", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOauth2AuthorizationOutputReference\"}")]
        public virtual azurerm.ApiManagementApi.ApiManagementApiOauth2AuthorizationOutputReference Oauth2Authorization
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.ApiManagementApiOauth2AuthorizationOutputReference>()!;
        }

        [JsiiProperty(name: "openidAuthentication", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOpenidAuthenticationOutputReference\"}")]
        public virtual azurerm.ApiManagementApi.ApiManagementApiOpenidAuthenticationOutputReference OpenidAuthentication
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.ApiManagementApiOpenidAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "subscriptionKeyParameterNames", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiSubscriptionKeyParameterNamesOutputReference\"}")]
        public virtual azurerm.ApiManagementApi.ApiManagementApiSubscriptionKeyParameterNamesOutputReference SubscriptionKeyParameterNames
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.ApiManagementApiSubscriptionKeyParameterNamesOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiTimeoutsOutputReference\"}")]
        public virtual azurerm.ApiManagementApi.ApiManagementApiTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.ApiManagementApiTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiManagementNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiManagementNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contactInput", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiContact\"}", isOptional: true)]
        public virtual azurerm.ApiManagementApi.IApiManagementApiContact? ContactInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiContact?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
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
        [JsiiProperty(name: "importInput", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiImport\"}", isOptional: true)]
        public virtual azurerm.ApiManagementApi.IApiManagementApiImport? ImportInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiImport?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseInput", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiLicense\"}", isOptional: true)]
        public virtual azurerm.ApiManagementApi.IApiManagementApiLicense? LicenseInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiLicense?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauth2AuthorizationInput", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOauth2Authorization\"}", isOptional: true)]
        public virtual azurerm.ApiManagementApi.IApiManagementApiOauth2Authorization? Oauth2AuthorizationInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiOauth2Authorization?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openidAuthenticationInput", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiOpenidAuthentication\"}", isOptional: true)]
        public virtual azurerm.ApiManagementApi.IApiManagementApiOpenidAuthentication? OpenidAuthenticationInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiOpenidAuthentication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ProtocolsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "revisionDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RevisionDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "revisionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RevisionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceApiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceApiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionKeyParameterNamesInput", typeJson: "{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiSubscriptionKeyParameterNames\"}", isOptional: true)]
        public virtual azurerm.ApiManagementApi.IApiManagementApiSubscriptionKeyParameterNames? SubscriptionKeyParameterNamesInput
        {
            get => GetInstanceProperty<azurerm.ApiManagementApi.IApiManagementApiSubscriptionKeyParameterNames?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriptionRequiredInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SubscriptionRequiredInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "termsOfServiceUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TermsOfServiceUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.apiManagementApi.ApiManagementApiTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionSetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiManagementName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "apiType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Protocols
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Revision
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "revisionDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevisionDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceApiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscriptionRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SubscriptionRequired
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

        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TermsOfServiceUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versionSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionSetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
