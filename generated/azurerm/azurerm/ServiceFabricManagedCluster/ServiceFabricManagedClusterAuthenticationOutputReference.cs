using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricManagedCluster
{
    [JsiiClass(nativeType: typeof(azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationOutputReference), fullyQualifiedName: "azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceFabricManagedClusterAuthenticationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceFabricManagedClusterAuthenticationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServiceFabricManagedClusterAuthenticationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceFabricManagedClusterAuthenticationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationActiveDirectory\"}}]")]
        public virtual void PutActiveDirectory(azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationCertificate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCertificate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationCertificate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationCertificate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationCertificate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveDirectory")]
        public virtual void ResetActiveDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationActiveDirectoryOutputReference\"}")]
        public virtual azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationActiveDirectoryOutputReference ActiveDirectory
        {
            get => GetInstanceProperty<azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationActiveDirectoryOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationCertificateList\"}")]
        public virtual azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationCertificateList Certificate
        {
            get => GetInstanceProperty<azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationCertificateList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryInput", typeJson: "{\"fqn\":\"azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationActiveDirectory\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationActiveDirectory? ActiveDirectoryInput
        {
            get => GetInstanceProperty<azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationActiveDirectory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthentication\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthentication? InternalValue
        {
            get => GetInstanceProperty<azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthentication?>();
            set => SetInstanceProperty(value);
        }
    }
}
