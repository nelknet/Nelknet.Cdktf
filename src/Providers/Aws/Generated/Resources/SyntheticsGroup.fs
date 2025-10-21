namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SyntheticsGroupState<'Name> = { assignments: ResizeArray<aws.SyntheticsGroup.SyntheticsGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_group">aws_synthetics_group</a>.
    /// </summary>
    type SyntheticsGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : SyntheticsGroupState<Missing> =
            ({ assignments = ResizeArray() } : SyntheticsGroupState<Missing>)

        member _.Zero(()) : SyntheticsGroupState<Missing> =
            ({ assignments = ResizeArray() } : SyntheticsGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_group#name-1">SyntheticsGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SyntheticsGroupState<Missing>, value: string) : SyntheticsGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SyntheticsGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_group#id-1">SyntheticsGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SyntheticsGroupState<'Name>, value: string) : SyntheticsGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SyntheticsGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_group#tags-1">SyntheticsGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SyntheticsGroupState<'Name>, value: seq<string * string>) : SyntheticsGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SyntheticsGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_group#tags_all-1">SyntheticsGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SyntheticsGroupState<'Name>, value: seq<string * string>) : SyntheticsGroupState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SyntheticsGroupState<'Name>

        member _.Run(state: SyntheticsGroupState<Present>) : aws.SyntheticsGroup.SyntheticsGroup =
            let config = aws.SyntheticsGroup.SyntheticsGroupConfig()
            for setter in state.assignments do
                setter config
            aws.SyntheticsGroup.SyntheticsGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.syntheticsGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: SyntheticsGroupState<_>) : aws.SyntheticsGroup.SyntheticsGroup =
            Unchecked.defaultof<aws.SyntheticsGroup.SyntheticsGroup>
