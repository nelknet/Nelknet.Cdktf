using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiClass(nativeType: typeof(azurerm.ServiceFabricCluster.ServiceFabricClusterCertificateCommonNamesOutputReference), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNamesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceFabricClusterCertificateCommonNamesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceFabricClusterCertificateCommonNamesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServiceFabricClusterCertificateCommonNamesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceFabricClusterCertificateCommonNamesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCommonNames", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNamesCommonNames\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCommonNames(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNamesCommonNames[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNamesCommonNames).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNamesCommonNames).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "commonNames", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNamesCommonNamesList\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterCertificateCommonNamesCommonNamesList CommonNames
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterCertificateCommonNamesCommonNamesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonNamesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNamesCommonNames\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CommonNamesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "x509StoreNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? X509StoreNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "x509StoreName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string X509StoreName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNames\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNames? InternalValue
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNames?>();
            set => SetInstanceProperty(value);
        }
    }
}
