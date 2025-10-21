namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> = { assignments: ResizeArray<azurerm.MachineLearningComputeCluster.MachineLearningComputeClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster">azurerm_machine_learning_compute_cluster</a>.
    /// </summary>
    type MachineLearningComputeClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : MachineLearningComputeClusterState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningComputeClusterState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MachineLearningComputeClusterState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningComputeClusterState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#location-1">MachineLearningComputeCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MachineLearningComputeClusterState<Missing, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: string) : MachineLearningComputeClusterState<Present, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MachineLearningComputeClusterState<Present, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#machine_learning_workspace_id-1">MachineLearningComputeCluster#machine_learning_workspace_id</a>.
        /// </summary>
        [<CustomOperation "machine_learning_workspace_id">]
        member _.MachineLearningWorkspaceId(state: MachineLearningComputeClusterState<'Location, Missing, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: string) : MachineLearningComputeClusterState<'Location, Present, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.MachineLearningWorkspaceId <- value)
            ({ assignments = state.assignments } : MachineLearningComputeClusterState<'Location, Present, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#name-1">MachineLearningComputeCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, Missing, 'ScaleSettings, 'VmPriority, 'VmSize>, value: string) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, Present, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, Present, 'ScaleSettings, 'VmPriority, 'VmSize>)

        /// <summary>
        /// scale_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#scale_settings-1">MachineLearningComputeCluster#scale_settings</a>
        /// </summary>
        [<CustomOperation "scale_settings">]
        member _.ScaleSettings(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, Missing, 'VmPriority, 'VmSize>, value: azurerm.MachineLearningComputeCluster.MachineLearningComputeClusterScaleSettings) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, Present, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.ScaleSettings <- value)
            ({ assignments = state.assignments } : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, Present, 'VmPriority, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#vm_priority-1">MachineLearningComputeCluster#vm_priority</a>.
        /// </summary>
        [<CustomOperation "vm_priority">]
        member _.VmPriority(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, Missing, 'VmSize>, value: string) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, Present, 'VmSize> =
            state.assignments.Add(fun config -> config.VmPriority <- value)
            ({ assignments = state.assignments } : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, Present, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#vm_size-1">MachineLearningComputeCluster#vm_size</a>.
        /// </summary>
        [<CustomOperation "vm_size">]
        member _.VmSize(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, Missing>, value: string) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, Present> =
            state.assignments.Add(fun config -> config.VmSize <- value)
            ({ assignments = state.assignments } : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#description-1">MachineLearningComputeCluster#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: string) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#id-1">MachineLearningComputeCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: string) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#identity-1">MachineLearningComputeCluster#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: azurerm.MachineLearningComputeCluster.MachineLearningComputeClusterIdentity) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#local_auth_enabled-1">MachineLearningComputeCluster#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: bool) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#local_auth_enabled-1">MachineLearningComputeCluster#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#node_public_ip_enabled-1">MachineLearningComputeCluster#node_public_ip_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "node_public_ip_enabled">]
        member _.NodePublicIpEnabled(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: bool) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.NodePublicIpEnabled <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#node_public_ip_enabled-1">MachineLearningComputeCluster#node_public_ip_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "node_public_ip_enabled">]
        member _.NodePublicIpEnabled(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.NodePublicIpEnabled <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// ssh block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#ssh-1">MachineLearningComputeCluster#ssh</a>
        /// </summary>
        [<CustomOperation "ssh">]
        member _.Ssh(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: azurerm.MachineLearningComputeCluster.MachineLearningComputeClusterSsh) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.Ssh <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#ssh_public_access_enabled-1">MachineLearningComputeCluster#ssh_public_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ssh_public_access_enabled">]
        member _.SshPublicAccessEnabled(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: bool) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.SshPublicAccessEnabled <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#ssh_public_access_enabled-1">MachineLearningComputeCluster#ssh_public_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ssh_public_access_enabled">]
        member _.SshPublicAccessEnabled(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.SshPublicAccessEnabled <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#subnet_resource_id-1">MachineLearningComputeCluster#subnet_resource_id</a>.
        /// </summary>
        [<CustomOperation "subnet_resource_id">]
        member _.SubnetResourceId(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: string) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.SubnetResourceId <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#tags-1">MachineLearningComputeCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: seq<string * string>) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#timeouts-1">MachineLearningComputeCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>, value: azurerm.MachineLearningComputeCluster.MachineLearningComputeClusterTimeouts) : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MachineLearningComputeClusterState<'Location, 'MachineLearningWorkspaceId, 'Name, 'ScaleSettings, 'VmPriority, 'VmSize>

        member _.Run(state: MachineLearningComputeClusterState<Present, Present, Present, Present, Present, Present>) : azurerm.MachineLearningComputeCluster.MachineLearningComputeCluster =
            let config = azurerm.MachineLearningComputeCluster.MachineLearningComputeClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.MachineLearningComputeCluster.MachineLearningComputeCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.machineLearningComputeCluster: missing required arguments. Must call: location, machine_learning_workspace_id, name, scale_settings, vm_priority, vm_size.", 9999, IsError = true)>]
        member _.Run(_: MachineLearningComputeClusterState<_, _, _, _, _, _>) : azurerm.MachineLearningComputeCluster.MachineLearningComputeCluster =
            Unchecked.defaultof<azurerm.MachineLearningComputeCluster.MachineLearningComputeCluster>
