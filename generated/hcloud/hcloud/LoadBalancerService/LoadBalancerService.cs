using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.LoadBalancerService
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service hcloud_load_balancer_service}.</summary>
    [JsiiClass(nativeType: typeof(hcloud.LoadBalancerService.LoadBalancerService), fullyQualifiedName: "hcloud.loadBalancerService.LoadBalancerService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"hcloud.loadBalancerService.LoadBalancerServiceConfig\"}}]")]
    public class LoadBalancerService : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service hcloud_load_balancer_service} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LoadBalancerService(Constructs.Construct scope, string id, hcloud.LoadBalancerService.ILoadBalancerServiceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, hcloud.LoadBalancerService.ILoadBalancerServiceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerService(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a LoadBalancerService resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LoadBalancerService to import.</param>
        /// <param name="importFromId">The id of the existing LoadBalancerService that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LoadBalancerService to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LoadBalancerService to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LoadBalancerService that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LoadBalancerService to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(hcloud.LoadBalancerService.LoadBalancerService), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putHealthCheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"hcloud.loadBalancerService.LoadBalancerServiceHealthCheck\"}}]")]
        public virtual void PutHealthCheck(hcloud.LoadBalancerService.ILoadBalancerServiceHealthCheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(hcloud.LoadBalancerService.ILoadBalancerServiceHealthCheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"hcloud.loadBalancerService.LoadBalancerServiceHttp\"}}]")]
        public virtual void PutHttp(hcloud.LoadBalancerService.ILoadBalancerServiceHttp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(hcloud.LoadBalancerService.ILoadBalancerServiceHttp)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationPort")]
        public virtual void ResetDestinationPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheck")]
        public virtual void ResetHealthCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttp")]
        public virtual void ResetHttp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetListenPort")]
        public virtual void ResetListenPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProxyprotocol")]
        public virtual void ResetProxyprotocol()
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
        = GetStaticProperty<string>(typeof(hcloud.LoadBalancerService.LoadBalancerService))!;

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"hcloud.loadBalancerService.LoadBalancerServiceHealthCheckOutputReference\"}")]
        public virtual hcloud.LoadBalancerService.LoadBalancerServiceHealthCheckOutputReference HealthCheck
        {
            get => GetInstanceProperty<hcloud.LoadBalancerService.LoadBalancerServiceHealthCheckOutputReference>()!;
        }

        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"hcloud.loadBalancerService.LoadBalancerServiceHttpOutputReference\"}")]
        public virtual hcloud.LoadBalancerService.LoadBalancerServiceHttpOutputReference Http
        {
            get => GetInstanceProperty<hcloud.LoadBalancerService.LoadBalancerServiceHttpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DestinationPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckInput", typeJson: "{\"fqn\":\"hcloud.loadBalancerService.LoadBalancerServiceHealthCheck\"}", isOptional: true)]
        public virtual hcloud.LoadBalancerService.ILoadBalancerServiceHealthCheck? HealthCheckInput
        {
            get => GetInstanceProperty<hcloud.LoadBalancerService.ILoadBalancerServiceHealthCheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpInput", typeJson: "{\"fqn\":\"hcloud.loadBalancerService.LoadBalancerServiceHttp\"}", isOptional: true)]
        public virtual hcloud.LoadBalancerService.ILoadBalancerServiceHttp? HttpInput
        {
            get => GetInstanceProperty<hcloud.LoadBalancerService.ILoadBalancerServiceHttp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "listenPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ListenPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoadBalancerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proxyprotocolInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ProxyprotocolInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "destinationPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DestinationPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "listenPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ListenPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "proxyprotocol", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Proxyprotocol
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
    }
}
