using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DatabricksWorkspace
{
    [JsiiByValue(fqn: "azurerm.databricksWorkspace.DatabricksWorkspaceCustomParameters")]
    public class DatabricksWorkspaceCustomParameters : azurerm.DatabricksWorkspace.IDatabricksWorkspaceCustomParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#machine_learning_workspace_id DatabricksWorkspace#machine_learning_workspace_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "machineLearningWorkspaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MachineLearningWorkspaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#nat_gateway_name DatabricksWorkspace#nat_gateway_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "natGatewayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NatGatewayName
        {
            get;
            set;
        }

        private object? _noPublicIp;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#no_public_ip DatabricksWorkspace#no_public_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "noPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? NoPublicIp
        {
            get => _noPublicIp;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _noPublicIp = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#private_subnet_name DatabricksWorkspace#private_subnet_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateSubnetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateSubnetName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#private_subnet_network_security_group_association_id DatabricksWorkspace#private_subnet_network_security_group_association_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateSubnetNetworkSecurityGroupAssociationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateSubnetNetworkSecurityGroupAssociationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#public_ip_name DatabricksWorkspace#public_ip_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicIpName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicIpName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#public_subnet_name DatabricksWorkspace#public_subnet_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicSubnetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicSubnetName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#public_subnet_network_security_group_association_id DatabricksWorkspace#public_subnet_network_security_group_association_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicSubnetNetworkSecurityGroupAssociationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicSubnetNetworkSecurityGroupAssociationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#storage_account_name DatabricksWorkspace#storage_account_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#storage_account_sku_name DatabricksWorkspace#storage_account_sku_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccountSkuName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccountSkuName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#virtual_network_id DatabricksWorkspace#virtual_network_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VirtualNetworkId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#vnet_address_prefix DatabricksWorkspace#vnet_address_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vnetAddressPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VnetAddressPrefix
        {
            get;
            set;
        }
    }
}
