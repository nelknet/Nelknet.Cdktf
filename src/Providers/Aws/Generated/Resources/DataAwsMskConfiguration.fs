namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMskConfigurationState<'Name> = { assignments: ResizeArray<aws.DataAwsMskConfiguration.DataAwsMskConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_configuration">aws_msk_configuration</a>.
    /// </summary>
    type DataAwsMskConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMskConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskConfigurationState<Missing>)

        member _.Zero(()) : DataAwsMskConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_configuration#name-1">DataAwsMskConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsMskConfigurationState<Missing>, value: string) : DataAwsMskConfigurationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsMskConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_configuration#id-1">DataAwsMskConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMskConfigurationState<'Name>, value: string) : DataAwsMskConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMskConfigurationState<'Name>

        member _.Run(state: DataAwsMskConfigurationState<Present>) : aws.DataAwsMskConfiguration.DataAwsMskConfiguration =
            let config = aws.DataAwsMskConfiguration.DataAwsMskConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMskConfiguration.DataAwsMskConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMskConfiguration: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMskConfigurationState<_>) : aws.DataAwsMskConfiguration.DataAwsMskConfiguration =
            Unchecked.defaultof<aws.DataAwsMskConfiguration.DataAwsMskConfiguration>
