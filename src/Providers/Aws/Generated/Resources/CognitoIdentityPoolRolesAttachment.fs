namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoIdentityPoolRolesAttachmentState<'IdentityPoolId, 'Roles> = { assignments: ResizeArray<aws.CognitoIdentityPoolRolesAttachment.CognitoIdentityPoolRolesAttachmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_roles_attachment">aws_cognito_identity_pool_roles_attachment</a>.
    /// </summary>
    type CognitoIdentityPoolRolesAttachmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoIdentityPoolRolesAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoIdentityPoolRolesAttachmentState<Missing, Missing>)

        member _.Zero(()) : CognitoIdentityPoolRolesAttachmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CognitoIdentityPoolRolesAttachmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_roles_attachment#identity_pool_id-1">CognitoIdentityPoolRolesAttachment#identity_pool_id</a>.
        /// </summary>
        [<CustomOperation "identity_pool_id">]
        member _.IdentityPoolId(state: CognitoIdentityPoolRolesAttachmentState<Missing, 'Roles>, value: string) : CognitoIdentityPoolRolesAttachmentState<Present, 'Roles> =
            state.assignments.Add(fun config -> config.IdentityPoolId <- value)
            ({ assignments = state.assignments } : CognitoIdentityPoolRolesAttachmentState<Present, 'Roles>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_roles_attachment#roles-1">CognitoIdentityPoolRolesAttachment#roles</a>.
        /// </summary>
        [<CustomOperation "roles">]
        member _.Roles(state: CognitoIdentityPoolRolesAttachmentState<'IdentityPoolId, Missing>, value: seq<string * string>) : CognitoIdentityPoolRolesAttachmentState<'IdentityPoolId, Present> =
            state.assignments.Add(fun config -> config.Roles <- dict value)
            ({ assignments = state.assignments } : CognitoIdentityPoolRolesAttachmentState<'IdentityPoolId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_roles_attachment#id-1">CognitoIdentityPoolRolesAttachment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoIdentityPoolRolesAttachmentState<'IdentityPoolId, 'Roles>, value: string) : CognitoIdentityPoolRolesAttachmentState<'IdentityPoolId, 'Roles> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoIdentityPoolRolesAttachmentState<'IdentityPoolId, 'Roles>

        /// <summary>
        /// role_mapping block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_identity_pool_roles_attachment#role_mapping-1">CognitoIdentityPoolRolesAttachment#role_mapping</a> Accepts: aws.IResolvable | aws.CognitoIdentityPoolRolesAttachment.CognitoIdentityPoolRolesAttachmentRoleMapping[]
        /// </summary>
        [<CustomOperation "role_mapping">]
        member _.RoleMapping(state: CognitoIdentityPoolRolesAttachmentState<'IdentityPoolId, 'Roles>, value: HashiCorp.Cdktf.IResolvable) : CognitoIdentityPoolRolesAttachmentState<'IdentityPoolId, 'Roles> =
            state.assignments.Add(fun config -> config.RoleMapping <- value)
            state : CognitoIdentityPoolRolesAttachmentState<'IdentityPoolId, 'Roles>

        member _.Run(state: CognitoIdentityPoolRolesAttachmentState<Present, Present>) : aws.CognitoIdentityPoolRolesAttachment.CognitoIdentityPoolRolesAttachment =
            let config = aws.CognitoIdentityPoolRolesAttachment.CognitoIdentityPoolRolesAttachmentConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoIdentityPoolRolesAttachment.CognitoIdentityPoolRolesAttachment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoIdentityPoolRolesAttachment: missing required arguments. Must call: identity_pool_id, roles.", 9999, IsError = true)>]
        member _.Run(_: CognitoIdentityPoolRolesAttachmentState<_, _>) : aws.CognitoIdentityPoolRolesAttachment.CognitoIdentityPoolRolesAttachment =
            Unchecked.defaultof<aws.CognitoIdentityPoolRolesAttachment.CognitoIdentityPoolRolesAttachment>
