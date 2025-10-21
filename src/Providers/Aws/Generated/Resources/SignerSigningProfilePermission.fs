namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName> = { assignments: ResizeArray<aws.SignerSigningProfilePermission.SignerSigningProfilePermissionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile_permission">aws_signer_signing_profile_permission</a>.
    /// </summary>
    type SignerSigningProfilePermissionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SignerSigningProfilePermissionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignerSigningProfilePermissionState<Missing, Missing, Missing>)

        member _.Zero(()) : SignerSigningProfilePermissionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SignerSigningProfilePermissionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile_permission#action-1">SignerSigningProfilePermission#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: SignerSigningProfilePermissionState<Missing, 'Principal, 'ProfileName>, value: string) : SignerSigningProfilePermissionState<Present, 'Principal, 'ProfileName> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : SignerSigningProfilePermissionState<Present, 'Principal, 'ProfileName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile_permission#principal-1">SignerSigningProfilePermission#principal</a>.
        /// </summary>
        [<CustomOperation "principal">]
        member _.Principal(state: SignerSigningProfilePermissionState<'Action, Missing, 'ProfileName>, value: string) : SignerSigningProfilePermissionState<'Action, Present, 'ProfileName> =
            state.assignments.Add(fun config -> config.Principal <- value)
            ({ assignments = state.assignments } : SignerSigningProfilePermissionState<'Action, Present, 'ProfileName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile_permission#profile_name-1">SignerSigningProfilePermission#profile_name</a>.
        /// </summary>
        [<CustomOperation "profile_name">]
        member _.ProfileName(state: SignerSigningProfilePermissionState<'Action, 'Principal, Missing>, value: string) : SignerSigningProfilePermissionState<'Action, 'Principal, Present> =
            state.assignments.Add(fun config -> config.ProfileName <- value)
            ({ assignments = state.assignments } : SignerSigningProfilePermissionState<'Action, 'Principal, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile_permission#id-1">SignerSigningProfilePermission#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName>, value: string) : SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile_permission#profile_version-1">SignerSigningProfilePermission#profile_version</a>.
        /// </summary>
        [<CustomOperation "profile_version">]
        member _.ProfileVersion(state: SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName>, value: string) : SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName> =
            state.assignments.Add(fun config -> config.ProfileVersion <- value)
            state : SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile_permission#statement_id-1">SignerSigningProfilePermission#statement_id</a>.
        /// </summary>
        [<CustomOperation "statement_id">]
        member _.StatementId(state: SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName>, value: string) : SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName> =
            state.assignments.Add(fun config -> config.StatementId <- value)
            state : SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/signer_signing_profile_permission#statement_id_prefix-1">SignerSigningProfilePermission#statement_id_prefix</a>.
        /// </summary>
        [<CustomOperation "statement_id_prefix">]
        member _.StatementIdPrefix(state: SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName>, value: string) : SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName> =
            state.assignments.Add(fun config -> config.StatementIdPrefix <- value)
            state : SignerSigningProfilePermissionState<'Action, 'Principal, 'ProfileName>

        member _.Run(state: SignerSigningProfilePermissionState<Present, Present, Present>) : aws.SignerSigningProfilePermission.SignerSigningProfilePermission =
            let config = aws.SignerSigningProfilePermission.SignerSigningProfilePermissionConfig()
            for setter in state.assignments do
                setter config
            aws.SignerSigningProfilePermission.SignerSigningProfilePermission(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.signerSigningProfilePermission: missing required arguments. Must call: action, principal, profile_name.", 9999, IsError = true)>]
        member _.Run(_: SignerSigningProfilePermissionState<_, _, _>) : aws.SignerSigningProfilePermission.SignerSigningProfilePermission =
            Unchecked.defaultof<aws.SignerSigningProfilePermission.SignerSigningProfilePermission>
