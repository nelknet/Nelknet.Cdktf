using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Iothub
{
    [JsiiByValue(fqn: "azurerm.iothub.IothubEndpoint")]
    public class IothubEndpoint : azurerm.Iothub.IIothubEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#authentication_type Iothub#authentication_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#batch_frequency_in_seconds Iothub#batch_frequency_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchFrequencyInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchFrequencyInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#connection_string Iothub#connection_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#container_name Iothub#container_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#encoding Iothub#encoding}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Encoding
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#endpoint_uri Iothub#endpoint_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#entity_path Iothub#entity_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entityPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EntityPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#file_name_format Iothub#file_name_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileNameFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileNameFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#identity_id Iothub#identity_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentityId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#max_chunk_size_in_bytes Iothub#max_chunk_size_in_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxChunkSizeInBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxChunkSizeInBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#name Iothub#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#resource_group_name Iothub#resource_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#type Iothub#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
