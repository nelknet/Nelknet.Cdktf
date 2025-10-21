using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListener
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener aws_lb_listener}.</summary>
    [JsiiClass(nativeType: typeof(aws.LbListener.LbListener), fullyQualifiedName: "aws.lbListener.LbListener", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lbListener.LbListenerConfig\"}}]")]
    public class LbListener : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener aws_lb_listener} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LbListener(Constructs.Construct scope, string id, aws.LbListener.ILbListenerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LbListener.ILbListenerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListener(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListener(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a LbListener resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LbListener to import.</param>
        /// <param name="importFromId">The id of the existing LbListener that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LbListener to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LbListener to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LbListener that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LbListener to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.LbListener.LbListener), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDefaultAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListener.LbListenerDefaultAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDefaultAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LbListener.ILbListenerDefaultAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LbListener.ILbListenerDefaultAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LbListener.ILbListenerDefaultAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMutualAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListener.LbListenerMutualAuthentication\"}}]")]
        public virtual void PutMutualAuthentication(aws.LbListener.ILbListenerMutualAuthentication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListener.ILbListenerMutualAuthentication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListener.LbListenerTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.LbListener.ILbListenerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListener.ILbListenerTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlpnPolicy")]
        public virtual void ResetAlpnPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateArn")]
        public virtual void ResetCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMutualAuthentication")]
        public virtual void ResetMutualAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpRequestXAmznMtlsClientcertHeaderName")]
        public virtual void ResetRoutingHttpRequestXAmznMtlsClientcertHeaderName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName")]
        public virtual void ResetRoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpRequestXAmznMtlsClientcertLeafHeaderName")]
        public virtual void ResetRoutingHttpRequestXAmznMtlsClientcertLeafHeaderName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName")]
        public virtual void ResetRoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName")]
        public virtual void ResetRoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpRequestXAmznMtlsClientcertValidityHeaderName")]
        public virtual void ResetRoutingHttpRequestXAmznMtlsClientcertValidityHeaderName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpRequestXAmznTlsCipherSuiteHeaderName")]
        public virtual void ResetRoutingHttpRequestXAmznTlsCipherSuiteHeaderName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpRequestXAmznTlsVersionHeaderName")]
        public virtual void ResetRoutingHttpRequestXAmznTlsVersionHeaderName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpResponseAccessControlAllowCredentialsHeaderValue")]
        public virtual void ResetRoutingHttpResponseAccessControlAllowCredentialsHeaderValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpResponseAccessControlAllowHeadersHeaderValue")]
        public virtual void ResetRoutingHttpResponseAccessControlAllowHeadersHeaderValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpResponseAccessControlAllowMethodsHeaderValue")]
        public virtual void ResetRoutingHttpResponseAccessControlAllowMethodsHeaderValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpResponseAccessControlAllowOriginHeaderValue")]
        public virtual void ResetRoutingHttpResponseAccessControlAllowOriginHeaderValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpResponseAccessControlExposeHeadersHeaderValue")]
        public virtual void ResetRoutingHttpResponseAccessControlExposeHeadersHeaderValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpResponseAccessControlMaxAgeHeaderValue")]
        public virtual void ResetRoutingHttpResponseAccessControlMaxAgeHeaderValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpResponseContentSecurityPolicyHeaderValue")]
        public virtual void ResetRoutingHttpResponseContentSecurityPolicyHeaderValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpResponseServerEnabled")]
        public virtual void ResetRoutingHttpResponseServerEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpResponseStrictTransportSecurityHeaderValue")]
        public virtual void ResetRoutingHttpResponseStrictTransportSecurityHeaderValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpResponseXContentTypeOptionsHeaderValue")]
        public virtual void ResetRoutingHttpResponseXContentTypeOptionsHeaderValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingHttpResponseXFrameOptionsHeaderValue")]
        public virtual void ResetRoutingHttpResponseXFrameOptionsHeaderValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslPolicy")]
        public virtual void ResetSslPolicy()
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

        [JsiiMethod(name: "resetTcpIdleTimeoutSeconds")]
        public virtual void ResetTcpIdleTimeoutSeconds()
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
        = GetStaticProperty<string>(typeof(aws.LbListener.LbListener))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultAction", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionList\"}")]
        public virtual aws.LbListener.LbListenerDefaultActionList DefaultAction
        {
            get => GetInstanceProperty<aws.LbListener.LbListenerDefaultActionList>()!;
        }

        [JsiiProperty(name: "mutualAuthentication", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerMutualAuthenticationOutputReference\"}")]
        public virtual aws.LbListener.LbListenerMutualAuthenticationOutputReference MutualAuthentication
        {
            get => GetInstanceProperty<aws.LbListener.LbListenerMutualAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerTimeoutsOutputReference\"}")]
        public virtual aws.LbListener.LbListenerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.LbListener.LbListenerTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alpnPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AlpnPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListener.LbListenerDefaultAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DefaultActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoadBalancerArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mutualAuthenticationInput", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerMutualAuthentication\"}", isOptional: true)]
        public virtual aws.LbListener.ILbListenerMutualAuthentication? MutualAuthenticationInput
        {
            get => GetInstanceProperty<aws.LbListener.ILbListenerMutualAuthentication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertHeaderNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpRequestXAmznMtlsClientcertHeaderNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertIssuerHeaderNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertLeafHeaderNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpRequestXAmznMtlsClientcertLeafHeaderNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertSerialNumberHeaderNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertSubjectHeaderNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertValidityHeaderNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpRequestXAmznMtlsClientcertValidityHeaderNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpRequestXAmznTlsCipherSuiteHeaderNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpRequestXAmznTlsCipherSuiteHeaderNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpRequestXAmznTlsVersionHeaderNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpRequestXAmznTlsVersionHeaderNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpResponseAccessControlAllowCredentialsHeaderValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpResponseAccessControlAllowCredentialsHeaderValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpResponseAccessControlAllowHeadersHeaderValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpResponseAccessControlAllowHeadersHeaderValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpResponseAccessControlAllowMethodsHeaderValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpResponseAccessControlAllowMethodsHeaderValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpResponseAccessControlAllowOriginHeaderValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpResponseAccessControlAllowOriginHeaderValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpResponseAccessControlExposeHeadersHeaderValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpResponseAccessControlExposeHeadersHeaderValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpResponseAccessControlMaxAgeHeaderValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpResponseAccessControlMaxAgeHeaderValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpResponseContentSecurityPolicyHeaderValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpResponseContentSecurityPolicyHeaderValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpResponseServerEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RoutingHttpResponseServerEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpResponseStrictTransportSecurityHeaderValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpResponseStrictTransportSecurityHeaderValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpResponseXContentTypeOptionsHeaderValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpResponseXContentTypeOptionsHeaderValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingHttpResponseXFrameOptionsHeaderValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingHttpResponseXFrameOptionsHeaderValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslPolicyInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "tcpIdleTimeoutSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TcpIdleTimeoutSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.lbListener.LbListenerTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "alpnPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AlpnPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateArn
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

        [JsiiProperty(name: "loadBalancerArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpRequestXAmznMtlsClientcertHeaderName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertIssuerHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertLeafHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertSubjectHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpRequestXAmznMtlsClientcertValidityHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpRequestXAmznTlsCipherSuiteHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpRequestXAmznTlsCipherSuiteHeaderName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpRequestXAmznTlsVersionHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpRequestXAmznTlsVersionHeaderName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpResponseAccessControlAllowCredentialsHeaderValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpResponseAccessControlAllowCredentialsHeaderValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpResponseAccessControlAllowHeadersHeaderValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpResponseAccessControlAllowHeadersHeaderValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpResponseAccessControlAllowMethodsHeaderValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpResponseAccessControlAllowMethodsHeaderValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpResponseAccessControlAllowOriginHeaderValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpResponseAccessControlAllowOriginHeaderValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpResponseAccessControlExposeHeadersHeaderValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpResponseAccessControlExposeHeadersHeaderValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpResponseAccessControlMaxAgeHeaderValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpResponseAccessControlMaxAgeHeaderValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpResponseContentSecurityPolicyHeaderValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpResponseContentSecurityPolicyHeaderValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpResponseServerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RoutingHttpResponseServerEnabled
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

        [JsiiProperty(name: "routingHttpResponseStrictTransportSecurityHeaderValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpResponseStrictTransportSecurityHeaderValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpResponseXContentTypeOptionsHeaderValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpResponseXContentTypeOptionsHeaderValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingHttpResponseXFrameOptionsHeaderValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingHttpResponseXFrameOptionsHeaderValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslPolicy
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tcpIdleTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TcpIdleTimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
