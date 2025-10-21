namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service">azurerm_active_directory_domain_service</a>.
    /// </summary>
    type ActiveDirectoryDomainServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : ActiveDirectoryDomainServiceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ActiveDirectoryDomainServiceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ActiveDirectoryDomainServiceState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ActiveDirectoryDomainServiceState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#domain_name-1">ActiveDirectoryDomainService#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: ActiveDirectoryDomainServiceState<Missing, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ActiveDirectoryDomainServiceState<Present, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceState<Present, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// initial_replica_set block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#initial_replica_set-1">ActiveDirectoryDomainService#initial_replica_set</a>
        /// </summary>
        [<CustomOperation "initial_replica_set">]
        member _.InitialReplicaSet(state: ActiveDirectoryDomainServiceState<'DomainName, Missing, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceInitialReplicaSet) : ActiveDirectoryDomainServiceState<'DomainName, Present, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.InitialReplicaSet <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceState<'DomainName, Present, 'Location, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#location-1">ActiveDirectoryDomainService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#name-1">ActiveDirectoryDomainService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#resource_group_name-1">ActiveDirectoryDomainService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, Missing, 'Sku>, value: string) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#sku-1">ActiveDirectoryDomainService#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#domain_configuration_type-1">ActiveDirectoryDomainService#domain_configuration_type</a>.
        /// </summary>
        [<CustomOperation "domain_configuration_type">]
        member _.DomainConfigurationType(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DomainConfigurationType <- value)
            state : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#filtered_sync_enabled-1">ActiveDirectoryDomainService#filtered_sync_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "filtered_sync_enabled">]
        member _.FilteredSyncEnabled(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.FilteredSyncEnabled <- value)
            state : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#filtered_sync_enabled-1">ActiveDirectoryDomainService#filtered_sync_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "filtered_sync_enabled">]
        member _.FilteredSyncEnabled(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.FilteredSyncEnabled <- value)
            state : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#id-1">ActiveDirectoryDomainService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// notifications block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#notifications-1">ActiveDirectoryDomainService#notifications</a>
        /// </summary>
        [<CustomOperation "notifications">]
        member _.Notifications(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceNotifications) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Notifications <- value)
            state : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// secure_ldap block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#secure_ldap-1">ActiveDirectoryDomainService#secure_ldap</a>
        /// </summary>
        [<CustomOperation "secure_ldap">]
        member _.SecureLdap(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceSecureLdap) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SecureLdap <- value)
            state : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// security block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#security-1">ActiveDirectoryDomainService#security</a>
        /// </summary>
        [<CustomOperation "security">]
        member _.Security(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceSecurity) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Security <- value)
            state : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#tags-1">ActiveDirectoryDomainService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#timeouts-1">ActiveDirectoryDomainService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceTimeouts) : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ActiveDirectoryDomainServiceState<'DomainName, 'InitialReplicaSet, 'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: ActiveDirectoryDomainServiceState<Present, Present, Present, Present, Present, Present>) : azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainService =
            let config = azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.activeDirectoryDomainService: missing required arguments. Must call: domain_name, initial_replica_set, location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: ActiveDirectoryDomainServiceState<_, _, _, _, _, _>) : azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainService =
            Unchecked.defaultof<azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainService>
