using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ServiceDiscoveryService
{
    [JsiiClass(nativeType: typeof(aws.ServiceDiscoveryService.ServiceDiscoveryServiceDnsConfigOutputReference), fullyQualifiedName: "aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceDiscoveryServiceDnsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceDiscoveryServiceDnsConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryServiceDnsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceDiscoveryServiceDnsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDnsRecords", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfigDnsRecords\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDnsRecords(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfigDnsRecords[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfigDnsRecords).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfigDnsRecords).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRoutingPolicy")]
        public virtual void ResetRoutingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dnsRecords", typeJson: "{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfigDnsRecordsList\"}")]
        public virtual aws.ServiceDiscoveryService.ServiceDiscoveryServiceDnsConfigDnsRecordsList DnsRecords
        {
            get => GetInstanceProperty<aws.ServiceDiscoveryService.ServiceDiscoveryServiceDnsConfigDnsRecordsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsRecordsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfigDnsRecords\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DnsRecordsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "namespaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamespaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.serviceDiscoveryService.ServiceDiscoveryServiceDnsConfig\"}", isOptional: true)]
        public virtual aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.ServiceDiscoveryService.IServiceDiscoveryServiceDnsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
