namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier> = { assignments: ResizeArray<aws.OamLink.OamLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link">aws_oam_link</a>.
    /// </summary>
    type OamLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : OamLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OamLinkState<Missing, Missing, Missing>)

        member _.Zero(()) : OamLinkState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OamLinkState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#label_template-1">OamLink#label_template</a>.
        /// </summary>
        [<CustomOperation "label_template">]
        member _.LabelTemplate(state: OamLinkState<Missing, 'ResourceTypes, 'SinkIdentifier>, value: string) : OamLinkState<Present, 'ResourceTypes, 'SinkIdentifier> =
            state.assignments.Add(fun config -> config.LabelTemplate <- value)
            ({ assignments = state.assignments } : OamLinkState<Present, 'ResourceTypes, 'SinkIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#resource_types-1">OamLink#resource_types</a>.
        /// </summary>
        [<CustomOperation "resource_types">]
        member _.ResourceTypes(state: OamLinkState<'LabelTemplate, Missing, 'SinkIdentifier>, value: seq<string>) : OamLinkState<'LabelTemplate, Present, 'SinkIdentifier> =
            state.assignments.Add(fun config -> config.ResourceTypes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : OamLinkState<'LabelTemplate, Present, 'SinkIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#sink_identifier-1">OamLink#sink_identifier</a>.
        /// </summary>
        [<CustomOperation "sink_identifier">]
        member _.SinkIdentifier(state: OamLinkState<'LabelTemplate, 'ResourceTypes, Missing>, value: string) : OamLinkState<'LabelTemplate, 'ResourceTypes, Present> =
            state.assignments.Add(fun config -> config.SinkIdentifier <- value)
            ({ assignments = state.assignments } : OamLinkState<'LabelTemplate, 'ResourceTypes, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#id-1">OamLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier>, value: string) : OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier>

        /// <summary>
        /// link_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#link_configuration-1">OamLink#link_configuration</a>
        /// </summary>
        [<CustomOperation "link_configuration">]
        member _.LinkConfiguration(state: OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier>, value: aws.OamLink.OamLinkLinkConfiguration) : OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier> =
            state.assignments.Add(fun config -> config.LinkConfiguration <- value)
            state : OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#tags-1">OamLink#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier>, value: seq<string * string>) : OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#tags_all-1">OamLink#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier>, value: seq<string * string>) : OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_link#timeouts-1">OamLink#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier>, value: aws.OamLink.OamLinkTimeouts) : OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OamLinkState<'LabelTemplate, 'ResourceTypes, 'SinkIdentifier>

        member _.Run(state: OamLinkState<Present, Present, Present>) : aws.OamLink.OamLink =
            let config = aws.OamLink.OamLinkConfig()
            for setter in state.assignments do
                setter config
            aws.OamLink.OamLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.oamLink: missing required arguments. Must call: label_template, resource_types, sink_identifier.", 9999, IsError = true)>]
        member _.Run(_: OamLinkState<_, _, _>) : aws.OamLink.OamLink =
            Unchecked.defaultof<aws.OamLink.OamLink>
