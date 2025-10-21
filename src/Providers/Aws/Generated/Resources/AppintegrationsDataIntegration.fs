namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri> = { assignments: ResizeArray<aws.AppintegrationsDataIntegration.AppintegrationsDataIntegrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration">aws_appintegrations_data_integration</a>.
    /// </summary>
    type AppintegrationsDataIntegrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppintegrationsDataIntegrationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppintegrationsDataIntegrationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppintegrationsDataIntegrationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppintegrationsDataIntegrationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#kms_key-1">AppintegrationsDataIntegration#kms_key</a>.
        /// </summary>
        [<CustomOperation "kms_key">]
        member _.KmsKey(state: AppintegrationsDataIntegrationState<Missing, 'Name, 'ScheduleConfig, 'SourceUri>, value: string) : AppintegrationsDataIntegrationState<Present, 'Name, 'ScheduleConfig, 'SourceUri> =
            state.assignments.Add(fun config -> config.KmsKey <- value)
            ({ assignments = state.assignments } : AppintegrationsDataIntegrationState<Present, 'Name, 'ScheduleConfig, 'SourceUri>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#name-1">AppintegrationsDataIntegration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppintegrationsDataIntegrationState<'KmsKey, Missing, 'ScheduleConfig, 'SourceUri>, value: string) : AppintegrationsDataIntegrationState<'KmsKey, Present, 'ScheduleConfig, 'SourceUri> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppintegrationsDataIntegrationState<'KmsKey, Present, 'ScheduleConfig, 'SourceUri>)

        /// <summary>
        /// schedule_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#schedule_config-1">AppintegrationsDataIntegration#schedule_config</a>
        /// </summary>
        [<CustomOperation "schedule_config">]
        member _.ScheduleConfig(state: AppintegrationsDataIntegrationState<'KmsKey, 'Name, Missing, 'SourceUri>, value: aws.AppintegrationsDataIntegration.AppintegrationsDataIntegrationScheduleConfig) : AppintegrationsDataIntegrationState<'KmsKey, 'Name, Present, 'SourceUri> =
            state.assignments.Add(fun config -> config.ScheduleConfig <- value)
            ({ assignments = state.assignments } : AppintegrationsDataIntegrationState<'KmsKey, 'Name, Present, 'SourceUri>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#source_uri-1">AppintegrationsDataIntegration#source_uri</a>.
        /// </summary>
        [<CustomOperation "source_uri">]
        member _.SourceUri(state: AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, Missing>, value: string) : AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, Present> =
            state.assignments.Add(fun config -> config.SourceUri <- value)
            ({ assignments = state.assignments } : AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#description-1">AppintegrationsDataIntegration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri>, value: string) : AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#id-1">AppintegrationsDataIntegration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri>, value: string) : AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#tags-1">AppintegrationsDataIntegration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri>, value: seq<string * string>) : AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_data_integration#tags_all-1">AppintegrationsDataIntegration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri>, value: seq<string * string>) : AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppintegrationsDataIntegrationState<'KmsKey, 'Name, 'ScheduleConfig, 'SourceUri>

        member _.Run(state: AppintegrationsDataIntegrationState<Present, Present, Present, Present>) : aws.AppintegrationsDataIntegration.AppintegrationsDataIntegration =
            let config = aws.AppintegrationsDataIntegration.AppintegrationsDataIntegrationConfig()
            for setter in state.assignments do
                setter config
            aws.AppintegrationsDataIntegration.AppintegrationsDataIntegration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appintegrationsDataIntegration: missing required arguments. Must call: kms_key, name, schedule_config, source_uri.", 9999, IsError = true)>]
        member _.Run(_: AppintegrationsDataIntegrationState<_, _, _, _>) : aws.AppintegrationsDataIntegration.AppintegrationsDataIntegration =
            Unchecked.defaultof<aws.AppintegrationsDataIntegration.AppintegrationsDataIntegration>
