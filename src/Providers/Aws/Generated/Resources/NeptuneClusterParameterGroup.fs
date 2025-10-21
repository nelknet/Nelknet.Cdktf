namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NeptuneClusterParameterGroupState<'Family> = { assignments: ResizeArray<aws.NeptuneClusterParameterGroup.NeptuneClusterParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_parameter_group">aws_neptune_cluster_parameter_group</a>.
    /// </summary>
    type NeptuneClusterParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : NeptuneClusterParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : NeptuneClusterParameterGroupState<Missing>)

        member _.Zero(()) : NeptuneClusterParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : NeptuneClusterParameterGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_parameter_group#family-1">NeptuneClusterParameterGroup#family</a>.
        /// </summary>
        [<CustomOperation "family">]
        member _.Family(state: NeptuneClusterParameterGroupState<Missing>, value: string) : NeptuneClusterParameterGroupState<Present> =
            state.assignments.Add(fun config -> config.Family <- value)
            ({ assignments = state.assignments } : NeptuneClusterParameterGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_parameter_group#description-1">NeptuneClusterParameterGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NeptuneClusterParameterGroupState<'Family>, value: string) : NeptuneClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NeptuneClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_parameter_group#id-1">NeptuneClusterParameterGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NeptuneClusterParameterGroupState<'Family>, value: string) : NeptuneClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NeptuneClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_parameter_group#name-1">NeptuneClusterParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NeptuneClusterParameterGroupState<'Family>, value: string) : NeptuneClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : NeptuneClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_parameter_group#name_prefix-1">NeptuneClusterParameterGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: NeptuneClusterParameterGroupState<'Family>, value: string) : NeptuneClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : NeptuneClusterParameterGroupState<'Family>

        /// <summary>
        /// parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_parameter_group#parameter-1">NeptuneClusterParameterGroup#parameter</a> Accepts: aws.IResolvable | aws.NeptuneClusterParameterGroup.NeptuneClusterParameterGroupParameter[]
        /// </summary>
        [<CustomOperation "parameter">]
        member _.Parameter(state: NeptuneClusterParameterGroupState<'Family>, value: HashiCorp.Cdktf.IResolvable) : NeptuneClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Parameter <- value)
            state : NeptuneClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_parameter_group#tags-1">NeptuneClusterParameterGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NeptuneClusterParameterGroupState<'Family>, value: seq<string * string>) : NeptuneClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NeptuneClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster_parameter_group#tags_all-1">NeptuneClusterParameterGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: NeptuneClusterParameterGroupState<'Family>, value: seq<string * string>) : NeptuneClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : NeptuneClusterParameterGroupState<'Family>

        member _.Run(state: NeptuneClusterParameterGroupState<Present>) : aws.NeptuneClusterParameterGroup.NeptuneClusterParameterGroup =
            let config = aws.NeptuneClusterParameterGroup.NeptuneClusterParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.NeptuneClusterParameterGroup.NeptuneClusterParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.neptuneClusterParameterGroup: missing required arguments. Must call: family.", 9999, IsError = true)>]
        member _.Run(_: NeptuneClusterParameterGroupState<_>) : aws.NeptuneClusterParameterGroup.NeptuneClusterParameterGroup =
            Unchecked.defaultof<aws.NeptuneClusterParameterGroup.NeptuneClusterParameterGroup>
