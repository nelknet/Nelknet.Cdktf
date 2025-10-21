namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EksPodIdentityAssociationState<'ClusterName, 'Namespace, 'RoleArn, 'ServiceAccount> = { assignments: ResizeArray<aws.EksPodIdentityAssociation.EksPodIdentityAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_pod_identity_association">aws_eks_pod_identity_association</a>.
    /// </summary>
    type EksPodIdentityAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : EksPodIdentityAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EksPodIdentityAssociationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EksPodIdentityAssociationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EksPodIdentityAssociationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_pod_identity_association#cluster_name-1">EksPodIdentityAssociation#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: EksPodIdentityAssociationState<Missing, 'Namespace, 'RoleArn, 'ServiceAccount>, value: string) : EksPodIdentityAssociationState<Present, 'Namespace, 'RoleArn, 'ServiceAccount> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : EksPodIdentityAssociationState<Present, 'Namespace, 'RoleArn, 'ServiceAccount>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_pod_identity_association#namespace-1">EksPodIdentityAssociation#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: EksPodIdentityAssociationState<'ClusterName, Missing, 'RoleArn, 'ServiceAccount>, value: string) : EksPodIdentityAssociationState<'ClusterName, Present, 'RoleArn, 'ServiceAccount> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            ({ assignments = state.assignments } : EksPodIdentityAssociationState<'ClusterName, Present, 'RoleArn, 'ServiceAccount>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_pod_identity_association#role_arn-1">EksPodIdentityAssociation#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: EksPodIdentityAssociationState<'ClusterName, 'Namespace, Missing, 'ServiceAccount>, value: string) : EksPodIdentityAssociationState<'ClusterName, 'Namespace, Present, 'ServiceAccount> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : EksPodIdentityAssociationState<'ClusterName, 'Namespace, Present, 'ServiceAccount>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_pod_identity_association#service_account-1">EksPodIdentityAssociation#service_account</a>.
        /// </summary>
        [<CustomOperation "service_account">]
        member _.ServiceAccount(state: EksPodIdentityAssociationState<'ClusterName, 'Namespace, 'RoleArn, Missing>, value: string) : EksPodIdentityAssociationState<'ClusterName, 'Namespace, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.ServiceAccount <- value)
            ({ assignments = state.assignments } : EksPodIdentityAssociationState<'ClusterName, 'Namespace, 'RoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_pod_identity_association#tags-1">EksPodIdentityAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EksPodIdentityAssociationState<'ClusterName, 'Namespace, 'RoleArn, 'ServiceAccount>, value: seq<string * string>) : EksPodIdentityAssociationState<'ClusterName, 'Namespace, 'RoleArn, 'ServiceAccount> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EksPodIdentityAssociationState<'ClusterName, 'Namespace, 'RoleArn, 'ServiceAccount>

        member _.Run(state: EksPodIdentityAssociationState<Present, Present, Present, Present>) : aws.EksPodIdentityAssociation.EksPodIdentityAssociation =
            let config = aws.EksPodIdentityAssociation.EksPodIdentityAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.EksPodIdentityAssociation.EksPodIdentityAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.eksPodIdentityAssociation: missing required arguments. Must call: cluster_name, namespace, role_arn, service_account.", 9999, IsError = true)>]
        member _.Run(_: EksPodIdentityAssociationState<_, _, _, _>) : aws.EksPodIdentityAssociation.EksPodIdentityAssociation =
            Unchecked.defaultof<aws.EksPodIdentityAssociation.EksPodIdentityAssociation>
