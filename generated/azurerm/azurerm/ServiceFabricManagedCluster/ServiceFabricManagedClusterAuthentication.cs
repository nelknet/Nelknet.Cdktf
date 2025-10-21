using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricManagedCluster
{
    [JsiiByValue(fqn: "azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthentication")]
    public class ServiceFabricManagedClusterAuthentication : azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthentication
    {
        /// <summary>active_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#active_directory ServiceFabricManagedCluster#active_directory}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationActiveDirectory\"}", isOptional: true)]
        public azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationActiveDirectory? ActiveDirectory
        {
            get;
            set;
        }

        private object? _certificate;

        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#certificate ServiceFabricManagedCluster#certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Certificate
        {
            get => _certificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _certificate = value;
            }
        }
    }
}
