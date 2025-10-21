namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> = { assignments: ResizeArray<azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command">azurerm_virtual_machine_run_command</a>.
    /// </summary>
    type VirtualMachineRunCommandBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineRunCommandState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineRunCommandState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VirtualMachineRunCommandState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineRunCommandState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#location-1">VirtualMachineRunCommand#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: VirtualMachineRunCommandState<Missing, 'Name, 'Source, 'VirtualMachineId>, value: string) : VirtualMachineRunCommandState<Present, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : VirtualMachineRunCommandState<Present, 'Name, 'Source, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#name-1">VirtualMachineRunCommand#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VirtualMachineRunCommandState<'Location, Missing, 'Source, 'VirtualMachineId>, value: string) : VirtualMachineRunCommandState<'Location, Present, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VirtualMachineRunCommandState<'Location, Present, 'Source, 'VirtualMachineId>)

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#source-1">VirtualMachineRunCommand#source</a>
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: VirtualMachineRunCommandState<'Location, 'Name, Missing, 'VirtualMachineId>, value: azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandSource) : VirtualMachineRunCommandState<'Location, 'Name, Present, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : VirtualMachineRunCommandState<'Location, 'Name, Present, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#virtual_machine_id-1">VirtualMachineRunCommand#virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_id">]
        member _.VirtualMachineId(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, Missing>, value: string) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineId <- value)
            ({ assignments = state.assignments } : VirtualMachineRunCommandState<'Location, 'Name, 'Source, Present>)

        /// <summary>
        /// error_blob_managed_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#error_blob_managed_identity-1">VirtualMachineRunCommand#error_blob_managed_identity</a>
        /// </summary>
        [<CustomOperation "error_blob_managed_identity">]
        member _.ErrorBlobManagedIdentity(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>, value: azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandErrorBlobManagedIdentity) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.ErrorBlobManagedIdentity <- value)
            state : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#error_blob_uri-1">VirtualMachineRunCommand#error_blob_uri</a>.
        /// </summary>
        [<CustomOperation "error_blob_uri">]
        member _.ErrorBlobUri(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>, value: string) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.ErrorBlobUri <- value)
            state : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#id-1">VirtualMachineRunCommand#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>, value: string) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>

        /// <summary>
        /// output_blob_managed_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#output_blob_managed_identity-1">VirtualMachineRunCommand#output_blob_managed_identity</a>
        /// </summary>
        [<CustomOperation "output_blob_managed_identity">]
        member _.OutputBlobManagedIdentity(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>, value: azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandOutputBlobManagedIdentity) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.OutputBlobManagedIdentity <- value)
            state : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#output_blob_uri-1">VirtualMachineRunCommand#output_blob_uri</a>.
        /// </summary>
        [<CustomOperation "output_blob_uri">]
        member _.OutputBlobUri(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>, value: string) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.OutputBlobUri <- value)
            state : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>

        /// <summary>
        /// parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#parameter-1">VirtualMachineRunCommand#parameter</a> Accepts: azurerm.IResolvable | azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandParameter[]
        /// </summary>
        [<CustomOperation "parameter">]
        member _.Parameter(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Parameter <- value)
            state : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>

        /// <summary>
        /// protected_parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#protected_parameter-1">VirtualMachineRunCommand#protected_parameter</a> Accepts: azurerm.IResolvable | azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandProtectedParameter[]
        /// </summary>
        [<CustomOperation "protected_parameter">]
        member _.ProtectedParameter(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.ProtectedParameter <- value)
            state : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#run_as_password-1">VirtualMachineRunCommand#run_as_password</a>.
        /// </summary>
        [<CustomOperation "run_as_password">]
        member _.RunAsPassword(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>, value: string) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.RunAsPassword <- value)
            state : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#run_as_user-1">VirtualMachineRunCommand#run_as_user</a>.
        /// </summary>
        [<CustomOperation "run_as_user">]
        member _.RunAsUser(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>, value: string) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.RunAsUser <- value)
            state : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#tags-1">VirtualMachineRunCommand#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>, value: seq<string * string>) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#timeouts-1">VirtualMachineRunCommand#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>, value: azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandTimeouts) : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineRunCommandState<'Location, 'Name, 'Source, 'VirtualMachineId>

        member _.Run(state: VirtualMachineRunCommandState<Present, Present, Present, Present>) : azurerm.VirtualMachineRunCommand.VirtualMachineRunCommand =
            let config = azurerm.VirtualMachineRunCommand.VirtualMachineRunCommandConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachineRunCommand.VirtualMachineRunCommand(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachineRunCommand: missing required arguments. Must call: location, name, source, virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineRunCommandState<_, _, _, _>) : azurerm.VirtualMachineRunCommand.VirtualMachineRunCommand =
            Unchecked.defaultof<azurerm.VirtualMachineRunCommand.VirtualMachineRunCommand>
