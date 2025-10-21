namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticacheParameterGroupState<'Family, 'Name> = { assignments: ResizeArray<aws.ElasticacheParameterGroup.ElasticacheParameterGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_parameter_group">aws_elasticache_parameter_group</a>.
    /// </summary>
    type ElasticacheParameterGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticacheParameterGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheParameterGroupState<Missing, Missing>)

        member _.Zero(()) : ElasticacheParameterGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheParameterGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_parameter_group#family-1">ElasticacheParameterGroup#family</a>.
        /// </summary>
        [<CustomOperation "family">]
        member _.Family(state: ElasticacheParameterGroupState<Missing, 'Name>, value: string) : ElasticacheParameterGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Family <- value)
            ({ assignments = state.assignments } : ElasticacheParameterGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_parameter_group#name-1">ElasticacheParameterGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElasticacheParameterGroupState<'Family, Missing>, value: string) : ElasticacheParameterGroupState<'Family, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ElasticacheParameterGroupState<'Family, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_parameter_group#description-1">ElasticacheParameterGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ElasticacheParameterGroupState<'Family, 'Name>, value: string) : ElasticacheParameterGroupState<'Family, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ElasticacheParameterGroupState<'Family, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_parameter_group#id-1">ElasticacheParameterGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticacheParameterGroupState<'Family, 'Name>, value: string) : ElasticacheParameterGroupState<'Family, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticacheParameterGroupState<'Family, 'Name>

        /// <summary>
        /// parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_parameter_group#parameter-1">ElasticacheParameterGroup#parameter</a> Accepts: aws.IResolvable | aws.ElasticacheParameterGroup.ElasticacheParameterGroupParameter[]
        /// </summary>
        [<CustomOperation "parameter">]
        member _.Parameter(state: ElasticacheParameterGroupState<'Family, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ElasticacheParameterGroupState<'Family, 'Name> =
            state.assignments.Add(fun config -> config.Parameter <- value)
            state : ElasticacheParameterGroupState<'Family, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_parameter_group#tags-1">ElasticacheParameterGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticacheParameterGroupState<'Family, 'Name>, value: seq<string * string>) : ElasticacheParameterGroupState<'Family, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticacheParameterGroupState<'Family, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_parameter_group#tags_all-1">ElasticacheParameterGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ElasticacheParameterGroupState<'Family, 'Name>, value: seq<string * string>) : ElasticacheParameterGroupState<'Family, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ElasticacheParameterGroupState<'Family, 'Name>

        member _.Run(state: ElasticacheParameterGroupState<Present, Present>) : aws.ElasticacheParameterGroup.ElasticacheParameterGroup =
            let config = aws.ElasticacheParameterGroup.ElasticacheParameterGroupConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticacheParameterGroup.ElasticacheParameterGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticacheParameterGroup: missing required arguments. Must call: family, name.", 9999, IsError = true)>]
        member _.Run(_: ElasticacheParameterGroupState<_, _>) : aws.ElasticacheParameterGroup.ElasticacheParameterGroup =
            Unchecked.defaultof<aws.ElasticacheParameterGroup.ElasticacheParameterGroup>
