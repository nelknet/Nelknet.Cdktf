namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, 'PolicyArn, 'PrincipalArn> = { assignments: ResizeArray<aws.EksAccessPolicyAssociation.EksAccessPolicyAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association">aws_eks_access_policy_association</a>.
    /// </summary>
    type EksAccessPolicyAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : EksAccessPolicyAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EksAccessPolicyAssociationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EksAccessPolicyAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EksAccessPolicyAssociationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// access_scope block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#access_scope-1">EksAccessPolicyAssociation#access_scope</a>
        /// </summary>
        [<CustomOperation "access_scope">]
        member _.AccessScope(state: EksAccessPolicyAssociationState<Missing, 'ClusterName, 'PolicyArn, 'PrincipalArn>, value: aws.EksAccessPolicyAssociation.EksAccessPolicyAssociationAccessScope) : EksAccessPolicyAssociationState<Present, 'ClusterName, 'PolicyArn, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.AccessScope <- value)
            ({ assignments = state.assignments } : EksAccessPolicyAssociationState<Present, 'ClusterName, 'PolicyArn, 'PrincipalArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#cluster_name-1">EksAccessPolicyAssociation#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: EksAccessPolicyAssociationState<'AccessScope, Missing, 'PolicyArn, 'PrincipalArn>, value: string) : EksAccessPolicyAssociationState<'AccessScope, Present, 'PolicyArn, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : EksAccessPolicyAssociationState<'AccessScope, Present, 'PolicyArn, 'PrincipalArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#policy_arn-1">EksAccessPolicyAssociation#policy_arn</a>.
        /// </summary>
        [<CustomOperation "policy_arn">]
        member _.PolicyArn(state: EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, Missing, 'PrincipalArn>, value: string) : EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, Present, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.PolicyArn <- value)
            ({ assignments = state.assignments } : EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, Present, 'PrincipalArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#principal_arn-1">EksAccessPolicyAssociation#principal_arn</a>.
        /// </summary>
        [<CustomOperation "principal_arn">]
        member _.PrincipalArn(state: EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, 'PolicyArn, Missing>, value: string) : EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, 'PolicyArn, Present> =
            state.assignments.Add(fun config -> config.PrincipalArn <- value)
            ({ assignments = state.assignments } : EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, 'PolicyArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#id-1">EksAccessPolicyAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, 'PolicyArn, 'PrincipalArn>, value: string) : EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, 'PolicyArn, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, 'PolicyArn, 'PrincipalArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#timeouts-1">EksAccessPolicyAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, 'PolicyArn, 'PrincipalArn>, value: aws.EksAccessPolicyAssociation.EksAccessPolicyAssociationTimeouts) : EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, 'PolicyArn, 'PrincipalArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EksAccessPolicyAssociationState<'AccessScope, 'ClusterName, 'PolicyArn, 'PrincipalArn>

        member _.Run(state: EksAccessPolicyAssociationState<Present, Present, Present, Present>) : aws.EksAccessPolicyAssociation.EksAccessPolicyAssociation =
            let config = aws.EksAccessPolicyAssociation.EksAccessPolicyAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.EksAccessPolicyAssociation.EksAccessPolicyAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.eksAccessPolicyAssociation: missing required arguments. Must call: access_scope, cluster_name, policy_arn, principal_arn.", 9999, IsError = true)>]
        member _.Run(_: EksAccessPolicyAssociationState<_, _, _, _>) : aws.EksAccessPolicyAssociation.EksAccessPolicyAssociation =
            Unchecked.defaultof<aws.EksAccessPolicyAssociation.EksAccessPolicyAssociation>
