using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorizationConnection
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection aws_appfabric_app_authorization_connection}.</summary>
    [JsiiClass(nativeType: typeof(aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnection), fullyQualifiedName: "aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionConfig\"}}]")]
    public class AppfabricAppAuthorizationConnection : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection aws_appfabric_app_authorization_connection} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppfabricAppAuthorizationConnection(Constructs.Construct scope, string id, aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppfabricAppAuthorizationConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppfabricAppAuthorizationConnection(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a AppfabricAppAuthorizationConnection resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AppfabricAppAuthorizationConnection to import.</param>
        /// <param name="importFromId">The id of the existing AppfabricAppAuthorizationConnection that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AppfabricAppAuthorizationConnection to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AppfabricAppAuthorizationConnection to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AppfabricAppAuthorizationConnection that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AppfabricAppAuthorizationConnection to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnection), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionAuthRequest\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAuthRequest(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionAuthRequest[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionAuthRequest).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionAuthRequest).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthRequest")]
        public virtual void ResetAuthRequest()
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
        = GetStaticProperty<string>(typeof(aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnection))!;

        [JsiiProperty(name: "app", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string App
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authRequest", typeJson: "{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionAuthRequestList\"}")]
        public virtual aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionAuthRequestList AuthRequest
        {
            get => GetInstanceProperty<aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionAuthRequestList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenant", typeJson: "{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionTenantList\"}")]
        public virtual aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionTenantList Tenant
        {
            get => GetInstanceProperty<aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionTenantList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionTimeoutsOutputReference\"}")]
        public virtual aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.AppfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appAuthorizationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppAuthorizationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appBundleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppBundleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authRequestInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionAuthRequest\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AuthRequestInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "appAuthorizationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppAuthorizationArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "appBundleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppBundleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
