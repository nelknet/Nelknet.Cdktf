namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbInstanceRoleAssociationState<'DbInstanceIdentifier, 'FeatureName, 'RoleArn> = { assignments: ResizeArray<aws.DbInstanceRoleAssociation.DbInstanceRoleAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_role_association">aws_db_instance_role_association</a>.
    /// </summary>
    type DbInstanceRoleAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbInstanceRoleAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DbInstanceRoleAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : DbInstanceRoleAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DbInstanceRoleAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_role_association#db_instance_identifier-1">DbInstanceRoleAssociation#db_instance_identifier</a>.
        /// </summary>
        [<CustomOperation "db_instance_identifier">]
        member _.DbInstanceIdentifier(state: DbInstanceRoleAssociationState<Missing, 'FeatureName, 'RoleArn>, value: string) : DbInstanceRoleAssociationState<Present, 'FeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.DbInstanceIdentifier <- value)
            ({ assignments = state.assignments } : DbInstanceRoleAssociationState<Present, 'FeatureName, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_role_association#feature_name-1">DbInstanceRoleAssociation#feature_name</a>.
        /// </summary>
        [<CustomOperation "feature_name">]
        member _.FeatureName(state: DbInstanceRoleAssociationState<'DbInstanceIdentifier, Missing, 'RoleArn>, value: string) : DbInstanceRoleAssociationState<'DbInstanceIdentifier, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.FeatureName <- value)
            ({ assignments = state.assignments } : DbInstanceRoleAssociationState<'DbInstanceIdentifier, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_role_association#role_arn-1">DbInstanceRoleAssociation#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: DbInstanceRoleAssociationState<'DbInstanceIdentifier, 'FeatureName, Missing>, value: string) : DbInstanceRoleAssociationState<'DbInstanceIdentifier, 'FeatureName, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : DbInstanceRoleAssociationState<'DbInstanceIdentifier, 'FeatureName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_role_association#id-1">DbInstanceRoleAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbInstanceRoleAssociationState<'DbInstanceIdentifier, 'FeatureName, 'RoleArn>, value: string) : DbInstanceRoleAssociationState<'DbInstanceIdentifier, 'FeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbInstanceRoleAssociationState<'DbInstanceIdentifier, 'FeatureName, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_role_association#timeouts-1">DbInstanceRoleAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DbInstanceRoleAssociationState<'DbInstanceIdentifier, 'FeatureName, 'RoleArn>, value: aws.DbInstanceRoleAssociation.DbInstanceRoleAssociationTimeouts) : DbInstanceRoleAssociationState<'DbInstanceIdentifier, 'FeatureName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DbInstanceRoleAssociationState<'DbInstanceIdentifier, 'FeatureName, 'RoleArn>

        member _.Run(state: DbInstanceRoleAssociationState<Present, Present, Present>) : aws.DbInstanceRoleAssociation.DbInstanceRoleAssociation =
            let config = aws.DbInstanceRoleAssociation.DbInstanceRoleAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.DbInstanceRoleAssociation.DbInstanceRoleAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbInstanceRoleAssociation: missing required arguments. Must call: db_instance_identifier, feature_name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: DbInstanceRoleAssociationState<_, _, _>) : aws.DbInstanceRoleAssociation.DbInstanceRoleAssociation =
            Unchecked.defaultof<aws.DbInstanceRoleAssociation.DbInstanceRoleAssociation>
