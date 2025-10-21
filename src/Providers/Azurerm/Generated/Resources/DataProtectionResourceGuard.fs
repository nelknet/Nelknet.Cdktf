namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataProtectionResourceGuard.DataProtectionResourceGuardConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_resource_guard">azurerm_data_protection_resource_guard</a>.
    /// </summary>
    type DataProtectionResourceGuardBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataProtectionResourceGuardState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionResourceGuardState<Missing, Missing, Missing>)

        member _.Zero(()) : DataProtectionResourceGuardState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataProtectionResourceGuardState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_resource_guard#location-1">DataProtectionResourceGuard#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataProtectionResourceGuardState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataProtectionResourceGuardState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataProtectionResourceGuardState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_resource_guard#name-1">DataProtectionResourceGuard#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataProtectionResourceGuardState<'Location, Missing, 'ResourceGroupName>, value: string) : DataProtectionResourceGuardState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataProtectionResourceGuardState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_resource_guard#resource_group_name-1">DataProtectionResourceGuard#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataProtectionResourceGuardState<'Location, 'Name, Missing>, value: string) : DataProtectionResourceGuardState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataProtectionResourceGuardState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_resource_guard#id-1">DataProtectionResourceGuard#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName>, value: string) : DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_resource_guard#tags-1">DataProtectionResourceGuard#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_resource_guard#timeouts-1">DataProtectionResourceGuard#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DataProtectionResourceGuard.DataProtectionResourceGuardTimeouts) : DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_protection_resource_guard#vault_critical_operation_exclusion_list-1">DataProtectionResourceGuard#vault_critical_operation_exclusion_list</a>.
        /// </summary>
        [<CustomOperation "vault_critical_operation_exclusion_list">]
        member _.VaultCriticalOperationExclusionList(state: DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.VaultCriticalOperationExclusionList <- (value |> Seq.toArray))
            state : DataProtectionResourceGuardState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DataProtectionResourceGuardState<Present, Present, Present>) : azurerm.DataProtectionResourceGuard.DataProtectionResourceGuard =
            let config = azurerm.DataProtectionResourceGuard.DataProtectionResourceGuardConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataProtectionResourceGuard.DataProtectionResourceGuard(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataProtectionResourceGuard: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataProtectionResourceGuardState<_, _, _>) : azurerm.DataProtectionResourceGuard.DataProtectionResourceGuard =
            Unchecked.defaultof<azurerm.DataProtectionResourceGuard.DataProtectionResourceGuard>
