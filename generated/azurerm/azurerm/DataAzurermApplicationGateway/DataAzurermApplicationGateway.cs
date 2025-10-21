using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApplicationGateway
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_gateway azurerm_application_gateway}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGateway), fullyQualifiedName: "azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGateway", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayConfig\"}}]")]
    public class DataAzurermApplicationGateway : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_gateway azurerm_application_gateway} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermApplicationGateway(Constructs.Construct scope, string id, azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermApplicationGateway(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermApplicationGateway(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermApplicationGateway resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermApplicationGateway to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermApplicationGateway that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermApplicationGateway to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermApplicationGateway to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_gateway#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermApplicationGateway that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermApplicationGateway to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGateway), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermApplicationGateway.IDataAzurermApplicationGatewayTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGateway))!;

        [JsiiProperty(name: "authenticationCertificate", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayAuthenticationCertificateList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayAuthenticationCertificateList AuthenticationCertificate
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayAuthenticationCertificateList>()!;
        }

        [JsiiProperty(name: "autoscaleConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayAutoscaleConfigurationList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayAutoscaleConfigurationList AutoscaleConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayAutoscaleConfigurationList>()!;
        }

        [JsiiProperty(name: "backendAddressPool", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayBackendAddressPoolList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayBackendAddressPoolList BackendAddressPool
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayBackendAddressPoolList>()!;
        }

        [JsiiProperty(name: "backendHttpSettings", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayBackendHttpSettingsList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayBackendHttpSettingsList BackendHttpSettings
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayBackendHttpSettingsList>()!;
        }

        [JsiiProperty(name: "customErrorConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayCustomErrorConfigurationList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayCustomErrorConfigurationList CustomErrorConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayCustomErrorConfigurationList>()!;
        }

        [JsiiProperty(name: "fipsEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable FipsEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "firewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirewallPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "forceFirewallPolicyAssociation", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ForceFirewallPolicyAssociation
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "frontendIpConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayFrontendIpConfigurationList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayFrontendIpConfigurationList FrontendIpConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayFrontendIpConfigurationList>()!;
        }

        [JsiiProperty(name: "frontendPort", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayFrontendPortList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayFrontendPortList FrontendPort
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayFrontendPortList>()!;
        }

        [JsiiProperty(name: "gatewayIpConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayGatewayIpConfigurationList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayGatewayIpConfigurationList GatewayIpConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayGatewayIpConfigurationList>()!;
        }

        [JsiiProperty(name: "global", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayGlobalList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayGlobalList Global
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayGlobalList>()!;
        }

        [JsiiProperty(name: "http2Enabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Http2Enabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "httpListener", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayHttpListenerList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayHttpListenerList HttpListener
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayHttpListenerList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayIdentityList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayIdentityList Identity
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayIdentityList>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateEndpointConnection", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayPrivateEndpointConnectionList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayPrivateEndpointConnectionList PrivateEndpointConnection
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayPrivateEndpointConnectionList>()!;
        }

        [JsiiProperty(name: "privateLinkConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayPrivateLinkConfigurationList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayPrivateLinkConfigurationList PrivateLinkConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayPrivateLinkConfigurationList>()!;
        }

        [JsiiProperty(name: "probe", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayProbeList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayProbeList Probe
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayProbeList>()!;
        }

        [JsiiProperty(name: "redirectConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayRedirectConfigurationList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRedirectConfigurationList RedirectConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRedirectConfigurationList>()!;
        }

        [JsiiProperty(name: "requestRoutingRule", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayRequestRoutingRuleList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRequestRoutingRuleList RequestRoutingRule
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRequestRoutingRuleList>()!;
        }

        [JsiiProperty(name: "rewriteRuleSet", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetList RewriteRuleSet
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayRewriteRuleSetList>()!;
        }

        [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewaySkuList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewaySkuList Sku
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewaySkuList>()!;
        }

        [JsiiProperty(name: "sslCertificate", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewaySslCertificateList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewaySslCertificateList SslCertificate
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewaySslCertificateList>()!;
        }

        [JsiiProperty(name: "sslPolicy", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewaySslPolicyList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewaySslPolicyList SslPolicy
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewaySslPolicyList>()!;
        }

        [JsiiProperty(name: "sslProfile", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewaySslProfileList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewaySslProfileList SslProfile
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewaySslProfileList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "trustedClientCertificate", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayTrustedClientCertificateList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayTrustedClientCertificateList TrustedClientCertificate
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayTrustedClientCertificateList>()!;
        }

        [JsiiProperty(name: "trustedRootCertificate", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayTrustedRootCertificateList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayTrustedRootCertificateList TrustedRootCertificate
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayTrustedRootCertificateList>()!;
        }

        [JsiiProperty(name: "urlPathMap", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayUrlPathMapList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayUrlPathMapList UrlPathMap
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayUrlPathMapList>()!;
        }

        [JsiiProperty(name: "wafConfiguration", typeJson: "{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayWafConfigurationList\"}")]
        public virtual azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayWafConfigurationList WafConfiguration
        {
            get => GetInstanceProperty<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayWafConfigurationList>()!;
        }

        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Zones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermApplicationGateway.DataAzurermApplicationGatewayTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
