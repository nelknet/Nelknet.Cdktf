using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchOutboundConnection
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection aws_opensearch_outbound_connection}.</summary>
    [JsiiClass(nativeType: typeof(aws.OpensearchOutboundConnection.OpensearchOutboundConnection), fullyQualifiedName: "aws.opensearchOutboundConnection.OpensearchOutboundConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConfig\"}}]")]
    public class OpensearchOutboundConnection : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection aws_opensearch_outbound_connection} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OpensearchOutboundConnection(Constructs.Construct scope, string id, aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchOutboundConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchOutboundConnection(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a OpensearchOutboundConnection resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OpensearchOutboundConnection to import.</param>
        /// <param name="importFromId">The id of the existing OpensearchOutboundConnection that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OpensearchOutboundConnection to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OpensearchOutboundConnection to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_outbound_connection#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OpensearchOutboundConnection that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OpensearchOutboundConnection to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.OpensearchOutboundConnection.OpensearchOutboundConnection), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConnectionProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionProperties\"}}]")]
        public virtual void PutConnectionProperties(aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocalDomainInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionLocalDomainInfo\"}}]")]
        public virtual void PutLocalDomainInfo(aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionLocalDomainInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionLocalDomainInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRemoteDomainInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionRemoteDomainInfo\"}}]")]
        public virtual void PutRemoteDomainInfo(aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionRemoteDomainInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionRemoteDomainInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceptConnection")]
        public virtual void ResetAcceptConnection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionMode")]
        public virtual void ResetConnectionMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionProperties")]
        public virtual void ResetConnectionProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(aws.OpensearchOutboundConnection.OpensearchOutboundConnection))!;

        [JsiiProperty(name: "connectionProperties", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesOutputReference\"}")]
        public virtual aws.OpensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesOutputReference ConnectionProperties
        {
            get => GetInstanceProperty<aws.OpensearchOutboundConnection.OpensearchOutboundConnectionConnectionPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "connectionStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localDomainInfo", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionLocalDomainInfoOutputReference\"}")]
        public virtual aws.OpensearchOutboundConnection.OpensearchOutboundConnectionLocalDomainInfoOutputReference LocalDomainInfo
        {
            get => GetInstanceProperty<aws.OpensearchOutboundConnection.OpensearchOutboundConnectionLocalDomainInfoOutputReference>()!;
        }

        [JsiiProperty(name: "remoteDomainInfo", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionRemoteDomainInfoOutputReference\"}")]
        public virtual aws.OpensearchOutboundConnection.OpensearchOutboundConnectionRemoteDomainInfoOutputReference RemoteDomainInfo
        {
            get => GetInstanceProperty<aws.OpensearchOutboundConnection.OpensearchOutboundConnectionRemoteDomainInfoOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionTimeoutsOutputReference\"}")]
        public virtual aws.OpensearchOutboundConnection.OpensearchOutboundConnectionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.OpensearchOutboundConnection.OpensearchOutboundConnectionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceptConnectionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AcceptConnectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionAliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionAliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionPropertiesInput", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionConnectionProperties\"}", isOptional: true)]
        public virtual aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionProperties? ConnectionPropertiesInput
        {
            get => GetInstanceProperty<aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionConnectionProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localDomainInfoInput", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionLocalDomainInfo\"}", isOptional: true)]
        public virtual aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionLocalDomainInfo? LocalDomainInfoInput
        {
            get => GetInstanceProperty<aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionLocalDomainInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteDomainInfoInput", typeJson: "{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionRemoteDomainInfo\"}", isOptional: true)]
        public virtual aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionRemoteDomainInfo? RemoteDomainInfoInput
        {
            get => GetInstanceProperty<aws.OpensearchOutboundConnection.IOpensearchOutboundConnectionRemoteDomainInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.opensearchOutboundConnection.OpensearchOutboundConnectionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "acceptConnection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AcceptConnection
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

        [JsiiProperty(name: "connectionAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionAlias
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionMode
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
    }
}
