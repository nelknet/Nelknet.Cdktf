namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig> = { assignments: ResizeArray<aws.AppflowFlow.AppflowFlowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow">aws_appflow_flow</a>.
    /// </summary>
    type AppflowFlowBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppflowFlowState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppflowFlowState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppflowFlowState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppflowFlowState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// destination_flow_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#destination_flow_config-1">AppflowFlow#destination_flow_config</a> Accepts: aws.IResolvable | aws.AppflowFlow.AppflowFlowDestinationFlowConfig[]
        /// </summary>
        [<CustomOperation "destination_flow_config">]
        member _.DestinationFlowConfig(state: AppflowFlowState<Missing, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>, value: HashiCorp.Cdktf.IResolvable) : AppflowFlowState<Present, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig> =
            state.assignments.Add(fun config -> config.DestinationFlowConfig <- value)
            ({ assignments = state.assignments } : AppflowFlowState<Present, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#name-1">AppflowFlow#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppflowFlowState<'DestinationFlowConfig, Missing, 'SourceFlowConfig, 'Task, 'TriggerConfig>, value: string) : AppflowFlowState<'DestinationFlowConfig, Present, 'SourceFlowConfig, 'Task, 'TriggerConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppflowFlowState<'DestinationFlowConfig, Present, 'SourceFlowConfig, 'Task, 'TriggerConfig>)

        /// <summary>
        /// source_flow_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#source_flow_config-1">AppflowFlow#source_flow_config</a>
        /// </summary>
        [<CustomOperation "source_flow_config">]
        member _.SourceFlowConfig(state: AppflowFlowState<'DestinationFlowConfig, 'Name, Missing, 'Task, 'TriggerConfig>, value: aws.AppflowFlow.AppflowFlowSourceFlowConfig) : AppflowFlowState<'DestinationFlowConfig, 'Name, Present, 'Task, 'TriggerConfig> =
            state.assignments.Add(fun config -> config.SourceFlowConfig <- value)
            ({ assignments = state.assignments } : AppflowFlowState<'DestinationFlowConfig, 'Name, Present, 'Task, 'TriggerConfig>)

        /// <summary>
        /// task block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#task-1">AppflowFlow#task</a> Accepts: aws.IResolvable | aws.AppflowFlow.AppflowFlowTask[]
        /// </summary>
        [<CustomOperation "task">]
        member _.Task(state: AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, Missing, 'TriggerConfig>, value: HashiCorp.Cdktf.IResolvable) : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, Present, 'TriggerConfig> =
            state.assignments.Add(fun config -> config.Task <- value)
            ({ assignments = state.assignments } : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, Present, 'TriggerConfig>)

        /// <summary>
        /// trigger_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#trigger_config-1">AppflowFlow#trigger_config</a>
        /// </summary>
        [<CustomOperation "trigger_config">]
        member _.TriggerConfig(state: AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, Missing>, value: aws.AppflowFlow.AppflowFlowTriggerConfig) : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, Present> =
            state.assignments.Add(fun config -> config.TriggerConfig <- value)
            ({ assignments = state.assignments } : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#description-1">AppflowFlow#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>, value: string) : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#id-1">AppflowFlow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>, value: string) : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#kms_arn-1">AppflowFlow#kms_arn</a>.
        /// </summary>
        [<CustomOperation "kms_arn">]
        member _.KmsArn(state: AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>, value: string) : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig> =
            state.assignments.Add(fun config -> config.KmsArn <- value)
            state : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>

        /// <summary>
        /// metadata_catalog_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#metadata_catalog_config-1">AppflowFlow#metadata_catalog_config</a>
        /// </summary>
        [<CustomOperation "metadata_catalog_config">]
        member _.MetadataCatalogConfig(state: AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>, value: aws.AppflowFlow.AppflowFlowMetadataCatalogConfig) : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig> =
            state.assignments.Add(fun config -> config.MetadataCatalogConfig <- value)
            state : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#tags-1">AppflowFlow#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>, value: seq<string * string>) : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#tags_all-1">AppflowFlow#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>, value: seq<string * string>) : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppflowFlowState<'DestinationFlowConfig, 'Name, 'SourceFlowConfig, 'Task, 'TriggerConfig>

        member _.Run(state: AppflowFlowState<Present, Present, Present, Present, Present>) : aws.AppflowFlow.AppflowFlow =
            let config = aws.AppflowFlow.AppflowFlowConfig()
            for setter in state.assignments do
                setter config
            aws.AppflowFlow.AppflowFlow(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appflowFlow: missing required arguments. Must call: destination_flow_config, name, source_flow_config, task, trigger_config.", 9999, IsError = true)>]
        member _.Run(_: AppflowFlowState<_, _, _, _, _>) : aws.AppflowFlow.AppflowFlow =
            Unchecked.defaultof<aws.AppflowFlow.AppflowFlow>
