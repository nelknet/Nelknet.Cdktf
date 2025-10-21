namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MskconnectCustomPluginState<'ContentType, 'Location, 'Name> = { assignments: ResizeArray<aws.MskconnectCustomPlugin.MskconnectCustomPluginConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin">aws_mskconnect_custom_plugin</a>.
    /// </summary>
    type MskconnectCustomPluginBuilder(logicalId: string) =
        member _.Yield(_: unit) : MskconnectCustomPluginState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskconnectCustomPluginState<Missing, Missing, Missing>)

        member _.Zero(()) : MskconnectCustomPluginState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MskconnectCustomPluginState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#content_type-1">MskconnectCustomPlugin#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: MskconnectCustomPluginState<Missing, 'Location, 'Name>, value: string) : MskconnectCustomPluginState<Present, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            ({ assignments = state.assignments } : MskconnectCustomPluginState<Present, 'Location, 'Name>)

        /// <summary>
        /// location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#location-1">MskconnectCustomPlugin#location</a>
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MskconnectCustomPluginState<'ContentType, Missing, 'Name>, value: aws.MskconnectCustomPlugin.MskconnectCustomPluginLocation) : MskconnectCustomPluginState<'ContentType, Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MskconnectCustomPluginState<'ContentType, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#name-1">MskconnectCustomPlugin#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MskconnectCustomPluginState<'ContentType, 'Location, Missing>, value: string) : MskconnectCustomPluginState<'ContentType, 'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MskconnectCustomPluginState<'ContentType, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#description-1">MskconnectCustomPlugin#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MskconnectCustomPluginState<'ContentType, 'Location, 'Name>, value: string) : MskconnectCustomPluginState<'ContentType, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MskconnectCustomPluginState<'ContentType, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#id-1">MskconnectCustomPlugin#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MskconnectCustomPluginState<'ContentType, 'Location, 'Name>, value: string) : MskconnectCustomPluginState<'ContentType, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MskconnectCustomPluginState<'ContentType, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#tags-1">MskconnectCustomPlugin#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MskconnectCustomPluginState<'ContentType, 'Location, 'Name>, value: seq<string * string>) : MskconnectCustomPluginState<'ContentType, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MskconnectCustomPluginState<'ContentType, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#tags_all-1">MskconnectCustomPlugin#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MskconnectCustomPluginState<'ContentType, 'Location, 'Name>, value: seq<string * string>) : MskconnectCustomPluginState<'ContentType, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MskconnectCustomPluginState<'ContentType, 'Location, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#timeouts-1">MskconnectCustomPlugin#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MskconnectCustomPluginState<'ContentType, 'Location, 'Name>, value: aws.MskconnectCustomPlugin.MskconnectCustomPluginTimeouts) : MskconnectCustomPluginState<'ContentType, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MskconnectCustomPluginState<'ContentType, 'Location, 'Name>

        member _.Run(state: MskconnectCustomPluginState<Present, Present, Present>) : aws.MskconnectCustomPlugin.MskconnectCustomPlugin =
            let config = aws.MskconnectCustomPlugin.MskconnectCustomPluginConfig()
            for setter in state.assignments do
                setter config
            aws.MskconnectCustomPlugin.MskconnectCustomPlugin(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mskconnectCustomPlugin: missing required arguments. Must call: content_type, location, name.", 9999, IsError = true)>]
        member _.Run(_: MskconnectCustomPluginState<_, _, _>) : aws.MskconnectCustomPlugin.MskconnectCustomPlugin =
            Unchecked.defaultof<aws.MskconnectCustomPlugin.MskconnectCustomPlugin>
