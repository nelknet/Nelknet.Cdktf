namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LicensemanagerGrantState<'AllowedOperations, 'LicenseArn, 'Name, 'Principal> = { assignments: ResizeArray<aws.LicensemanagerGrant.LicensemanagerGrantConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_grant">aws_licensemanager_grant</a>.
    /// </summary>
    type LicensemanagerGrantBuilder(logicalId: string) =
        member _.Yield(_: unit) : LicensemanagerGrantState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LicensemanagerGrantState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LicensemanagerGrantState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LicensemanagerGrantState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Allowed operations for the grant. This is a subset of the allowed operations on the license. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_grant#allowed_operations-1">LicensemanagerGrant#allowed_operations</a>
        /// </summary>
        [<CustomOperation "allowed_operations">]
        member _.AllowedOperations(state: LicensemanagerGrantState<Missing, 'LicenseArn, 'Name, 'Principal>, value: seq<string>) : LicensemanagerGrantState<Present, 'LicenseArn, 'Name, 'Principal> =
            state.assignments.Add(fun config -> config.AllowedOperations <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : LicensemanagerGrantState<Present, 'LicenseArn, 'Name, 'Principal>)

        /// <summary>
        /// License ARN. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_grant#license_arn-1">LicensemanagerGrant#license_arn</a>
        /// </summary>
        [<CustomOperation "license_arn">]
        member _.LicenseArn(state: LicensemanagerGrantState<'AllowedOperations, Missing, 'Name, 'Principal>, value: string) : LicensemanagerGrantState<'AllowedOperations, Present, 'Name, 'Principal> =
            state.assignments.Add(fun config -> config.LicenseArn <- value)
            ({ assignments = state.assignments } : LicensemanagerGrantState<'AllowedOperations, Present, 'Name, 'Principal>)

        /// <summary>
        /// Name of the grant. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_grant#name-1">LicensemanagerGrant#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LicensemanagerGrantState<'AllowedOperations, 'LicenseArn, Missing, 'Principal>, value: string) : LicensemanagerGrantState<'AllowedOperations, 'LicenseArn, Present, 'Principal> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LicensemanagerGrantState<'AllowedOperations, 'LicenseArn, Present, 'Principal>)

        /// <summary>
        /// The grantee principal ARN. The target account for the grant in the form of the ARN for an account principal of the root user. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_grant#principal-1">LicensemanagerGrant#principal</a>
        /// </summary>
        [<CustomOperation "principal">]
        member _.Principal(state: LicensemanagerGrantState<'AllowedOperations, 'LicenseArn, 'Name, Missing>, value: string) : LicensemanagerGrantState<'AllowedOperations, 'LicenseArn, 'Name, Present> =
            state.assignments.Add(fun config -> config.Principal <- value)
            ({ assignments = state.assignments } : LicensemanagerGrantState<'AllowedOperations, 'LicenseArn, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_grant#id-1">LicensemanagerGrant#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LicensemanagerGrantState<'AllowedOperations, 'LicenseArn, 'Name, 'Principal>, value: string) : LicensemanagerGrantState<'AllowedOperations, 'LicenseArn, 'Name, 'Principal> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LicensemanagerGrantState<'AllowedOperations, 'LicenseArn, 'Name, 'Principal>

        member _.Run(state: LicensemanagerGrantState<Present, Present, Present, Present>) : aws.LicensemanagerGrant.LicensemanagerGrant =
            let config = aws.LicensemanagerGrant.LicensemanagerGrantConfig()
            for setter in state.assignments do
                setter config
            aws.LicensemanagerGrant.LicensemanagerGrant(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.licensemanagerGrant: missing required arguments. Must call: allowed_operations, license_arn, name, principal.", 9999, IsError = true)>]
        member _.Run(_: LicensemanagerGrantState<_, _, _, _>) : aws.LicensemanagerGrant.LicensemanagerGrant =
            Unchecked.defaultof<aws.LicensemanagerGrant.LicensemanagerGrant>
