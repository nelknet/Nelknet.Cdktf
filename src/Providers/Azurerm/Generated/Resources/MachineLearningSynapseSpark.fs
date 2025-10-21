namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId> = { assignments: ResizeArray<azurerm.MachineLearningSynapseSpark.MachineLearningSynapseSparkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark">azurerm_machine_learning_synapse_spark</a>.
    /// </summary>
    type MachineLearningSynapseSparkBuilder(logicalId: string) =
        member _.Yield(_: unit) : MachineLearningSynapseSparkState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningSynapseSparkState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MachineLearningSynapseSparkState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningSynapseSparkState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark#location-1">MachineLearningSynapseSpark#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MachineLearningSynapseSparkState<Missing, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>, value: string) : MachineLearningSynapseSparkState<Present, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MachineLearningSynapseSparkState<Present, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark#machine_learning_workspace_id-1">MachineLearningSynapseSpark#machine_learning_workspace_id</a>.
        /// </summary>
        [<CustomOperation "machine_learning_workspace_id">]
        member _.MachineLearningWorkspaceId(state: MachineLearningSynapseSparkState<'Location, Missing, 'Name, 'SynapseSparkPoolId>, value: string) : MachineLearningSynapseSparkState<'Location, Present, 'Name, 'SynapseSparkPoolId> =
            state.assignments.Add(fun config -> config.MachineLearningWorkspaceId <- value)
            ({ assignments = state.assignments } : MachineLearningSynapseSparkState<'Location, Present, 'Name, 'SynapseSparkPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark#name-1">MachineLearningSynapseSpark#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, Missing, 'SynapseSparkPoolId>, value: string) : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, Present, 'SynapseSparkPoolId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, Present, 'SynapseSparkPoolId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark#synapse_spark_pool_id-1">MachineLearningSynapseSpark#synapse_spark_pool_id</a>.
        /// </summary>
        [<CustomOperation "synapse_spark_pool_id">]
        member _.SynapseSparkPoolId(state: MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, Missing>, value: string) : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SynapseSparkPoolId <- value)
            ({ assignments = state.assignments } : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark#description-1">MachineLearningSynapseSpark#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>, value: string) : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark#id-1">MachineLearningSynapseSpark#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>, value: string) : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark#identity-1">MachineLearningSynapseSpark#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>, value: azurerm.MachineLearningSynapseSpark.MachineLearningSynapseSparkIdentity) : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark#local_auth_enabled-1">MachineLearningSynapseSpark#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>, value: bool) : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark#local_auth_enabled-1">MachineLearningSynapseSpark#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>, value: HashiCorp.Cdktf.IResolvable) : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark#tags-1">MachineLearningSynapseSpark#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>, value: seq<string * string>) : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_synapse_spark#timeouts-1">MachineLearningSynapseSpark#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>, value: azurerm.MachineLearningSynapseSpark.MachineLearningSynapseSparkTimeouts) : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MachineLearningSynapseSparkState<'Location, 'MachineLearningWorkspaceId, 'Name, 'SynapseSparkPoolId>

        member _.Run(state: MachineLearningSynapseSparkState<Present, Present, Present, Present>) : azurerm.MachineLearningSynapseSpark.MachineLearningSynapseSpark =
            let config = azurerm.MachineLearningSynapseSpark.MachineLearningSynapseSparkConfig()
            for setter in state.assignments do
                setter config
            azurerm.MachineLearningSynapseSpark.MachineLearningSynapseSpark(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.machineLearningSynapseSpark: missing required arguments. Must call: location, machine_learning_workspace_id, name, synapse_spark_pool_id.", 9999, IsError = true)>]
        member _.Run(_: MachineLearningSynapseSparkState<_, _, _, _>) : azurerm.MachineLearningSynapseSpark.MachineLearningSynapseSpark =
            Unchecked.defaultof<azurerm.MachineLearningSynapseSpark.MachineLearningSynapseSpark>
