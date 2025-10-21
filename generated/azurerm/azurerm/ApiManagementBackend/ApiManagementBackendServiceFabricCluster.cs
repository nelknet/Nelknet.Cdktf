using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementBackend.ApiManagementBackendServiceFabricCluster")]
    public class ApiManagementBackendServiceFabricCluster : azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#management_endpoints ApiManagementBackend#management_endpoints}.</summary>
        [JsiiProperty(name: "managementEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ManagementEndpoints
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#max_partition_resolution_retries ApiManagementBackend#max_partition_resolution_retries}.</summary>
        [JsiiProperty(name: "maxPartitionResolutionRetries", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxPartitionResolutionRetries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#client_certificate_id ApiManagementBackend#client_certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#client_certificate_thumbprint ApiManagementBackend#client_certificate_thumbprint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificateThumbprint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#server_certificate_thumbprints ApiManagementBackend#server_certificate_thumbprints}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverCertificateThumbprints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ServerCertificateThumbprints
        {
            get;
            set;
        }

        private object? _serverX509Name;

        /// <summary>server_x509_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#server_x509_name ApiManagementBackend#server_x509_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serverX509Name", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.apiManagementBackend.ApiManagementBackendServiceFabricClusterServerX509Name\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ServerX509Name
        {
            get => _serverX509Name;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricClusterServerX509Name[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricClusterServerX509Name).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serverX509Name = value;
            }
        }
    }
}
