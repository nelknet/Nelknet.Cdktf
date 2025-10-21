namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> = { assignments: ResizeArray<azurerm.BatchPool.BatchPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool">azurerm_batch_pool</a>.
    /// </summary>
    type BatchPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : BatchPoolState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchPoolState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BatchPoolState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchPoolState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#account_name-1">BatchPool#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: BatchPoolState<Missing, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: string) : BatchPoolState<Present, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : BatchPoolState<Present, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#name-1">BatchPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BatchPoolState<'AccountName, Missing, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: string) : BatchPoolState<'AccountName, Present, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BatchPoolState<'AccountName, Present, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#node_agent_sku_id-1">BatchPool#node_agent_sku_id</a>.
        /// </summary>
        [<CustomOperation "node_agent_sku_id">]
        member _.NodeAgentSkuId(state: BatchPoolState<'AccountName, 'Name, Missing, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: string) : BatchPoolState<'AccountName, 'Name, Present, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.NodeAgentSkuId <- value)
            ({ assignments = state.assignments } : BatchPoolState<'AccountName, 'Name, Present, 'ResourceGroupName, 'StorageImageReference, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#resource_group_name-1">BatchPool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, Missing, 'StorageImageReference, 'VmSize>, value: string) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, Present, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, Present, 'StorageImageReference, 'VmSize>)

        /// <summary>
        /// storage_image_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#storage_image_reference-1">BatchPool#storage_image_reference</a>
        /// </summary>
        [<CustomOperation "storage_image_reference">]
        member _.StorageImageReference(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, Missing, 'VmSize>, value: azurerm.BatchPool.BatchPoolStorageImageReference) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, Present, 'VmSize> =
            state.assignments.Add(fun config -> config.StorageImageReference <- value)
            ({ assignments = state.assignments } : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, Present, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#vm_size-1">BatchPool#vm_size</a>.
        /// </summary>
        [<CustomOperation "vm_size">]
        member _.VmSize(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, Missing>, value: string) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, Present> =
            state.assignments.Add(fun config -> config.VmSize <- value)
            ({ assignments = state.assignments } : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, Present>)

        /// <summary>
        /// auto_scale block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#auto_scale-1">BatchPool#auto_scale</a>
        /// </summary>
        [<CustomOperation "auto_scale">]
        member _.AutoScale(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: azurerm.BatchPool.BatchPoolAutoScale) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.AutoScale <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#certificate-1">BatchPool#certificate</a> Accepts: azurerm.IResolvable | azurerm.BatchPool.BatchPoolCertificate[]
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// container_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#container_configuration-1">BatchPool#container_configuration</a>
        /// </summary>
        [<CustomOperation "container_configuration">]
        member _.ContainerConfiguration(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: azurerm.BatchPool.BatchPoolContainerConfiguration) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.ContainerConfiguration <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// data_disks block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#data_disks-1">BatchPool#data_disks</a> Accepts: azurerm.IResolvable | azurerm.BatchPool.BatchPoolDataDisks[]
        /// </summary>
        [<CustomOperation "data_disks">]
        member _.DataDisks(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.DataDisks <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// disk_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#disk_encryption-1">BatchPool#disk_encryption</a> Accepts: azurerm.IResolvable | azurerm.BatchPool.BatchPoolDiskEncryption[]
        /// </summary>
        [<CustomOperation "disk_encryption">]
        member _.DiskEncryption(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.DiskEncryption <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#display_name-1">BatchPool#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: string) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// extensions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#extensions-1">BatchPool#extensions</a> Accepts: azurerm.IResolvable | azurerm.BatchPool.BatchPoolExtensions[]
        /// </summary>
        [<CustomOperation "extensions">]
        member _.Extensions(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.Extensions <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// fixed_scale block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#fixed_scale-1">BatchPool#fixed_scale</a>
        /// </summary>
        [<CustomOperation "fixed_scale">]
        member _.FixedScale(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: azurerm.BatchPool.BatchPoolFixedScale) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.FixedScale <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#id-1">BatchPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: string) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#identity-1">BatchPool#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: azurerm.BatchPool.BatchPoolIdentity) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#inter_node_communication-1">BatchPool#inter_node_communication</a>.
        /// </summary>
        [<CustomOperation "inter_node_communication">]
        member _.InterNodeCommunication(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: string) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.InterNodeCommunication <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#license_type-1">BatchPool#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: string) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#max_tasks_per_node-1">BatchPool#max_tasks_per_node</a>.
        /// </summary>
        [<CustomOperation "max_tasks_per_node">]
        member _.MaxTasksPerNode(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: double) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.MaxTasksPerNode <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#metadata-1">BatchPool#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: seq<string * string>) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// mount block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#mount-1">BatchPool#mount</a> Accepts: azurerm.IResolvable | azurerm.BatchPool.BatchPoolMount[]
        /// </summary>
        [<CustomOperation "mount">]
        member _.Mount(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.Mount <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// network_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#network_configuration-1">BatchPool#network_configuration</a>
        /// </summary>
        [<CustomOperation "network_configuration">]
        member _.NetworkConfiguration(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: azurerm.BatchPool.BatchPoolNetworkConfiguration) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.NetworkConfiguration <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// node_placement block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#node_placement-1">BatchPool#node_placement</a> Accepts: azurerm.IResolvable | azurerm.BatchPool.BatchPoolNodePlacement[]
        /// </summary>
        [<CustomOperation "node_placement">]
        member _.NodePlacement(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.NodePlacement <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#os_disk_placement-1">BatchPool#os_disk_placement</a>.
        /// </summary>
        [<CustomOperation "os_disk_placement">]
        member _.OsDiskPlacement(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: string) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.OsDiskPlacement <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// start_task block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#start_task-1">BatchPool#start_task</a>
        /// </summary>
        [<CustomOperation "start_task">]
        member _.StartTask(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: azurerm.BatchPool.BatchPoolStartTask) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.StartTask <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#stop_pending_resize_operation-1">BatchPool#stop_pending_resize_operation</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "stop_pending_resize_operation">]
        member _.StopPendingResizeOperation(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: bool) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.StopPendingResizeOperation <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#stop_pending_resize_operation-1">BatchPool#stop_pending_resize_operation</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "stop_pending_resize_operation">]
        member _.StopPendingResizeOperation(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.StopPendingResizeOperation <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#target_node_communication_mode-1">BatchPool#target_node_communication_mode</a>.
        /// </summary>
        [<CustomOperation "target_node_communication_mode">]
        member _.TargetNodeCommunicationMode(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: string) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.TargetNodeCommunicationMode <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// task_scheduling_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#task_scheduling_policy-1">BatchPool#task_scheduling_policy</a> Accepts: azurerm.IResolvable | azurerm.BatchPool.BatchPoolTaskSchedulingPolicy[]
        /// </summary>
        [<CustomOperation "task_scheduling_policy">]
        member _.TaskSchedulingPolicy(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.TaskSchedulingPolicy <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#timeouts-1">BatchPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: azurerm.BatchPool.BatchPoolTimeouts) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// user_accounts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#user_accounts-1">BatchPool#user_accounts</a> Accepts: azurerm.IResolvable | azurerm.BatchPool.BatchPoolUserAccounts[]
        /// </summary>
        [<CustomOperation "user_accounts">]
        member _.UserAccounts(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.UserAccounts <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        /// <summary>
        /// windows block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#windows-1">BatchPool#windows</a> Accepts: azurerm.IResolvable | azurerm.BatchPool.BatchPoolWindows[]
        /// </summary>
        [<CustomOperation "windows">]
        member _.Windows(state: BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize> =
            state.assignments.Add(fun config -> config.Windows <- value)
            state : BatchPoolState<'AccountName, 'Name, 'NodeAgentSkuId, 'ResourceGroupName, 'StorageImageReference, 'VmSize>

        member _.Run(state: BatchPoolState<Present, Present, Present, Present, Present, Present>) : azurerm.BatchPool.BatchPool =
            let config = azurerm.BatchPool.BatchPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.BatchPool.BatchPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.batchPool: missing required arguments. Must call: account_name, name, node_agent_sku_id, resource_group_name, storage_image_reference, vm_size.", 9999, IsError = true)>]
        member _.Run(_: BatchPoolState<_, _, _, _, _, _>) : azurerm.BatchPool.BatchPool =
            Unchecked.defaultof<azurerm.BatchPool.BatchPool>
