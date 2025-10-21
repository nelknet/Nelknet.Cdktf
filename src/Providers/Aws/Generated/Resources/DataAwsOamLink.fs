namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOamLinkState<'LinkIdentifier> = { assignments: ResizeArray<aws.DataAwsOamLink.DataAwsOamLinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/oam_link">aws_oam_link</a>.
    /// </summary>
    type DataAwsOamLinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOamLinkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOamLinkState<Missing>)

        member _.Zero(()) : DataAwsOamLinkState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOamLinkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/oam_link#link_identifier-1">DataAwsOamLink#link_identifier</a>.
        /// </summary>
        [<CustomOperation "link_identifier">]
        member _.LinkIdentifier(state: DataAwsOamLinkState<Missing>, value: string) : DataAwsOamLinkState<Present> =
            state.assignments.Add(fun config -> config.LinkIdentifier <- value)
            ({ assignments = state.assignments } : DataAwsOamLinkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/oam_link#id-1">DataAwsOamLink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOamLinkState<'LinkIdentifier>, value: string) : DataAwsOamLinkState<'LinkIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOamLinkState<'LinkIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/oam_link#tags-1">DataAwsOamLink#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsOamLinkState<'LinkIdentifier>, value: seq<string * string>) : DataAwsOamLinkState<'LinkIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsOamLinkState<'LinkIdentifier>

        member _.Run(state: DataAwsOamLinkState<Present>) : aws.DataAwsOamLink.DataAwsOamLink =
            let config = aws.DataAwsOamLink.DataAwsOamLinkConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOamLink.DataAwsOamLink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOamLink: missing required arguments. Must call: link_identifier.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOamLinkState<_>) : aws.DataAwsOamLink.DataAwsOamLink =
            Unchecked.defaultof<aws.DataAwsOamLink.DataAwsOamLink>
