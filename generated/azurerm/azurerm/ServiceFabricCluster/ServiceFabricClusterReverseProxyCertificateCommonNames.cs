using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificateCommonNames")]
    public class ServiceFabricClusterReverseProxyCertificateCommonNames : azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificateCommonNames
    {
        private object _commonNames;

        /// <summary>common_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#common_names ServiceFabricCluster#common_names}
        /// </remarks>
        [JsiiProperty(name: "commonNames", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificateCommonNamesCommonNames\"},\"kind\":\"array\"}}]}}")]
        public object CommonNames
        {
            get => _commonNames;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificateCommonNamesCommonNames[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificateCommonNamesCommonNames).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificateCommonNamesCommonNames).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _commonNames = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#x509_store_name ServiceFabricCluster#x509_store_name}.</summary>
        [JsiiProperty(name: "x509StoreName", typeJson: "{\"primitive\":\"string\"}")]
        public string X509StoreName
        {
            get;
            set;
        }
    }
}
