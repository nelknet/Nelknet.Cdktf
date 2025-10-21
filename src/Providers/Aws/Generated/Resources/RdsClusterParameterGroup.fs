namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsClusterParameterGroupState<'Family> = { assignments: ResizeArray<aws.RdsClusterParameterGroup.RdsClusterParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_parameter_group">aws_rds_cluster_parameter_group</a>.
    /// </summary>
    type RdsClusterParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsClusterParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : RdsClusterParameterGroupState<Missing>)

        member _.Zero(()) : RdsClusterParameterGroupState<Missing> =
            ({ assignments = ResizeArray() } : RdsClusterParameterGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_parameter_group#family-1">RdsClusterParameterGroup#family</a>.
        /// </summary>
        [<CustomOperation "family">]
        member _.Family(state: RdsClusterParameterGroupState<Missing>, value: string) : RdsClusterParameterGroupState<Present> =
            state.assignments.Add(fun config -> config.Family <- value)
            ({ assignments = state.assignments } : RdsClusterParameterGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_parameter_group#description-1">RdsClusterParameterGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: RdsClusterParameterGroupState<'Family>, value: string) : RdsClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : RdsClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_parameter_group#id-1">RdsClusterParameterGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RdsClusterParameterGroupState<'Family>, value: string) : RdsClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RdsClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_parameter_group#name-1">RdsClusterParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RdsClusterParameterGroupState<'Family>, value: string) : RdsClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : RdsClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_parameter_group#name_prefix-1">RdsClusterParameterGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: RdsClusterParameterGroupState<'Family>, value: string) : RdsClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : RdsClusterParameterGroupState<'Family>

        /// <summary>
        /// parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_parameter_group#parameter-1">RdsClusterParameterGroup#parameter</a> Accepts: aws.IResolvable | aws.RdsClusterParameterGroup.RdsClusterParameterGroupParameter[]
        /// </summary>
        [<CustomOperation "parameter">]
        member _.Parameter(state: RdsClusterParameterGroupState<'Family>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Parameter <- value)
            state : RdsClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_parameter_group#tags-1">RdsClusterParameterGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RdsClusterParameterGroupState<'Family>, value: seq<string * string>) : RdsClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RdsClusterParameterGroupState<'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_parameter_group#tags_all-1">RdsClusterParameterGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RdsClusterParameterGroupState<'Family>, value: seq<string * string>) : RdsClusterParameterGroupState<'Family> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RdsClusterParameterGroupState<'Family>

        member _.Run(state: RdsClusterParameterGroupState<Present>) : aws.RdsClusterParameterGroup.RdsClusterParameterGroup =
            let config = aws.RdsClusterParameterGroup.RdsClusterParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.RdsClusterParameterGroup.RdsClusterParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsClusterParameterGroup: missing required arguments. Must call: family.", 9999, IsError = true)>]
        member _.Run(_: RdsClusterParameterGroupState<_>) : aws.RdsClusterParameterGroup.RdsClusterParameterGroup =
            Unchecked.defaultof<aws.RdsClusterParameterGroup.RdsClusterParameterGroup>
