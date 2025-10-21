using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementLogger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementLogger.ApiManagementLoggerEventhub")]
    public class ApiManagementLoggerEventhub : azurerm.ApiManagementLogger.IApiManagementLoggerEventhub
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#name ApiManagementLogger#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#connection_string ApiManagementLogger#connection_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#endpoint_uri ApiManagementLogger#endpoint_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#user_assigned_identity_client_id ApiManagementLogger#user_assigned_identity_client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userAssignedIdentityClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAssignedIdentityClientId
        {
            get;
            set;
        }
    }
}
