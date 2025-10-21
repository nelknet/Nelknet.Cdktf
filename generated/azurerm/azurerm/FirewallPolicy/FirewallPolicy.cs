using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FirewallPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy azurerm_firewall_policy}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.FirewallPolicy.FirewallPolicy), fullyQualifiedName: "azurerm.firewallPolicy.FirewallPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyConfig\"}}]")]
    public class FirewallPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy azurerm_firewall_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FirewallPolicy(Constructs.Construct scope, string id, azurerm.FirewallPolicy.IFirewallPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.FirewallPolicy.IFirewallPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FirewallPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FirewallPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a FirewallPolicy resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the FirewallPolicy to import.</param>
        /// <param name="importFromId">The id of the existing FirewallPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the FirewallPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the FirewallPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/firewall_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing FirewallPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the FirewallPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.FirewallPolicy.FirewallPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyDns\"}}]")]
        public virtual void PutDns(azurerm.FirewallPolicy.IFirewallPolicyDns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FirewallPolicy.IFirewallPolicyDns)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExplicitProxy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyExplicitProxy\"}}]")]
        public virtual void PutExplicitProxy(azurerm.FirewallPolicy.IFirewallPolicyExplicitProxy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FirewallPolicy.IFirewallPolicyExplicitProxy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.FirewallPolicy.IFirewallPolicyIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FirewallPolicy.IFirewallPolicyIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInsights", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyInsights\"}}]")]
        public virtual void PutInsights(azurerm.FirewallPolicy.IFirewallPolicyInsights @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FirewallPolicy.IFirewallPolicyInsights)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIntrusionDetection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIntrusionDetection\"}}]")]
        public virtual void PutIntrusionDetection(azurerm.FirewallPolicy.IFirewallPolicyIntrusionDetection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FirewallPolicy.IFirewallPolicyIntrusionDetection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThreatIntelligenceAllowlist", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyThreatIntelligenceAllowlistStruct\"}}]")]
        public virtual void PutThreatIntelligenceAllowlist(azurerm.FirewallPolicy.IFirewallPolicyThreatIntelligenceAllowlistStruct @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FirewallPolicy.IFirewallPolicyThreatIntelligenceAllowlistStruct)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.FirewallPolicy.IFirewallPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FirewallPolicy.IFirewallPolicyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTlsCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyTlsCertificate\"}}]")]
        public virtual void PutTlsCertificate(azurerm.FirewallPolicy.IFirewallPolicyTlsCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.FirewallPolicy.IFirewallPolicyTlsCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoLearnPrivateRangesEnabled")]
        public virtual void ResetAutoLearnPrivateRangesEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBasePolicyId")]
        public virtual void ResetBasePolicyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDns")]
        public virtual void ResetDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExplicitProxy")]
        public virtual void ResetExplicitProxy()
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

        [JsiiMethod(name: "resetInsights")]
        public virtual void ResetInsights()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIntrusionDetection")]
        public virtual void ResetIntrusionDetection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateIpRanges")]
        public virtual void ResetPrivateIpRanges()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSku")]
        public virtual void ResetSku()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlRedirectAllowed")]
        public virtual void ResetSqlRedirectAllowed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreatIntelligenceAllowlist")]
        public virtual void ResetThreatIntelligenceAllowlist()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreatIntelligenceMode")]
        public virtual void ResetThreatIntelligenceMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsCertificate")]
        public virtual void ResetTlsCertificate()
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
        = GetStaticProperty<string>(typeof(azurerm.FirewallPolicy.FirewallPolicy))!;

        [JsiiProperty(name: "childPolicies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ChildPolicies
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyDnsOutputReference\"}")]
        public virtual azurerm.FirewallPolicy.FirewallPolicyDnsOutputReference Dns
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.FirewallPolicyDnsOutputReference>()!;
        }

        [JsiiProperty(name: "explicitProxy", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyExplicitProxyOutputReference\"}")]
        public virtual azurerm.FirewallPolicy.FirewallPolicyExplicitProxyOutputReference ExplicitProxy
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.FirewallPolicyExplicitProxyOutputReference>()!;
        }

        [JsiiProperty(name: "firewalls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Firewalls
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIdentityOutputReference\"}")]
        public virtual azurerm.FirewallPolicy.FirewallPolicyIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.FirewallPolicyIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "insights", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyInsightsOutputReference\"}")]
        public virtual azurerm.FirewallPolicy.FirewallPolicyInsightsOutputReference Insights
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.FirewallPolicyInsightsOutputReference>()!;
        }

        [JsiiProperty(name: "intrusionDetection", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIntrusionDetectionOutputReference\"}")]
        public virtual azurerm.FirewallPolicy.FirewallPolicyIntrusionDetectionOutputReference IntrusionDetection
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.FirewallPolicyIntrusionDetectionOutputReference>()!;
        }

        [JsiiProperty(name: "ruleCollectionGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RuleCollectionGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "threatIntelligenceAllowlist", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyThreatIntelligenceAllowlistStructOutputReference\"}")]
        public virtual azurerm.FirewallPolicy.FirewallPolicyThreatIntelligenceAllowlistStructOutputReference ThreatIntelligenceAllowlist
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.FirewallPolicyThreatIntelligenceAllowlistStructOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyTimeoutsOutputReference\"}")]
        public virtual azurerm.FirewallPolicy.FirewallPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.FirewallPolicyTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "tlsCertificate", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyTlsCertificateOutputReference\"}")]
        public virtual azurerm.FirewallPolicy.FirewallPolicyTlsCertificateOutputReference TlsCertificate
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.FirewallPolicyTlsCertificateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoLearnPrivateRangesEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoLearnPrivateRangesEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "basePolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BasePolicyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsInput", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyDns\"}", isOptional: true)]
        public virtual azurerm.FirewallPolicy.IFirewallPolicyDns? DnsInput
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.IFirewallPolicyDns?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "explicitProxyInput", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyExplicitProxy\"}", isOptional: true)]
        public virtual azurerm.FirewallPolicy.IFirewallPolicyExplicitProxy? ExplicitProxyInput
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.IFirewallPolicyExplicitProxy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIdentity\"}", isOptional: true)]
        public virtual azurerm.FirewallPolicy.IFirewallPolicyIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.IFirewallPolicyIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "insightsInput", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyInsights\"}", isOptional: true)]
        public virtual azurerm.FirewallPolicy.IFirewallPolicyInsights? InsightsInput
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.IFirewallPolicyInsights?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intrusionDetectionInput", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyIntrusionDetection\"}", isOptional: true)]
        public virtual azurerm.FirewallPolicy.IFirewallPolicyIntrusionDetection? IntrusionDetectionInput
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.IFirewallPolicyIntrusionDetection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
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
        [JsiiProperty(name: "privateIpRangesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PrivateIpRangesInput
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
        [JsiiProperty(name: "skuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlRedirectAllowedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SqlRedirectAllowedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threatIntelligenceAllowlistInput", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyThreatIntelligenceAllowlistStruct\"}", isOptional: true)]
        public virtual azurerm.FirewallPolicy.IFirewallPolicyThreatIntelligenceAllowlistStruct? ThreatIntelligenceAllowlistInput
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.IFirewallPolicyThreatIntelligenceAllowlistStruct?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threatIntelligenceModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ThreatIntelligenceModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsCertificateInput", typeJson: "{\"fqn\":\"azurerm.firewallPolicy.FirewallPolicyTlsCertificate\"}", isOptional: true)]
        public virtual azurerm.FirewallPolicy.IFirewallPolicyTlsCertificate? TlsCertificateInput
        {
            get => GetInstanceProperty<azurerm.FirewallPolicy.IFirewallPolicyTlsCertificate?>();
        }

        [JsiiProperty(name: "autoLearnPrivateRangesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoLearnPrivateRangesEnabled
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

        [JsiiProperty(name: "basePolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BasePolicyId
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
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

        [JsiiProperty(name: "privateIpRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PrivateIpRanges
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

        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sku
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlRedirectAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SqlRedirectAllowed
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threatIntelligenceMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ThreatIntelligenceMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
