using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualGateway
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecOutputReference), fullyQualifiedName: "aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualGatewaySpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualGatewaySpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshVirtualGatewaySpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBackendDefaults", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecBackendDefaults\"}}]")]
        public virtual void PutBackendDefaults(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecBackendDefaults @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecBackendDefaults)}, new object[]{@value});
        }

        [JsiiMethod(name: "putListener", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListener\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutListener(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListener[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListener).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecListener).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogging", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLogging\"}}]")]
        public virtual void PutLogging(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLogging @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLogging)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackendDefaults")]
        public virtual void ResetBackendDefaults()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "backendDefaults", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecBackendDefaultsOutputReference\"}")]
        public virtual aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecBackendDefaultsOutputReference BackendDefaults
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecBackendDefaultsOutputReference>()!;
        }

        [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerList\"}")]
        public virtual aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerList Listener
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecListenerList>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingOutputReference\"}")]
        public virtual aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingOutputReference Logging
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpecLoggingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendDefaultsInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecBackendDefaults\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecBackendDefaults? BackendDefaultsInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecBackendDefaults?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "listenerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecListener\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ListenerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpecLogging\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLogging? LoggingInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpecLogging?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshVirtualGateway.AppmeshVirtualGatewaySpec\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpec? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshVirtualGateway.IAppmeshVirtualGatewaySpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
