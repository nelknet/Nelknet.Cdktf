using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiClass(nativeType: typeof(aws.EcsService.EcsServiceServiceConnectConfigurationServiceOutputReference), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EcsServiceServiceConnectConfigurationServiceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public EcsServiceServiceConnectConfigurationServiceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsServiceServiceConnectConfigurationServiceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsServiceServiceConnectConfigurationServiceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientAlias", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAlias\"}}]")]
        public virtual void PutClientAlias(aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAlias @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAlias)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTimeout\"}}]")]
        public virtual void PutTimeout(aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTls\"}}]")]
        public virtual void PutTls(aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientAlias")]
        public virtual void ResetClientAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiscoveryName")]
        public virtual void ResetDiscoveryName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIngressPortOverride")]
        public virtual void ResetIngressPortOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTls")]
        public virtual void ResetTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientAlias", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAliasOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceServiceConnectConfigurationServiceClientAliasOutputReference ClientAlias
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceServiceConnectConfigurationServiceClientAliasOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTimeoutOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceServiceConnectConfigurationServiceTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceServiceConnectConfigurationServiceTimeoutOutputReference>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTlsOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceServiceConnectConfigurationServiceTlsOutputReference Tls
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceServiceConnectConfigurationServiceTlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientAliasInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAlias\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAlias? ClientAliasInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAlias?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "discoveryNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DiscoveryNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ingressPortOverrideInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IngressPortOverrideInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PortNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTimeout\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTimeout? TimeoutInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTls\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTls? TlsInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTls?>();
        }

        [JsiiProperty(name: "discoveryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiscoveryName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ingressPortOverride", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IngressPortOverride
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "portName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PortName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationService\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EcsService.IEcsServiceServiceConnectConfigurationService cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceServiceConnectConfigurationService).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
