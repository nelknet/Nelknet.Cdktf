namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMskconnectWorkerConfigurationState<'Name> = { assignments: ResizeArray<aws.DataAwsMskconnectWorkerConfiguration.DataAwsMskconnectWorkerConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_worker_configuration">aws_mskconnect_worker_configuration</a>.
    /// </summary>
    type DataAwsMskconnectWorkerConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMskconnectWorkerConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskconnectWorkerConfigurationState<Missing>)

        member _.Zero(()) : DataAwsMskconnectWorkerConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskconnectWorkerConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_worker_configuration#name-1">DataAwsMskconnectWorkerConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsMskconnectWorkerConfigurationState<Missing>, value: string) : DataAwsMskconnectWorkerConfigurationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsMskconnectWorkerConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_worker_configuration#id-1">DataAwsMskconnectWorkerConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMskconnectWorkerConfigurationState<'Name>, value: string) : DataAwsMskconnectWorkerConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMskconnectWorkerConfigurationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_worker_configuration#tags-1">DataAwsMskconnectWorkerConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMskconnectWorkerConfigurationState<'Name>, value: seq<string * string>) : DataAwsMskconnectWorkerConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMskconnectWorkerConfigurationState<'Name>

        member _.Run(state: DataAwsMskconnectWorkerConfigurationState<Present>) : aws.DataAwsMskconnectWorkerConfiguration.DataAwsMskconnectWorkerConfiguration =
            let config = aws.DataAwsMskconnectWorkerConfiguration.DataAwsMskconnectWorkerConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMskconnectWorkerConfiguration.DataAwsMskconnectWorkerConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMskconnectWorkerConfiguration: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMskconnectWorkerConfigurationState<_>) : aws.DataAwsMskconnectWorkerConfiguration.DataAwsMskconnectWorkerConfiguration =
            Unchecked.defaultof<aws.DataAwsMskconnectWorkerConfiguration.DataAwsMskconnectWorkerConfiguration>
