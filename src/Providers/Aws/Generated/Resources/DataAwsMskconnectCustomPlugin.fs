namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMskconnectCustomPluginState<'Name> = { assignments: ResizeArray<aws.DataAwsMskconnectCustomPlugin.DataAwsMskconnectCustomPluginConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_custom_plugin">aws_mskconnect_custom_plugin</a>.
    /// </summary>
    type DataAwsMskconnectCustomPluginBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMskconnectCustomPluginState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskconnectCustomPluginState<Missing>)

        member _.Zero(()) : DataAwsMskconnectCustomPluginState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskconnectCustomPluginState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_custom_plugin#name-1">DataAwsMskconnectCustomPlugin#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsMskconnectCustomPluginState<Missing>, value: string) : DataAwsMskconnectCustomPluginState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsMskconnectCustomPluginState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_custom_plugin#id-1">DataAwsMskconnectCustomPlugin#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMskconnectCustomPluginState<'Name>, value: string) : DataAwsMskconnectCustomPluginState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMskconnectCustomPluginState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/mskconnect_custom_plugin#tags-1">DataAwsMskconnectCustomPlugin#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsMskconnectCustomPluginState<'Name>, value: seq<string * string>) : DataAwsMskconnectCustomPluginState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsMskconnectCustomPluginState<'Name>

        member _.Run(state: DataAwsMskconnectCustomPluginState<Present>) : aws.DataAwsMskconnectCustomPlugin.DataAwsMskconnectCustomPlugin =
            let config = aws.DataAwsMskconnectCustomPlugin.DataAwsMskconnectCustomPluginConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMskconnectCustomPlugin.DataAwsMskconnectCustomPlugin(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMskconnectCustomPlugin: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMskconnectCustomPluginState<_>) : aws.DataAwsMskconnectCustomPlugin.DataAwsMskconnectCustomPlugin =
            Unchecked.defaultof<aws.DataAwsMskconnectCustomPlugin.DataAwsMskconnectCustomPlugin>
