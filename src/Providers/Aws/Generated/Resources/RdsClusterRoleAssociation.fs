namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsClusterRoleAssociationState<'DbClusterIdentifier, 'FeatureName, 'RoleArn> = { assignments: ResizeArray<aws.RdsClusterRoleAssociation.RdsClusterRoleAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_role_association">aws_rds_cluster_role_association</a>.
    /// </summary>
    type RdsClusterRoleAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsClusterRoleAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsClusterRoleAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : RdsClusterRoleAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsClusterRoleAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_role_association#db_cluster_identifier-1">RdsClusterRoleAssociation#db_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "db_cluster_identifier">]
        member _.DbClusterIdentifier(state: RdsClusterRoleAssociationState<Missing, 'FeatureName, 'RoleArn>, value: string) : RdsClusterRoleAssociationState<Present, 'FeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.DbClusterIdentifier <- value)
            ({ assignments = state.assignments } : RdsClusterRoleAssociationState<Present, 'FeatureName, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_role_association#feature_name-1">RdsClusterRoleAssociation#feature_name</a>.
        /// </summary>
        [<CustomOperation "feature_name">]
        member _.FeatureName(state: RdsClusterRoleAssociationState<'DbClusterIdentifier, Missing, 'RoleArn>, value: string) : RdsClusterRoleAssociationState<'DbClusterIdentifier, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.FeatureName <- value)
            ({ assignments = state.assignments } : RdsClusterRoleAssociationState<'DbClusterIdentifier, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_role_association#role_arn-1">RdsClusterRoleAssociation#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: RdsClusterRoleAssociationState<'DbClusterIdentifier, 'FeatureName, Missing>, value: string) : RdsClusterRoleAssociationState<'DbClusterIdentifier, 'FeatureName, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : RdsClusterRoleAssociationState<'DbClusterIdentifier, 'FeatureName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_role_association#id-1">RdsClusterRoleAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RdsClusterRoleAssociationState<'DbClusterIdentifier, 'FeatureName, 'RoleArn>, value: string) : RdsClusterRoleAssociationState<'DbClusterIdentifier, 'FeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RdsClusterRoleAssociationState<'DbClusterIdentifier, 'FeatureName, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_role_association#timeouts-1">RdsClusterRoleAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RdsClusterRoleAssociationState<'DbClusterIdentifier, 'FeatureName, 'RoleArn>, value: aws.RdsClusterRoleAssociation.RdsClusterRoleAssociationTimeouts) : RdsClusterRoleAssociationState<'DbClusterIdentifier, 'FeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RdsClusterRoleAssociationState<'DbClusterIdentifier, 'FeatureName, 'RoleArn>

        member _.Run(state: RdsClusterRoleAssociationState<Present, Present, Present>) : aws.RdsClusterRoleAssociation.RdsClusterRoleAssociation =
            let config = aws.RdsClusterRoleAssociation.RdsClusterRoleAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.RdsClusterRoleAssociation.RdsClusterRoleAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsClusterRoleAssociation: missing required arguments. Must call: db_cluster_identifier, feature_name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: RdsClusterRoleAssociationState<_, _, _>) : aws.RdsClusterRoleAssociation.RdsClusterRoleAssociation =
            Unchecked.defaultof<aws.RdsClusterRoleAssociation.RdsClusterRoleAssociation>
