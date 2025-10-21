namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NeptuneParameterGroupState<'Family> = { assignments: ResizeArray<aws.NeptuneParameterGroup.NeptuneParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_parameter_group">aws_neptune_parameter_group</a>.
    /// </summary>
    type NeptuneParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : NeptuneParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : NeptuneParameterGroupState<Missing>)

        member _.Zero(()) : NeptuneParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : NeptuneParameterGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_parameter_group#family-1">NeptuneParameterGroup#family</a>.
        /// </summary>
        [<CustomOperation "family">]
        member _.Family(state: NeptuneParameterGroupState<Missing>, value: string) : NeptuneParameterGroupState<Present> =
            state.assignments.Add(fun config -> config.Family <- value)
            ({ assignments = state.assignments } : NeptuneParameterGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_parameter_group#description-1">NeptuneParameterGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NeptuneParameterGroupState<'Family>, value: string) : NeptuneParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NeptuneParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_parameter_group#id-1">NeptuneParameterGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NeptuneParameterGroupState<'Family>, value: string) : NeptuneParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NeptuneParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_parameter_group#name-1">NeptuneParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NeptuneParameterGroupState<'Family>, value: string) : NeptuneParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : NeptuneParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_parameter_group#name_prefix-1">NeptuneParameterGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: NeptuneParameterGroupState<'Family>, value: string) : NeptuneParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : NeptuneParameterGroupState<'Family>

        /// <summary>
        /// parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_parameter_group#parameter-1">NeptuneParameterGroup#parameter</a> Accepts: aws.IResolvable | aws.NeptuneParameterGroup.NeptuneParameterGroupParameter[]
        /// </summary>
        [<CustomOperation "parameter">]
        member _.Parameter(state: NeptuneParameterGroupState<'Family>, value: HashiCorp.Cdktf.IResolvable) : NeptuneParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Parameter <- value)
            state : NeptuneParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_parameter_group#tags-1">NeptuneParameterGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NeptuneParameterGroupState<'Family>, value: seq<string * string>) : NeptuneParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NeptuneParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_parameter_group#tags_all-1">NeptuneParameterGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NeptuneParameterGroupState<'Family>, value: seq<string * string>) : NeptuneParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NeptuneParameterGroupState<'Family>

        member _.Run(state: NeptuneParameterGroupState<Present>) : aws.NeptuneParameterGroup.NeptuneParameterGroup =
            let config = aws.NeptuneParameterGroup.NeptuneParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.NeptuneParameterGroup.NeptuneParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.neptuneParameterGroup: missing required arguments. Must call: family.", 9999, IsError = true)>]
        member _.Run(_: NeptuneParameterGroupState<_>) : aws.NeptuneParameterGroup.NeptuneParameterGroup =
            Unchecked.defaultof<aws.NeptuneParameterGroup.NeptuneParameterGroup>
