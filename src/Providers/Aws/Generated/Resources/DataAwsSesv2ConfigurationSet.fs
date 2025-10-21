namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSesv2ConfigurationSetState<'ConfigurationSetName> = { assignments: ResizeArray<aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_configuration_set">aws_sesv2_configuration_set</a>.
    /// </summary>
    type DataAwsSesv2ConfigurationSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSesv2ConfigurationSetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesv2ConfigurationSetState<Missing>)

        member _.Zero(()) : DataAwsSesv2ConfigurationSetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSesv2ConfigurationSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_configuration_set#configuration_set_name-1">DataAwsSesv2ConfigurationSet#configuration_set_name</a>.
        /// </summary>
        [<CustomOperation "configuration_set_name">]
        member _.ConfigurationSetName(state: DataAwsSesv2ConfigurationSetState<Missing>, value: string) : DataAwsSesv2ConfigurationSetState<Present> =
            state.assignments.Add(fun config -> config.ConfigurationSetName <- value)
            ({ assignments = state.assignments } : DataAwsSesv2ConfigurationSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_configuration_set#id-1">DataAwsSesv2ConfigurationSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSesv2ConfigurationSetState<'ConfigurationSetName>, value: string) : DataAwsSesv2ConfigurationSetState<'ConfigurationSetName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSesv2ConfigurationSetState<'ConfigurationSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sesv2_configuration_set#tags-1">DataAwsSesv2ConfigurationSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSesv2ConfigurationSetState<'ConfigurationSetName>, value: seq<string * string>) : DataAwsSesv2ConfigurationSetState<'ConfigurationSetName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSesv2ConfigurationSetState<'ConfigurationSetName>

        member _.Run(state: DataAwsSesv2ConfigurationSetState<Present>) : aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSet =
            let config = aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSesv2ConfigurationSet: missing required arguments. Must call: configuration_set_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSesv2ConfigurationSetState<_>) : aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSet =
            Unchecked.defaultof<aws.DataAwsSesv2ConfigurationSet.DataAwsSesv2ConfigurationSet>
