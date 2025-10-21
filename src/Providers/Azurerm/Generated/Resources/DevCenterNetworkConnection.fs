namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId> = { assignments: ResizeArray<azurerm.DevCenterNetworkConnection.DevCenterNetworkConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection">azurerm_dev_center_network_connection</a>.
    /// </summary>
    type DevCenterNetworkConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevCenterNetworkConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterNetworkConnectionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DevCenterNetworkConnectionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterNetworkConnectionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#domain_join_type-1">DevCenterNetworkConnection#domain_join_type</a>.
        /// </summary>
        [<CustomOperation "domain_join_type">]
        member _.DomainJoinType(state: DevCenterNetworkConnectionState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>, value: string) : DevCenterNetworkConnectionState<Present, 'Location, 'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.DomainJoinType <- value)
            ({ assignments = state.assignments } : DevCenterNetworkConnectionState<Present, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#location-1">DevCenterNetworkConnection#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DevCenterNetworkConnectionState<'DomainJoinType, Missing, 'Name, 'ResourceGroupName, 'SubnetId>, value: string) : DevCenterNetworkConnectionState<'DomainJoinType, Present, 'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DevCenterNetworkConnectionState<'DomainJoinType, Present, 'Name, 'ResourceGroupName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#name-1">DevCenterNetworkConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevCenterNetworkConnectionState<'DomainJoinType, 'Location, Missing, 'ResourceGroupName, 'SubnetId>, value: string) : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, Present, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, Present, 'ResourceGroupName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#resource_group_name-1">DevCenterNetworkConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, Missing, 'SubnetId>, value: string) : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#subnet_id-1">DevCenterNetworkConnection#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#domain_name-1">DevCenterNetworkConnection#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>, value: string) : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            state : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#domain_password-1">DevCenterNetworkConnection#domain_password</a>.
        /// </summary>
        [<CustomOperation "domain_password">]
        member _.DomainPassword(state: DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>, value: string) : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.DomainPassword <- value)
            state : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#domain_username-1">DevCenterNetworkConnection#domain_username</a>.
        /// </summary>
        [<CustomOperation "domain_username">]
        member _.DomainUsername(state: DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>, value: string) : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.DomainUsername <- value)
            state : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#id-1">DevCenterNetworkConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>, value: string) : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#organization_unit-1">DevCenterNetworkConnection#organization_unit</a>.
        /// </summary>
        [<CustomOperation "organization_unit">]
        member _.OrganizationUnit(state: DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>, value: string) : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.OrganizationUnit <- value)
            state : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#tags-1">DevCenterNetworkConnection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>, value: seq<string * string>) : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_network_connection#timeouts-1">DevCenterNetworkConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>, value: azurerm.DevCenterNetworkConnection.DevCenterNetworkConnectionTimeouts) : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevCenterNetworkConnectionState<'DomainJoinType, 'Location, 'Name, 'ResourceGroupName, 'SubnetId>

        member _.Run(state: DevCenterNetworkConnectionState<Present, Present, Present, Present, Present>) : azurerm.DevCenterNetworkConnection.DevCenterNetworkConnection =
            let config = azurerm.DevCenterNetworkConnection.DevCenterNetworkConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevCenterNetworkConnection.DevCenterNetworkConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devCenterNetworkConnection: missing required arguments. Must call: domain_join_type, location, name, resource_group_name, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: DevCenterNetworkConnectionState<_, _, _, _, _>) : azurerm.DevCenterNetworkConnection.DevCenterNetworkConnection =
            Unchecked.defaultof<azurerm.DevCenterNetworkConnection.DevCenterNetworkConnection>
