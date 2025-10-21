namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticacheUserGroupState<'Engine, 'UserGroupId> = { assignments: ResizeArray<aws.ElasticacheUserGroup.ElasticacheUserGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group">aws_elasticache_user_group</a>.
    /// </summary>
    type ElasticacheUserGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticacheUserGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheUserGroupState<Missing, Missing>)

        member _.Zero(()) : ElasticacheUserGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheUserGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group#engine-1">ElasticacheUserGroup#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: ElasticacheUserGroupState<Missing, 'UserGroupId>, value: string) : ElasticacheUserGroupState<Present, 'UserGroupId> =
            state.assignments.Add(fun config -> config.Engine <- value)
            ({ assignments = state.assignments } : ElasticacheUserGroupState<Present, 'UserGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group#user_group_id-1">ElasticacheUserGroup#user_group_id</a>.
        /// </summary>
        [<CustomOperation "user_group_id">]
        member _.UserGroupId(state: ElasticacheUserGroupState<'Engine, Missing>, value: string) : ElasticacheUserGroupState<'Engine, Present> =
            state.assignments.Add(fun config -> config.UserGroupId <- value)
            ({ assignments = state.assignments } : ElasticacheUserGroupState<'Engine, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group#id-1">ElasticacheUserGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticacheUserGroupState<'Engine, 'UserGroupId>, value: string) : ElasticacheUserGroupState<'Engine, 'UserGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticacheUserGroupState<'Engine, 'UserGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group#tags-1">ElasticacheUserGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticacheUserGroupState<'Engine, 'UserGroupId>, value: seq<string * string>) : ElasticacheUserGroupState<'Engine, 'UserGroupId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticacheUserGroupState<'Engine, 'UserGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group#tags_all-1">ElasticacheUserGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ElasticacheUserGroupState<'Engine, 'UserGroupId>, value: seq<string * string>) : ElasticacheUserGroupState<'Engine, 'UserGroupId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ElasticacheUserGroupState<'Engine, 'UserGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group#user_ids-1">ElasticacheUserGroup#user_ids</a>.
        /// </summary>
        [<CustomOperation "user_ids">]
        member _.UserIds(state: ElasticacheUserGroupState<'Engine, 'UserGroupId>, value: seq<string>) : ElasticacheUserGroupState<'Engine, 'UserGroupId> =
            state.assignments.Add(fun config -> config.UserIds <- (value |> Seq.toArray))
            state : ElasticacheUserGroupState<'Engine, 'UserGroupId>

        member _.Run(state: ElasticacheUserGroupState<Present, Present>) : aws.ElasticacheUserGroup.ElasticacheUserGroup =
            let config = aws.ElasticacheUserGroup.ElasticacheUserGroupConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticacheUserGroup.ElasticacheUserGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticacheUserGroup: missing required arguments. Must call: engine, user_group_id.", 9999, IsError = true)>]
        member _.Run(_: ElasticacheUserGroupState<_, _>) : aws.ElasticacheUserGroup.ElasticacheUserGroup =
            Unchecked.defaultof<aws.ElasticacheUserGroup.ElasticacheUserGroup>
