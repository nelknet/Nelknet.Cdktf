namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagedDiskSasTokenState<'AccessLevel, 'DurationInSeconds, 'ManagedDiskId> = { assignments: ResizeArray<azurerm.ManagedDiskSasToken.ManagedDiskSasTokenConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk_sas_token">azurerm_managed_disk_sas_token</a>.
    /// </summary>
    type ManagedDiskSasTokenBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagedDiskSasTokenState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedDiskSasTokenState<Missing, Missing, Missing>)

        member _.Zero(()) : ManagedDiskSasTokenState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedDiskSasTokenState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk_sas_token#access_level-1">ManagedDiskSasToken#access_level</a>.
        /// </summary>
        [<CustomOperation "access_level">]
        member _.AccessLevel(state: ManagedDiskSasTokenState<Missing, 'DurationInSeconds, 'ManagedDiskId>, value: string) : ManagedDiskSasTokenState<Present, 'DurationInSeconds, 'ManagedDiskId> =
            state.assignments.Add(fun config -> config.AccessLevel <- value)
            ({ assignments = state.assignments } : ManagedDiskSasTokenState<Present, 'DurationInSeconds, 'ManagedDiskId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk_sas_token#duration_in_seconds-1">ManagedDiskSasToken#duration_in_seconds</a>.
        /// </summary>
        [<CustomOperation "duration_in_seconds">]
        member _.DurationInSeconds(state: ManagedDiskSasTokenState<'AccessLevel, Missing, 'ManagedDiskId>, value: double) : ManagedDiskSasTokenState<'AccessLevel, Present, 'ManagedDiskId> =
            state.assignments.Add(fun config -> config.DurationInSeconds <- value)
            ({ assignments = state.assignments } : ManagedDiskSasTokenState<'AccessLevel, Present, 'ManagedDiskId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk_sas_token#managed_disk_id-1">ManagedDiskSasToken#managed_disk_id</a>.
        /// </summary>
        [<CustomOperation "managed_disk_id">]
        member _.ManagedDiskId(state: ManagedDiskSasTokenState<'AccessLevel, 'DurationInSeconds, Missing>, value: string) : ManagedDiskSasTokenState<'AccessLevel, 'DurationInSeconds, Present> =
            state.assignments.Add(fun config -> config.ManagedDiskId <- value)
            ({ assignments = state.assignments } : ManagedDiskSasTokenState<'AccessLevel, 'DurationInSeconds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk_sas_token#id-1">ManagedDiskSasToken#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagedDiskSasTokenState<'AccessLevel, 'DurationInSeconds, 'ManagedDiskId>, value: string) : ManagedDiskSasTokenState<'AccessLevel, 'DurationInSeconds, 'ManagedDiskId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagedDiskSasTokenState<'AccessLevel, 'DurationInSeconds, 'ManagedDiskId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_disk_sas_token#timeouts-1">ManagedDiskSasToken#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagedDiskSasTokenState<'AccessLevel, 'DurationInSeconds, 'ManagedDiskId>, value: azurerm.ManagedDiskSasToken.ManagedDiskSasTokenTimeouts) : ManagedDiskSasTokenState<'AccessLevel, 'DurationInSeconds, 'ManagedDiskId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagedDiskSasTokenState<'AccessLevel, 'DurationInSeconds, 'ManagedDiskId>

        member _.Run(state: ManagedDiskSasTokenState<Present, Present, Present>) : azurerm.ManagedDiskSasToken.ManagedDiskSasToken =
            let config = azurerm.ManagedDiskSasToken.ManagedDiskSasTokenConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagedDiskSasToken.ManagedDiskSasToken(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.managedDiskSasToken: missing required arguments. Must call: access_level, duration_in_seconds, managed_disk_id.", 9999, IsError = true)>]
        member _.Run(_: ManagedDiskSasTokenState<_, _, _>) : azurerm.ManagedDiskSasToken.ManagedDiskSasToken =
            Unchecked.defaultof<azurerm.ManagedDiskSasToken.ManagedDiskSasToken>
