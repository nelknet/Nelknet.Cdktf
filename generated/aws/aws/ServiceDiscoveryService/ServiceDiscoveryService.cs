using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ServiceDiscoveryService
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service aws_service_discovery_service}.</summary>
    [JsiiClass(nativeType: typeof(aws.ServiceDiscoveryService.ServiceDiscoveryService), fullyQualifiedName: "aws.serviceDiscoveryService.ServiceDiscoveryService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceConfig\"}}]")]
    public class ServiceDiscoveryService : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service aws_service_discovery_service} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceDiscoveryService(Constructs.Construct scope, string id, aws.ServiceDiscoveryService.IServiceDiscoveryServiceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ServiceDiscoveryService.IServiceDiscoveryServiceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryService(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ServiceDiscoveryService resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceDiscoveryService to import.</param>
        /// <param name="importFromId">The id of the existing ServiceDiscoveryService that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceDiscoveryService to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceDiscoveryService to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/service_discovery_service#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceDiscoveryService that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceDiscoveryService to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ServiceDiscoveryService.ServiceDiscoveryService), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDnsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfig\"}}]")]
        public virtual void PutDnsConfig(aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheckConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceHealthCheckConfig\"}}]")]
        public virtual void PutHealthCheckConfig(aws.ServiceDiscoveryService.IServiceDiscoveryServiceHealthCheckConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ServiceDiscoveryService.IServiceDiscoveryServiceHealthCheckConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheckCustomConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceHealthCheckCustomConfig\"}}]")]
        public virtual void PutHealthCheckCustomConfig(aws.ServiceDiscoveryService.IServiceDiscoveryServiceHealthCheckCustomConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ServiceDiscoveryService.IServiceDiscoveryServiceHealthCheckCustomConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsConfig")]
        public virtual void ResetDnsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDestroy")]
        public virtual void ResetForceDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckConfig")]
        public virtual void ResetHealthCheckConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckCustomConfig")]
        public virtual void ResetHealthCheckCustomConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamespaceId")]
        public virtual void ResetNamespaceId()
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

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(aws.ServiceDiscoveryService.ServiceDiscoveryService))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsConfig", typeJson: "{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfigOutputReference\"}")]
        public virtual aws.ServiceDiscoveryService.ServiceDiscoveryServiceDnsConfigOutputReference DnsConfig
        {
            get => GetInstanceProperty<aws.ServiceDiscoveryService.ServiceDiscoveryServiceDnsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheckConfig", typeJson: "{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceHealthCheckConfigOutputReference\"}")]
        public virtual aws.ServiceDiscoveryService.ServiceDiscoveryServiceHealthCheckConfigOutputReference HealthCheckConfig
        {
            get => GetInstanceProperty<aws.ServiceDiscoveryService.ServiceDiscoveryServiceHealthCheckConfigOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheckCustomConfig", typeJson: "{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference\"}")]
        public virtual aws.ServiceDiscoveryService.ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference HealthCheckCustomConfig
        {
            get => GetInstanceProperty<aws.ServiceDiscoveryService.ServiceDiscoveryServiceHealthCheckCustomConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsConfigInput", typeJson: "{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfig\"}", isOptional: true)]
        public virtual aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfig? DnsConfigInput
        {
            get => GetInstanceProperty<aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDestroyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceDestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckConfigInput", typeJson: "{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceHealthCheckConfig\"}", isOptional: true)]
        public virtual aws.ServiceDiscoveryService.IServiceDiscoveryServiceHealthCheckConfig? HealthCheckConfigInput
        {
            get => GetInstanceProperty<aws.ServiceDiscoveryService.IServiceDiscoveryServiceHealthCheckConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckCustomConfigInput", typeJson: "{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceHealthCheckCustomConfig\"}", isOptional: true)]
        public virtual aws.ServiceDiscoveryService.IServiceDiscoveryServiceHealthCheckCustomConfig? HealthCheckCustomConfigInput
        {
            get => GetInstanceProperty<aws.ServiceDiscoveryService.IServiceDiscoveryServiceHealthCheckCustomConfig?>();
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
        [JsiiProperty(name: "namespaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceIdInput
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
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceDestroy
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamespaceId
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
