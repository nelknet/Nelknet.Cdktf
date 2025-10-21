using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2ClientVpnEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint aws_ec2_client_vpn_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpoint), fullyQualifiedName: "aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointConfig\"}}]")]
    public class Ec2ClientVpnEndpoint : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint aws_ec2_client_vpn_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Ec2ClientVpnEndpoint(Constructs.Construct scope, string id, aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2ClientVpnEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2ClientVpnEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a Ec2ClientVpnEndpoint resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Ec2ClientVpnEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing Ec2ClientVpnEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Ec2ClientVpnEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Ec2ClientVpnEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_client_vpn_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Ec2ClientVpnEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Ec2ClientVpnEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthenticationOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointAuthenticationOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAuthenticationOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointAuthenticationOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointAuthenticationOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointAuthenticationOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientConnectOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientConnectOptions\"}}]")]
        public virtual void PutClientConnectOptions(aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientConnectOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientConnectOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientLoginBannerOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientLoginBannerOptions\"}}]")]
        public virtual void PutClientLoginBannerOptions(aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientLoginBannerOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientLoginBannerOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientRouteEnforcementOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientRouteEnforcementOptions\"}}]")]
        public virtual void PutClientRouteEnforcementOptions(aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientRouteEnforcementOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientRouteEnforcementOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConnectionLogOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointConnectionLogOptions\"}}]")]
        public virtual void PutConnectionLogOptions(aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointConnectionLogOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointConnectionLogOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientConnectOptions")]
        public virtual void ResetClientConnectOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientLoginBannerOptions")]
        public virtual void ResetClientLoginBannerOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientRouteEnforcementOptions")]
        public virtual void ResetClientRouteEnforcementOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisconnectOnSessionTimeout")]
        public virtual void ResetDisconnectOnSessionTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsServers")]
        public virtual void ResetDnsServers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupIds")]
        public virtual void ResetSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSelfServicePortal")]
        public virtual void ResetSelfServicePortal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionTimeoutHours")]
        public virtual void ResetSessionTimeoutHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSplitTunnel")]
        public virtual void ResetSplitTunnel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransportProtocol")]
        public virtual void ResetTransportProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcId")]
        public virtual void ResetVpcId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpnPort")]
        public virtual void ResetVpnPort()
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
        = GetStaticProperty<string>(typeof(aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpoint))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticationOptions", typeJson: "{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointAuthenticationOptionsList\"}")]
        public virtual aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointAuthenticationOptionsList AuthenticationOptions
        {
            get => GetInstanceProperty<aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointAuthenticationOptionsList>()!;
        }

        [JsiiProperty(name: "clientConnectOptions", typeJson: "{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientConnectOptionsOutputReference\"}")]
        public virtual aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientConnectOptionsOutputReference ClientConnectOptions
        {
            get => GetInstanceProperty<aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientConnectOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "clientLoginBannerOptions", typeJson: "{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientLoginBannerOptionsOutputReference\"}")]
        public virtual aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientLoginBannerOptionsOutputReference ClientLoginBannerOptions
        {
            get => GetInstanceProperty<aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientLoginBannerOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "clientRouteEnforcementOptions", typeJson: "{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientRouteEnforcementOptionsOutputReference\"}")]
        public virtual aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientRouteEnforcementOptionsOutputReference ClientRouteEnforcementOptions
        {
            get => GetInstanceProperty<aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientRouteEnforcementOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "connectionLogOptions", typeJson: "{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointConnectionLogOptionsOutputReference\"}")]
        public virtual aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointConnectionLogOptionsOutputReference ConnectionLogOptions
        {
            get => GetInstanceProperty<aws.Ec2ClientVpnEndpoint.Ec2ClientVpnEndpointConnectionLogOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "selfServicePortalUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SelfServicePortalUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointAuthenticationOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AuthenticationOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCidrBlockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientCidrBlockInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientConnectOptionsInput", typeJson: "{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientConnectOptions\"}", isOptional: true)]
        public virtual aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientConnectOptions? ClientConnectOptionsInput
        {
            get => GetInstanceProperty<aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientConnectOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientLoginBannerOptionsInput", typeJson: "{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientLoginBannerOptions\"}", isOptional: true)]
        public virtual aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientLoginBannerOptions? ClientLoginBannerOptionsInput
        {
            get => GetInstanceProperty<aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientLoginBannerOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientRouteEnforcementOptionsInput", typeJson: "{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointClientRouteEnforcementOptions\"}", isOptional: true)]
        public virtual aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientRouteEnforcementOptions? ClientRouteEnforcementOptionsInput
        {
            get => GetInstanceProperty<aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointClientRouteEnforcementOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionLogOptionsInput", typeJson: "{\"fqn\":\"aws.ec2ClientVpnEndpoint.Ec2ClientVpnEndpointConnectionLogOptions\"}", isOptional: true)]
        public virtual aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointConnectionLogOptions? ConnectionLogOptionsInput
        {
            get => GetInstanceProperty<aws.Ec2ClientVpnEndpoint.IEc2ClientVpnEndpointConnectionLogOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disconnectOnSessionTimeoutInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisconnectOnSessionTimeoutInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsServersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DnsServersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selfServicePortalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SelfServicePortalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverCertificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerCertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionTimeoutHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SessionTimeoutHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "splitTunnelInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SplitTunnelInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transportProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransportProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpnPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? VpnPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "clientCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientCidrBlock
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

        [JsiiProperty(name: "disconnectOnSessionTimeout", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DisconnectOnSessionTimeout
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

        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsServers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "selfServicePortal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SelfServicePortal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerCertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sessionTimeoutHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionTimeoutHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "splitTunnel", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SplitTunnel
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transportProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransportProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpnPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VpnPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
