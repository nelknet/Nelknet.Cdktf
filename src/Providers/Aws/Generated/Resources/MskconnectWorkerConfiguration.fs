namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent> = { assignments: ResizeArray<aws.MskconnectWorkerConfiguration.MskconnectWorkerConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_worker_configuration">aws_mskconnect_worker_configuration</a>.
    /// </summary>
    type MskconnectWorkerConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : MskconnectWorkerConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MskconnectWorkerConfigurationState<Missing, Missing>)

        member _.Zero(()) : MskconnectWorkerConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MskconnectWorkerConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_worker_configuration#name-1">MskconnectWorkerConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MskconnectWorkerConfigurationState<Missing, 'PropertiesFileContent>, value: string) : MskconnectWorkerConfigurationState<Present, 'PropertiesFileContent> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MskconnectWorkerConfigurationState<Present, 'PropertiesFileContent>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_worker_configuration#properties_file_content-1">MskconnectWorkerConfiguration#properties_file_content</a>.
        /// </summary>
        [<CustomOperation "properties_file_content">]
        member _.PropertiesFileContent(state: MskconnectWorkerConfigurationState<'Name, Missing>, value: string) : MskconnectWorkerConfigurationState<'Name, Present> =
            state.assignments.Add(fun config -> config.PropertiesFileContent <- value)
            ({ assignments = state.assignments } : MskconnectWorkerConfigurationState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_worker_configuration#description-1">MskconnectWorkerConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent>, value: string) : MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_worker_configuration#id-1">MskconnectWorkerConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent>, value: string) : MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_worker_configuration#tags-1">MskconnectWorkerConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent>, value: seq<string * string>) : MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_worker_configuration#tags_all-1">MskconnectWorkerConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent>, value: seq<string * string>) : MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_worker_configuration#timeouts-1">MskconnectWorkerConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent>, value: aws.MskconnectWorkerConfiguration.MskconnectWorkerConfigurationTimeouts) : MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MskconnectWorkerConfigurationState<'Name, 'PropertiesFileContent>

        member _.Run(state: MskconnectWorkerConfigurationState<Present, Present>) : aws.MskconnectWorkerConfiguration.MskconnectWorkerConfiguration =
            let config = aws.MskconnectWorkerConfiguration.MskconnectWorkerConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.MskconnectWorkerConfiguration.MskconnectWorkerConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mskconnectWorkerConfiguration: missing required arguments. Must call: name, properties_file_content.", 9999, IsError = true)>]
        member _.Run(_: MskconnectWorkerConfigurationState<_, _>) : aws.MskconnectWorkerConfiguration.MskconnectWorkerConfiguration =
            Unchecked.defaultof<aws.MskconnectWorkerConfiguration.MskconnectWorkerConfiguration>
