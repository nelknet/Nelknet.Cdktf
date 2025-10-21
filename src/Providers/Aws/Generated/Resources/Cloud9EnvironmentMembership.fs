namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Cloud9EnvironmentMembershipState<'EnvironmentId, 'Permissions, 'UserArn> = { assignments: ResizeArray<aws.Cloud9EnvironmentMembership.Cloud9EnvironmentMembershipConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_membership">aws_cloud9_environment_membership</a>.
    /// </summary>
    type Cloud9EnvironmentMembershipBuilder(logicalId: string) =
        member _.Yield(_: unit) : Cloud9EnvironmentMembershipState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Cloud9EnvironmentMembershipState<Missing, Missing, Missing>)

        member _.Zero(()) : Cloud9EnvironmentMembershipState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Cloud9EnvironmentMembershipState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_membership#environment_id-1">Cloud9EnvironmentMembership#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: Cloud9EnvironmentMembershipState<Missing, 'Permissions, 'UserArn>, value: string) : Cloud9EnvironmentMembershipState<Present, 'Permissions, 'UserArn> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            ({ assignments = state.assignments } : Cloud9EnvironmentMembershipState<Present, 'Permissions, 'UserArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_membership#permissions-1">Cloud9EnvironmentMembership#permissions</a>.
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: Cloud9EnvironmentMembershipState<'EnvironmentId, Missing, 'UserArn>, value: string) : Cloud9EnvironmentMembershipState<'EnvironmentId, Present, 'UserArn> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            ({ assignments = state.assignments } : Cloud9EnvironmentMembershipState<'EnvironmentId, Present, 'UserArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_membership#user_arn-1">Cloud9EnvironmentMembership#user_arn</a>.
        /// </summary>
        [<CustomOperation "user_arn">]
        member _.UserArn(state: Cloud9EnvironmentMembershipState<'EnvironmentId, 'Permissions, Missing>, value: string) : Cloud9EnvironmentMembershipState<'EnvironmentId, 'Permissions, Present> =
            state.assignments.Add(fun config -> config.UserArn <- value)
            ({ assignments = state.assignments } : Cloud9EnvironmentMembershipState<'EnvironmentId, 'Permissions, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloud9_environment_membership#id-1">Cloud9EnvironmentMembership#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Cloud9EnvironmentMembershipState<'EnvironmentId, 'Permissions, 'UserArn>, value: string) : Cloud9EnvironmentMembershipState<'EnvironmentId, 'Permissions, 'UserArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Cloud9EnvironmentMembershipState<'EnvironmentId, 'Permissions, 'UserArn>

        member _.Run(state: Cloud9EnvironmentMembershipState<Present, Present, Present>) : aws.Cloud9EnvironmentMembership.Cloud9EnvironmentMembership =
            let config = aws.Cloud9EnvironmentMembership.Cloud9EnvironmentMembershipConfig()
            for setter in state.assignments do
                setter config
            aws.Cloud9EnvironmentMembership.Cloud9EnvironmentMembership(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloud9EnvironmentMembership: missing required arguments. Must call: environment_id, permissions, user_arn.", 9999, IsError = true)>]
        member _.Run(_: Cloud9EnvironmentMembershipState<_, _, _>) : aws.Cloud9EnvironmentMembership.Cloud9EnvironmentMembership =
            Unchecked.defaultof<aws.Cloud9EnvironmentMembership.Cloud9EnvironmentMembership>
