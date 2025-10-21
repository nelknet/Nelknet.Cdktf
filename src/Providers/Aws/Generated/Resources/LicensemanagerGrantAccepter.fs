namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LicensemanagerGrantAccepterState<'GrantArn> = { assignments: ResizeArray<aws.LicensemanagerGrantAccepter.LicensemanagerGrantAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_grant_accepter">aws_licensemanager_grant_accepter</a>.
    /// </summary>
    type LicensemanagerGrantAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : LicensemanagerGrantAccepterState<Missing> =
            ({ assignments = ResizeArray() } : LicensemanagerGrantAccepterState<Missing>)

        member _.Zero(()) : LicensemanagerGrantAccepterState<Missing> =
            ({ assignments = ResizeArray() } : LicensemanagerGrantAccepterState<Missing>)

        /// <summary>
        /// Amazon Resource Name (ARN) of the grant. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_grant_accepter#grant_arn-1">LicensemanagerGrantAccepter#grant_arn</a>
        /// </summary>
        [<CustomOperation "grant_arn">]
        member _.GrantArn(state: LicensemanagerGrantAccepterState<Missing>, value: string) : LicensemanagerGrantAccepterState<Present> =
            state.assignments.Add(fun config -> config.GrantArn <- value)
            ({ assignments = state.assignments } : LicensemanagerGrantAccepterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/licensemanager_grant_accepter#id-1">LicensemanagerGrantAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LicensemanagerGrantAccepterState<'GrantArn>, value: string) : LicensemanagerGrantAccepterState<'GrantArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LicensemanagerGrantAccepterState<'GrantArn>

        member _.Run(state: LicensemanagerGrantAccepterState<Present>) : aws.LicensemanagerGrantAccepter.LicensemanagerGrantAccepter =
            let config = aws.LicensemanagerGrantAccepter.LicensemanagerGrantAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.LicensemanagerGrantAccepter.LicensemanagerGrantAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.licensemanagerGrantAccepter: missing required arguments. Must call: grant_arn.", 9999, IsError = true)>]
        member _.Run(_: LicensemanagerGrantAccepterState<_>) : aws.LicensemanagerGrantAccepter.LicensemanagerGrantAccepter =
            Unchecked.defaultof<aws.LicensemanagerGrantAccepter.LicensemanagerGrantAccepter>
