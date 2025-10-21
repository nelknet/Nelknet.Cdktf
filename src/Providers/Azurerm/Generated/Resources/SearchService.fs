namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.SearchService.SearchServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service">azurerm_search_service</a>.
    /// </summary>
    type SearchServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SearchServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SearchServiceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SearchServiceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SearchServiceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#location-1">SearchService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SearchServiceState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : SearchServiceState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SearchServiceState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#name-1">SearchService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SearchServiceState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : SearchServiceState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SearchServiceState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#resource_group_name-1">SearchService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SearchServiceState<'Location, 'Name, Missing, 'Sku>, value: string) : SearchServiceState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SearchServiceState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#sku-1">SearchService#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : SearchServiceState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#allowed_ips-1">SearchService#allowed_ips</a>.
        /// </summary>
        [<CustomOperation "allowed_ips">]
        member _.AllowedIps(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string>) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AllowedIps <- (value |> Seq.toArray))
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#authentication_failure_mode-1">SearchService#authentication_failure_mode</a>.
        /// </summary>
        [<CustomOperation "authentication_failure_mode">]
        member _.AuthenticationFailureMode(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AuthenticationFailureMode <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#customer_managed_key_enforcement_enabled-1">SearchService#customer_managed_key_enforcement_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "customer_managed_key_enforcement_enabled">]
        member _.CustomerManagedKeyEnforcementEnabled(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CustomerManagedKeyEnforcementEnabled <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#customer_managed_key_enforcement_enabled-1">SearchService#customer_managed_key_enforcement_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "customer_managed_key_enforcement_enabled">]
        member _.CustomerManagedKeyEnforcementEnabled(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CustomerManagedKeyEnforcementEnabled <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#hosting_mode-1">SearchService#hosting_mode</a>.
        /// </summary>
        [<CustomOperation "hosting_mode">]
        member _.HostingMode(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.HostingMode <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#id-1">SearchService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#identity-1">SearchService#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.SearchService.SearchServiceIdentity) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#local_authentication_enabled-1">SearchService#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#local_authentication_enabled-1">SearchService#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#partition_count-1">SearchService#partition_count</a>.
        /// </summary>
        [<CustomOperation "partition_count">]
        member _.PartitionCount(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PartitionCount <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#public_network_access_enabled-1">SearchService#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#public_network_access_enabled-1">SearchService#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#replica_count-1">SearchService#replica_count</a>.
        /// </summary>
        [<CustomOperation "replica_count">]
        member _.ReplicaCount(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ReplicaCount <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#semantic_search_sku-1">SearchService#semantic_search_sku</a>.
        /// </summary>
        [<CustomOperation "semantic_search_sku">]
        member _.SemanticSearchSku(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SemanticSearchSku <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#tags-1">SearchService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/search_service#timeouts-1">SearchService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.SearchService.SearchServiceTimeouts) : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SearchServiceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: SearchServiceState<Present, Present, Present, Present>) : azurerm.SearchService.SearchService =
            let config = azurerm.SearchService.SearchServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SearchService.SearchService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.searchService: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: SearchServiceState<_, _, _, _>) : azurerm.SearchService.SearchService =
            Unchecked.defaultof<azurerm.SearchService.SearchService>
