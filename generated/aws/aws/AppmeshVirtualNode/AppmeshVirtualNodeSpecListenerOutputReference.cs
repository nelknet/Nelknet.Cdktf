using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerOutputReference), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecListenerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppmeshVirtualNodeSpecListenerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppmeshVirtualNodeSpecListenerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectionPool", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPool\"}}]")]
        public virtual void PutConnectionPool(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerConnectionPool @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerConnectionPool)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerHealthCheck\"}}]")]
        public virtual void PutHealthCheck(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerHealthCheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerHealthCheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutlierDetection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerOutlierDetection\"}}]")]
        public virtual void PutOutlierDetection(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerOutlierDetection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerOutlierDetection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPortMapping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerPortMapping\"}}]")]
        public virtual void PutPortMapping(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerPortMapping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerPortMapping)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeout\"}}]")]
        public virtual void PutTimeout(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTls\"}}]")]
        public virtual void PutTls(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectionPool")]
        public virtual void ResetConnectionPool()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheck")]
        public virtual void ResetHealthCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutlierDetection")]
        public virtual void ResetOutlierDetection()
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

        [JsiiProperty(name: "connectionPool", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference ConnectionPool
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerHealthCheckOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerHealthCheckOutputReference HealthCheck
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerHealthCheckOutputReference>()!;
        }

        [JsiiProperty(name: "outlierDetection", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference OutlierDetection
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference>()!;
        }

        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerPortMappingOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerPortMappingOutputReference PortMapping
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerPortMappingOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutOutputReference>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTlsOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTlsOutputReference Tls
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionPoolInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPool\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerConnectionPool? ConnectionPoolInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerConnectionPool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerHealthCheck\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerHealthCheck? HealthCheckInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerHealthCheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outlierDetectionInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerOutlierDetection\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerOutlierDetection? OutlierDetectionInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerOutlierDetection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portMappingInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerPortMapping\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerPortMapping? PortMappingInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerPortMapping?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeout\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeout? TimeoutInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTls\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTls? TlsInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListener\"}]}}", isOptional: true)]
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
                        case aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListener cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListener).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
