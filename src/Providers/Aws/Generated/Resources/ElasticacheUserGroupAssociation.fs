namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticacheUserGroupAssociationState<'UserGroupId, 'UserId> = { assignments: ResizeArray<aws.ElasticacheUserGroupAssociation.ElasticacheUserGroupAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group_association">aws_elasticache_user_group_association</a>.
    /// </summary>
    type ElasticacheUserGroupAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticacheUserGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheUserGroupAssociationState<Missing, Missing>)

        member _.Zero(()) : ElasticacheUserGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheUserGroupAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group_association#user_group_id-1">ElasticacheUserGroupAssociation#user_group_id</a>.
        /// </summary>
        [<CustomOperation "user_group_id">]
        member _.UserGroupId(state: ElasticacheUserGroupAssociationState<Missing, 'UserId>, value: string) : ElasticacheUserGroupAssociationState<Present, 'UserId> =
            state.assignments.Add(fun config -> config.UserGroupId <- value)
            ({ assignments = state.assignments } : ElasticacheUserGroupAssociationState<Present, 'UserId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group_association#user_id-1">ElasticacheUserGroupAssociation#user_id</a>.
        /// </summary>
        [<CustomOperation "user_id">]
        member _.UserId(state: ElasticacheUserGroupAssociationState<'UserGroupId, Missing>, value: string) : ElasticacheUserGroupAssociationState<'UserGroupId, Present> =
            state.assignments.Add(fun config -> config.UserId <- value)
            ({ assignments = state.assignments } : ElasticacheUserGroupAssociationState<'UserGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group_association#id-1">ElasticacheUserGroupAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticacheUserGroupAssociationState<'UserGroupId, 'UserId>, value: string) : ElasticacheUserGroupAssociationState<'UserGroupId, 'UserId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticacheUserGroupAssociationState<'UserGroupId, 'UserId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user_group_association#timeouts-1">ElasticacheUserGroupAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticacheUserGroupAssociationState<'UserGroupId, 'UserId>, value: aws.ElasticacheUserGroupAssociation.ElasticacheUserGroupAssociationTimeouts) : ElasticacheUserGroupAssociationState<'UserGroupId, 'UserId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticacheUserGroupAssociationState<'UserGroupId, 'UserId>

        member _.Run(state: ElasticacheUserGroupAssociationState<Present, Present>) : aws.ElasticacheUserGroupAssociation.ElasticacheUserGroupAssociation =
            let config = aws.ElasticacheUserGroupAssociation.ElasticacheUserGroupAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticacheUserGroupAssociation.ElasticacheUserGroupAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticacheUserGroupAssociation: missing required arguments. Must call: user_group_id, user_id.", 9999, IsError = true)>]
        member _.Run(_: ElasticacheUserGroupAssociationState<_, _>) : aws.ElasticacheUserGroupAssociation.ElasticacheUserGroupAssociation =
            Unchecked.defaultof<aws.ElasticacheUserGroupAssociation.ElasticacheUserGroupAssociation>
