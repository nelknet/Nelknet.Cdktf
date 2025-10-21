namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DocdbClusterParameterGroupState<'Family> = { assignments: ResizeArray<aws.DocdbClusterParameterGroup.DocdbClusterParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group">aws_docdb_cluster_parameter_group</a>.
    /// </summary>
    type DocdbClusterParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DocdbClusterParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DocdbClusterParameterGroupState<Missing>)

        member _.Zero(()) : DocdbClusterParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : DocdbClusterParameterGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#family-1">DocdbClusterParameterGroup#family</a>.
        /// </summary>
        [<CustomOperation "family">]
        member _.Family(state: DocdbClusterParameterGroupState<Missing>, value: string) : DocdbClusterParameterGroupState<Present> =
            state.assignments.Add(fun config -> config.Family <- value)
            ({ assignments = state.assignments } : DocdbClusterParameterGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#description-1">DocdbClusterParameterGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DocdbClusterParameterGroupState<'Family>, value: string) : DocdbClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DocdbClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#id-1">DocdbClusterParameterGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DocdbClusterParameterGroupState<'Family>, value: string) : DocdbClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DocdbClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#name-1">DocdbClusterParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DocdbClusterParameterGroupState<'Family>, value: string) : DocdbClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DocdbClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#name_prefix-1">DocdbClusterParameterGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DocdbClusterParameterGroupState<'Family>, value: string) : DocdbClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DocdbClusterParameterGroupState<'Family>

        /// <summary>
        /// parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#parameter-1">DocdbClusterParameterGroup#parameter</a> Accepts: aws.IResolvable | aws.DocdbClusterParameterGroup.DocdbClusterParameterGroupParameter[]
        /// </summary>
        [<CustomOperation "parameter">]
        member _.Parameter(state: DocdbClusterParameterGroupState<'Family>, value: HashiCorp.Cdktf.IResolvable) : DocdbClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Parameter <- value)
            state : DocdbClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#tags-1">DocdbClusterParameterGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DocdbClusterParameterGroupState<'Family>, value: seq<string * string>) : DocdbClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DocdbClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#tags_all-1">DocdbClusterParameterGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DocdbClusterParameterGroupState<'Family>, value: seq<string * string>) : DocdbClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DocdbClusterParameterGroupState<'Family>

        member _.Run(state: DocdbClusterParameterGroupState<Present>) : aws.DocdbClusterParameterGroup.DocdbClusterParameterGroup =
            let config = aws.DocdbClusterParameterGroup.DocdbClusterParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DocdbClusterParameterGroup.DocdbClusterParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.docdbClusterParameterGroup: missing required arguments. Must call: family.", 9999, IsError = true)>]
        member _.Run(_: DocdbClusterParameterGroupState<_>) : aws.DocdbClusterParameterGroup.DocdbClusterParameterGroup =
            Unchecked.defaultof<aws.DocdbClusterParameterGroup.DocdbClusterParameterGroup>
