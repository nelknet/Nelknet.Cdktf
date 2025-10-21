namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType> = { assignments: ResizeArray<aws.ImagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy">aws_imagebuilder_lifecycle_policy</a>.
    /// </summary>
    type ImagebuilderLifecyclePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ImagebuilderLifecyclePolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderLifecyclePolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : ImagebuilderLifecyclePolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderLifecyclePolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#execution_role-1">ImagebuilderLifecyclePolicy#execution_role</a>.
        /// </summary>
        [<CustomOperation "execution_role">]
        member _.ExecutionRole(state: ImagebuilderLifecyclePolicyState<Missing, 'Name, 'ResourceType>, value: string) : ImagebuilderLifecyclePolicyState<Present, 'Name, 'ResourceType> =
            state.assignments.Add(fun config -> config.ExecutionRole <- value)
            ({ assignments = state.assignments } : ImagebuilderLifecyclePolicyState<Present, 'Name, 'ResourceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#name-1">ImagebuilderLifecyclePolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ImagebuilderLifecyclePolicyState<'ExecutionRole, Missing, 'ResourceType>, value: string) : ImagebuilderLifecyclePolicyState<'ExecutionRole, Present, 'ResourceType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ImagebuilderLifecyclePolicyState<'ExecutionRole, Present, 'ResourceType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#resource_type-1">ImagebuilderLifecyclePolicy#resource_type</a>.
        /// </summary>
        [<CustomOperation "resource_type">]
        member _.ResourceType(state: ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, Missing>, value: string) : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceType <- value)
            ({ assignments = state.assignments } : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#description-1">ImagebuilderLifecyclePolicy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType>, value: string) : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType>

        /// <summary>
        /// policy_detail block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#policy_detail-1">ImagebuilderLifecyclePolicy#policy_detail</a> Accepts: aws.IResolvable | aws.ImagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyPolicyDetail[]
        /// </summary>
        [<CustomOperation "policy_detail">]
        member _.PolicyDetail(state: ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType> =
            state.assignments.Add(fun config -> config.PolicyDetail <- value)
            state : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType>

        /// <summary>
        /// resource_selection block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#resource_selection-1">ImagebuilderLifecyclePolicy#resource_selection</a> Accepts: aws.IResolvable | aws.ImagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyResourceSelection[]
        /// </summary>
        [<CustomOperation "resource_selection">]
        member _.ResourceSelection(state: ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType> =
            state.assignments.Add(fun config -> config.ResourceSelection <- value)
            state : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#status-1">ImagebuilderLifecyclePolicy#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType>, value: string) : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#tags-1">ImagebuilderLifecyclePolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType>, value: seq<string * string>) : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ImagebuilderLifecyclePolicyState<'ExecutionRole, 'Name, 'ResourceType>

        member _.Run(state: ImagebuilderLifecyclePolicyState<Present, Present, Present>) : aws.ImagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicy =
            let config = aws.ImagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.ImagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.imagebuilderLifecyclePolicy: missing required arguments. Must call: execution_role, name, resource_type.", 9999, IsError = true)>]
        member _.Run(_: ImagebuilderLifecyclePolicyState<_, _, _>) : aws.ImagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicy =
            Unchecked.defaultof<aws.ImagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicy>
