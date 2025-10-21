namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId> = { assignments: ResizeArray<azurerm.RedisCacheAccessPolicyAssignment.RedisCacheAccessPolicyAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy_assignment">azurerm_redis_cache_access_policy_assignment</a>.
    /// </summary>
    type RedisCacheAccessPolicyAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedisCacheAccessPolicyAssignmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisCacheAccessPolicyAssignmentState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RedisCacheAccessPolicyAssignmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisCacheAccessPolicyAssignmentState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy_assignment#access_policy_name-1">RedisCacheAccessPolicyAssignment#access_policy_name</a>.
        /// </summary>
        [<CustomOperation "access_policy_name">]
        member _.AccessPolicyName(state: RedisCacheAccessPolicyAssignmentState<Missing, 'Name, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId>, value: string) : RedisCacheAccessPolicyAssignmentState<Present, 'Name, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId> =
            state.assignments.Add(fun config -> config.AccessPolicyName <- value)
            ({ assignments = state.assignments } : RedisCacheAccessPolicyAssignmentState<Present, 'Name, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy_assignment#name-1">RedisCacheAccessPolicyAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, Missing, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId>, value: string) : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, Present, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, Present, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy_assignment#object_id-1">RedisCacheAccessPolicyAssignment#object_id</a>.
        /// </summary>
        [<CustomOperation "object_id">]
        member _.ObjectId(state: RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, Missing, 'ObjectIdAlias, 'RedisCacheId>, value: string) : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, Present, 'ObjectIdAlias, 'RedisCacheId> =
            state.assignments.Add(fun config -> config.ObjectId <- value)
            ({ assignments = state.assignments } : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, Present, 'ObjectIdAlias, 'RedisCacheId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy_assignment#object_id_alias-1">RedisCacheAccessPolicyAssignment#object_id_alias</a>.
        /// </summary>
        [<CustomOperation "object_id_alias">]
        member _.ObjectIdAlias(state: RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, Missing, 'RedisCacheId>, value: string) : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, Present, 'RedisCacheId> =
            state.assignments.Add(fun config -> config.ObjectIdAlias <- value)
            ({ assignments = state.assignments } : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, Present, 'RedisCacheId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy_assignment#redis_cache_id-1">RedisCacheAccessPolicyAssignment#redis_cache_id</a>.
        /// </summary>
        [<CustomOperation "redis_cache_id">]
        member _.RedisCacheId(state: RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, 'ObjectIdAlias, Missing>, value: string) : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, 'ObjectIdAlias, Present> =
            state.assignments.Add(fun config -> config.RedisCacheId <- value)
            ({ assignments = state.assignments } : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, 'ObjectIdAlias, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy_assignment#id-1">RedisCacheAccessPolicyAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId>, value: string) : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache_access_policy_assignment#timeouts-1">RedisCacheAccessPolicyAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId>, value: azurerm.RedisCacheAccessPolicyAssignment.RedisCacheAccessPolicyAssignmentTimeouts) : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedisCacheAccessPolicyAssignmentState<'AccessPolicyName, 'Name, 'ObjectId, 'ObjectIdAlias, 'RedisCacheId>

        member _.Run(state: RedisCacheAccessPolicyAssignmentState<Present, Present, Present, Present, Present>) : azurerm.RedisCacheAccessPolicyAssignment.RedisCacheAccessPolicyAssignment =
            let config = azurerm.RedisCacheAccessPolicyAssignment.RedisCacheAccessPolicyAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.RedisCacheAccessPolicyAssignment.RedisCacheAccessPolicyAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.redisCacheAccessPolicyAssignment: missing required arguments. Must call: access_policy_name, name, object_id, object_id_alias, redis_cache_id.", 9999, IsError = true)>]
        member _.Run(_: RedisCacheAccessPolicyAssignmentState<_, _, _, _, _>) : azurerm.RedisCacheAccessPolicyAssignment.RedisCacheAccessPolicyAssignment =
            Unchecked.defaultof<azurerm.RedisCacheAccessPolicyAssignment.RedisCacheAccessPolicyAssignment>
