using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management azurerm_api_management}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ApiManagement.ApiManagement), fullyQualifiedName: "azurerm.apiManagement.ApiManagement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementConfig\"}}]")]
    public class ApiManagement : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management azurerm_api_management} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApiManagement(Constructs.Construct scope, string id, azurerm.ApiManagement.IApiManagementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ApiManagement.IApiManagementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiManagement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ApiManagement resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ApiManagement to import.</param>
        /// <param name="importFromId">The id of the existing ApiManagement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ApiManagement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ApiManagement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ApiManagement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ApiManagement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ApiManagement.ApiManagement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdditionalLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementAdditionalLocation\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAdditionalLocation(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ApiManagement.IApiManagementAdditionalLocation[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementAdditionalLocation).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementAdditionalLocation).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementCertificate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCertificate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ApiManagement.IApiManagementCertificate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementCertificate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagement.IApiManagementCertificate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDelegation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementDelegation\"}}]")]
        public virtual void PutDelegation(azurerm.ApiManagement.IApiManagementDelegation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagement.IApiManagementDelegation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHostnameConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfiguration\"}}]")]
        public virtual void PutHostnameConfiguration(azurerm.ApiManagement.IApiManagementHostnameConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagement.IApiManagementHostnameConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.ApiManagement.IApiManagementIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagement.IApiManagementIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProtocols", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementProtocols\"}}]")]
        public virtual void PutProtocols(azurerm.ApiManagement.IApiManagementProtocols @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagement.IApiManagementProtocols)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementSecurity\"}}]")]
        public virtual void PutSecurity(azurerm.ApiManagement.IApiManagementSecurity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagement.IApiManagementSecurity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSignIn", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementSignIn\"}}]")]
        public virtual void PutSignIn(azurerm.ApiManagement.IApiManagementSignIn @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagement.IApiManagementSignIn)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSignUp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementSignUp\"}}]")]
        public virtual void PutSignUp(azurerm.ApiManagement.IApiManagementSignUp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagement.IApiManagementSignUp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTenantAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementTenantAccess\"}}]")]
        public virtual void PutTenantAccess(azurerm.ApiManagement.IApiManagementTenantAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagement.IApiManagementTenantAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ApiManagement.IApiManagementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagement.IApiManagementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVirtualNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.apiManagement.ApiManagementVirtualNetworkConfiguration\"}}]")]
        public virtual void PutVirtualNetworkConfiguration(azurerm.ApiManagement.IApiManagementVirtualNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApiManagement.IApiManagementVirtualNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalLocation")]
        public virtual void ResetAdditionalLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateEnabled")]
        public virtual void ResetClientCertificateEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDelegation")]
        public virtual void ResetDelegation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGatewayDisabled")]
        public virtual void ResetGatewayDisabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostnameConfiguration")]
        public virtual void ResetHostnameConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinApiVersion")]
        public virtual void ResetMinApiVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationSenderEmail")]
        public virtual void ResetNotificationSenderEmail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocols")]
        public virtual void ResetProtocols()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicIpAddressId")]
        public virtual void ResetPublicIpAddressId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicNetworkAccessEnabled")]
        public virtual void ResetPublicNetworkAccessEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurity")]
        public virtual void ResetSecurity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSignIn")]
        public virtual void ResetSignIn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSignUp")]
        public virtual void ResetSignUp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTenantAccess")]
        public virtual void ResetTenantAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualNetworkConfiguration")]
        public virtual void ResetVirtualNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualNetworkType")]
        public virtual void ResetVirtualNetworkType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZones")]
        public virtual void ResetZones()
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
        = GetStaticProperty<string>(typeof(azurerm.ApiManagement.ApiManagement))!;

        [JsiiProperty(name: "additionalLocation", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementAdditionalLocationList\"}")]
        public virtual azurerm.ApiManagement.ApiManagementAdditionalLocationList AdditionalLocation
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementAdditionalLocationList>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementCertificateList\"}")]
        public virtual azurerm.ApiManagement.ApiManagementCertificateList Certificate
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementCertificateList>()!;
        }

        [JsiiProperty(name: "delegation", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementDelegationOutputReference\"}")]
        public virtual azurerm.ApiManagement.ApiManagementDelegationOutputReference Delegation
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementDelegationOutputReference>()!;
        }

        [JsiiProperty(name: "developerPortalUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeveloperPortalUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayRegionalUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayRegionalUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostnameConfiguration", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfigurationOutputReference\"}")]
        public virtual azurerm.ApiManagement.ApiManagementHostnameConfigurationOutputReference HostnameConfiguration
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementHostnameConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementIdentityOutputReference\"}")]
        public virtual azurerm.ApiManagement.ApiManagementIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "managementApiUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementApiUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "portalUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortalUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PrivateIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "protocols", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementProtocolsOutputReference\"}")]
        public virtual azurerm.ApiManagement.ApiManagementProtocolsOutputReference Protocols
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementProtocolsOutputReference>()!;
        }

        [JsiiProperty(name: "publicIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PublicIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scmUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScmUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSecurityOutputReference\"}")]
        public virtual azurerm.ApiManagement.ApiManagementSecurityOutputReference Security
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementSecurityOutputReference>()!;
        }

        [JsiiProperty(name: "signIn", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignInOutputReference\"}")]
        public virtual azurerm.ApiManagement.ApiManagementSignInOutputReference SignIn
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementSignInOutputReference>()!;
        }

        [JsiiProperty(name: "signUp", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignUpOutputReference\"}")]
        public virtual azurerm.ApiManagement.ApiManagementSignUpOutputReference SignUp
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementSignUpOutputReference>()!;
        }

        [JsiiProperty(name: "tenantAccess", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementTenantAccessOutputReference\"}")]
        public virtual azurerm.ApiManagement.ApiManagementTenantAccessOutputReference TenantAccess
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementTenantAccessOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementTimeoutsOutputReference\"}")]
        public virtual azurerm.ApiManagement.ApiManagementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "virtualNetworkConfiguration", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementVirtualNetworkConfigurationOutputReference\"}")]
        public virtual azurerm.ApiManagement.ApiManagementVirtualNetworkConfigurationOutputReference VirtualNetworkConfiguration
        {
            get => GetInstanceProperty<azurerm.ApiManagement.ApiManagementVirtualNetworkConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalLocationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementAdditionalLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AdditionalLocationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagement.ApiManagementCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ClientCertificateEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "delegationInput", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementDelegation\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementDelegation? DelegationInput
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementDelegation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayDisabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? GatewayDisabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameConfigurationInput", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementHostnameConfiguration\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementHostnameConfiguration? HostnameConfigurationInput
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementHostnameConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementIdentity\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minApiVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinApiVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationSenderEmailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NotificationSenderEmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolsInput", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementProtocols\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementProtocols? ProtocolsInput
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementProtocols?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicIpAddressIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicIpAddressIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicNetworkAccessEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublicNetworkAccessEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publisherEmailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublisherEmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publisherNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublisherNameInput
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
        [JsiiProperty(name: "securityInput", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSecurity\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementSecurity? SecurityInput
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementSecurity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signInInput", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignIn\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementSignIn? SignInInput
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementSignIn?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signUpInput", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementSignUp\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementSignUp? SignUpInput
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementSignUp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tenantAccessInput", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementTenantAccess\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementTenantAccess? TenantAccessInput
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementTenantAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.apiManagement.ApiManagementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkConfigurationInput", typeJson: "{\"fqn\":\"azurerm.apiManagement.ApiManagementVirtualNetworkConfiguration\"}", isOptional: true)]
        public virtual azurerm.ApiManagement.IApiManagementVirtualNetworkConfiguration? VirtualNetworkConfigurationInput
        {
            get => GetInstanceProperty<azurerm.ApiManagement.IApiManagementVirtualNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualNetworkTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zonesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ZonesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "clientCertificateEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ClientCertificateEnabled
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

        [JsiiProperty(name: "gatewayDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object GatewayDisabled
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minApiVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinApiVersion
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

        [JsiiProperty(name: "notificationSenderEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationSenderEmail
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicIpAddressId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIpAddressId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PublicNetworkAccessEnabled
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

        [JsiiProperty(name: "publisherEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublisherEmail
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publisherName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublisherName
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

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualNetworkType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualNetworkType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Zones
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
