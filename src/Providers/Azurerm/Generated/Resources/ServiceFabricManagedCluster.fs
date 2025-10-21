namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster">azurerm_service_fabric_managed_cluster</a>.
    /// </summary>
    type ServiceFabricManagedClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServiceFabricManagedClusterState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServiceFabricManagedClusterState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ServiceFabricManagedClusterState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServiceFabricManagedClusterState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#client_connection_port-1">ServiceFabricManagedCluster#client_connection_port</a>.
        /// </summary>
        [<CustomOperation "client_connection_port">]
        member _.ClientConnectionPort(state: ServiceFabricManagedClusterState<Missing, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: double) : ServiceFabricManagedClusterState<Present, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientConnectionPort <- value)
            ({ assignments = state.assignments } : ServiceFabricManagedClusterState<Present, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#http_gateway_port-1">ServiceFabricManagedCluster#http_gateway_port</a>.
        /// </summary>
        [<CustomOperation "http_gateway_port">]
        member _.HttpGatewayPort(state: ServiceFabricManagedClusterState<'ClientConnectionPort, Missing, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: double) : ServiceFabricManagedClusterState<'ClientConnectionPort, Present, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpGatewayPort <- value)
            ({ assignments = state.assignments } : ServiceFabricManagedClusterState<'ClientConnectionPort, Present, 'LbRule, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// lb_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#lb_rule-1">ServiceFabricManagedCluster#lb_rule</a> Accepts: azurerm.IResolvable | azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterLbRule[]
        /// </summary>
        [<CustomOperation "lb_rule">]
        member _.LbRule(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, Missing, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LbRule <- value)
            ({ assignments = state.assignments } : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#location-1">ServiceFabricManagedCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, Missing, 'Name, 'ResourceGroupName>, value: string) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#name-1">ServiceFabricManagedCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, Missing, 'ResourceGroupName>, value: string) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#resource_group_name-1">ServiceFabricManagedCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, Missing>, value: string) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, Present>)

        /// <summary>
        /// authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#authentication-1">ServiceFabricManagedCluster#authentication</a>
        /// </summary>
        [<CustomOperation "authentication">]
        member _.Authentication(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterAuthentication) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Authentication <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#backup_service_enabled-1">ServiceFabricManagedCluster#backup_service_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "backup_service_enabled">]
        member _.BackupServiceEnabled(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: bool) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackupServiceEnabled <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#backup_service_enabled-1">ServiceFabricManagedCluster#backup_service_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "backup_service_enabled">]
        member _.BackupServiceEnabled(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackupServiceEnabled <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// custom_fabric_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#custom_fabric_setting-1">ServiceFabricManagedCluster#custom_fabric_setting</a> Accepts: azurerm.IResolvable | azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterCustomFabricSetting[]
        /// </summary>
        [<CustomOperation "custom_fabric_setting">]
        member _.CustomFabricSetting(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomFabricSetting <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#dns_name-1">ServiceFabricManagedCluster#dns_name</a>.
        /// </summary>
        [<CustomOperation "dns_name">]
        member _.DnsName(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: string) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsName <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#dns_service_enabled-1">ServiceFabricManagedCluster#dns_service_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dns_service_enabled">]
        member _.DnsServiceEnabled(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: bool) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsServiceEnabled <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#dns_service_enabled-1">ServiceFabricManagedCluster#dns_service_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "dns_service_enabled">]
        member _.DnsServiceEnabled(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsServiceEnabled <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#id-1">ServiceFabricManagedCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: string) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// node_type block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#node_type-1">ServiceFabricManagedCluster#node_type</a> Accepts: azurerm.IResolvable | azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterNodeType[]
        /// </summary>
        [<CustomOperation "node_type">]
        member _.NodeType(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NodeType <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#password-1">ServiceFabricManagedCluster#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: string) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#sku-1">ServiceFabricManagedCluster#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: string) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#tags-1">ServiceFabricManagedCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#timeouts-1">ServiceFabricManagedCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterTimeouts) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#upgrade_wave-1">ServiceFabricManagedCluster#upgrade_wave</a>.
        /// </summary>
        [<CustomOperation "upgrade_wave">]
        member _.UpgradeWave(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: string) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.UpgradeWave <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#username-1">ServiceFabricManagedCluster#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>, value: string) : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Username <- value)
            state : ServiceFabricManagedClusterState<'ClientConnectionPort, 'HttpGatewayPort, 'LbRule, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ServiceFabricManagedClusterState<Present, Present, Present, Present, Present, Present>) : azurerm.ServiceFabricManagedCluster.ServiceFabricManagedCluster =
            let config = azurerm.ServiceFabricManagedCluster.ServiceFabricManagedClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServiceFabricManagedCluster.ServiceFabricManagedCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.serviceFabricManagedCluster: missing required arguments. Must call: client_connection_port, http_gateway_port, lb_rule, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ServiceFabricManagedClusterState<_, _, _, _, _, _>) : azurerm.ServiceFabricManagedCluster.ServiceFabricManagedCluster =
            Unchecked.defaultof<azurerm.ServiceFabricManagedCluster.ServiceFabricManagedCluster>
