using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint aws_cloudwatch_event_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(aws.CloudwatchEventEndpoint.CloudwatchEventEndpoint), fullyQualifiedName: "aws.cloudwatchEventEndpoint.CloudwatchEventEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointConfig\"}}]")]
    public class CloudwatchEventEndpoint : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint aws_cloudwatch_event_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudwatchEventEndpoint(Constructs.Construct scope, string id, aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CloudwatchEventEndpoint resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudwatchEventEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing CloudwatchEventEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudwatchEventEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudwatchEventEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudwatchEventEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudwatchEventEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CloudwatchEventEndpoint.CloudwatchEventEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putEventBus", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointEventBus\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEventBus(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointEventBus[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointEventBus).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointEventBus).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReplicationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointReplicationConfig\"}}]")]
        public virtual void PutReplicationConfig(aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointReplicationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointReplicationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoutingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfig\"}}]")]
        public virtual void PutRoutingConfig(aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationConfig")]
        public virtual void ResetReplicationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoleArn")]
        public virtual void ResetRoleArn()
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
        = GetStaticProperty<string>(typeof(aws.CloudwatchEventEndpoint.CloudwatchEventEndpoint))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventBus", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointEventBusList\"}")]
        public virtual aws.CloudwatchEventEndpoint.CloudwatchEventEndpointEventBusList EventBus
        {
            get => GetInstanceProperty<aws.CloudwatchEventEndpoint.CloudwatchEventEndpointEventBusList>()!;
        }

        [JsiiProperty(name: "replicationConfig", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointReplicationConfigOutputReference\"}")]
        public virtual aws.CloudwatchEventEndpoint.CloudwatchEventEndpointReplicationConfigOutputReference ReplicationConfig
        {
            get => GetInstanceProperty<aws.CloudwatchEventEndpoint.CloudwatchEventEndpointReplicationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "routingConfig", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigOutputReference\"}")]
        public virtual aws.CloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigOutputReference RoutingConfig
        {
            get => GetInstanceProperty<aws.CloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventBusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointEventBus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EventBusInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationConfigInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointReplicationConfig\"}", isOptional: true)]
        public virtual aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointReplicationConfig? ReplicationConfigInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointReplicationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingConfigInput", typeJson: "{\"fqn\":\"aws.cloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfig\"}", isOptional: true)]
        public virtual aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfig? RoutingConfigInput
        {
            get => GetInstanceProperty<aws.CloudwatchEventEndpoint.ICloudwatchEventEndpointRoutingConfig?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
