namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerRegistryTaskState<'ContainerRegistryId, 'Name> = { assignments: ResizeArray<azurerm.ContainerRegistryTask.ContainerRegistryTaskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task">azurerm_container_registry_task</a>.
    /// </summary>
    type ContainerRegistryTaskBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerRegistryTaskState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryTaskState<Missing, Missing>)

        member _.Zero(()) : ContainerRegistryTaskState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryTaskState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#container_registry_id-1">ContainerRegistryTask#container_registry_id</a>.
        /// </summary>
        [<CustomOperation "container_registry_id">]
        member _.ContainerRegistryId(state: ContainerRegistryTaskState<Missing, 'Name>, value: string) : ContainerRegistryTaskState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ContainerRegistryId <- value)
            ({ assignments = state.assignments } : ContainerRegistryTaskState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#name-1">ContainerRegistryTask#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerRegistryTaskState<'ContainerRegistryId, Missing>, value: string) : ContainerRegistryTaskState<'ContainerRegistryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerRegistryTaskState<'ContainerRegistryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#agent_pool_name-1">ContainerRegistryTask#agent_pool_name</a>.
        /// </summary>
        [<CustomOperation "agent_pool_name">]
        member _.AgentPoolName(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: string) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.AgentPoolName <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// agent_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#agent_setting-1">ContainerRegistryTask#agent_setting</a>
        /// </summary>
        [<CustomOperation "agent_setting">]
        member _.AgentSetting(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: azurerm.ContainerRegistryTask.ContainerRegistryTaskAgentSetting) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.AgentSetting <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// base_image_trigger block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#base_image_trigger-1">ContainerRegistryTask#base_image_trigger</a>
        /// </summary>
        [<CustomOperation "base_image_trigger">]
        member _.BaseImageTrigger(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: azurerm.ContainerRegistryTask.ContainerRegistryTaskBaseImageTrigger) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.BaseImageTrigger <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// docker_step block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#docker_step-1">ContainerRegistryTask#docker_step</a>
        /// </summary>
        [<CustomOperation "docker_step">]
        member _.DockerStep(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: azurerm.ContainerRegistryTask.ContainerRegistryTaskDockerStep) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.DockerStep <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#enabled-1">ContainerRegistryTask#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: bool) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#enabled-1">ContainerRegistryTask#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// encoded_step block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#encoded_step-1">ContainerRegistryTask#encoded_step</a>
        /// </summary>
        [<CustomOperation "encoded_step">]
        member _.EncodedStep(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: azurerm.ContainerRegistryTask.ContainerRegistryTaskEncodedStep) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.EncodedStep <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// file_step block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#file_step-1">ContainerRegistryTask#file_step</a>
        /// </summary>
        [<CustomOperation "file_step">]
        member _.FileStep(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: azurerm.ContainerRegistryTask.ContainerRegistryTaskFileStep) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.FileStep <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#id-1">ContainerRegistryTask#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: string) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#identity-1">ContainerRegistryTask#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: azurerm.ContainerRegistryTask.ContainerRegistryTaskIdentity) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#is_system_task-1">ContainerRegistryTask#is_system_task</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_system_task">]
        member _.IsSystemTask(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: bool) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.IsSystemTask <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#is_system_task-1">ContainerRegistryTask#is_system_task</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_system_task">]
        member _.IsSystemTask(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.IsSystemTask <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#log_template-1">ContainerRegistryTask#log_template</a>.
        /// </summary>
        [<CustomOperation "log_template">]
        member _.LogTemplate(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: string) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.LogTemplate <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// platform block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#platform-1">ContainerRegistryTask#platform</a>
        /// </summary>
        [<CustomOperation "platform">]
        member _.Platform(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: azurerm.ContainerRegistryTask.ContainerRegistryTaskPlatform) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.Platform <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// registry_credential block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#registry_credential-1">ContainerRegistryTask#registry_credential</a>
        /// </summary>
        [<CustomOperation "registry_credential">]
        member _.RegistryCredential(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: azurerm.ContainerRegistryTask.ContainerRegistryTaskRegistryCredential) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.RegistryCredential <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// source_trigger block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#source_trigger-1">ContainerRegistryTask#source_trigger</a> Accepts: azurerm.IResolvable | azurerm.ContainerRegistryTask.ContainerRegistryTaskSourceTrigger[]
        /// </summary>
        [<CustomOperation "source_trigger">]
        member _.SourceTrigger(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.SourceTrigger <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#tags-1">ContainerRegistryTask#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: seq<string * string>) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#timeout_in_seconds-1">ContainerRegistryTask#timeout_in_seconds</a>.
        /// </summary>
        [<CustomOperation "timeout_in_seconds">]
        member _.TimeoutInSeconds(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: double) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.TimeoutInSeconds <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#timeouts-1">ContainerRegistryTask#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: azurerm.ContainerRegistryTask.ContainerRegistryTaskTimeouts) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// timer_trigger block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_task#timer_trigger-1">ContainerRegistryTask#timer_trigger</a> Accepts: azurerm.IResolvable | azurerm.ContainerRegistryTask.ContainerRegistryTaskTimerTrigger[]
        /// </summary>
        [<CustomOperation "timer_trigger">]
        member _.TimerTrigger(state: ContainerRegistryTaskState<'ContainerRegistryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryTaskState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.TimerTrigger <- value)
            state : ContainerRegistryTaskState<'ContainerRegistryId, 'Name>

        member _.Run(state: ContainerRegistryTaskState<Present, Present>) : azurerm.ContainerRegistryTask.ContainerRegistryTask =
            let config = azurerm.ContainerRegistryTask.ContainerRegistryTaskConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerRegistryTask.ContainerRegistryTask(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerRegistryTask: missing required arguments. Must call: container_registry_id, name.", 9999, IsError = true)>]
        member _.Run(_: ContainerRegistryTaskState<_, _>) : azurerm.ContainerRegistryTask.ContainerRegistryTask =
            Unchecked.defaultof<azurerm.ContainerRegistryTask.ContainerRegistryTask>
