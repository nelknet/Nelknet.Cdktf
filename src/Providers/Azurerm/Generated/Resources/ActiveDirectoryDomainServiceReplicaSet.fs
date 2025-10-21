namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, 'Location, 'SubnetId> = { assignments: ResizeArray<azurerm.ActiveDirectoryDomainServiceReplicaSet.ActiveDirectoryDomainServiceReplicaSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set">azurerm_active_directory_domain_service_replica_set</a>.
    /// </summary>
    type ActiveDirectoryDomainServiceReplicaSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : ActiveDirectoryDomainServiceReplicaSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ActiveDirectoryDomainServiceReplicaSetState<Missing, Missing, Missing>)

        member _.Zero(()) : ActiveDirectoryDomainServiceReplicaSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ActiveDirectoryDomainServiceReplicaSetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#domain_service_id-1">ActiveDirectoryDomainServiceReplicaSet#domain_service_id</a>.
        /// </summary>
        [<CustomOperation "domain_service_id">]
        member _.DomainServiceId(state: ActiveDirectoryDomainServiceReplicaSetState<Missing, 'Location, 'SubnetId>, value: string) : ActiveDirectoryDomainServiceReplicaSetState<Present, 'Location, 'SubnetId> =
            state.assignments.Add(fun config -> config.DomainServiceId <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceReplicaSetState<Present, 'Location, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#location-1">ActiveDirectoryDomainServiceReplicaSet#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, Missing, 'SubnetId>, value: string) : ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#subnet_id-1">ActiveDirectoryDomainServiceReplicaSet#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, 'Location, Missing>, value: string) : ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, 'Location, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#id-1">ActiveDirectoryDomainServiceReplicaSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, 'Location, 'SubnetId>, value: string) : ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, 'Location, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, 'Location, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service_replica_set#timeouts-1">ActiveDirectoryDomainServiceReplicaSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, 'Location, 'SubnetId>, value: azurerm.ActiveDirectoryDomainServiceReplicaSet.ActiveDirectoryDomainServiceReplicaSetTimeouts) : ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, 'Location, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ActiveDirectoryDomainServiceReplicaSetState<'DomainServiceId, 'Location, 'SubnetId>

        member _.Run(state: ActiveDirectoryDomainServiceReplicaSetState<Present, Present, Present>) : azurerm.ActiveDirectoryDomainServiceReplicaSet.ActiveDirectoryDomainServiceReplicaSet =
            let config = azurerm.ActiveDirectoryDomainServiceReplicaSet.ActiveDirectoryDomainServiceReplicaSetConfig()
            for setter in state.assignments do
                setter config
            azurerm.ActiveDirectoryDomainServiceReplicaSet.ActiveDirectoryDomainServiceReplicaSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.activeDirectoryDomainServiceReplicaSet: missing required arguments. Must call: domain_service_id, location, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: ActiveDirectoryDomainServiceReplicaSetState<_, _, _>) : azurerm.ActiveDirectoryDomainServiceReplicaSet.ActiveDirectoryDomainServiceReplicaSet =
            Unchecked.defaultof<azurerm.ActiveDirectoryDomainServiceReplicaSet.ActiveDirectoryDomainServiceReplicaSet>
