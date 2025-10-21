namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> = { assignments: ResizeArray<azurerm.ContainerAppJob.ContainerAppJobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job">azurerm_container_app_job</a>.
    /// </summary>
    type ContainerAppJobBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerAppJobState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppJobState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerAppJobState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppJobState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#container_app_environment_id-1">ContainerAppJob#container_app_environment_id</a>.
        /// </summary>
        [<CustomOperation "container_app_environment_id">]
        member _.ContainerAppEnvironmentId(state: ContainerAppJobState<Missing, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: string) : ContainerAppJobState<Present, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.ContainerAppEnvironmentId <- value)
            ({ assignments = state.assignments } : ContainerAppJobState<Present, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#location-1">ContainerAppJob#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ContainerAppJobState<'ContainerAppEnvironmentId, Missing, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: string) : ContainerAppJobState<'ContainerAppEnvironmentId, Present, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ContainerAppJobState<'ContainerAppEnvironmentId, Present, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#name-1">ContainerAppJob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, Missing, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: string) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, Present, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, Present, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#replica_timeout_in_seconds-1">ContainerAppJob#replica_timeout_in_seconds</a>.
        /// </summary>
        [<CustomOperation "replica_timeout_in_seconds">]
        member _.ReplicaTimeoutInSeconds(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, Missing, 'ResourceGroupName, 'Template>, value: double) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, Present, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.ReplicaTimeoutInSeconds <- value)
            ({ assignments = state.assignments } : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, Present, 'ResourceGroupName, 'Template>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#resource_group_name-1">ContainerAppJob#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, Missing, 'Template>, value: string) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, Present, 'Template> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, Present, 'Template>)

        /// <summary>
        /// template block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#template-1">ContainerAppJob#template</a>
        /// </summary>
        [<CustomOperation "template">]
        member _.Template(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, Missing>, value: azurerm.ContainerAppJob.ContainerAppJobTemplate) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Template <- value)
            ({ assignments = state.assignments } : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, Present>)

        /// <summary>
        /// event_trigger_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#event_trigger_config-1">ContainerAppJob#event_trigger_config</a>
        /// </summary>
        [<CustomOperation "event_trigger_config">]
        member _.EventTriggerConfig(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: azurerm.ContainerAppJob.ContainerAppJobEventTriggerConfig) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.EventTriggerConfig <- value)
            state : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#id-1">ContainerAppJob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: string) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#identity-1">ContainerAppJob#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: azurerm.ContainerAppJob.ContainerAppJobIdentity) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>

        /// <summary>
        /// manual_trigger_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#manual_trigger_config-1">ContainerAppJob#manual_trigger_config</a>
        /// </summary>
        [<CustomOperation "manual_trigger_config">]
        member _.ManualTriggerConfig(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: azurerm.ContainerAppJob.ContainerAppJobManualTriggerConfig) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.ManualTriggerConfig <- value)
            state : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>

        /// <summary>
        /// registry block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#registry-1">ContainerAppJob#registry</a> Accepts: azurerm.IResolvable | azurerm.ContainerAppJob.ContainerAppJobRegistry[]
        /// </summary>
        [<CustomOperation "registry">]
        member _.Registry(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: HashiCorp.Cdktf.IResolvable) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.Registry <- value)
            state : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#replica_retry_limit-1">ContainerAppJob#replica_retry_limit</a>.
        /// </summary>
        [<CustomOperation "replica_retry_limit">]
        member _.ReplicaRetryLimit(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: double) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.ReplicaRetryLimit <- value)
            state : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>

        /// <summary>
        /// schedule_trigger_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#schedule_trigger_config-1">ContainerAppJob#schedule_trigger_config</a>
        /// </summary>
        [<CustomOperation "schedule_trigger_config">]
        member _.ScheduleTriggerConfig(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: azurerm.ContainerAppJob.ContainerAppJobScheduleTriggerConfig) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.ScheduleTriggerConfig <- value)
            state : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>

        /// <summary>
        /// secret block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#secret-1">ContainerAppJob#secret</a> Accepts: azurerm.IResolvable | azurerm.ContainerAppJob.ContainerAppJobSecret[]
        /// </summary>
        [<CustomOperation "secret">]
        member _.Secret(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: HashiCorp.Cdktf.IResolvable) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.Secret <- value)
            state : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#tags-1">ContainerAppJob#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: seq<string * string>) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#timeouts-1">ContainerAppJob#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: azurerm.ContainerAppJob.ContainerAppJobTimeouts) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_job#workload_profile_name-1">ContainerAppJob#workload_profile_name</a>.
        /// </summary>
        [<CustomOperation "workload_profile_name">]
        member _.WorkloadProfileName(state: ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>, value: string) : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template> =
            state.assignments.Add(fun config -> config.WorkloadProfileName <- value)
            state : ContainerAppJobState<'ContainerAppEnvironmentId, 'Location, 'Name, 'ReplicaTimeoutInSeconds, 'ResourceGroupName, 'Template>

        member _.Run(state: ContainerAppJobState<Present, Present, Present, Present, Present, Present>) : azurerm.ContainerAppJob.ContainerAppJob =
            let config = azurerm.ContainerAppJob.ContainerAppJobConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerAppJob.ContainerAppJob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerAppJob: missing required arguments. Must call: container_app_environment_id, location, name, replica_timeout_in_seconds, resource_group_name, template.", 9999, IsError = true)>]
        member _.Run(_: ContainerAppJobState<_, _, _, _, _, _>) : azurerm.ContainerAppJob.ContainerAppJob =
            Unchecked.defaultof<azurerm.ContainerAppJob.ContainerAppJob>
