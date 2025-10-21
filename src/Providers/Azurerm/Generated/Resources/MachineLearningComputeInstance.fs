namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> = { assignments: ResizeArray<azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance">azurerm_machine_learning_compute_instance</a>.
    /// </summary>
    type MachineLearningComputeInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : MachineLearningComputeInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningComputeInstanceState<Missing, Missing, Missing>)

        member _.Zero(()) : MachineLearningComputeInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningComputeInstanceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#machine_learning_workspace_id-1">MachineLearningComputeInstance#machine_learning_workspace_id</a>.
        /// </summary>
        [<CustomOperation "machine_learning_workspace_id">]
        member _.MachineLearningWorkspaceId(state: MachineLearningComputeInstanceState<Missing, 'Name, 'VirtualMachineSize>, value: string) : MachineLearningComputeInstanceState<Present, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.MachineLearningWorkspaceId <- value)
            ({ assignments = state.assignments } : MachineLearningComputeInstanceState<Present, 'Name, 'VirtualMachineSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#name-1">MachineLearningComputeInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, Missing, 'VirtualMachineSize>, value: string) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, Present, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, Present, 'VirtualMachineSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#virtual_machine_size-1">MachineLearningComputeInstance#virtual_machine_size</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_size">]
        member _.VirtualMachineSize(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, Missing>, value: string) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineSize <- value)
            ({ assignments = state.assignments } : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, Present>)

        /// <summary>
        /// assign_to_user block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#assign_to_user-1">MachineLearningComputeInstance#assign_to_user</a>
        /// </summary>
        [<CustomOperation "assign_to_user">]
        member _.AssignToUser(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceAssignToUser) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.AssignToUser <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#authorization_type-1">MachineLearningComputeInstance#authorization_type</a>.
        /// </summary>
        [<CustomOperation "authorization_type">]
        member _.AuthorizationType(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: string) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.AuthorizationType <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#description-1">MachineLearningComputeInstance#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: string) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#id-1">MachineLearningComputeInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: string) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#identity-1">MachineLearningComputeInstance#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceIdentity) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#local_auth_enabled-1">MachineLearningComputeInstance#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: bool) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#local_auth_enabled-1">MachineLearningComputeInstance#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: HashiCorp.Cdktf.IResolvable) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#node_public_ip_enabled-1">MachineLearningComputeInstance#node_public_ip_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "node_public_ip_enabled">]
        member _.NodePublicIpEnabled(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: bool) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.NodePublicIpEnabled <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#node_public_ip_enabled-1">MachineLearningComputeInstance#node_public_ip_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "node_public_ip_enabled">]
        member _.NodePublicIpEnabled(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: HashiCorp.Cdktf.IResolvable) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.NodePublicIpEnabled <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// ssh block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#ssh-1">MachineLearningComputeInstance#ssh</a>
        /// </summary>
        [<CustomOperation "ssh">]
        member _.Ssh(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceSsh) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.Ssh <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#subnet_resource_id-1">MachineLearningComputeInstance#subnet_resource_id</a>.
        /// </summary>
        [<CustomOperation "subnet_resource_id">]
        member _.SubnetResourceId(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: string) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.SubnetResourceId <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#tags-1">MachineLearningComputeInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: seq<string * string>) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#timeouts-1">MachineLearningComputeInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>, value: azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceTimeouts) : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MachineLearningComputeInstanceState<'MachineLearningWorkspaceId, 'Name, 'VirtualMachineSize>

        member _.Run(state: MachineLearningComputeInstanceState<Present, Present, Present>) : azurerm.MachineLearningComputeInstance.MachineLearningComputeInstance =
            let config = azurerm.MachineLearningComputeInstance.MachineLearningComputeInstanceConfig()
            for setter in state.assignments do
                setter config
            azurerm.MachineLearningComputeInstance.MachineLearningComputeInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.machineLearningComputeInstance: missing required arguments. Must call: machine_learning_workspace_id, name, virtual_machine_size.", 9999, IsError = true)>]
        member _.Run(_: MachineLearningComputeInstanceState<_, _, _>) : azurerm.MachineLearningComputeInstance.MachineLearningComputeInstance =
            Unchecked.defaultof<azurerm.MachineLearningComputeInstance.MachineLearningComputeInstance>
